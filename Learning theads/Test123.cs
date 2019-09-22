using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Learning_theads
{
    public partial class Test123 : Form
    {
        public Test123()
        {
            Thread Start = new Thread(new ThreadStart(StartForm));
            Start.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            Start.Abort();
        }

        public void StartForm()
        {
            Application.Run(new frmSplash());
        }
    }
}
