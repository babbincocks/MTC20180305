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
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double firstVal = 0;
            double secondVal = 0;
            bool number = true;

            number = (double.TryParse(txtFirstValue.Text, out firstVal) 
                        && double.TryParse(txtSecondValue.Text, out secondVal));

            if (txtFirstValue.Text != null && txtSecondValue.Text != null && number == true)
            {

                if (rbAdd.Checked)
                {
                    txtResult.Text = (firstVal + secondVal).ToString();

                }

                if (rbSubtract.Checked)
                {
                    txtResult.Text = (firstVal - secondVal).ToString();

                }

                if (rbMultiply.Checked)
                {
                    txtResult.Text = (firstVal * secondVal).ToString();

                }

                if (rbDivide.Checked)
                {
                    txtResult.Text = (firstVal / secondVal).ToString();

                }





            }

            else brule.Show("dingus");

           
        }


    }
}
