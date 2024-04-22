using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectanglePainter
{
    public partial class RectanglePainterForm : Form
    {
        private Bitmap originImage;

        public RectanglePainterForm()
        {
            InitializeComponent();
        }

        private void SelectImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImgView.Image = new Bitmap(dialog.FileName);
                    originImage = new Bitmap(dialog.FileName);
                    ImgView.Size = ImgView.Image.Size;
                    ImageResolutionLabel.Text = $"Image Resolution {ImgView.Size.Width}x{ImgView.Size.Height}";
                } catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int formWidth = this.Size.Width;
            int formHeight = this.Size.Height;

            if (ImgView.Image != null && ImgView.Image.Size.Width > 500)
            {
                formWidth = ImgView.Image.Size.Width + 100;
            }
            if (ImgView.Image != null && ImgView.Image.Size.Height > 377)
            {
                formHeight = ImgView.Image.Size.Height + 150;
            }

            this.Size = new Size(formWidth, formHeight);
        }

        private void PaintButton_Click(object sender, EventArgs e)
        {
            if (ImgView.Image == null || XTextBox.Text.Equals("") || YTextBox.Text.Equals("") || WidthTextBox.Text.Equals("") || HeightTextBox.Text.Equals("")) {
                return;
            }

            Bitmap image = new Bitmap(originImage);
            Rectangle rectangle = new Rectangle(Int32.Parse(XTextBox.Text), Int32.Parse(YTextBox.Text), Int32.Parse(WidthTextBox.Text), Int32.Parse(HeightTextBox.Text));

            using (Graphics g = Graphics.FromImage(image))
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    g.DrawRectangle(pen, rectangle);
                }
            }

            ImgView.Image = image;
        }

        private void ProcessKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessKeyPress(e);
        }

        private void YTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessKeyPress(e);
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessKeyPress(e);
        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessKeyPress(e);
        }
    }
}
