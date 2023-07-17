using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int Width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = Width.ToString() + "-" + height.ToString();
        }

        private void Form3_ResizeEnd(object sender, EventArgs e)
        {

       
            int Width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = Width.ToString() + "-" + height.ToString();

        }
        
    }
}
