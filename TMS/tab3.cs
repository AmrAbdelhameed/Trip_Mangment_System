using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class tab3 : UserControl
    {
        public tab3()
        {
            InitializeComponent();
        }

       
        private void city_Enter(object sender, EventArgs e)
        {
            city.Text = "";
        }
    }
}
