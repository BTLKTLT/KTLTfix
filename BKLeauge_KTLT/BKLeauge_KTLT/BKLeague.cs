using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKLeauge_KTLT
{
    public partial class BKLeague : Form
    {
        public BKLeague()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Schedule frm = new Schedule();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Results frm = new Results();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Info frm = new Info();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Results frm = new Results();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update frm = new Update();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateClub frm = new UpdateClub();
            frm.Show();
        }
    }
}
