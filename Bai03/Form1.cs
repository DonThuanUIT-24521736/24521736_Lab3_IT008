using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            Random random = new Random(); 
            Color newcolor = Color.FromArgb(
                random.Next(256), 
                random.Next(255),
                random.Next(255));
            this.BackColor = newcolor; 
        }

        
    }
}
