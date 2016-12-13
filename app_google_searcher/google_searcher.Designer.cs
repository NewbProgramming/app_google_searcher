namespace app_google_searcher
{
    partial class google_searcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(google_searcher));
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notify_menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.website_browser = new System.Windows.Forms.WebBrowser();
            this.notify_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.notify_menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Google Searcher";
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // notify_menu
            // 
            this.notify_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notify_menu_exit});
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(93, 26);
            this.notify_menu.Text = "notify_menu";
            // 
            // notify_menu_exit
            // 
            this.notify_menu_exit.Name = "notify_menu_exit";
            this.notify_menu_exit.Size = new System.Drawing.Size(92, 22);
            this.notify_menu_exit.Text = "Exit";
            this.notify_menu_exit.Click += new System.EventHandler(this.notify_menu_exit_Click);
            // 
            // website_browser
            // 
            this.website_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.website_browser.Location = new System.Drawing.Point(0, 0);
            this.website_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.website_browser.Name = "website_browser";
            this.website_browser.Size = new System.Drawing.Size(686, 316);
            this.website_browser.TabIndex = 1;
            // 
            // google_searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 316);
            this.Controls.Add(this.website_browser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "google_searcher";
            this.Text = "Google Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.google_searcher_FormClosing);
            this.Load += new System.EventHandler(this.google_searcher_Load);
            this.Resize += new System.EventHandler(this.google_searcher_Resize);
            this.notify_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip notify_menu;
        private System.Windows.Forms.WebBrowser website_browser;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_exit;
    }
}

