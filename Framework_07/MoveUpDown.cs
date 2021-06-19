using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_07
{
    internal class MoveUpDown : Movement
    {
        private int minimumYValue;
        private int maximumYValue;
        private bool isMoveUp;
        private bool isMoveDown;
        private PlayerStates currentState;
        internal MoveUpDown()
        {
            this.minimumYValue = 0;
            this.maximumYValue = 0;
            currentState = PlayerStates.Up;
        }
        public override void moveObject(int speed, PictureBox pictureBox)
        {
            if (pictureBox.Top >= maximumYValue)
            {
                currentState = PlayerStates.Up;
            }
            else if (pictureBox.Top <= minimumYValue)
            {
                currentState = PlayerStates.Down;
            }
            if (currentState == PlayerStates.Up && isMoveUp)
            {
                pictureBox.Top -= speed;
            }
            else if(currentState == PlayerStates.Down && isMoveDown)
            {
                pictureBox.Top += speed;
            }
        }
        public override MovementTypes getMovementType()
        {
            return MovementTypes.UpDown;
        }
        public override void setUpLimit(int minimumYValue)
        {
            this.minimumYValue = minimumYValue;
        }
        public void setIsMoveUp(int maximumYValue)
        {
            this.maximumYValue = maximumYValue;
        }
        public override void setIsMoveUp(bool isMoveUp)
        {
            this.isMoveUp = isMoveUp;
        }
        public override void setIsMoveDown(bool isMoveDown)
        {
            this.isMoveDown = isMoveDown;
        }
    }
}
