namespace UsingLock
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_stopCounting = new System.Windows.Forms.Button();
            this.label_showCounting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_stopCounting
            // 
            this.btn_stopCounting.Location = new System.Drawing.Point(261, 90);
            this.btn_stopCounting.Name = "btn_stopCounting";
            this.btn_stopCounting.Size = new System.Drawing.Size(106, 27);
            this.btn_stopCounting.TabIndex = 0;
            this.btn_stopCounting.Text = "StopCount";
            this.btn_stopCounting.UseVisualStyleBackColor = true;
            this.btn_stopCounting.Click += new System.EventHandler(this.btn_stopCounting_Click);
            // 
            // label_showCounting
            // 
            this.label_showCounting.AutoSize = true;
            this.label_showCounting.Location = new System.Drawing.Point(261, 188);
            this.label_showCounting.Name = "label_showCounting";
            this.label_showCounting.Size = new System.Drawing.Size(62, 18);
            this.label_showCounting.TabIndex = 1;
            this.label_showCounting.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 454);
            this.Controls.Add(this.label_showCounting);
            this.Controls.Add(this.btn_stopCounting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stopCounting;
        private System.Windows.Forms.Label label_showCounting;
    }
}

