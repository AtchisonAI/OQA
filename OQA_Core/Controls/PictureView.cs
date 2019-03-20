using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OQA_Core.Controls
{

    public partial class PictureView : UserControl
    {
        public class ImageObj
        {
            public int imgHeigth { get; set; }
            public int imgWidth { get; set; }
            public string imgPath { get; set; }

            public void Initial(string Path, int Heigth, int Width)
            {
                imgPath = Path;
                imgHeigth = Heigth;
                imgWidth = Width;
            }
        }

        public PictureView()
        {
            InitializeComponent();
            InitPara();
        }

        private void InitPara()
        {
            imageObj = new ImageObj();
            isSelected = false;
        }

        private Point mouseDownPoint { get; set; }
        private bool isSelected { get; set; }
        private ImageObj imageObj { get; set; }


        public void LoadImage(string url)
        {
            name_label.Text = url;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Load(url);
            imageObj.Initial(url,pictureBox.Image.Height, pictureBox.Image.Width);
            picZoomToPanle();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void LoadImageAsync(string url)
        {
            name_label.Text = url;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.LoadAsync(url);
            imageObj.imgPath = url;
        }

        private void picZoomToPanle()
        {
            pictureBox.Height = imageObj.imgHeigth;
            pictureBox.Width = imageObj.imgWidth;

            //Point cur = PointToScreen( new Point(,);
            pictureBox.Left = (picture_panel.Width - imageObj.imgWidth) / 2 + picture_panel.Left;
            pictureBox.Top = (picture_panel.Height - imageObj.imgHeigth) / 2 + picture_panel.Top;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            pictureBox.Focus();
            pictureBox.Cursor = Cursors.SizeAll;
            pictureBox.MouseWheel += new MouseEventHandler(pictureBox_MouseWheel);
        }

        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int i = e.Delta * SystemInformation.MouseWheelScrollLines / 5;
            ScalImg(i);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint = Cursor.Position;
                isSelected = true;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelected && IsMouseInPanel())//确定已经激发MouseDown事件，和鼠标在picturebox的范围内
            {
                this.pictureBox.Left = this.pictureBox.Left + (Cursor.Position.X - mouseDownPoint.X);
                this.pictureBox.Top = this.pictureBox.Top + (Cursor.Position.Y - mouseDownPoint.Y);
                mouseDownPoint = Cursor.Position;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isSelected = false;
        }

        private bool IsMouseInPanel()
        {
            if (this.picture_panel.Left < PointToClient(Cursor.Position).X && PointToClient(Cursor.Position).X < this.picture_panel.Left + this.picture_panel.Width && this.picture_panel.Top < PointToClient(Cursor.Position).Y && PointToClient(Cursor.Position).Y < this.picture_panel.Top + this.picture_panel.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void enlarge_button_Click(object sender, EventArgs e)
        {
            ScalImg(GetScale());
        }

        private void reduce_button_Click(object sender, EventArgs e)
        {
            ScalImg(0- GetScale());
        }

        private int GetScale()
        {
            int scale = pictureBox.Width / 5;
            if (scale < 50)
                scale = 50;
            return scale;
        }

        private void zoom_button_Click(object sender, EventArgs e)
        {
            picZoomToPanle();
        }

        private void lspin_button_Click(object sender, EventArgs e)
        {
            if(null != pictureBox.Image)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox.Refresh();
            }
        }

        private void rspin_button_Click(object sender, EventArgs e)
        {
            if (null != pictureBox.Image)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Refresh();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if(null == pictureBox.Image || string.IsNullOrEmpty(imageObj.imgPath))
            {
                MessageBox.Show("请先绑定图像");
                return;
            }
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = imageObj.imgPath.Substring(imageObj.imgPath.LastIndexOf('\\')+1);
            save.Filter = "(.jpg)|*.jpg";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(pictureBox.ClientRectangle.Width, pictureBox.ClientRectangle.Height);
                pictureBox.DrawToBitmap(bit, pictureBox.ClientRectangle);
                bit.Save(save.FileName);
            }
        }

        private void print_button_Click(object sender, EventArgs e)
        {

        }

        private void ScalImg(int scale)
        {
            double hwScale = (double) pictureBox.Height / pictureBox.Width;
            if (pictureBox.Width + scale <= 0 || pictureBox.Height + scale* hwScale <= 0) return;

            pictureBox.Width = pictureBox.Width + scale;//增加picturebox的宽度
            pictureBox.Height = pictureBox.Height + (int)(scale * hwScale);
            pictureBox.Left = pictureBox.Left - scale / 2;//使picturebox的中心位于窗体的中心
            pictureBox.Top = pictureBox.Top - (int)(scale * hwScale) / 2;//进而缩放时图片也位于窗体的中心
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureBox.MouseWheel -= new MouseEventHandler(pictureBox_MouseWheel);
        }

        private void pictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            imageObj.imgHeigth = pictureBox.Image.Height;
            imageObj.imgWidth = pictureBox.Image.Width;
            picZoomToPanle();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
