namespace SimpleWormGame {
    partial class StartScreen {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.main_title = new System.Windows.Forms.Label();
            this.main_start = new System.Windows.Forms.Button();
            this.main_exit = new System.Windows.Forms.Button();
            this.main_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title.ForeColor = System.Drawing.Color.White;
            this.main_title.Location = new System.Drawing.Point(30, 22);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(226, 29);
            this.main_title.TabIndex = 0;
            this.main_title.Text = "SimpleWormGame";
            this.main_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_start
            // 
            this.main_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.main_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.main_start.Location = new System.Drawing.Point(35, 101);
            this.main_start.Name = "main_start";
            this.main_start.Size = new System.Drawing.Size(100, 30);
            this.main_start.TabIndex = 1;
            this.main_start.Text = "Start";
            this.main_start.UseVisualStyleBackColor = false;
            this.main_start.Click += new System.EventHandler(this.main_start_Click);
            // 
            // main_exit
            // 
            this.main_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.main_exit.Location = new System.Drawing.Point(155, 101);
            this.main_exit.Name = "main_exit";
            this.main_exit.Size = new System.Drawing.Size(100, 30);
            this.main_exit.TabIndex = 2;
            this.main_exit.Text = "Exit";
            this.main_exit.UseVisualStyleBackColor = true;
            this.main_exit.Click += new System.EventHandler(this.main_exit_Click);
            // 
            // main_score
            // 
            this.main_score.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_score.ForeColor = System.Drawing.Color.Yellow;
            this.main_score.Location = new System.Drawing.Point(32, 63);
            this.main_score.Name = "main_score";
            this.main_score.Size = new System.Drawing.Size(223, 35);
            this.main_score.TabIndex = 3;
            this.main_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.main_score);
            this.Controls.Add(this.main_exit);
            this.Controls.Add(this.main_start);
            this.Controls.Add(this.main_title);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleWormGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Button main_start;
        private System.Windows.Forms.Button main_exit;
        private System.Windows.Forms.Label main_score;
    }
}

