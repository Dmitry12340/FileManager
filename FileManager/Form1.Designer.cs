namespace FileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FileTypeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(713, 0);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FileName";
            // 
            // ListView1
            // 
            this.ListView1.HideSelection = false;
            this.ListView1.LargeImageList = this.iconList;
            this.ListView1.Location = new System.Drawing.Point(0, 26);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(788, 382);
            this.ListView1.SmallImageList = this.iconList;
            this.ListView1.TabIndex = 3;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView1_ItemSelectionChanged);
            this.ListView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "unknown.png");
            this.iconList.Images.SetKeyName(1, "folder.png");
            this.iconList.Images.SetKeyName(2, "txt.png");
            this.iconList.Images.SetKeyName(3, "png.png");
            this.iconList.Images.SetKeyName(4, "exe.png");
            this.iconList.Images.SetKeyName(5, "mp4.png");
            this.iconList.Images.SetKeyName(6, "mp3.png");
            this.iconList.Images.SetKeyName(7, "pdf.png");
            this.iconList.Images.SetKeyName(8, "doc.png");
            this.iconList.Images.SetKeyName(9, "file.png");
            this.iconList.Images.SetKeyName(10, "bin.png");
            this.iconList.Images.SetKeyName(11, "dll.png");
            this.iconList.Images.SetKeyName(12, "ini.png");
            this.iconList.Images.SetKeyName(13, "dat.png");
            this.iconList.Images.SetKeyName(14, "lnk.png");
            this.iconList.Images.SetKeyName(15, "url.png");
            this.iconList.Images.SetKeyName(16, "xlsx.png");
            this.iconList.Images.SetKeyName(17, "xls.png");
            this.iconList.Images.SetKeyName(18, "jpg.png");
            this.iconList.Images.SetKeyName(19, "jpeg.png");
            this.iconList.Images.SetKeyName(20, "pptx.png");
            this.iconList.Images.SetKeyName(21, "docx.png");
            this.iconList.Images.SetKeyName(22, "sln.png");
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(81, 0);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(626, 20);
            this.FilePathTextBox.TabIndex = 4;
            // 
            // FileNameLable
            // 
            this.FileNameLable.AutoSize = true;
            this.FileNameLable.Location = new System.Drawing.Point(68, 428);
            this.FileNameLable.Name = "FileNameLable";
            this.FileNameLable.Size = new System.Drawing.Size(13, 13);
            this.FileNameLable.TabIndex = 5;
            this.FileNameLable.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FileType";
            // 
            // FileTypeLable
            // 
            this.FileTypeLable.AutoSize = true;
            this.FileTypeLable.Location = new System.Drawing.Point(717, 428);
            this.FileTypeLable.Name = "FileTypeLable";
            this.FileTypeLable.Size = new System.Drawing.Size(13, 13);
            this.FileTypeLable.TabIndex = 7;
            this.FileTypeLable.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileTypeLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileNameLable);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.BackButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label FileNameLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FileTypeLable;
        private System.Windows.Forms.ImageList iconList;
    }
}

