using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_03
{
    class MoveLeftRight: IMovement
    {
        private int minimumXValue;
        private int maximumXValue;
        private State currentState;
        public MoveLeftRight(int minimumXValue , int maximumXValue)
        {
            this.minimumXValue = minimumXValue;
            this.maximumXValue = maximumXValue;
            currentState = State.Left;
        }
        public void moveObject(int speed , PictureBox pictureBox)
        {
            if(pictureBox.Left >= maximumXValue)
            {
                currentState = State.Left;
            }
            else if(pictureBox.Left <= minimumXValue)
            {
                currentState = State.Right;
            }
            if(currentState == State.Right)
            {
                pictureBox.Left += speed;
            }
            else
            {
                pictureBox.Left -= speed;
            }
        }
    }
}
