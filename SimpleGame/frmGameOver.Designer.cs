namespace SimpleGame
{
    partial class frmGameOver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LpTime = new System.Windows.Forms.Label();
            this.LpCoins = new System.Windows.Forms.Label();
            this.LpWave = new System.Windows.Forms.Label();
            this.PbCoin4 = new System.Windows.Forms.PictureBox();
            this.PbPlayer = new System.Windows.Forms.PictureBox();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over You Lost!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "You reached Wave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Coins Collected:";
            // 
            // LpTime
            // 
            this.LpTime.AutoSize = true;
            this.LpTime.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LpTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LpTime.Location = new System.Drawing.Point(117, 118);
            this.LpTime.Name = "LpTime";
            this.LpTime.Size = new System.Drawing.Size(106, 49);
            this.LpTime.TabIndex = 3;
            this.LpTime.Text = "0000";
            // 
            // LpCoins
            // 
            this.LpCoins.AutoSize = true;
            this.LpCoins.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LpCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LpCoins.Location = new System.Drawing.Point(302, 189);
            this.LpCoins.Name = "LpCoins";
            this.LpCoins.Size = new System.Drawing.Size(106, 49);
            this.LpCoins.TabIndex = 4;
            this.LpCoins.Text = "0000";
            // 
            // LpWave
            // 
            this.LpWave.AutoSize = true;
            this.LpWave.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LpWave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LpWave.Location = new System.Drawing.Point(351, 263);
            this.LpWave.Name = "LpWave";
            this.LpWave.Size = new System.Drawing.Size(106, 49);
            this.LpWave.TabIndex = 4;
            this.LpWave.Text = "0000";
            // 
            // PbCoin4
            // 
            this.PbCoin4.Image = global::SimpleGame.Properties.Resources.pngimg_com___coin_PNG36871;
            this.PbCoin4.Location = new System.Drawing.Point(-60, 323);
            this.PbCoin4.Name = "PbCoin4";
            this.PbCoin4.Size = new System.Drawing.Size(351, 236);
            this.PbCoin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCoin4.TabIndex = 89;
            this.PbCoin4.TabStop = false;
            this.PbCoin4.Tag = "Item coin";
            // 
            // PbPlayer
            // 
            this.PbPlayer.Image = global::SimpleGame.Properties.Resources.Idle__000;
            this.PbPlayer.Location = new System.Drawing.Point(482, 118);
            this.PbPlayer.Name = "PbPlayer";
            this.PbPlayer.Size = new System.Drawing.Size(376, 365);
            this.PbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPlayer.TabIndex = 90;
            this.PbPlayer.TabStop = false;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Enabled = true;
            this.AnimationTimer.Interval = 80;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.PbPlayer);
            this.Controls.Add(this.PbCoin4);
            this.Controls.Add(this.LpWave);
            this.Controls.Add(this.LpCoins);
            this.Controls.Add(this.LpTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGameOver";
            this.Text = "frmGameOver";
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LpTime;
        private System.Windows.Forms.Label LpCoins;
        private System.Windows.Forms.Label LpWave;
        private System.Windows.Forms.PictureBox PbCoin4;
        private System.Windows.Forms.PictureBox PbPlayer;
        private System.Windows.Forms.Timer AnimationTimer;
    }
}