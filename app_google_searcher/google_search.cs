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
    public partial class google_search : Form
    {
        public string input_result = string.Empty;

        public google_search()
        {
            InitializeComponent();
        }

        private void google_search_Load(object sender, EventArgs e)
        {

        }

        private void input_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            this.input_result = input_box.Text;
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void input_box_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.input_result = input_box.Text;
                this.Close();
            }
        }
    }
}
