using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework_01
{
    public partial class GameForm : Form
    {
        Game game = new Game(10); // Puttiing Gravity On the Object
        public GameForm()
        {
            InitializeComponent();
            GameObject playerObject = new GameObject(this.player);
            game.add(playerObject);
        }
        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
