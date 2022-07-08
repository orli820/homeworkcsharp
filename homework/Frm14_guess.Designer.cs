
namespace homework
{
    partial class Frm14_guess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm14_guess));
            this.lab1 = new System.Windows.Forms.Label();
            this.btnguess = new System.Windows.Forms.Button();
            this.btnans = new System.Windows.Forms.Button();
            this.lab2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1.Location = new System.Drawing.Point(25, 98);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(688, 42);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Pleae Select A Number Between 1 To 100!";
            // 
            // btnguess
            // 
            this.btnguess.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnguess.Location = new System.Drawing.Point(321, 200);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(162, 99);
            this.btnguess.TabIndex = 1;
            this.btnguess.Text = "Guess";
            this.btnguess.UseVisualStyleBackColor = true;
            this.btnguess.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnans
            // 
            this.btnans.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnans.Location = new System.Drawing.Point(426, 363);
            this.btnans.Name = "btnans";
            this.btnans.Size = new System.Drawing.Size(264, 97);
            this.btnans.TabIndex = 2;
            this.btnans.Text = "Show Answer";
            this.btnans.UseVisualStyleBackColor = true;
            this.btnans.Click += new System.EventHandler(this.btnans_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2.Location = new System.Drawing.Point(86, 140);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(0, 38);
            this.lab2.TabIndex = 3;
            // 
            // Frm14_guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(763, 527);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.btnans);
            this.Controls.Add(this.btnguess);
            this.Controls.Add(this.lab1);
            this.Name = "Frm14_guess";
            this.Text = "Frm14_guess";
            this.Load += new System.EventHandler(this.Frm14_guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Button btnans;
        private System.Windows.Forms.Label lab2;
    }
}