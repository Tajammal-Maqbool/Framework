using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_04
{
    public class MoveUp : IMovement
    {
        private int upLimit;
        private bool isLimitPut;
        public MoveUp()
        {
            this.isLimitPut = false;
        }
        public MoveUp(int leftLimit)
        {
            this.isLimitPut = true;
            this.upLimit = leftLimit;
        }
        public void moveObject(int speed, PictureBox pictureBox)
        {
            pictureBox.Top -= speed;
            if (isLimitPut)
            {
                if (pictureBox.Top <= upLimit)
                {
                    pictureBox.Top += speed;
                }
            }
        }
    }
}
