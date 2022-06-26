
namespace homework
{
    partial class Frm_Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hello));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Birth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Sex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Hello = new System.Windows.Forms.Button();
            this.txt_Star = new System.Windows.Forms.TextBox();
            this.btn_Hi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(67, 62);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(80, 29);
            this.txt_Name.TabIndex = 3;
            // 
            // lab_name
            // 
            this.lab_name.AllowDrop = true;
            this.lab_name.AutoSize = true;
            this.lab_name.BackColor = System.Drawing.Color.Transparent;
            this.lab_name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_name.Location = new System.Drawing.Point(11, 63);
            this.lab_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(52, 24);
            this.lab_name.TabIndex = 4;
            this.lab_name.Text = "姓名:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "生日:";
            // 
            // txt_Birth
            // 
            this.txt_Birth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Birth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Birth.Location = new System.Drawing.Point(67, 104);
            this.txt_Birth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Birth.Name = "txt_Birth";
            this.txt_Birth.Size = new System.Drawing.Size(80, 29);
            this.txt_Birth.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "性別:";
            // 
            // cmb_Sex
            // 
            this.cmb_Sex.FormattingEnabled = true;
            this.cmb_Sex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cmb_Sex.Location = new System.Drawing.Point(67, 162);
            this.cmb_Sex.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Sex.Name = "cmb_Sex";
            this.cmb_Sex.Size = new System.Drawing.Size(80, 20);
            this.cmb_Sex.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "星座:";
            // 
            // btn_Hello
            // 
            this.btn_Hello.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Hello.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_Hello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hello.Location = new System.Drawing.Point(403, 63);
            this.btn_Hello.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(69, 38);
            this.btn_Hello.TabIndex = 10;
            this.btn_Hello.Text = "Hello!";
            this.btn_Hello.UseVisualStyleBackColor = false;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // txt_Star
            // 
            this.txt_Star.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Star.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Star.Location = new System.Drawing.Point(67, 210);
            this.txt_Star.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Star.Name = "txt_Star";
            this.txt_Star.Size = new System.Drawing.Size(80, 29);
            this.txt_Star.TabIndex = 11;
            // 
            // btn_Hi
            // 
            this.btn_Hi.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Hi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_Hi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hi.Location = new System.Drawing.Point(403, 175);
            this.btn_Hi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Hi.Name = "btn_Hi";
            this.btn_Hi.Size = new System.Drawing.Size(69, 38);
            this.btn_Hi.TabIndex = 12;
            this.btn_Hi.Text = "Hi!";
            this.btn_Hi.UseVisualStyleBackColor = false;
            this.btn_Hi.Click += new System.EventHandler(this.btn_Hi_Click);
            // 
            // Frm_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(545, 304);
            this.Controls.Add(this.btn_Hi);
            this.Controls.Add(this.txt_Star);
            this.Controls.Add(this.btn_Hello);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Sex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Birth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.txt_Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Hello";
            this.ShowIcon = false;
            this.Text = "Frm01_hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Birth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Sex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.TextBox txt_Star;
        private System.Windows.Forms.Button btn_Hi;
    }
}