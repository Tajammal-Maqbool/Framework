
namespace Framework_03
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.enemy_02 = new System.Windows.Forms.PictureBox();
            this.enemy_01 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Framework_03.Properties.Resources.Normal;
            this.player.Location = new System.Drawing.Point(67, 74);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 90);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 42);
            this.label.TabIndex = 1;
            this.label.Text = "Total Players  : 0\r\nTotal Enemies: 0";
            // 
            // enemy_02
            // 
            this.enemy_02.BackColor = System.Drawing.Color.Transparent;
            this.enemy_02.Image = global::Framework_03.Properties.Resources.Enemy_02;
            this.enemy_02.Location = new System.Drawing.Point(0, 363);
            this.enemy_02.Name = "enemy_02";
            this.enemy_02.Size = new System.Drawing.Size(60, 90);
            this.enemy_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy_02.TabIndex = 2;
            this.enemy_02.TabStop = false;
            // 
            // enemy_01
            // 
            this.enemy_01.BackColor = System.Drawing.Color.Transparent;
            this.enemy_01.Image = global::Framework_03.Properties.Resources.Enemy_01;
            this.enemy_01.Location = new System.Drawing.Point(925, 363);
            this.enemy_01.Name = "enemy_01";
            this.enemy_01.Size = new System.Drawing.Size(60, 90);
            this.enemy_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy_01.TabIndex = 3;
            this.enemy_01.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Framework_03.Properties.Resources.UpperGround;
            this.ground.Location = new System.Drawing.Point(617, 227);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(122, 51);
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Framework_03.Properties.Resources.BackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.enemy_01);
            this.Controls.Add(this.enemy_02);
            this.Controls.Add(this.label);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox enemy_02;
        private System.Windows.Forms.PictureBox enemy_01;
        private System.Windows.Forms.PictureBox ground;
    }
}

