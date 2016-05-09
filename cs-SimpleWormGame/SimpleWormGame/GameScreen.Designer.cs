namespace SimpleWormGame {
    partial class GameScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.game_score = new System.Windows.Forms.Label();
            this.game_time = new System.Windows.Forms.Label();
            this.game_filed = new System.Windows.Forms.Label();
            this.game_direction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // game_score
            // 
            this.game_score.Location = new System.Drawing.Point(10, 18);
            this.game_score.Name = "game_score";
            this.game_score.Size = new System.Drawing.Size(160, 20);
            this.game_score.TabIndex = 0;
            this.game_score.Text = "Score: 0";
            this.game_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // game_time
            // 
            this.game_time.Location = new System.Drawing.Point(479, 18);
            this.game_time.Name = "game_time";
            this.game_time.Size = new System.Drawing.Size(160, 20);
            this.game_time.TabIndex = 1;
            this.game_time.Text = "0 :Time";
            this.game_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // game_filed
            // 
            this.game_filed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.game_filed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_filed.Location = new System.Drawing.Point(12, 47);
            this.game_filed.Margin = new System.Windows.Forms.Padding(5);
            this.game_filed.Name = "game_filed";
            this.game_filed.Size = new System.Drawing.Size(626, 521);
            this.game_filed.TabIndex = 2;
            this.game_filed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game_direction
            // 
            this.game_direction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_direction.Location = new System.Drawing.Point(176, 14);
            this.game_direction.Name = "game_direction";
            this.game_direction.Size = new System.Drawing.Size(297, 24);
            this.game_direction.TabIndex = 3;
            this.game_direction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(651, 582);
            this.Controls.Add(this.game_direction);
            this.Controls.Add(this.game_filed);
            this.Controls.Add(this.game_time);
            this.Controls.Add(this.game_score);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleWormGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameScreen_FormClosing);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label game_score;
        private System.Windows.Forms.Label game_time;
        private System.Windows.Forms.Label game_filed;
        private System.Windows.Forms.Label game_direction;
    }
}