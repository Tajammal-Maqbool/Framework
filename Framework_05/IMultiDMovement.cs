using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_05
{
    public interface IMultiDMovement: IMovement
    {
        public void setIsMoveRight(bool isMoveRight);
        public void setIsMoveLeft(bool isMoveLeft);
        public void setIsMoveUp(bool isMoveUp);
        public void setIsMoveDown(bool isMoveDown);
        public void setIsJump(bool isJump);
        public void setRightLimt(int rightLimit);
        public void setLeftLimt(int leftLimit);
        public void setUpLimt(int upLimit);
        public void setDownLimt(int downLimit);
        public void setJumpSpeed(int jumpSpeed);
    }
}
