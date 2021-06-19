using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_03
{
    class MoveDown: IMovement
    {
        private int downLimit;
        private bool isLimitPut;
        public MoveDown()
        {
            this.isLimitPut = false;
        }
        public MoveDown(int leftLimit)
        {
            this.isLimitPut = true;
            this.downLimit = leftLimit;
        }
        public void moveObject(int speed, PictureBox pictureBox)
        {
            pictureBox.Top += speed;
            if (isLimitPut)
            {
                if (pictureBox.Top >= downLimit)
                {
                    pictureBox.Top -= speed;
                }
            }
        }
    }
}
