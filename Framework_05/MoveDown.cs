using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_05
{
    public class MoveDown : IOneDMovement
    {
        private int downLimit;
        private bool hasLimit;
        internal MoveDown()
        {
            this.hasLimit = false;
        }
        public void moveObject(int speed, PictureBox pictureBox)
        {
            pictureBox.Top += speed;
            if (hasLimit)
            {
                if (pictureBox.Top >= downLimit)
                {
                    pictureBox.Top -= speed;
                }
            }
        }
        public Types getMovementType()
        {
            return Types.Down;
        }
        public void setLimit(int downLimit)
        {
            this.downLimit = downLimit;
        }
        public void setHasLimit(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
