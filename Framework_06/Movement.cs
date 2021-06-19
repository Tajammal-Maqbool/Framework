using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_06
{
    public class Movement
    {
        internal Movement()
        { 
          //Private Empty Constructor
        }

        public virtual Types getMovementType()
        {
            return Types.None;
        }
        public virtual void moveObject(int speed, PictureBox pictureBox) { }
        public virtual void setIsMoveRight(bool isMoveRight) { }
        public virtual void setIsMoveLeft(bool isMoveLeft) { } 
        public virtual void setIsMoveUp(bool isMoveUp) { } 
        public virtual void setIsMoveDown(bool isMoveDown) { } 
        public virtual void setIsJump(bool isJump) { } 
        public virtual void setRightLimit(int rightLimit) { } 
        public virtual void setLeftLimit(int lftLimit) { } 
        public virtual void setUpLimit(int upLimit) { }
        public virtual void setDownLimit(int downLimit) { }
        public virtual void setJumpSpeed(int jumpSpeed) { }
    }
}
