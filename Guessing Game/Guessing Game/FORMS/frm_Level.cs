using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class frm_Level : Form
    {
        public frm_Level()
        {
            InitializeComponent();
        }

        private void frm_Level_Load(object sender, EventArgs e)
        {

        }

        private void btn_Easy_Click(object sender, EventArgs e)
        {
            string difficulty = "EASY";
            int lives = 5;
            frm_Difficulties difficult = new frm_Difficulties(difficulty, lives);
            difficult.Show();
            this.Hide();
        }

        private void btn_Medium_Click(object sender, EventArgs e)
        {
            string difficulty = "MEDIUM";
            int lives = 4;
            frm_Difficulties difficult = new frm_Difficulties(difficulty, lives);
            difficult.Show();
            this.Hide();
        }

        private void btn_Hard_Click(object sender, EventArgs e)
        {
            string difficulty = "HARD";
            int lives = 3;
            frm_Difficulties difficult = new frm_Difficulties(difficulty, lives);
            difficult.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Play play = new frm_Play();
            this.Hide();
            play.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Easy_MouseHover(object sender, EventArgs e)
        {
            btn_Easy.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_Easy_MouseLeave(object sender, EventArgs e)
        {
            btn_Easy.FlatAppearance.BorderColor = Color.LightSeaGreen;
        }

        private void btn_Medium_MouseHover(object sender, EventArgs e)
        {
            btn_Medium.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_Medium_MouseLeave(object sender, EventArgs e)
        {
            btn_Medium.FlatAppearance.BorderColor = Color.LightSeaGreen;
        }

        private void btn_Hard_MouseHover(object sender, EventArgs e)
        {
            btn_Hard.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_Hard_MouseLeave(object sender, EventArgs e)
        {
            btn_Hard.FlatAppearance.BorderColor = Color.LightSeaGreen;
        }

        
    }
}
