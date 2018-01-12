namespace PongGame
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
            this.gameCanvas = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.yourScore = new System.Windows.Forms.Label();
            this.enemyScoreLabel = new System.Windows.Forms.Label();
            this.enemyScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.continueLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCanvas
            // 
            this.gameCanvas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameCanvas.Location = new System.Drawing.Point(12, 12);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(650, 650);
            this.gameCanvas.TabIndex = 0;
            this.gameCanvas.TabStop = false;
            this.gameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.gameCanvas_Paint);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(778, 42);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(85, 31);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score";
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.Location = new System.Drawing.Point(668, 107);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(62, 31);
            this.yourScoreLabel.TabIndex = 2;
            this.yourScoreLabel.Text = "You";
            // 
            // yourScore
            // 
            this.yourScore.AutoSize = true;
            this.yourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScore.Location = new System.Drawing.Point(736, 107);
            this.yourScore.Name = "yourScore";
            this.yourScore.Size = new System.Drawing.Size(0, 31);
            this.yourScore.TabIndex = 3;
            // 
            // enemyScoreLabel
            // 
            this.enemyScoreLabel.AutoSize = true;
            this.enemyScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyScoreLabel.Location = new System.Drawing.Point(818, 107);
            this.enemyScoreLabel.Name = "enemyScoreLabel";
            this.enemyScoreLabel.Size = new System.Drawing.Size(98, 31);
            this.enemyScoreLabel.TabIndex = 4;
            this.enemyScoreLabel.Text = "Enemy";
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyScore.Location = new System.Drawing.Point(916, 107);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(0, 31);
            this.enemyScore.TabIndex = 5;
            // 
            // continueLabel
            // 
            this.continueLabel.AutoSize = true;
            this.continueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueLabel.Location = new System.Drawing.Point(82, 290);
            this.continueLabel.Name = "continueLabel";
            this.continueLabel.Size = new System.Drawing.Size(457, 46);
            this.continueLabel.TabIndex = 6;
            this.continueLabel.Text = "Press Enter To Continue";
            this.continueLabel.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(213, 184);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(224, 46);
            this.winLabel.TabIndex = 8;
            this.winLabel.Text = "WinnerText";
            this.winLabel.Visible = false;
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(29, 424);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(617, 46);
            this.restartLabel.TabIndex = 9;
            this.restartLabel.Text = "Press Enter To Start a new Game";
            this.restartLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.continueLabel);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.enemyScoreLabel);
            this.Controls.Add(this.yourScore);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameCanvas;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label yourScore;
        private System.Windows.Forms.Label enemyScoreLabel;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label continueLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label restartLabel;
    }
}

