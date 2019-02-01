namespace MonsterBattle
{
    partial class SwitchForm
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
            this.switchCancelPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.currentPokemonHealth = new System.Windows.Forms.PictureBox();
            this.currentPokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondPokemonPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secondHealthPB = new System.Windows.Forms.PictureBox();
            this.secondPokemonLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.switchCancelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPokemonHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPokemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPokemonPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondHealthPB)).BeginInit();
            this.SuspendLayout();
            // 
            // switchCancelPictureBox
            // 
            this.switchCancelPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.switchCancelPictureBox.BackgroundImage = global::MonsterBattle.Properties.Resources.pokimon_cancel_button;
            this.switchCancelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCancelPictureBox.Location = new System.Drawing.Point(595, 368);
            this.switchCancelPictureBox.Name = "switchCancelPictureBox";
            this.switchCancelPictureBox.Size = new System.Drawing.Size(221, 76);
            this.switchCancelPictureBox.TabIndex = 0;
            this.switchCancelPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MonsterBattle.Properties.Resources.health_bar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(84, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 22);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // currentPokemonHealth
            // 
            this.currentPokemonHealth.BackColor = System.Drawing.Color.Transparent;
            this.currentPokemonHealth.BackgroundImage = global::MonsterBattle.Properties.Resources.bar_healthy;
            this.currentPokemonHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentPokemonHealth.Location = new System.Drawing.Point(122, 184);
            this.currentPokemonHealth.Name = "currentPokemonHealth";
            this.currentPokemonHealth.Size = new System.Drawing.Size(134, 10);
            this.currentPokemonHealth.TabIndex = 3;
            this.currentPokemonHealth.TabStop = false;
            // 
            // currentPokemonPictureBox
            // 
            this.currentPokemonPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.currentPokemonPictureBox.BackgroundImage = global::MonsterBattle.Properties.Resources.zapdos_sprite;
            this.currentPokemonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentPokemonPictureBox.Location = new System.Drawing.Point(28, 71);
            this.currentPokemonPictureBox.Name = "currentPokemonPictureBox";
            this.currentPokemonPictureBox.Size = new System.Drawing.Size(94, 92);
            this.currentPokemonPictureBox.TabIndex = 5;
            this.currentPokemonPictureBox.TabStop = false;
            this.currentPokemonPictureBox.Click += new System.EventHandler(this.currentPokemonPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = " ";
            // 
            // secondPokemonPB
            // 
            this.secondPokemonPB.BackColor = System.Drawing.Color.Transparent;
            this.secondPokemonPB.BackgroundImage = global::MonsterBattle.Properties.Resources.pikachu_sprite;
            this.secondPokemonPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondPokemonPB.Location = new System.Drawing.Point(296, 15);
            this.secondPokemonPB.Name = "secondPokemonPB";
            this.secondPokemonPB.Size = new System.Drawing.Size(121, 91);
            this.secondPokemonPB.TabIndex = 7;
            this.secondPokemonPB.TabStop = false;
            this.secondPokemonPB.Click += new System.EventHandler(this.secondPokemonPB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MonsterBattle.Properties.Resources.health_bar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(428, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 22);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // secondHealthPB
            // 
            this.secondHealthPB.BackColor = System.Drawing.Color.Transparent;
            this.secondHealthPB.BackgroundImage = global::MonsterBattle.Properties.Resources.bar_healthy;
            this.secondHealthPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondHealthPB.Location = new System.Drawing.Point(467, 65);
            this.secondHealthPB.Name = "secondHealthPB";
            this.secondHealthPB.Size = new System.Drawing.Size(134, 10);
            this.secondHealthPB.TabIndex = 9;
            this.secondHealthPB.TabStop = false;
            // 
            // secondPokemonLabel
            // 
            this.secondPokemonLabel.AutoSize = true;
            this.secondPokemonLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondPokemonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPokemonLabel.Location = new System.Drawing.Point(429, 37);
            this.secondPokemonLabel.Name = "secondPokemonLabel";
            this.secondPokemonLabel.Size = new System.Drawing.Size(77, 24);
            this.secondPokemonLabel.TabIndex = 10;
            this.secondPokemonLabel.Text = "Pikachu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zapdos";
            // 
            // SwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonsterBattle.Properties.Resources.switch_interface;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondPokemonLabel);
            this.Controls.Add(this.secondHealthPB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.secondPokemonPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPokemonPictureBox);
            this.Controls.Add(this.currentPokemonHealth);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.switchCancelPictureBox);
            this.Name = "SwitchForm";
            this.Text = "Switchform";
            ((System.ComponentModel.ISupportInitialize)(this.switchCancelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPokemonHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPokemonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPokemonPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondHealthPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox switchCancelPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox currentPokemonHealth;
        private System.Windows.Forms.PictureBox currentPokemonPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox secondPokemonPB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox secondHealthPB;
        private System.Windows.Forms.Label secondPokemonLabel;
        private System.Windows.Forms.Label label2;
    }
}