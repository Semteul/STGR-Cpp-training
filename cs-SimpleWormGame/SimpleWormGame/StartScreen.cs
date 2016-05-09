using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWormGame {
    public partial class StartScreen:Form {

        static int score = -1;

        public StartScreen() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void main_exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void main_start_Click(object sender, EventArgs e) {
            this.Hide();
            StartScreen.score = -1;
            GameScreen gs = new GameScreen();
            gs.ShowDialog();
            this.refreshScore();
            this.Show();
        }

        private void refreshScore() {
            if(StartScreen.score < 0) {
                this.main_score.Text = "";
            } else {
                this.main_score.Text = "Score: " + StartScreen.score;
            }
        }

        public static void setScore(int score) {
            StartScreen.score = score;
        }
    }
}
