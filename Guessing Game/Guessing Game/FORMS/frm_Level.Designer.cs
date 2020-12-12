namespace Guessing_Game
{
    partial class frm_Level
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Level));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Easy = new System.Windows.Forms.Button();
            this.btn_Medium = new System.Windows.Forms.Button();
            this.btn_Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Black;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.FlatAppearance.BorderSize = 4;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Location = new System.Drawing.Point(3, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 57);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Easy
            // 
            this.btn_Easy.BackColor = System.Drawing.Color.Transparent;
            this.btn_Easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Easy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Easy.FlatAppearance.BorderSize = 8;
            this.btn_Easy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Easy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Easy.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Easy.Location = new System.Drawing.Point(99, 146);
            this.btn_Easy.Name = "btn_Easy";
            this.btn_Easy.Size = new System.Drawing.Size(169, 143);
            this.btn_Easy.TabIndex = 1;
            this.btn_Easy.UseVisualStyleBackColor = false;
            this.btn_Easy.Click += new System.EventHandler(this.btn_Easy_Click);
            this.btn_Easy.MouseLeave += new System.EventHandler(this.btn_Easy_MouseLeave);
            this.btn_Easy.MouseHover += new System.EventHandler(this.btn_Easy_MouseHover);
            // 
            // btn_Medium
            // 
            this.btn_Medium.BackColor = System.Drawing.Color.Transparent;
            this.btn_Medium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Medium.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Medium.FlatAppearance.BorderSize = 8;
            this.btn_Medium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Medium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Medium.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Medium.Location = new System.Drawing.Point(287, 146);
            this.btn_Medium.Name = "btn_Medium";
            this.btn_Medium.Size = new System.Drawing.Size(171, 143);
            this.btn_Medium.TabIndex = 2;
            this.btn_Medium.UseVisualStyleBackColor = false;
            this.btn_Medium.Click += new System.EventHandler(this.btn_Medium_Click);
            this.btn_Medium.MouseLeave += new System.EventHandler(this.btn_Medium_MouseLeave);
            this.btn_Medium.MouseHover += new System.EventHandler(this.btn_Medium_MouseHover);
            // 
            // btn_Hard
            // 
            this.btn_Hard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Hard.FlatAppearance.BorderSize = 8;
            this.btn_Hard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Hard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hard.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Hard.Location = new System.Drawing.Point(479, 146);
            this.btn_Hard.Name = "btn_Hard";
            this.btn_Hard.Size = new System.Drawing.Size(170, 143);
            this.btn_Hard.TabIndex = 3;
            this.btn_Hard.UseVisualStyleBackColor = false;
            this.btn_Hard.Click += new System.EventHandler(this.btn_Hard_Click);
            this.btn_Hard.MouseLeave += new System.EventHandler(this.btn_Hard_MouseLeave);
            this.btn_Hard.MouseHover += new System.EventHandler(this.btn_Hard_MouseHover);
            // 
            // frm_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 433);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Hard);
            this.Controls.Add(this.btn_Medium);
            this.Controls.Add(this.btn_Easy);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Level";
            this.Load += new System.EventHandler(this.frm_Level_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Easy;
        private System.Windows.Forms.Button btn_Medium;
        private System.Windows.Forms.Button btn_Hard;


    }
}