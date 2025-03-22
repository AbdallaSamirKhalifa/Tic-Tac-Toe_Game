namespace Draw
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 71);
            this.label1.TabIndex = 88;
            this.label1.Text = "ASK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(119, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 64);
            this.label2.TabIndex = 99;
            this.label2.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.CausesValidation = false;
            this.lblTurn.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblTurn.Location = new System.Drawing.Point(56, 206);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(295, 64);
            this.lblTurn.TabIndex = 78;
            this.lblTurn.Text = "GameOver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(98, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 64);
            this.label4.TabIndex = 67;
            this.label4.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.CausesValidation = false;
            this.lblWinner.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblWinner.Location = new System.Drawing.Point(48, 362);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(308, 64);
            this.lblWinner.TabIndex = 56;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.Font = new System.Drawing.Font("MS PGothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(62, 460);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(283, 48);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Location = new System.Drawing.Point(598, 121);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Location = new System.Drawing.Point(763, 121);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(101, 50);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Location = new System.Drawing.Point(938, 130);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(101, 50);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Location = new System.Drawing.Point(938, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(101, 50);
            this.btn6.TabIndex = 5;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Location = new System.Drawing.Point(938, 326);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(101, 50);
            this.btn9.TabIndex = 8;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Location = new System.Drawing.Point(775, 223);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(101, 50);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Location = new System.Drawing.Point(604, 223);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(101, 50);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Location = new System.Drawing.Point(604, 326);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(101, 50);
            this.btn7.TabIndex = 6;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.BackgroundImage = global::Draw.Properties.Resources.question_mark_96;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Location = new System.Drawing.Point(786, 326);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(101, 50);
            this.btn8.TabIndex = 7;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1135, 578);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe-Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
    }
}

