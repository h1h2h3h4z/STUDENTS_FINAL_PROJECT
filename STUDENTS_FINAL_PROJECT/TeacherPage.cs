using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static STUDENTS_FINAL_PROJECT.UCenrollement;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class TeacherPage : Form
    {
        int teacherid;
        public TeacherPage(int teacherid1)
        {
            InitializeComponent();
            RoundLabel(lblemail, 15);
            RoundLabel(lblphone, 15);
            RoundLabel(lblid, 15);
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.FlatAppearance.BorderSize = 0;
            exitbtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            teacherid = teacherid1;
        }
        private void TeacherPage_Load(object sender, EventArgs e)
        {
            TEACHER_PAGE th = new TEACHER_PAGE();
            TEACHER_PAGE teacher = th.GetteacherInfo(teacherid);

            if (teacher != null)
            {
                lblemail.Text += teacher.teacheremail;
                lblid.Text += teacher.teacherid;
                lblphone.Text += teacher.teacherphone;
                lblnamedate.Text = teacher.teachername + "-" + teacher.teacherdateofbirth;

                if (teacherimage != null)
                {
                    teacherimage.ImageLocation = teacher.teacherimage;
                    teacherimage.Load();
                    ApplyShadowAndRoundedBorder(teacherimage);
                }

                List<(string coursename, string studentname, string studentimage)> Studentlist = th.GetTeacherCoursestoteacher(teacherid);
               

                Panel panelStudent = new Panel
                {
                    Size = new Size(900, 500),  
                    Location = new Point(28, 370)
                };
                this.Controls.Add(panelStudent);

                int x = 10;
                int y = 10;
                int itemWidth = 140;
                int itemHeight = 210;
                int spacingX = 30;
                int spacingY = 20;
                int columns = 5; 

                int count = 0;
                foreach (var student in Studentlist)
                {
                    if (count % columns == 0 && count != 0)
                    {
                        x = 10;
                        y += itemHeight + spacingY;
                    }

                    PictureBox pictureBox = new PictureBox
                    {
                        Name = "studentname_" + student.studentname,
                        Size = new Size(160, 150),
                        Location = new Point(x, y),
                        BackColor = Color.Transparent,
                        BorderStyle = BorderStyle.None,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand
                    };
                    if (!string.IsNullOrEmpty(student.studentimage))
                    {
                        pictureBox.ImageLocation = student.studentimage;
                        pictureBox.Load();
                    }
                    ApplyShadowAndRoundedBorder(pictureBox);
                    panelStudent.Controls.Add(pictureBox);

                    Label lblStudent = new Label
                    {
                        Text = $"{student.studentname}-{student.coursename}",
                        Size = new Size(160, 50),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(x, y + 150),
                        BackColor = Color.Silver,
                        ForeColor = Color.Black
                    };
                    StyleLabel(lblStudent, Color.Silver, Color.Black, "Segoe UI", 12, true);
                    RoundLabel(lblStudent, 13);
                    panelStudent.Controls.Add(lblStudent);

                    x += itemWidth + spacingX;
                    count++;
                }
            }
        }

        #region
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
