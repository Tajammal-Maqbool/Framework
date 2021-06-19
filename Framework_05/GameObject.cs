using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Framework_05
{
    public class GameObject
    {
        private PictureBox pictureBoxObject;
        private IOneDMovement movement1;
        private ITwoDMovement movement2;
        private IMultiDMovement movement3;
        private bool hasGravity;
        private int speed;
        internal GameObject(PictureBox pictureBoxObject,bool hasGravity)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.hasGravity = hasGravity;
            this.speed = 0;
            this.movement1 = null;
            this.movement2 = null;
            this.movement3 = null;
        }
        internal GameObject(PictureBox pictureBoxObject,bool hasGravity , int speed ,IOneDMovement movement)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.hasGravity = hasGravity;
            this.speed = speed;
            this.movement1 = movement;
            this.movement2 = null;
            this.movement3 = null;
        }
        internal GameObject(PictureBox pictureBoxObject, bool hasGravity, int speed, ITwoDMovement movement)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.hasGravity = hasGravity;
            this.speed = speed;
            this.movement1 = null;
            this.movement2 = movement;
            this.movement3 = null;
        }
        internal GameObject(PictureBox pictureBoxObject, bool hasGravity, int speed, IMultiDMovement movement)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.hasGravity = hasGravity;
            this.speed = speed;
            this.movement1 = null;
            this.movement2 = null;
            this.movement3 = movement;
        }
        internal void update(int gravity)
        {
            if (hasGravity)
            {
                pictureBoxObject.Top += gravity;
            }
            if(movement1 != null)
            {
                movement1.moveObject(speed, pictureBoxObject);
            }
            else if(movement2 != null)
            {
                movement2.moveObject(speed, pictureBoxObject);
            }
            else if(movement3 != null)
            {
                movement3.moveObject(speed, pictureBoxObject);
            }
        }
        internal void update(int gravity, int groundPositionX)
        {
            if (hasGravity)
            {
                pictureBoxObject.Top += gravity;
                if (pictureBoxObject.Bottom > groundPositionX)
                {
                    pictureBoxObject.Top -= gravity;
                }
            }
            if (movement1 != null)
            {
                movement1.moveObject(speed, pictureBoxObject);
            }
            else if (movement2 != null) 
            {
                movement2.moveObject(speed, pictureBoxObject);
            }
            else if(movement3 != null)
            {
                movement3.moveObject(speed, pictureBoxObject);
            }
        }
        public void setGravity(bool hasGravity)
        {
            this.hasGravity = hasGravity;
        }
        public void changeMovemnet(IOneDMovement movement)
        {
            MovementPool pool = MovementPool.getInstance();
            if (movement1 != null)
            {
                pool.realseMovement(movement);
            }
            else if (movement2 != null)
            {
                pool.realseMovement(movement);
            }
            else if (movement3 != null)
            {
                pool.realseMovement(movement);
            }
            this.movement1 = movement;
            this.movement2 = null;
            this.movement3 = null;
        }
        public void changeMovemnet(ITwoDMovement movement)
        {
            MovementPool pool = MovementPool.getInstance();
            if (movement1 != null)
            {
                pool.realseMovement(movement);
            }
            else if (movement2 != null)
            {
                pool.realseMovement(movement);
            }
            else if (movement3 != null)
            {
                pool.realseMovement(movement);
            }
            this.movement1 = null;
            this.movement2 = movement;
            this.movement3 = null;

        }
        public void changeMovemnet(IMultiDMovement movement)
        {
            MovementPool pool = MovementPool.getInstance();
            if (movement1 != null)
            {
                pool.realseMovement(movement);
            }
            else if (movement2 != null)
            {
                pool.realseMovement(movement);
            }
            else if (movement3 != null)
            {
                pool.realseMovement(movement);
            }
            this.movement1 = null;
            this.movement2 = null;
            this.movement3 = movement;
        }
        ~GameObject()
        {
            if (movement1 != null)
            {
                MovementPool pool = MovementPool.getInstance();
                pool.realseMovement(movement1);
            }
            else if (movement2 != null)
            {
                MovementPool pool = MovementPool.getInstance();
                pool.realseMovement(movement2);
            }
            else if (movement3 != null)
            {
                MovementPool pool = MovementPool.getInstance();
                pool.realseMovement(movement3);
            }
        }
    }
}
