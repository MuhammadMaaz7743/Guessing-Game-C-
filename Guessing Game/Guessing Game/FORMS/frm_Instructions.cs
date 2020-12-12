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
    public partial class frm_Instructions : Form
    {
        public frm_Instructions()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Play play = new frm_Play();
            play.Show();
            this.Hide();
        }
    }
}
