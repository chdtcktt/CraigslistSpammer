using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraigslistSpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpam_Click(object sender, EventArgs e)
        {
            GetJobs getJobs = new GetJobs();

            getJobs.Find("http://seattle.craigslist.org/search/jjj?zoomToPosting=&catAbb=jjj&query=web+developer&excats=");


        }
    }
}
