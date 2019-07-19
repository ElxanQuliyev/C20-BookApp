using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20_Form_07_15_2019
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            lblWelcome.Text = "Welcome to Library!";
            pcMain.Image = new Bitmap(@"C:\Users\User\source\repos\C20-Form-07-15-2019\C20-Form-07-15-2019\Images\content.png");
            pcMain.Location = new Point(pcMain.Parent.ClientSize.Width / 2 - pcMain.Size.Width / 2,
                pcMain.Parent.ClientSize.Height / 2 - pcMain.Size.Height / 2

                );
        }

        private void menuClickToll(object sender, EventArgs e)
        {
            ReadersForm rd = new ReadersForm();
            rd.ShowDialog();
        }
    }
}
