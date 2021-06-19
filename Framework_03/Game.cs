using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Framework_03
{
    class Game
    {
        //Singleton Class
        private int gravity;
        private ArrayList allGameObjects;
        private static Game game;
        private static State currentKey;
        private int groundPositionX;
        private bool isHasGround;
        private Game(int gravity)
        {
            this.gravity = gravity;
            allGameObjects = new ArrayList();
            isHasGround = false;
        }
        private Game(int gravity,int groundPositionX)
        {
            this.gravity = gravity;
            this.groundPositionX = groundPositionX;
            allGameObjects = new ArrayList();
            isHasGround = true;
        }
        public static Game getInstance(int gravity)
        {
            if(game == null)
            {
                game = new Game(gravity);
            }
            return game;
        }
        public static Game getInstance(int gravity,int groundPositionX)
        {
            if (game == null)
            {
                game = new Game(gravity,groundPositionX);
            }
            return game;
        }
        public void add(GameObject createdObject)
        {
            allGameObjects.Add(createdObject);
        }
        public void update()
        {
            foreach(GameObject gameObject in allGameObjects)
            {
                if (isHasGround)
                {
                    gameObject.update(gravity, groundPositionX);
                }
                else
                {
                    gameObject.update(gravity);
                }
            }
            currentKey = State.None;
        }
        public void keyDowned(object sender , KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                currentKey = State.Right;
            }
            else if(e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                currentKey = State.Left;
            }
            else if(e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                currentKey = State.Up;
            }
            else if(e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                currentKey = State.Down;
            }
        }
        public static State getCurrentKey()
        {
            return currentKey;
        }
    }
}
