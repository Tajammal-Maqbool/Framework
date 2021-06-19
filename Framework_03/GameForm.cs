using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework_03
{
    public partial class GameForm : Form
    {
        Game game;
        Factory factory;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            game = Game.getInstance(0,525);
            factory = Factory.getInstance();
            GameObject playerObject  = factory.createGameObject(player, true, 5,new MoveWithKeyBoard(), Rolls.Player);
            GameObject enemy01Object = factory.createGameObject(enemy_01, false, 5, new MoveLeft(450), Rolls.Enemy);
            GameObject enemy02Object = factory.createGameObject(enemy_02, false, 2, new MoveRight(550), Rolls.Enemy);
            GameObject groundObject  = factory.createGameObject(ground, false, 2, new MoveLeftRight(200,800), Rolls.None);
            game.add(playerObject);
            game.add(enemy01Object);
            game.add(enemy02Object);
            game.add(groundObject);
        }
        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
            this.label.Text = "Total Players  : " + factory.getCounterList()[0] + "\r\nTotal Enemies: " + factory.getCounterList()[1];
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            game.keyDowned(sender, e);
        }
    }
}
