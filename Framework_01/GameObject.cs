using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_01
{
    class GameObject
    {
        PictureBox pictureBoxObject;
        public GameObject(PictureBox pictureBoxObject)
        {
            this.pictureBoxObject = pictureBoxObject;
        }
        public void putGravity(int gravity)
        {
            pictureBoxObject.Top += gravity;
        }
    }
}
