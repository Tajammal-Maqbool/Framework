using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_04
{
    public class MoveLeft : IMovement
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
        public void moveObject(int speed, PictureBox pictureBox)
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
