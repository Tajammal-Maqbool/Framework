using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Framework_06
{
    public class Game
    {
        private int gravity;
        private List<GameObject> allGameObjects;
        private List<Collision> allCollisionObjects;
        private static Game game;
        private static States currentKey;
        private int groundPositionX;
        private bool isHasGround;

        private Keys RightKey = Keys.Right;
        private Keys LeftKey = Keys.Left;
        private Keys UpKey = Keys.Up;
        private Keys DownKey = Keys.Down;
        private Keys JumpKey = Keys.Space;

        private Game(int gravity)
        {
            this.gravity = gravity;
            isHasGround = false;
            allGameObjects = new List<GameObject>();
            allCollisionObjects = new List<Collision>();
        }
        private Game(int gravity, int groundPositionX)
        {
            this.gravity = gravity;
            isHasGround = true;
            this.groundPositionX = groundPositionX;
            allGameObjects = new List<GameObject>();
            allCollisionObjects = new List<Collision>();
        }
        public static Game getInstance()
        {
            if (game == null)
            {
                game = new Game(0);
            }
            return game;
        }
        public static Game getInstance(int gravity)
        {
            if (game == null)
            {
                game = new Game(gravity);
            }
            return game;
        }
        public static Game getInstance(int gravity, int groundPositionX)
        {
            if (game == null)
            {
                game = new Game(gravity, groundPositionX);
            }
            return game;
        }
        public void addGameObject(GameObject createdObject)
        {
            allGameObjects.Add(createdObject);
        }
        public void addCollisionObject(Collision collision)
        {
            this.allCollisionObjects.Add(collision);
        }
        public void removeGameObject(GameObject myObject)
        {
            if (myObject != null)
            {
                int counter;
                if (allGameObjects.Count != 0)
                {
                    counter = 0;
                    for (int idx = 0; idx < allGameObjects.Count; idx++)
                    {
                        GameObject gameObject = (GameObject)allGameObjects[idx];
                        if (myObject == gameObject)
                        {
                            allGameObjects.RemoveAt(counter);
                        }
                        counter++;
                    }
                }
            }
        }
        public void update()
        {
            foreach (GameObject gameObject in allGameObjects)
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
            foreach (Collision collision in allCollisionObjects)
            {
                collision.checkCollision();
            }
            currentKey = States.None;
        }
        public void movementkeyDowned(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == RightKey)
            {
                currentKey = States.Right;
            }
            else if (e.KeyCode == LeftKey)
            {
                currentKey = States.Left;
            }
            else if (e.KeyCode == UpKey)
            {
                currentKey = States.Up;
            }
            else if (e.KeyCode == DownKey)
            {
                currentKey = States.Down;
            }
            else if(e.KeyCode == JumpKey)
            {
                currentKey = States.Jump;
            }
        }
        public void setRightKey(Keys key)
        {
            this.RightKey = key;
        }
        public void setLeftKey(Keys key)
        {
            this.LeftKey = key;
        }
        public void setUpKey(Keys key)
        {
            this.UpKey = key;
        }
        public void setDownKey(Keys key)
        {
            this.DownKey = key;
        }
        public void setJumpKey(Keys key)
        {
            this.JumpKey = key;
        }
        internal static States getCurrentKey()
        {
            return currentKey;
        }
    }
}
