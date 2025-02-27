using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class StudentDetail_Form : Form
    {
        public int studentid;
        public string studentname;
        public string studentphone;
        public string studentemail;
        public DateTime studentbirthdate;
        public string studentimagep;

        public StudentDetail_Form(int studentid, string studentname, string studentphone, string studentemail, DateTime studentbirthdate, string studentimagep)
        {
            InitializeComponent();
            RoundForm(this, 30);
            this.studentid = studentid;  // Use "this" to refer to instance variables
            this.studentname = studentname;
            this.studentphone = studentphone;
            this.studentemail = studentemail;
            this.studentbirthdate = studentbirthdate;
            this.studentimagep = studentimagep;
            RoundLabel(lblemail, 15);
            RoundLabel(lblphone, 15);
            RoundLabel(lblid, 15);
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.FlatAppearance.BorderSize = 0;  // Removes the border
            exitbtn.FlatAppearance.MouseOverBackColor = Color.Transparent; // Optional: Change color when hovered
            exitbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        public static void RoundForm(Form targetForm, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            // Create rounded rectangle path
            path.AddArc(0, 0, diameter, diameter, 180, 90); // Top-left
            path.AddArc(targetForm.Width - diameter, 0, diameter, diameter, 270, 90); // Top-right
            path.AddArc(targetForm.Width - diameter, targetForm.Height - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(0, targetForm.Height - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            // Apply rounded region to the form
            targetForm.Region = new Region(path);
        }
        private void StudentDetail_Form_Load(object sender, EventArgs e)
        {
            lblnamedate.Text = studentname + " - " + studentbirthdate.ToString("yyyy-MM-dd");
            lblid.Text += studentid.ToString();
            lblphone.Text += studentphone;
            lblemail.Text += studentemail;
            if (!string.IsNullOrEmpty(studentimagep))  // Check if image path is valid
            {
                studentimage.ImageLocation = studentimagep;
                studentimage.Load();
                ApplyShadowAndRoundedBorder(studentimage);
            }
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

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
