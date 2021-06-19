using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_02
{
    class MoveLeft
    {
        private int leftLimit;
        private bool isLimitPut;
        public MoveLeft()
        {
            this.isLimitPut = false;
        }
        public MoveLeft(int leftLimit)
        {
            this.isLimitPut = true;
            this.leftLimit = leftLimit;
        }
        public void moveLeft(int speed, PictureBox pictureBox)
        {
            pictureBox.Left -= speed;
            if (isLimitPut)
            {
                if(pictureBox.Left <= leftLimit)
                {
                    pictureBox.Left += speed;
                }
            }
        }
    }
}
