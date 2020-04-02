namespace Download_Time_Calculator
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.enterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.storageTxtBox = new System.Windows.Forms.TextBox();
            this.storageCmbBox = new System.Windows.Forms.ComboBox();
            this.downRateCmboBox = new System.Windows.Forms.ComboBox();
            this.downRateTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.createTimerBtn = new System.Windows.Forms.Button();
            this.subTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(208, 182);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(68, 28);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Storage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Download Time Calculator";
            // 
            // storageTxtBox
            // 
            this.storageTxtBox.Location = new System.Drawing.Point(16, 69);
            this.storageTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.storageTxtBox.Name = "storageTxtBox";
            this.storageTxtBox.Size = new System.Drawing.Size(179, 22);
            this.storageTxtBox.TabIndex = 3;
            // 
            // storageCmbBox
            // 
            this.storageCmbBox.FormattingEnabled = true;
            this.storageCmbBox.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.storageCmbBox.Location = new System.Drawing.Point(208, 69);
            this.storageCmbBox.Margin = new System.Windows.Forms.Padding(4);
            this.storageCmbBox.Name = "storageCmbBox";
            this.storageCmbBox.Size = new System.Drawing.Size(67, 24);
            this.storageCmbBox.TabIndex = 6;
            this.storageCmbBox.SelectedIndexChanged += new System.EventHandler(this.storageCmbBox_SelectedIndexChanged);
            // 
            // downRateCmboBox
            // 
            this.downRateCmboBox.FormattingEnabled = true;
            this.downRateCmboBox.Items.AddRange(new object[] {
            "KB/s",
            "MB/s",
            "GB/s",
            "TB/s"});
            this.downRateCmboBox.Location = new System.Drawing.Point(208, 135);
            this.downRateCmboBox.Margin = new System.Windows.Forms.Padding(4);
            this.downRateCmboBox.Name = "downRateCmboBox";
            this.downRateCmboBox.Size = new System.Drawing.Size(67, 24);
            this.downRateCmboBox.TabIndex = 7;
            // 
            // downRateTxtBox
            // 
            this.downRateTxtBox.Location = new System.Drawing.Point(16, 135);
            this.downRateTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.downRateTxtBox.Name = "downRateTxtBox";
            this.downRateTxtBox.Size = new System.Drawing.Size(179, 22);
            this.downRateTxtBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Download Rate";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(16, 182);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(183, 22);
            this.resultBox.TabIndex = 10;
            this.resultBox.Text = "Result";
            // 
            // createTimerBtn
            // 
            this.createTimerBtn.Location = new System.Drawing.Point(16, 218);
            this.createTimerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createTimerBtn.Name = "createTimerBtn";
            this.createTimerBtn.Size = new System.Drawing.Size(260, 28);
            this.createTimerBtn.TabIndex = 12;
            this.createTimerBtn.Text = "Create Timer";
            this.createTimerBtn.UseVisualStyleBackColor = true;
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Location = new System.Drawing.Point(117, 27);
            this.subTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(64, 17);
            this.subTitle.TabIndex = 13;
            this.subTitle.Text = "By Mr. El";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 257);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.createTimerBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downRateTxtBox);
            this.Controls.Add(this.downRateCmboBox);
            this.Controls.Add(this.storageCmbBox);
            this.Controls.Add(this.storageTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Download Time Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox storageTxtBox;
        private System.Windows.Forms.ComboBox storageCmbBox;
        private System.Windows.Forms.ComboBox downRateCmboBox;
        private System.Windows.Forms.TextBox downRateTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button createTimerBtn;
        private System.Windows.Forms.Label subTitle;
    }
}

