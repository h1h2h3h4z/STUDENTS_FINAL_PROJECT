using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using static STUDENTS_FINAL_PROJECT.STUDENT_PAGE;
using static STUDENTS_FINAL_PROJECT.UCenrollement;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class StudentPage : Form
    {
        private int studentid;

        public StudentPage(int studetid1)
        {
            InitializeComponent();
            studentid = studetid1;
            RoundLabel(lblemail, 15);
            RoundLabel(lblphone, 15);
            RoundLabel(lblid, 15);
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.FlatAppearance.BorderSize = 0;  
            exitbtn.FlatAppearance.MouseOverBackColor = Color.Transparent; 
            exitbtn.FlatAppearance.MouseDownBackColor = Color.Transparent; 

        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            STUDENT_PAGE std = new STUDENT_PAGE();
            StudentInfo student = std.GetStudentInfo(studentid);

            if (student != null)
            {
                lblnamedate.Text =$"{student.StudentName}-{student.StudentBirthdate:yyyy - MM - dd}";
                lblid.Text += student.StudentId.ToString();
                lblphone.Text += student.StudentPhone;
                lblemail.Text += student.StudentEmail;

                if (studentimage != null && !string.IsNullOrEmpty(student.StudentImage) && File.Exists(student.StudentImage))
                {
                    studentimage.ImageLocation = student.StudentImage;
                    studentimage.Load();
                    ApplyShadowAndRoundedBorder(studentimage);
                }
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

            List<(int studentid, string studentName, DateTime studentbirthdate, string studentimage, string studentphone, string studentemail)> StudentList = std.GetOtherStudents(studentid);
            List<(string coursename, string teachername, string teacherimage)>CourseList = std.GetStudentCoursesandteacher(studentid);
            // 🟡 **Scrollable Panel Setup**
            Panel panelStudent = new Panel
            {
                AutoScroll = true,
                Size = new Size(520, 279), 
                Location = new Point(28, 370),
                BorderStyle = BorderStyle.FixedSingle
            };
            panelStudent.BorderStyle = BorderStyle.None;
            this.Controls.Add(panelStudent);
            // 🟡 **Scrollable Panel Setup for Courses (Horizontal Scroll)**
            Panel panelCourses = new Panel
            {
                AutoScroll = true,
                Size = new Size(388, 279),
                Location = new Point(554, 370),
                BorderStyle = BorderStyle.FixedSingle,
                HorizontalScroll = { Enabled = true }  // Enable horizontal scrolling
            };
            panelCourses.BorderStyle = BorderStyle.None;
            this.Controls.Add(panelCourses);

            // 🟡 **Layout Variables for Courses**
            int xc = 10;
            int yc = 10;
            int itemWidthc = 250; // Width of each card
            int itemHeightc = 180; // Increased height to accommodate larger image and text
            int spacingc = 20;

            // 🟡 **Loop to Create Course Items**
            foreach (var Course in CourseList)
            {
                // 🟡 **Create a Card Panel**
                Panel cardPanel = new Panel
                {
                    Size = new Size(itemWidthc, itemHeightc),
                    Location = new Point(xc, yc),
                    BackColor = Color.Silver,
                    BorderStyle = BorderStyle.None,
                    Padding = new Padding(10)
                };
                RoundPanel(cardPanel, 15); // Apply rounded corners to the card

                // 🟡 **PictureBox for Teacher Image (Bigger Size)**
                PictureBox pictureBox = new PictureBox
                {
                    Name = "teacherimage_" + Course.teachername + Course.coursename,
                    Size = new Size(130, 150), // Larger size for the image
                    Location = new Point(10, 15), // Positioned at the top of the card
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.None,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = Course.teacherimage,
                  
                };
                ApplyShadowAndRoundedBorder(pictureBox);

                // 🟡 **Label for Course Name (Bigger Font)**
                Label coursenameLabel = new Label
                {
                    Text = Course.coursename,
                    Font = new Font("Segoe UI", 17, FontStyle.Bold), // Larger font size
                    ForeColor = Color.Black,
                    Location = new Point(150, 15), // Positioned below the image
                    AutoSize = true
                };

                // 🟡 **Label for Teacher Name (Smaller Font, Under the Course Name)**
                Label teachernameLabel = new Label
                {
                    Text = Course.teachername.ToUpper(),
                    Font = new Font("Segoe UI", 12, FontStyle.Bold), // Smaller font size
                    ForeColor = Color.White,
                    Location = new Point(150, 130), // Positioned below the course name
                    Size = new Size(80, 30),
                    BackColor = Color.Black
                };
                RoundLabel(teachernameLabel, 13);

                // 🟡 **Add Controls to the Card Panel**
                cardPanel.Controls.Add(pictureBox);
                cardPanel.Controls.Add(coursenameLabel);
                cardPanel.Controls.Add(teachernameLabel);

                // 🟡 **Add Card Panel to the Courses Panel**
                panelCourses.Controls.Add(cardPanel);

                // 🟡 **Increment X for Next Card**
                xc += itemWidthc + spacingc;
            }

            // 🟡 **Adjust Scroll Range for Horizontal Scroll**
            panelCourses.AutoScrollMinSize = new Size(xc, itemHeightc);

            // 🟡 **Layout Variables**
            int x = 10;
            int y = 10;
            int itemWidth = 140;
            int itemHeight = 260;
            int spacing = 30;

            
            // 🟡 **Loop to Create Items Horizontally**
            // 🟡 **Loop to Create Items Horizontally**
            foreach (var otherstudent in StudentList)
            {
                int studentid = otherstudent.studentid;
                string studentname = otherstudent.studentName;
                string studentemail = otherstudent.studentemail;
                DateTime studentbirthdate = otherstudent.studentbirthdate;
                string studentphone = otherstudent.studentphone;
                string studentimage = otherstudent.studentimage;

                // 🟡 **PictureBox**
                PictureBox pictureBox = new PictureBox
                {
                    Name = "studentimage_" + studentname,
                    Size = new Size(130, 110),
                    Location = new Point(x, y),
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.None,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand
                };
                if (!string.IsNullOrEmpty(studentimage) && File.Exists(studentimage))
                {
                    pictureBox.ImageLocation = studentimage;
                    pictureBox.Load();  // Load the image if found
                }
                ApplyShadowAndRoundedBorder(pictureBox);

                pictureBox.Click += (s, args) =>
                {
                    StudentDetail_Form detailsForm = new StudentDetail_Form(studentid, studentname, studentphone, studentemail, studentbirthdate, studentimage);
                    detailsForm.ShowDialog();
                };
                panelStudent.Controls.Add(pictureBox);

                // 🟡 **Label**
                Label lblStudent = new Label
                {
                    Text = $"{studentname}\nBirth Date: {studentbirthdate:yyyy-MM-dd}",
                    Size = new Size(130, 120),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(x, y + 120),
                    BackColor = Color.Silver,
                    ForeColor = Color.Black
                };
                StyleLabel(lblStudent, Color.Silver, Color.Black, "Segoe UI", 12, true);
                RoundLabel(lblStudent, 13);
                panelStudent.Controls.Add(lblStudent);

                // 🟡 **Increment X for Next Item**
                x += itemWidth + spacing;
            }

            // 🟡 **Adjust Scroll Range**
            panelStudent.AutoScrollMinSize = new Size(x, itemHeight);

        }

        #region Label Styling Methods
        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, panel.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public void StyleLabel(Label label, Color backgroundColor, Color textColor, string fontFamily, int fontSize, bool isBold)
        {
            // Set the background color of the label
            label.BackColor = backgroundColor;

            // Set the font of the label
            FontStyle fontStyle = isBold ? FontStyle.Bold : FontStyle.Regular;
            label.Font = new Font(fontFamily, fontSize, fontStyle);

            // Set the text color of the label
            label.ForeColor = textColor;

            // Optional: Center the text inside the label
            label.TextAlign = ContentAlignment.MiddleCenter;
        }

        public static void RoundLabel(Label label, int radius)
        {
            label.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Create a rounded rectangle for the label
                GraphicsPath path = new GraphicsPath();
                int diameter = radius * 2;
                path.AddArc(0, 0, diameter, diameter, 180, 90); // Top-left corner
                path.AddArc(label.Width - diameter, 0, diameter, diameter, 270, 90); // Top-right corner
                path.AddArc(label.Width - diameter, label.Height - diameter, diameter, diameter, 0, 90); // Bottom-right corner
                path.AddArc(0, label.Height - diameter, diameter, diameter, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set the region of the label to the rounded path
                label.Region = new Region(path);

                // Fill the label background
                using (SolidBrush brush = new SolidBrush(label.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw the label text
                TextRenderer.DrawText(g, label.Text, label.Font, new Point(0, 0), label.ForeColor);
            };

            // Trigger a repaint to apply the custom drawing
            label.Invalidate();
        }
        #endregion

        #region PictureBox Methods
        public static void ApplyShadowAndRoundedBorder(PictureBox pictureBox, int borderRadius = 20, int shadowSize = 50)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Handle Paint event for custom drawing
            pictureBox.Paint += (sender, e) =>
            {
                if (pictureBox.Image == null) return;

                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                int width = pictureBox.Width;
                int height = pictureBox.Height;

                // Draw shadow
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(80, 0, 0, 0)))
                {
                    GraphicsPath shadowPath = CreateRoundedRectanglePath(new Rectangle(shadowSize, shadowSize, width - shadowSize * 2, height - shadowSize * 2), borderRadius);
                    g.FillPath(shadowBrush, shadowPath);
                }

                // Draw rounded image
                GraphicsPath imagePath = CreateRoundedRectanglePath(new Rectangle(0, 0, width, height), borderRadius);
                g.SetClip(imagePath);
                g.DrawImage(pictureBox.Image, 0, 0, width, height);
                g.ResetClip();

                // Draw border
                using (Pen borderPen = new Pen(Color.Gray, 2))
                {
                    g.DrawPath(borderPen, imagePath);
                }
            };

            pictureBox.Invalidate();
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner

            path.CloseFigure();
            return path;
        }
        #endregion

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
