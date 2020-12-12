namespace Guessing_Game
{
    partial class frm_Difficulties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Difficulties));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Remaining = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.lbl_Lives = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Guess = new System.Windows.Forms.TextBox();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.pnl_guess = new System.Windows.Forms.Panel();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.list_guesses = new System.Windows.Forms.ListBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Replay = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Range = new System.Windows.Forms.Panel();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_Range = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_guess.SuspendLayout();
            this.pnl_Range.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Level);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Remaining);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_Mode);
            this.panel1.Controls.Add(this.lbl_Lives);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 103);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Level.Location = new System.Drawing.Point(55, 2);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(16, 20);
            this.lbl_Level.TabIndex = 8;
            this.lbl_Level.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Level: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Remaining
            // 
            this.lbl_Remaining.AutoSize = true;
            this.lbl_Remaining.Enabled = false;
            this.lbl_Remaining.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Remaining.Location = new System.Drawing.Point(217, 75);
            this.lbl_Remaining.Name = "lbl_Remaining";
            this.lbl_Remaining.Size = new System.Drawing.Size(133, 20);
            this.lbl_Remaining.TabIndex = 5;
            this.lbl_Remaining.Text = "Guesses Remaining";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number Of Guesses Remaining: ";
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.Enabled = false;
            this.lbl_Mode.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Mode.Location = new System.Drawing.Point(84, 26);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(43, 20);
            this.lbl_Mode.TabIndex = 3;
            this.lbl_Mode.Text = "Mode";
            // 
            // lbl_Lives
            // 
            this.lbl_Lives.AutoSize = true;
            this.lbl_Lives.Enabled = false;
            this.lbl_Lives.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Lives.Location = new System.Drawing.Point(207, 50);
            this.lbl_Lives.Name = "lbl_Lives";
            this.lbl_Lives.Size = new System.Drawing.Size(97, 20);
            this.lbl_Lives.TabIndex = 2;
            this.lbl_Lives.Text = "Total Guesses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Guesses Allowed: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficulty: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "ENTER YOUR GUESS HERE: ";
            // 
            // txt_Guess
            // 
            this.txt_Guess.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Guess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Guess.Location = new System.Drawing.Point(365, 79);
            this.txt_Guess.MaxLength = 6;
            this.txt_Guess.Name = "txt_Guess";
            this.txt_Guess.Size = new System.Drawing.Size(182, 41);
            this.txt_Guess.TabIndex = 1;
            this.txt_Guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Guess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Guess_KeyDown);
            this.txt_Guess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Guess_KeyPress);
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.ForeColor = System.Drawing.Color.White;
            this.lbl_Head.Location = new System.Drawing.Point(145, 12);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(0, 31);
            this.lbl_Head.TabIndex = 3;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Check.Location = new System.Drawing.Point(112, 160);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(349, 41);
            this.btn_Check.TabIndex = 2;
            this.btn_Check.Text = "CHECK";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            this.btn_Check.MouseLeave += new System.EventHandler(this.btn_Check_MouseLeave);
            this.btn_Check.MouseHover += new System.EventHandler(this.btn_Check_MouseHover);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Enabled = false;
            this.lbl_result.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.Red;
            this.lbl_result.Location = new System.Drawing.Point(163, 440);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(421, 31);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "YOU HAVE ENTERED LESSER VALUE";
            // 
            // pnl_guess
            // 
            this.pnl_guess.BackColor = System.Drawing.Color.Transparent;
            this.pnl_guess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_guess.Controls.Add(this.lbl_Number);
            this.pnl_guess.Controls.Add(this.list_guesses);
            this.pnl_guess.Controls.Add(this.btn_Check);
            this.pnl_guess.Controls.Add(this.txt_Guess);
            this.pnl_guess.Controls.Add(this.lbl_Head);
            this.pnl_guess.Controls.Add(this.label3);
            this.pnl_guess.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_guess.Location = new System.Drawing.Point(3, 185);
            this.pnl_guess.Name = "pnl_guess";
            this.pnl_guess.Size = new System.Drawing.Size(740, 223);
            this.pnl_guess.TabIndex = 5;
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Enabled = false;
            this.lbl_Number.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_Number.Location = new System.Drawing.Point(15, 11);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(0, 75);
            this.lbl_Number.TabIndex = 9;
            // 
            // list_guesses
            // 
            this.list_guesses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.list_guesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_guesses.Enabled = false;
            this.list_guesses.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_guesses.ForeColor = System.Drawing.Color.Red;
            this.list_guesses.FormattingEnabled = true;
            this.list_guesses.ItemHeight = 20;
            this.list_guesses.Location = new System.Drawing.Point(566, 77);
            this.list_guesses.Name = "list_guesses";
            this.list_guesses.Size = new System.Drawing.Size(164, 142);
            this.list_guesses.TabIndex = 8;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Enabled = false;
            this.lbl_position.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.ForeColor = System.Drawing.Color.Red;
            this.lbl_position.Location = new System.Drawing.Point(308, 468);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(129, 31);
            this.lbl_position.TabIndex = 6;
            this.lbl_position.Text = "YOU LOSE";
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Enabled = false;
            this.lbl_Value.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.ForeColor = System.Drawing.Color.Red;
            this.lbl_Value.Location = new System.Drawing.Point(192, 411);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(363, 31);
            this.lbl_Value.TabIndex = 7;
            this.lbl_Value.Text = "PLEASE ENTER A VALID VALUE";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.Location = new System.Drawing.Point(12, 411);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(126, 41);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewGame.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_NewGame.Location = new System.Drawing.Point(12, 458);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(126, 41);
            this.btn_NewGame.TabIndex = 10;
            this.btn_NewGame.Text = "NEW GAME";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Replay
            // 
            this.btn_Replay.BackColor = System.Drawing.Color.Transparent;
            this.btn_Replay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Replay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Replay.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Replay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Replay.Location = new System.Drawing.Point(608, 412);
            this.btn_Replay.Name = "btn_Replay";
            this.btn_Replay.Size = new System.Drawing.Size(126, 41);
            this.btn_Replay.TabIndex = 13;
            this.btn_Replay.Text = "REPLAY";
            this.btn_Replay.UseVisualStyleBackColor = false;
            this.btn_Replay.Click += new System.EventHandler(this.btn_Replay_Click_1);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.Location = new System.Drawing.Point(608, 459);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(126, 41);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // pnl_Range
            // 
            this.pnl_Range.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Range.Controls.Add(this.btn_OK);
            this.pnl_Range.Controls.Add(this.txt_Range);
            this.pnl_Range.Controls.Add(this.label6);
            this.pnl_Range.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_Range.Location = new System.Drawing.Point(3, 112);
            this.pnl_Range.Name = "pnl_Range";
            this.pnl_Range.Size = new System.Drawing.Size(740, 67);
            this.pnl_Range.TabIndex = 14;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_OK.Location = new System.Drawing.Point(587, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(126, 41);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_Range
            // 
            this.txt_Range.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Range.Location = new System.Drawing.Point(365, 9);
            this.txt_Range.MaxLength = 6;
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(182, 41);
            this.txt_Range.TabIndex = 3;
            this.txt_Range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Range.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Range_KeyDown);
            this.txt_Range.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Range_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "ENTER YOUR RANGE HERE: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(746, 408);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Difficulties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(746, 507);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Replay);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.pnl_guess);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Range);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Difficulties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Difficulties";
            this.Load += new System.EventHandler(this.frm_Difficulties_Load);
            this.Shown += new System.EventHandler(this.frm_Difficulties_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_guess.ResumeLayout(false);
            this.pnl_guess.PerformLayout();
            this.pnl_Range.ResumeLayout(false);
            this.pnl_Range.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Lives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Guess;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Label lbl_Level;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Remaining;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Panel pnl_guess;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.ListBox list_guesses;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Replay;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Panel pnl_Range;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_Range;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}