using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_06
{
    internal class MoveLeftRight : Movement
    {
        private int minimumXValue;
        private int maximumXValue;
        private bool hasRightLimit = true;
        private bool hasLeftLimit = true;
        private States currentState;
        internal MoveLeftRight()
        {
            this.minimumXValue = 0;
            this.maximumXValue = 0;
            currentState = States.Left;
        }
        public override void moveObject(int speed , PictureBox pictureBox)
        {
            if(pictureBox.Left >= maximumXValue)
            {
                currentState = States.Left;
            }
            else if(pictureBox.Left <= minimumXValue)
            {
                currentState = States.Right;
            }
            if(currentState == States.Right && hasRightLimit)
            {
                pictureBox.Left += speed;
            }
            else if(currentState == States.Left && hasLeftLimit)
            {
                pictureBox.Left -= speed;
            }
        }
        public override Types getMovementType()
        {
            return Types.LeftRight;
        }
        public override void setLeftLimit(int minimumXValue)
        {
            this.minimumXValue = minimumXValue;
        }
        public override void setRightLimit(int maximumXValue)
        {
            this.maximumXValue = maximumXValue;
        }
        public override void setIsMoveRight(bool isMoveRight)
        {
            this.hasRightLimit = isMoveRight;
        }
        public override void setIsMoveLeft(bool isMoveLeft)
        {
            this.hasLeftLimit = isMoveLeft;
        }
    }
}
