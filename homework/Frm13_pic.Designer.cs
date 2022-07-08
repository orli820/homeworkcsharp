
namespace homework
{
    partial class Frm13_pic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm13_pic));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewpic = new System.Windows.Forms.ListView();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2339600-XXL.jpg");
            this.imageList1.Images.SetKeyName(1, "原生臉.jpg");
            // 
            // listViewpic
            // 
            this.listViewpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewpic.HideSelection = false;
            this.listViewpic.LargeImageList = this.imageList1;
            this.listViewpic.Location = new System.Drawing.Point(0, 0);
            this.listViewpic.Name = "listViewpic";
            this.listViewpic.Size = new System.Drawing.Size(800, 450);
            this.listViewpic.TabIndex = 1;
            this.listViewpic.UseCompatibleStateImageBehavior = false;
            // 
            // pcb1
            // 
            this.pcb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb1.BackgroundImage")));
            this.pcb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcb1.Location = new System.Drawing.Point(23, 24);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(158, 101);
            this.pcb1.TabIndex = 2;
            this.pcb1.TabStop = false;
            this.pcb1.Click += new System.EventHandler(this.pcb1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(218, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 101);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Frm13_pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.listViewpic);
            this.Name = "Frm13_pic";
            this.Text = "Pic View";
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewpic;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}