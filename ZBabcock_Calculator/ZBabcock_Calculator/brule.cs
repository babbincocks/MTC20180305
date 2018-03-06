using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBabcock_Calculator
{
    internal partial class brule : Form
    {
        public brule()
        {
            InitializeComponent();
        }

        public static void Show(string dingus)
        {
            brule messagebox = new brule();
            messagebox.ShowDialog();
        }



    }


}
