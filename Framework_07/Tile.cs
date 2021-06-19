using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework_07
{
    internal class Tile
    {
        private static int counter = 0;
        private PictureBox picture;
        internal Tile(int locationX, int locationY, int width, int height, string path, Form gameForm)
        {
            this.picture = new PictureBox();
            this.picture.Location = new System.Drawing.Point(locationX, locationY);
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Size = new System.Drawing.Size(width, height);
            this.picture.ImageLocation = path;
            this.picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture.Name = $"pictureBox{counter}";
            gameForm.Controls.Add(this.picture);
            counter++;
        }
        internal PictureBox getPicture()
        {
            return picture;
        }
    }
}
