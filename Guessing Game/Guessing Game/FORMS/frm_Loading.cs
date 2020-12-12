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
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 2;
            if (rectangleShape2.Width == 348)
            {
                timer1.Stop();
                frm_Level level = new frm_Level();
                this.Hide();
                level.Show();
            }
            
            }

        private void frm_Loading_Load(object sender, EventArgs e)
        {
        
        }

        
    }
}
