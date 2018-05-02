namespace RegressionSuiteTestHarness
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProjectSuiteSelector = new System.Windows.Forms.TextBox();
            this.ProjectSelector = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.APFeedbackBox = new System.Windows.Forms.TextBox();
            this.APGifZone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.APGifZone)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select TestSuite ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ProjectSuiteSelector
            // 
            this.ProjectSuiteSelector.Location = new System.Drawing.Point(12, 33);
            this.ProjectSuiteSelector.Name = "ProjectSuiteSelector";
            this.ProjectSuiteSelector.Size = new System.Drawing.Size(425, 20);
            this.ProjectSuiteSelector.TabIndex = 1;
            this.ProjectSuiteSelector.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProjectSelector
            // 
            this.ProjectSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectSelector.FormattingEnabled = true;
            this.ProjectSelector.Location = new System.Drawing.Point(12, 85);
            this.ProjectSelector.Name = "ProjectSelector";
            this.ProjectSelector.Size = new System.Drawing.Size(425, 21);
            this.ProjectSelector.TabIndex = 3;
            this.ProjectSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Run Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // APFeedbackBox
            // 
            this.APFeedbackBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APFeedbackBox.Location = new System.Drawing.Point(153, 248);
            this.APFeedbackBox.Multiline = true;
            this.APFeedbackBox.Name = "APFeedbackBox";
            this.APFeedbackBox.Size = new System.Drawing.Size(284, 111);
            this.APFeedbackBox.TabIndex = 6;
            this.APFeedbackBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // APGifZone
            // 
            this.APGifZone.BackColor = System.Drawing.Color.Transparent;
            this.APGifZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.APGifZone.Image = ((System.Drawing.Image)(resources.GetObject("APGifZone.Image")));
            this.APGifZone.Location = new System.Drawing.Point(12, 141);
            this.APGifZone.Name = "APGifZone";
            this.APGifZone.Size = new System.Drawing.Size(118, 218);
            this.APGifZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.APGifZone.TabIndex = 5;
            this.APGifZone.TabStop = false;
            this.APGifZone.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 367);
            this.Controls.Add(this.APFeedbackBox);
            this.Controls.Add(this.APGifZone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProjectSelector);
            this.Controls.Add(this.ProjectSuiteSelector);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Regression Suite Test Harness";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.APGifZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ProjectSuiteSelector;
        private System.Windows.Forms.ComboBox ProjectSelector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox APFeedbackBox;
        private System.Windows.Forms.PictureBox APGifZone;
    }
}

