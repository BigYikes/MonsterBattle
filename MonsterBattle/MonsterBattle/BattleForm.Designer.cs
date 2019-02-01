namespace MonsterBattle
{
    partial class BattleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.attackButton = new System.Windows.Forms.Button();
            this.attackTimer = new System.Windows.Forms.Timer(this.components);
            this.screenShakeTimer = new System.Windows.Forms.Timer(this.components);
            this.switchButton = new System.Windows.Forms.Button();
            this.bagButton = new System.Windows.Forms.Button();
            this.attackButton2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enemyLevel = new System.Windows.Forms.Label();
            this.enemyHealthPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.friendlyPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(16, 283);
            this.attackButton.Margin = new System.Windows.Forms.Padding(4);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(115, 75);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Cannon";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // attackTimer
            // 
            this.attackTimer.Interval = 1000;
            this.attackTimer.Tick += new System.EventHandler(this.attackTimer_Tick);
            // 
            // screenShakeTimer
            // 
            this.screenShakeTimer.Interval = 50;
            this.screenShakeTimer.Tick += new System.EventHandler(this.screenShakeTimer_Tick);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(340, 284);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(109, 74);
            this.switchButton.TabIndex = 2;
            this.switchButton.Text = "Switch";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // bagButton
            // 
            this.bagButton.Location = new System.Drawing.Point(467, 284);
            this.bagButton.Name = "bagButton";
            this.bagButton.Size = new System.Drawing.Size(109, 74);
            this.bagButton.TabIndex = 3;
            this.bagButton.Text = "Bag";
            this.bagButton.UseVisualStyleBackColor = true;
            this.bagButton.Click += new System.EventHandler(this.bagButton_Click);
            // 
            // attackButton2
            // 
            this.attackButton2.Location = new System.Drawing.Point(148, 284);
            this.attackButton2.Margin = new System.Windows.Forms.Padding(4);
            this.attackButton2.Name = "attackButton2";
            this.attackButton2.Size = new System.Drawing.Size(121, 75);
            this.attackButton2.TabIndex = 4;
            this.attackButton2.Text = "Tackle";
            this.attackButton2.UseVisualStyleBackColor = true;
            this.attackButton2.Click += new System.EventHandler(this.attackButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.enemyPictureBox);
            this.panel1.Controls.Add(this.friendlyPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 276);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(340, 207);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 65);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 6);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.enemyLevel);
            this.panel2.Controls.Add(this.enemyHealthPictureBox);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 60);
            this.panel2.TabIndex = 2;
            // 
            // enemyLevel
            // 
            this.enemyLevel.AutoSize = true;
            this.enemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLevel.Location = new System.Drawing.Point(204, 11);
            this.enemyLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(17, 17);
            this.enemyLevel.TabIndex = 4;
            this.enemyLevel.Text = "1";
            // 
            // enemyHealthPictureBox
            // 
            this.enemyHealthPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealthPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyHealthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyHealthPictureBox.Image")));
            this.enemyHealthPictureBox.Location = new System.Drawing.Point(99, 34);
            this.enemyHealthPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyHealthPictureBox.Name = "enemyHealthPictureBox";
            this.enemyHealthPictureBox.Size = new System.Drawing.Size(120, 6);
            this.enemyHealthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyHealthPictureBox.TabIndex = 4;
            this.enemyHealthPictureBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyPictureBox.Image")));
            this.enemyPictureBox.Location = new System.Drawing.Point(385, 15);
            this.enemyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(171, 153);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 1;
            this.enemyPictureBox.TabStop = false;
            this.enemyPictureBox.BackgroundImageChanged += new System.EventHandler(this.enemyPictureBox_BackgroundImageChanged);
            this.enemyPictureBox.Click += new System.EventHandler(this.enemyPictureBox_Click);
            // 
            // friendlyPictureBox
            // 
            this.friendlyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.friendlyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.friendlyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("friendlyPictureBox.Image")));
            this.friendlyPictureBox.Location = new System.Drawing.Point(79, 175);
            this.friendlyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.friendlyPictureBox.Name = "friendlyPictureBox";
            this.friendlyPictureBox.Size = new System.Drawing.Size(149, 101);
            this.friendlyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendlyPictureBox.TabIndex = 0;
            this.friendlyPictureBox.TabStop = false;
            this.friendlyPictureBox.Click += new System.EventHandler(this.friendlyPictureBox_Click);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 373);
            this.Controls.Add(this.attackButton2);
            this.Controls.Add(this.bagButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BattleForm";
            this.Text = "Pokemon Battle";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox friendlyPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox enemyHealthPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Timer attackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemyLevel;
        private System.Windows.Forms.Timer screenShakeTimer;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button bagButton;
        private System.Windows.Forms.Button attackButton2;
    }
}

