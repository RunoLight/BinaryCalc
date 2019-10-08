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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Calculus.Term variableA = new Calculus.Term();
            Calculus.Term variableB = new Calculus.Term();
            Calculus.Term variableC = new Calculus.Term();
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
        }
    }
}