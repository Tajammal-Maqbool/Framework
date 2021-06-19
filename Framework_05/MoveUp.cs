using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_05
{
    public class MoveUp : IOneDMovement
    {
        private int  upLimit;
        private bool hasLimit;
        internal MoveUp()
        {
            this.hasLimit = false;
        }
        public void moveObject(int speed, PictureBox pictureBox)
        {
            pictureBox.Top -= speed;
            if (hasLimit)
            {
                if (pictureBox.Top <= upLimit)
                {
                    pictureBox.Top += speed;
                }
            }
        }
        public Types getMovementType()
        {
            return Types.Up;
        }
        public void setLimit(int upLimit)
        {
            this.upLimit = upLimit;
        }
        public void setHasLimit(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
