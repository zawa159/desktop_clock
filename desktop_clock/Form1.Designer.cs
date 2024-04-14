namespace desktop_clock
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NowTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowTime
            // 
            this.NowTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NowTime.ContextMenuStrip = this.contextMenuStrip1;
            this.NowTime.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::desktop_clock.Properties.Settings.Default, "MyLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NowTime.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowTime.Location = global::desktop_clock.Properties.Settings.Default.MyLocation;
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(167, 50);
            this.NowTime.TabIndex = 0;
            this.NowTime.Text = "00:00:00";
            this.NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NowTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NowTime_MouseDown);
            this.NowTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NowTime_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(167, 50);
            this.ControlBox = false;
            this.Controls.Add(this.NowTime);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::desktop_clock.Properties.Settings.Default, "MyLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::desktop_clock.Properties.Settings.Default.MyLocation;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "desktop_clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NowTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}

