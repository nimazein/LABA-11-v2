using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class InputCapacity : Form
    {
        public InputCapacity()
        {
            InitializeComponent();
        }
        public static int capacity;
        private void BTInputCapacity_Click(object sender, EventArgs e)
        {
            capacity = Convert.ToInt32(TBCapacity.Text);

        }
    }
}
