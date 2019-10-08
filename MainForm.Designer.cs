namespace BinaryCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flatTop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.A15 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            // 
            // flatTop
            // 
            this.flatTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.flatTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTop.FlatAppearance.BorderSize = 0;
            this.flatTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatTop.Location = new System.Drawing.Point(0, 0);
            this.flatTop.Name = "flatTop";
            this.flatTop.Size = new System.Drawing.Size(800, 30);
            this.flatTop.TabIndex = 0;
            this.flatTop.UseVisualStyleBackColor = false;
            this.flatTop.Click += new System.EventHandler(this.flatTop_Click);
            this.flatTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flatTop_MouseDown);
            this.flatTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flatTop_MouseMove);
            this.flatTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flatTop_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "comboBox1";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.LineColor = System.Drawing.Color.Empty;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(9, 224);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "1";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Artifakt Element", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(57, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(45, 45);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Artifakt Element", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(57, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(45, 45);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A15
            // 
            this.A15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.A15.FlatAppearance.BorderSize = 0;
            this.A15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A15.Font = new System.Drawing.Font("Artifakt Element", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A15.ForeColor = System.Drawing.Color.White;
            this.A15.Location = new System.Drawing.Point(9, 36);
            this.A15.Name = "A15";
            this.A15.Size = new System.Drawing.Size(50, 50);
            this.A15.TabIndex = 2;
            this.A15.Text = "0";
            this.A15.UseVisualStyleBackColor = false;
            this.A15.Click += new System.EventHandler(this.ButtonSwitcher);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Artifakt Element", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(65, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonSwitcher);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.A15);
            this.Controls.Add(this.flatTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Binary Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);

        }

        #endregion

        private System.Windows.Forms.Button flatTop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Abinary1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button A15;
        private System.Windows.Forms.Button button1;
    }
}