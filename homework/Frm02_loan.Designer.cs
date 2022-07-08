
namespace homework
{
    partial class Frm02_loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm02_loan));
            this.lab_dnpay = new System.Windows.Forms.Label();
            this.lab_Rate = new System.Windows.Forms.Label();
            this.lab_Year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_loan = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.txt_dnpay = new System.Windows.Forms.TextBox();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_Month = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_dnpay
            // 
            this.lab_dnpay.AutoSize = true;
            this.lab_dnpay.BackColor = System.Drawing.Color.Transparent;
            this.lab_dnpay.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_dnpay.Location = new System.Drawing.Point(45, 258);
            this.lab_dnpay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_dnpay.Name = "lab_dnpay";
            this.lab_dnpay.Size = new System.Drawing.Size(106, 24);
            this.lab_dnpay.TabIndex = 8;
            this.lab_dnpay.Text = "頭期款：";
            // 
            // lab_Rate
            // 
            this.lab_Rate.AutoSize = true;
            this.lab_Rate.BackColor = System.Drawing.Color.Transparent;
            this.lab_Rate.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Rate.Location = new System.Drawing.Point(29, 196);
            this.lab_Rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Rate.Name = "lab_Rate";
            this.lab_Rate.Size = new System.Drawing.Size(117, 24);
            this.lab_Rate.TabIndex = 7;
            this.lab_Rate.Text = "利率(%)：";
            // 
            // lab_Year
            // 
            this.lab_Year.AutoSize = true;
            this.lab_Year.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Year.Location = new System.Drawing.Point(29, 131);
            this.lab_Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Year.Name = "lab_Year";
            this.lab_Year.Size = new System.Drawing.Size(122, 24);
            this.lab_Year.TabIndex = 6;
            this.lab_Year.Text = "期限(年)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "貸款金額：";
            // 
            // txt_loan
            // 
            this.txt_loan.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_loan.Location = new System.Drawing.Point(181, 65);
            this.txt_loan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_loan.Name = "txt_loan";
            this.txt_loan.Size = new System.Drawing.Size(217, 35);
            this.txt_loan.TabIndex = 16;
            this.txt_loan.Text = "100000";
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_year.Location = new System.Drawing.Point(181, 128);
            this.txt_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(217, 35);
            this.txt_year.TabIndex = 15;
            this.txt_year.Text = "2";
            // 
            // txt_rate
            // 
            this.txt_rate.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_rate.Location = new System.Drawing.Point(181, 192);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(217, 35);
            this.txt_rate.TabIndex = 14;
            this.txt_rate.Text = "10";
            // 
            // txt_dnpay
            // 
            this.txt_dnpay.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_dnpay.Location = new System.Drawing.Point(181, 254);
            this.txt_dnpay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_dnpay.Name = "txt_dnpay";
            this.txt_dnpay.Size = new System.Drawing.Size(217, 35);
            this.txt_dnpay.TabIndex = 13;
            this.txt_dnpay.Text = "0";
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.LightYellow;
            this.btn_report.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(355, 344);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(131, 66);
            this.btn_report.TabIndex = 19;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Total.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Total.Location = new System.Drawing.Point(200, 344);
            this.btn_Total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(125, 66);
            this.btn_Total.TabIndex = 18;
            this.btn_Total.Text = "總付額";
            this.btn_Total.UseVisualStyleBackColor = false;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // btn_Month
            // 
            this.btn_Month.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Month.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Month.Location = new System.Drawing.Point(25, 355);
            this.btn_Month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Month.Name = "btn_Month";
            this.btn_Month.Size = new System.Drawing.Size(137, 55);
            this.btn_Month.TabIndex = 17;
            this.btn_Month.Text = "PMT月付額";
            this.btn_Month.UseVisualStyleBackColor = false;
            this.btn_Month.Click += new System.EventHandler(this.btn_Month_Click);
            // 
            // Frm02_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 430);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.btn_Month);
            this.Controls.Add(this.txt_loan);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.txt_dnpay);
            this.Controls.Add(this.lab_dnpay);
            this.Controls.Add(this.lab_Rate);
            this.Controls.Add(this.lab_Year);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm02_loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_dnpay;
        private System.Windows.Forms.Label lab_Rate;
        private System.Windows.Forms.Label lab_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_loan;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.TextBox txt_dnpay;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_Month;
    }
}