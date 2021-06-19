using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_05
{
    public class MoveLeftRight : ITwoDMovement
    {
        private int minimumXValue;
        private int maximumXValue;
        private States currentState;
        internal MoveLeftRight()
        {
            this.minimumXValue = 0;
            this.maximumXValue = 0;
            currentState = States.Left;
        }
        public void moveObject(int speed , PictureBox pictureBox)
        {
            if(pictureBox.Left >= maximumXValue)
            {
                currentState = States.Left;
            }
            else if(pictureBox.Left <= minimumXValue)
            {
                currentState = States.Right;
            }
            if(currentState == States.Right)
            {
                pictureBox.Left += speed;
            }
            else
            {
                pictureBox.Left -= speed;
            }
        }
        public Types getMovementType()
        {
            return Types.LeftRight;
        }
        public void setMinimumLimit(int minimumXValue)
        {
            this.minimumXValue = minimumXValue;
        }
        public void setMaximumLimit(int maximumXValue)
        {
            this.maximumXValue = maximumXValue;
        }
    }
}
