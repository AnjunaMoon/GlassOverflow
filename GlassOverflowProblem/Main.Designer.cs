namespace GlassOverflowProblem
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btCalc = new Button();
            txtTime = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numCol = new NumericUpDown();
            numRow = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRow).BeginInit();
            SuspendLayout();
            // 
            // btCalc
            // 
            btCalc.Location = new Point(4, 70);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(103, 24);
            btCalc.TabIndex = 0;
            btCalc.Text = "Beräkna";
            btCalc.UseVisualStyleBackColor = true;
            btCalc.Click += btCalc_Click;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(211, 72);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(56, 23);
            txtTime.TabIndex = 6;
            txtTime.Text = "0";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(4, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(61, 16);
            textBox1.TabIndex = 7;
            textBox1.Text = "Glas";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(4, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 16);
            textBox2.TabIndex = 8;
            textBox2.Text = "Rad";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(113, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 16);
            textBox3.TabIndex = 9;
            textBox3.Text = "Tid till överflöde";
            // 
            // numCol
            // 
            numCol.AllowDrop = true;
            numCol.BorderStyle = BorderStyle.FixedSingle;
            numCol.Location = new Point(33, 36);
            numCol.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCol.Name = "numCol";
            numCol.Size = new Size(74, 23);
            numCol.TabIndex = 10;
            numCol.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numCol.ValueChanged += numCol_ValueChanged;
            // 
            // numRow
            // 
            numRow.BorderStyle = BorderStyle.FixedSingle;
            numRow.Location = new Point(33, 7);
            numRow.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numRow.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numRow.Name = "numRow";
            numRow.Size = new Size(74, 23);
            numRow.TabIndex = 11;
            numRow.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 102);
            Controls.Add(numRow);
            Controls.Add(numCol);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtTime);
            Controls.Add(btCalc);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overflow calculator";
            ((System.ComponentModel.ISupportInitialize)numCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCalc;
        private TextBox txtTime;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numCol;
        private NumericUpDown numRow;
    }
}
