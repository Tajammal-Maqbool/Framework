using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework_02
{
    public partial class GameForm : Form
    {
        Game game;
        public GameForm()
        {
            InitializeComponent();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            game = Game.getInstance(5,640);
            GameObject playerObject  = new GameObject(player,true,5,new MoveWithKeyBoard());
            GameObject enemyObject01 = new GameObject(enemy01,true,5, new MoveLeft(700));
            GameObject enemyObject02 = new GameObject(enemy02,true,5, new MoveRight(500));
            GameObject groundObject = new GameObject(ground,false,5, new MoveLeftRight(800,1050));
            game.add(playerObject);
            game.add(enemyObject01);
            game.add(enemyObject02);
            game.add(groundObject);
        }
        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            game.keyDowned(sender, e);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
