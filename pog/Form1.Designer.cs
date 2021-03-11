
namespace pog
{
    partial class Football
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Football));
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winnerLabel = new System.Windows.Forms.Label();
            this.goalBox = new System.Windows.Forms.PictureBox();
            this.winnerLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1ScoreLabel.Location = new System.Drawing.Point(246, 21);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(42, 23);
            this.p1ScoreLabel.TabIndex = 0;
            this.p1ScoreLabel.Text = "0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2ScoreLabel.Location = new System.Drawing.Point(281, 21);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(58, 23);
            this.p2ScoreLabel.TabIndex = 1;
            this.p2ScoreLabel.Text = "0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(35, 45);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(10, 275);
            this.winnerLabel.TabIndex = 2;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalBox
            // 
            this.goalBox.BackColor = System.Drawing.Color.Transparent;
            this.goalBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goalBox.Image = global::pog.Properties.Resources.golaso;
            this.goalBox.Location = new System.Drawing.Point(150, 190);
            this.goalBox.Name = "goalBox";
            this.goalBox.Size = new System.Drawing.Size(258, 177);
            this.goalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goalBox.TabIndex = 3;
            this.goalBox.TabStop = false;
            this.goalBox.Visible = false;
            // 
            // winnerLabel2
            // 
            this.winnerLabel2.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel2.ForeColor = System.Drawing.Color.White;
            this.winnerLabel2.Location = new System.Drawing.Point(548, 29);
            this.winnerLabel2.Name = "winnerLabel2";
            this.winnerLabel2.Size = new System.Drawing.Size(11, 307);
            this.winnerLabel2.TabIndex = 4;
            this.winnerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Football
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.winnerLabel2);
            this.Controls.Add(this.goalBox);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Football";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.goalBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.PictureBox goalBox;
        private System.Windows.Forms.Label winnerLabel2;
    }
}

