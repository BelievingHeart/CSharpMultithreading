namespace AsyncAndAwait
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
            this.btn_runAsync = new System.Windows.Forms.Button();
            this.btn_ranAsyncParallel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_runAsync
            // 
            this.btn_runAsync.Location = new System.Drawing.Point(18, 60);
            this.btn_runAsync.Margin = new System.Windows.Forms.Padding(4);
            this.btn_runAsync.Name = "btn_runAsync";
            this.btn_runAsync.Size = new System.Drawing.Size(112, 34);
            this.btn_runAsync.TabIndex = 0;
            this.btn_runAsync.Text = "RunAsync";
            this.btn_runAsync.UseVisualStyleBackColor = true;
            this.btn_runAsync.Click += new System.EventHandler(this.btn_runAsync_Click);
            // 
            // btn_ranAsyncParallel
            // 
            this.btn_ranAsyncParallel.Location = new System.Drawing.Point(184, 60);
            this.btn_ranAsyncParallel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ranAsyncParallel.Name = "btn_ranAsyncParallel";
            this.btn_ranAsyncParallel.Size = new System.Drawing.Size(202, 36);
            this.btn_ranAsyncParallel.TabIndex = 1;
            this.btn_ranAsyncParallel.Text = "RunAsyncParallel";
            this.btn_ranAsyncParallel.UseVisualStyleBackColor = true;
            this.btn_ranAsyncParallel.Click += new System.EventHandler(this.btn_ranAsyncParallel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 208);
            this.textBox1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(321, 16);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(18, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 494);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ranAsyncParallel);
            this.Controls.Add(this.btn_runAsync);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_runAsync;
        private System.Windows.Forms.Button btn_ranAsyncParallel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_cancel;
    }
}

