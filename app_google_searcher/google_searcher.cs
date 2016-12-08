using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_google_searcher
{
    public partial class google_searcher : Form
    {
        bool close = false;

        public google_searcher()
        {
            InitializeComponent();
        }

        private void google_searcher_Load(object sender, EventArgs e)
        {
            website_browser.Url = new Uri("http://www.google.com");
            
            this.Hide();
        }
        
        private void google_searcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.close == false) {
                e.Cancel = true;

                // Stop the page from background processing.
                website_browser.Url = new Uri("http://www.google.com");
                // website_browser.Stop();
                ((Control) website_browser).Enabled = false;

                this.Hide();
            }
        }

        private void google_searcher_Resize(object sender, EventArgs e)
        {
            website_browser.Width = this.Width;
            website_browser.Height = this.Height;
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.Visible == true)
            {
                this.Hide();
            }
            else { 
                google_search dialog = new google_search();

                dialog.ShowDialog();
                dialog.BringToFront();

                string search = dialog.input_result;

                if(string.IsNullOrWhiteSpace(search) == false) {
                    this.Show();
                    this.BringToFront();

                    // Allow the page to do background stuff.
                    ((Control)website_browser).Enabled = true;

                    string uri = 
                        "http://www.google.com/search?q=" + 
                        System
                            .Web
                            .HttpUtility
                            .ParseQueryString(search)
                            .ToString()
                    ;

                    website_browser.Url = new Uri(uri);
                }
            }
        }

        private void notify_menu_exit_Click(object sender, EventArgs e)
        {
            this.close = true;
            Application.Exit();
        }
    }
}
