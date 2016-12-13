namespace app_google_searcher
{
    partial class google_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(google_search));
            this.input_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_box.Location = new System.Drawing.Point(-1, 12);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(286, 20);
            this.input_box.TabIndex = 0;
            this.input_box.TextChanged += new System.EventHandler(this.input_box_TextChanged);
            this.input_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_box_KeyUp);
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Location = new System.Drawing.Point(129, 38);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.Location = new System.Drawing.Point(210, 38);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // google_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 73);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.input_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "google_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Searcher";
            this.Load += new System.EventHandler(this.google_search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button cancel_button;
    }
}