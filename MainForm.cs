using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BinaryCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        bool mouseDown;
        Point lastLocation;
        private void MainForm_Load(object sender, EventArgs e)
        {
            Calculus.Term variableA = new Calculus.Term();
            Calculus.Term variableB = new Calculus.Term();
            Calculus.Term variableC = new Calculus.Term();

            variableA.denary = 0; variableB.denary = 0; variableC.denary = 0;
            variableA.RefreshBy(10); variableB.RefreshBy(10); variableC.RefreshBy(10);
        }

        private void flatTop_Click(object sender, EventArgs e)
        {

        }

        private void Abinary15_TextChanged(object sender, EventArgs e)
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
    }
}
