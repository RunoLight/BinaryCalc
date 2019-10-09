using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinaryCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Moving Form
        private bool mouseDown;
        private Point lastLocation;
        //*

        //Notation
        int Notation = 10;
        //*

        Calculus.Term variableA = new Calculus.Term();
        Calculus.Term variableB = new Calculus.Term();
        Calculus.Term variableC = new Calculus.Term();
       

        public void MainForm_Load(object sender, EventArgs e)
        {
            variableA.denary = 0; variableB.denary = 0; variableC.denary = 0;
            variableA.RefreshBy(10); variableB.RefreshBy(10); variableC.RefreshBy(10);
            Anotation.Text = Convert.ToString(Notation);
        }

        private void flatTop_Click(object sender, EventArgs e)
        {
        }

        private void flatTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void flatTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void flatTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ButtonSwitcher(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton == null)
                return;

            if (clickedButton.Text == "0")
            {
                clickedButton.Text = "1";
            }
            else
            {
                clickedButton.Text = "0";
            }

            RefreshValue(sender, e);
        }

        private void SwitchNotation(object sender, EventArgs e)
        {
            if (Notation == 10)
                Notation = 16;
            else if (Notation == 16)
                Notation = 8;
            else if (Notation == 8)
                Notation = 10;

            Anotation.Text = Convert.ToString(Notation);

            RefreshValue(sender, e);
        }

        private void RefreshValue(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            //string temp = string.Empty;

            

            if (clickedButton.Name.StartsWith("A"))
            {
                string temp = A15.Text + A14.Text + A13.Text + A12.Text + A11.Text + A10.Text + A9.Text + A8.Text +
                    A7.Text + A6.Text + A5.Text + A4.Text + A3.Text + A2.Text + A1.Text + A0.Text;

                variableA.binary = temp;
                variableA.RefreshBy(2);

                if (Notation == 8)
                    Afull.Text = variableA.octal;
                else if (Notation == 10)
                    Afull.Text = Convert.ToString(variableA.denary);
                else if (Notation == 16)
                    Afull.Text = variableA.hexadecimal.ToUpper();
            }
            else if (clickedButton.Name.StartsWith("B"))
            {

            }
            else // C denary button
            {

            }
        }
    }
}