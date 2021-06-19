
namespace Framework_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.player = new System.Windows.Forms.PictureBox();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.enemy02 = new System.Windows.Forms.PictureBox();
            this.enemy01 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Framework_02.Properties.Resources.Normal;
            this.player.Location = new System.Drawing.Point(120, 52);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 90);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 20;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1154, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // enemy02
            // 
            this.enemy02.BackColor = System.Drawing.Color.Transparent;
            this.enemy02.Image = global::Framework_02.Properties.Resources.Enemy_02;
            this.enemy02.Location = new System.Drawing.Point(1, 554);
            this.enemy02.Name = "enemy02";
            this.enemy02.Size = new System.Drawing.Size(50, 90);
            this.enemy02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy02.TabIndex = 2;
            this.enemy02.TabStop = false;
            // 
            // enemy01
            // 
            this.enemy01.BackColor = System.Drawing.Color.Transparent;
            this.enemy01.Image = global::Framework_02.Properties.Resources.Enemy_01;
            this.enemy01.Location = new System.Drawing.Point(1150, 554);
            this.enemy01.Name = "enemy01";
            this.enemy01.Size = new System.Drawing.Size(50, 90);
            this.enemy01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy01.TabIndex = 3;
            this.enemy01.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Framework_02.Properties.Resources.UpperGround;
            this.ground.Location = new System.Drawing.Point(948, 207);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(125, 55);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Framework_02.Properties.Resources.BackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.enemy01);
            this.Controls.Add(this.enemy02);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox enemy02;
        private System.Windows.Forms.PictureBox enemy01;
        private System.Windows.Forms.PictureBox ground;
    }
}

