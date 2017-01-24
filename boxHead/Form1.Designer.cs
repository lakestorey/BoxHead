namespace boxHead
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newGameLabel = new System.Windows.Forms.Label();
            this.chooseCharacterLabel = new System.Windows.Forms.Label();
            this.howToPlayLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.character3Box = new System.Windows.Forms.PictureBox();
            this.character2Box = new System.Windows.Forms.PictureBox();
            this.character1Box = new System.Windows.Forms.PictureBox();
            this.titleScreenPicture = new System.Windows.Forms.PictureBox();
            this.startGameLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.character3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleScreenPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameLabel
            // 
            this.newGameLabel.AutoSize = true;
            this.newGameLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameLabel.Location = new System.Drawing.Point(228, 187);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(177, 45);
            this.newGameLabel.TabIndex = 1;
            this.newGameLabel.Text = "New Game";
            this.newGameLabel.Click += new System.EventHandler(this.newGameLabel_Click);
            // 
            // chooseCharacterLabel
            // 
            this.chooseCharacterLabel.AutoSize = true;
            this.chooseCharacterLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCharacterLabel.Location = new System.Drawing.Point(172, 232);
            this.chooseCharacterLabel.Name = "chooseCharacterLabel";
            this.chooseCharacterLabel.Size = new System.Drawing.Size(283, 45);
            this.chooseCharacterLabel.TabIndex = 2;
            this.chooseCharacterLabel.Text = "Choose Character";
            this.chooseCharacterLabel.Click += new System.EventHandler(this.chooseCharacterLabel_Click);
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.AutoSize = true;
            this.howToPlayLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayLabel.Location = new System.Drawing.Point(218, 277);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(202, 45);
            this.howToPlayLabel.TabIndex = 3;
            this.howToPlayLabel.Text = "How To Play";
            this.howToPlayLabel.Click += new System.EventHandler(this.howToPlayLabel_Click);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.Location = new System.Drawing.Point(535, 358);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(45, 23);
            this.backLabel.TabIndex = 4;
            this.backLabel.Text = "Back";
            this.backLabel.Visible = false;
            this.backLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // character3Box
            // 
            this.character3Box.Image = global::boxHead.Properties.Resources.Hero3;
            this.character3Box.Location = new System.Drawing.Point(107, 167);
            this.character3Box.Name = "character3Box";
            this.character3Box.Size = new System.Drawing.Size(59, 85);
            this.character3Box.TabIndex = 7;
            this.character3Box.TabStop = false;
            this.character3Box.Click += new System.EventHandler(this.character3Box_Click);
            // 
            // character2Box
            // 
            this.character2Box.Image = global::boxHead.Properties.Resources.Hero2;
            this.character2Box.Location = new System.Drawing.Point(269, 154);
            this.character2Box.Name = "character2Box";
            this.character2Box.Size = new System.Drawing.Size(71, 101);
            this.character2Box.TabIndex = 6;
            this.character2Box.TabStop = false;
            this.character2Box.Click += new System.EventHandler(this.character2Box_Click);
            // 
            // character1Box
            // 
            this.character1Box.Image = global::boxHead.Properties.Resources.Hero1;
            this.character1Box.Location = new System.Drawing.Point(461, 154);
            this.character1Box.Name = "character1Box";
            this.character1Box.Size = new System.Drawing.Size(87, 98);
            this.character1Box.TabIndex = 5;
            this.character1Box.TabStop = false;
            this.character1Box.Click += new System.EventHandler(this.character1Box_Click);
            // 
            // titleScreenPicture
            // 
            this.titleScreenPicture.Image = global::boxHead.Properties.Resources.titleScreen;
            this.titleScreenPicture.Location = new System.Drawing.Point(132, 12);
            this.titleScreenPicture.Name = "titleScreenPicture";
            this.titleScreenPicture.Size = new System.Drawing.Size(364, 166);
            this.titleScreenPicture.TabIndex = 0;
            this.titleScreenPicture.TabStop = false;
            // 
            // startGameLabel
            // 
            this.startGameLabel.AutoSize = true;
            this.startGameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameLabel.Location = new System.Drawing.Point(486, 358);
            this.startGameLabel.Name = "startGameLabel";
            this.startGameLabel.Size = new System.Drawing.Size(94, 23);
            this.startGameLabel.TabIndex = 8;
            this.startGameLabel.Text = "Start Game";
            this.startGameLabel.Visible = false;
            this.startGameLabel.Click += new System.EventHandler(this.startGameLabel_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 390);
            this.Controls.Add(this.startGameLabel);
            this.Controls.Add(this.character3Box);
            this.Controls.Add(this.character2Box);
            this.Controls.Add(this.character1Box);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.howToPlayLabel);
            this.Controls.Add(this.chooseCharacterLabel);
            this.Controls.Add(this.newGameLabel);
            this.Controls.Add(this.titleScreenPicture);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Box Head";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.character3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleScreenPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titleScreenPicture;
        private System.Windows.Forms.Label newGameLabel;
        private System.Windows.Forms.Label chooseCharacterLabel;
        private System.Windows.Forms.Label howToPlayLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.PictureBox character1Box;
        private System.Windows.Forms.PictureBox character2Box;
        private System.Windows.Forms.PictureBox character3Box;
        private System.Windows.Forms.Label startGameLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

