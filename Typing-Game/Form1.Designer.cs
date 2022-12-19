
namespace Typing_Game
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
            this.lblright = new System.Windows.Forms.Label();
            this.lblwrong = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbllifescore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblright
            // 
            this.lblright.AutoSize = true;
            this.lblright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblright.Location = new System.Drawing.Point(65, 64);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(100, 20);
            this.lblright.TabIndex = 0;
            this.lblright.Text = "CORRECT:0";
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.Location = new System.Drawing.Point(658, 64);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(120, 20);
            this.lblwrong.TabIndex = 1;
            this.lblwrong.Text = "INCORRECT: 0";
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(291, 195);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(180, 55);
            this.lblword.TabIndex = 2;
            this.lblword.Text = "WORD";
            this.lblword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Press Enter to check the word!";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(269, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 57);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkGame);
            // 
            // lbllifescore
            // 
            this.lbllifescore.AutoSize = true;
            this.lbllifescore.Location = new System.Drawing.Point(658, 95);
            this.lbllifescore.Name = "lbllifescore";
            this.lbllifescore.Size = new System.Drawing.Size(122, 20);
            this.lbllifescore.TabIndex = 5;
            this.lbllifescore.Text = "LIFE SCORE: 3";
            this.lbllifescore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(649, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = "Restart\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(837, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbllifescore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.lblright);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Typing-Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblright;
        private System.Windows.Forms.Label lblwrong;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbllifescore;
        private System.Windows.Forms.Button button1;
    }
}

