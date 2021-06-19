using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Framework_01
{
    class Game
    {
        private int gravity;
        private ArrayList allGameObjects;
        public Game(int gravity)
        {
            this.gravity = gravity;
            allGameObjects = new ArrayList();
        }
        public void add(GameObject createdObject)
        {
            allGameObjects.Add(createdObject);
        }
        public void update()
        {
            for(int i=0; i < allGameObjects.Count; i++)
            {
                GameObject gameObject = (GameObject)allGameObjects[i];
                gameObject.putGravity(gravity);
            }
        }
    }
}
