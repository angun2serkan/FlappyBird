
namespace flappyBirdGit
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
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.Image = global::flappyBirdGit.Properties.Resources.birdnew;
            this.pbBird.Location = new System.Drawing.Point(33, 127);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(63, 31);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::flappyBirdGit.Properties.Resources.pipe;
            this.pbPipe2.Location = new System.Drawing.Point(312, 249);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(73, 155);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 1;
            this.pbPipe2.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = global::flappyBirdGit.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(175, 200);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(58, 204);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 2;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe3
            // 
            this.pbPipe3.ErrorImage = null;
            this.pbPipe3.Image = global::flappyBirdGit.Properties.Resources.pipedown;
            this.pbPipe3.Location = new System.Drawing.Point(470, -2);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(61, 160);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 3;
            this.pbPipe3.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.Image = global::flappyBirdGit.Properties.Resources.pipedown;
            this.pbPipe4.Location = new System.Drawing.Point(639, -2);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(54, 237);
            this.pbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe4.TabIndex = 4;
            this.pbPipe4.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround.Image = global::flappyBirdGit.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(0, 400);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(800, 50);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 5;
            this.pbGround.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.pbPipe3);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label lblScore;
    }
}

