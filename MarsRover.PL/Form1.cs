using System;
using System.Windows.Forms;
using MarsRover.BL;
namespace MarsRover.PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckMovementDirectives()
        {
            string newValue="";
            foreach (char item in txt_MovementDirectives.Text.ToUpper())
            {
                newValue = (item == 'L' || item == 'R' || item == 'M') ? newValue = string.Concat(newValue, item) : newValue;
            }
            txt_MovementDirectives.Text = newValue;
        }
        private void btn_Result_Click(object sender, EventArgs e)
        {

            CheckMovementDirectives(); 
            if (txt_MovementDirectives.Text.Trim().Length < 1)
            {
                MessageBox.Show("Movement directives is invalid !!!");
                return;
            }

            
            OperationControls operationControls = new OperationControls();

            string returnValue = operationControls.MainControls(new OperationInformation
            {
                UpperRightCoordinateX = (int)txt_MapMaxX.Value,
                UpperRightCoordinateY = (int)txt_MapMaxY.Value,
                FirstLocationX = (int)txt_RbtFirstX.Value,
                FirstLocationY = (int)txt_RbtFirstY.Value,
                FirstDirection = (rdo_E.Checked) ? 'E' : ((rdo_N.Checked) ? 'N' : (rdo_S.Checked) ? 'S' : 'W'),
                MovementDirectives = txt_MovementDirectives.Text.ToUpper().Trim()
            });

            MessageBox.Show(returnValue);
            
        }
    }
}
