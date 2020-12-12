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
    public partial class frm_Difficulties : Form
    {
        // --------------------- FOR RANDOM NUMBERS----------------//

        int m;
        int[] ArrayOfRandomNumbers;

        // --------------------- FOR RANDOM NUMBERS----------------//

        string Difficulty;
        int Lives;
        int guess = 0;
        int remainingLives;
        int randomNumber;
        int[] array;
        int i = 0;
        public frm_Difficulties(string _Difficulty,int _Lives)
        {
            InitializeComponent();

            Difficulty = _Difficulty;
            Lives = _Lives;
            remainingLives = Lives;
            array = new int[Lives + 1];
        }
        private void frm_Difficulties_Load(object sender, EventArgs e)
        {
            lbl_Mode.Enabled = true;
            lbl_Mode.Text = Difficulty;
            lbl_Lives.Enabled = true;
            lbl_Lives.Text = Convert.ToString(Lives);
            lbl_Remaining.Enabled = true;
            lbl_Remaining.Text = Convert.ToString(remainingLives);
            pnl_guess.Enabled = false;
            pictureBox2.Visible = false;
        }
        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txt_Guess.Text))
            {
                lbl_Value.Enabled = true;
                lbl_Value.Text = "     PLEASE! ENTER A VALUE";
                lbl_result.Enabled = false;
            }
            else
            {
                lbl_Value.Enabled = false;
                remainingLives--;
                lbl_Remaining.Text = Convert.ToString(remainingLives);
                guess = int.Parse(txt_Guess.Text);
                if (guess < randomNumber && guess >= 0 && remainingLives != 0 && guess <= m)
                {
                    i++;
                    string less = "YOU HAVE ENTERED LESSER VALUE";
                    lbl_result.Enabled = true;
                    lbl_result.Text = less;
                    txt_Guess.Clear();
                    array[i] = guess;
                    list_guesses.Items.Add(i + ". " + array[i] + " (LESSER VALUE)");

                }
                if (guess > randomNumber && guess >= 0 && remainingLives != 0 && guess <= m)
                {
                    i++;
                    string greater = "YOU HAVE ENTERED GREATER VALUE";
                    lbl_result.Enabled = true;
                    lbl_result.Text = greater;
                    txt_Guess.Clear();
                    array[i] = guess;
                    list_guesses.Items.Add(i + ". " + array[i] + " (GREATER VALUE)");
                }
                if (remainingLives == 0 && guess != randomNumber)
                {
                    i++;
                    string over = "YOU LOSE";
                    lbl_position.Enabled = true;
                    lbl_position.Text = over;
                    lbl_result.Enabled = false;
                    txt_Guess.Clear();
                    pnl_guess.Enabled = false;
                    array[i] = guess;
                    list_guesses.Items.Add(i + ". " + array[i]);
                    lbl_Number.Enabled = true;
                    lbl_Number.Text = "I WAS THINKING OF THE     " + "\n               NUMBER " + "\n                    " + randomNumber.ToString();
                    //list_guesses.Items.Clear();
                }
                if (guess == randomNumber)
                {
                    i++;
                    string won = "YOU WON";
                    lbl_position.Enabled = true;
                    lbl_position.Text = won;
                    lbl_position.ForeColor = Color.GreenYellow;
                    lbl_result.Enabled = false;
                    txt_Guess.Clear();
                    pnl_guess.Enabled = false;
                    array[i] = guess;
                    list_guesses.Items.Add(i + ". " + array[i]);
                    txt_Range.Clear();
                    pictureBox2.Visible = true;
                    //list_guesses.Items.Clear();
                }
                if (guess < 0)
                {
                    remainingLives++;
                    lbl_Remaining.Text = Convert.ToString(remainingLives);
                    lbl_Value.Enabled = true;
                    lbl_Value.Text = "PLEASE! ENTER A VALID NUMBER";
                    lbl_result.Enabled = false;
                    txt_Guess.Clear();
                }

                if (guess > m)
                {
                    remainingLives++;
                    lbl_Remaining.Text = Convert.ToString(remainingLives);
                    MessageBox.Show("PLEASE CHECK YOUR RANGE", "ERROR");
                    txt_Guess.Clear();
                }

            }
        }
            
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Check_MouseHover(object sender, EventArgs e)
        {
            btn_Check.ForeColor = Color.Black;
            btn_Check.BackColor = Color.LightSeaGreen;
            btn_Check.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_Check_MouseLeave(object sender, EventArgs e)
        {
            btn_Check.ForeColor = Color.LightSeaGreen;
            btn_Check.BackColor = Color.Black;
            btn_Check.FlatAppearance.BorderColor = Color.LightSeaGreen;
        }

        private void frm_Difficulties_Shown(object sender, EventArgs e)
        {
            if (pnl_Range.Enabled == true)
            {
                txt_Range.Focus();
            }
            else
            {
                txt_Guess.Focus();
            }
        }

        private void txt_Guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Check_Click(this, new EventArgs());
            }
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            frm_Play play = new frm_Play();
            play.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Level level = new frm_Level();
            level.Show();
            this.Hide();
        }

        private void btn_Replay_Click_1(object sender, EventArgs e)
        {
            frm_Difficulties diff = new frm_Difficulties(Difficulty, Lives);
            diff.Show();
            this.Hide();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txt_Range.Text))
            {
                lbl_Value.Enabled = true;
                lbl_Value.Text = "     PLEASE! ENTER A VALUE";
            }
            else
            {
                
                m = int.Parse(txt_Range.Text);
                if (m == 0)
                {
                    lbl_Value.Enabled = true;
                    lbl_Value.Text = "          INVALID RANGE !!!";
                    txt_Range.Clear();
                }
                if (m != 0)
                {
                    pnl_guess.Enabled = true;
                    pnl_Range.Enabled = false;
                    Randoms rand = new Randoms(m);
                    ArrayOfRandomNumbers = new int[m];
                    ArrayOfRandomNumbers = rand.next();
                    randomNumber = ArrayOfRandomNumbers[0];

                    lbl_Head.Text = "GUESS A NUMBER BETWEEN 0 AND " + txt_Range.Text;
                    lbl_Value.Enabled = false;
                    //lbl_Value.Text = "";
                }
            }
        }

        private void txt_Range_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_OK_Click(this, new EventArgs());
            }
        }

        private void txt_Range_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 58; i <= 127; i++)//58 to 127 are alphabets that will be         blocked
            {
                if (e.KeyChar == i)
                {
                    e.Handled = true;
                }
            }
            for (int i = 32; i <= 47; i++)//32 to 47 are special characters that will be.........blocked
            {
                if (e.KeyChar == i)
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_Guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 58; i <= 127; i++)//58 to 127 are alphabets that will be         blocked
            {
                if (e.KeyChar == i)
                {
                    e.Handled = true;
                }
            }
            for (int i = 32; i <= 47; i++)//32 to 47 are special characters that will be.........blocked
            {
                if (e.KeyChar == i)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
