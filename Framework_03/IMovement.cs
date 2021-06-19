using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_03
{
    interface IMovement
    {
        public void moveObject(int speed, PictureBox pictureBox);
    }
}
