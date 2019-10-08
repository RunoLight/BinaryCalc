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
            this.binaryA0 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // binaryA0
            // 
            this.binaryA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.binaryA0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.binaryA0.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.binaryA0.Font = new System.Drawing.Font("Artifakt Element", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binaryA0.ForeColor = System.Drawing.Color.White;
            this.binaryA0.Location = new System.Drawing.Point(6, 36);
            this.binaryA0.Name = "binaryA0";
            this.binaryA0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.binaryA0.Size = new System.Drawing.Size(45, 45);
            this.binaryA0.TabIndex = 2;
            this.binaryA0.Text = "0";
            this.binaryA0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Artifakt Element", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(6, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(45, 45);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.binaryA0);
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
        private System.Windows.Forms.TextBox binaryA0;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
    }
}