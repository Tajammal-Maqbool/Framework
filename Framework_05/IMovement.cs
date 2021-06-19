using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_05
{
    public interface IMovement
    {
        public void moveObject(int speed, PictureBox pictureBox);
        public Types getMovementType();
    }
}
