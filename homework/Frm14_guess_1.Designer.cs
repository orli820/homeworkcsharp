
namespace homework
{
    partial class Frm14_guess_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm14_guess_1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtgu = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please input number!";
            
            // 
            // txtgu
            // 
            this.txtgu.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtgu.Location = new System.Drawing.Point(12, 463);
            this.txtgu.Name = "txtgu";
            this.txtgu.Size = new System.Drawing.Size(292, 43);
            this.txtgu.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnok.Location = new System.Drawing.Point(322, 457);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(94, 48);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "enter";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnno
            // 
            this.btnno.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnno.Location = new System.Drawing.Point(422, 458);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(94, 47);
            this.btnno.TabIndex = 3;
            this.btnno.Text = "cancel";
            this.btnno.UseVisualStyleBackColor = true;
            // 
            // Frm14_guess_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(528, 529);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtgu);
            this.Controls.Add(this.label1);
            this.Name = "Frm14_guess_1";
            this.Text = "Frm14_guess_1";
            this.Load += new System.EventHandler(this.Frm14_guess_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgu;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnno;
    }
}