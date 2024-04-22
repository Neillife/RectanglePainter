namespace RectanglePainter
{
    partial class RectanglePainterForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglePainterForm));
            this.PaintButton = new System.Windows.Forms.Button();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.SelectImgButton = new System.Windows.Forms.Button();
            this.ImgView = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ImageResolutionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgView)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintButton
            // 
            this.PaintButton.Location = new System.Drawing.Point(5, 5);
            this.PaintButton.Name = "PaintButton";
            this.PaintButton.Size = new System.Drawing.Size(100, 30);
            this.PaintButton.TabIndex = 0;
            this.PaintButton.Text = "Paint";
            this.PaintButton.UseVisualStyleBackColor = true;
            this.PaintButton.Click += new System.EventHandler(this.PaintButton_Click);
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(227, 11);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(50, 22);
            this.YTextBox.TabIndex = 1;
            this.YTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YTextBox_KeyPress);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(141, 11);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(50, 22);
            this.XTextBox.TabIndex = 2;
            this.XTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XTextBox_KeyPress);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(450, 11);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(50, 22);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(338, 11);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(50, 22);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTextBox_KeyPress);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("新細明體", 10F);
            this.XLabel.Location = new System.Drawing.Point(120, 15);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(16, 14);
            this.XLabel.TabIndex = 5;
            this.XLabel.Text = "X";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("新細明體", 10F);
            this.YLabel.Location = new System.Drawing.Point(206, 15);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(16, 14);
            this.YLabel.TabIndex = 6;
            this.YLabel.Text = "Y";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("新細明體", 10F);
            this.WidthLabel.Location = new System.Drawing.Point(291, 15);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(41, 14);
            this.WidthLabel.TabIndex = 7;
            this.WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("新細明體", 10F);
            this.HeightLabel.Location = new System.Drawing.Point(403, 15);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(44, 14);
            this.HeightLabel.TabIndex = 8;
            this.HeightLabel.Text = "Height";
            // 
            // SelectImgButton
            // 
            this.SelectImgButton.Location = new System.Drawing.Point(5, 41);
            this.SelectImgButton.Name = "SelectImgButton";
            this.SelectImgButton.Size = new System.Drawing.Size(100, 30);
            this.SelectImgButton.TabIndex = 9;
            this.SelectImgButton.Text = "Select Image";
            this.SelectImgButton.UseVisualStyleBackColor = true;
            this.SelectImgButton.Click += new System.EventHandler(this.SelectImgButton_Click);
            // 
            // ImgView
            // 
            this.ImgView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ImgView.Location = new System.Drawing.Point(5, 77);
            this.ImgView.Name = "ImgView";
            this.ImgView.Size = new System.Drawing.Size(400, 300);
            this.ImgView.TabIndex = 10;
            this.ImgView.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Window adapts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageResolutionLabel
            // 
            this.ImageResolutionLabel.AutoSize = true;
            this.ImageResolutionLabel.Font = new System.Drawing.Font("新細明體", 10F);
            this.ImageResolutionLabel.Location = new System.Drawing.Point(224, 50);
            this.ImageResolutionLabel.Name = "ImageResolutionLabel";
            this.ImageResolutionLabel.Size = new System.Drawing.Size(129, 14);
            this.ImageResolutionLabel.TabIndex = 12;
            this.ImageResolutionLabel.Text = "Image Resolution 0x0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImageResolutionLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImgView);
            this.Controls.Add(this.SelectImgButton);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.PaintButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RectanglePainter";
            ((System.ComponentModel.ISupportInitialize)(this.ImgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PaintButton;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button SelectImgButton;
        private System.Windows.Forms.PictureBox ImgView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ImageResolutionLabel;
    }
}

