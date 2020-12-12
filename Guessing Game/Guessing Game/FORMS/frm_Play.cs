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
    public partial class frm_Play : Form
    {
        public frm_Play()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {

            frm_Loading Loading = new frm_Loading();
            this.Hide();
            Loading.Show();
        }

        private void btn_instructions_Click(object sender, EventArgs e)
        {
            frm_Instructions INSTRUCTIONS = new frm_Instructions();
            INSTRUCTIONS.Show();
            this.Hide();
        }

        private void btn_endgame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Play_MouseHover(object sender, EventArgs e)
        {
            btn_Play.ForeColor = Color.Black;
            btn_Play.BackColor = Color.Aqua;
            btn_Play.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.ForeColor = Color.LightSeaGreen;
            btn_Play.BackColor = Color.Black;
            btn_Play.FlatAppearance.BorderColor = Color.LightSeaGreen;
        }

        private void btn_instructions_MouseHover(object sender, EventArgs e)
        {
            btn_instructions.ForeColor = Color.Black;
            btn_instructions.BackColor = Color.Aqua;
            btn_instructions.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_instructions_MouseLeave(object sender, EventArgs e)
        {
            btn_instructions.ForeColor = Color.LightSeaGreen;
            btn_instructions.BackColor = Color.Black;
            btn_instructions.FlatAppearance.BorderColor = Color.LightSeaGreen;
        }

        private void btn_endgame_MouseHover(object sender, EventArgs e)
        {
            btn_endgame.ForeColor = Color.Black;
            btn_endgame.BackColor = Color.Aqua;
            btn_endgame.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_endgame_MouseLeave(object sender, EventArgs e)
        {
            btn_endgame.ForeColor = Color.LightSeaGreen;
            btn_endgame.BackColor = Color.Black;
            btn_endgame.FlatAppearance.BorderColor = Color.LightSeaGreen;
        }
    }
}
