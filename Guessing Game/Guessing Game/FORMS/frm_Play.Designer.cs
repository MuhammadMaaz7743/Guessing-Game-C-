namespace Guessing_Game
{
    partial class frm_Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Play));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_instructions = new System.Windows.Forms.Button();
            this.btn_endgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Play.FlatAppearance.BorderSize = 3;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Play.Location = new System.Drawing.Point(515, 26);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(207, 86);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "PLAY";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover);
            // 
            // btn_instructions
            // 
            this.btn_instructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_instructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_instructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_instructions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_instructions.FlatAppearance.BorderSize = 3;
            this.btn_instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instructions.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_instructions.Location = new System.Drawing.Point(515, 169);
            this.btn_instructions.Name = "btn_instructions";
            this.btn_instructions.Size = new System.Drawing.Size(207, 86);
            this.btn_instructions.TabIndex = 2;
            this.btn_instructions.Text = "INSTRUCTIONS";
            this.btn_instructions.UseVisualStyleBackColor = false;
            this.btn_instructions.Click += new System.EventHandler(this.btn_instructions_Click);
            this.btn_instructions.MouseLeave += new System.EventHandler(this.btn_instructions_MouseLeave);
            this.btn_instructions.MouseHover += new System.EventHandler(this.btn_instructions_MouseHover);
            // 
            // btn_endgame
            // 
            this.btn_endgame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_endgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_endgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_endgame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_endgame.FlatAppearance.BorderSize = 3;
            this.btn_endgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_endgame.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_endgame.Location = new System.Drawing.Point(515, 316);
            this.btn_endgame.Name = "btn_endgame";
            this.btn_endgame.Size = new System.Drawing.Size(207, 86);
            this.btn_endgame.TabIndex = 3;
            this.btn_endgame.Text = "END GAME";
            this.btn_endgame.UseVisualStyleBackColor = false;
            this.btn_endgame.Click += new System.EventHandler(this.btn_endgame_Click);
            this.btn_endgame.MouseLeave += new System.EventHandler(this.btn_endgame_MouseLeave);
            this.btn_endgame.MouseHover += new System.EventHandler(this.btn_endgame_MouseHover);
            // 
            // frm_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(746, 433);
            this.ControlBox = false;
            this.Controls.Add(this.btn_endgame);
            this.Controls.Add(this.btn_instructions);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_instructions;
        private System.Windows.Forms.Button btn_endgame;
    }
}

