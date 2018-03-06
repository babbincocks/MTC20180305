namespace ZBabcock_Calculator
{
    partial class frmCalc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDivide);
            this.groupBox1.Controls.Add(this.rbMultiply);
            this.groupBox1.Controls.Add(this.rbSubtract);
            this.groupBox1.Controls.Add(this.rbAdd);
            this.groupBox1.Location = new System.Drawing.Point(205, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifiers";
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(19, 88);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(55, 17);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(19, 65);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(19, 42);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(65, 17);
            this.rbSubtract.TabIndex = 1;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "Subtract";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(19, 19);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(77, 208);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(12, 56);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(140, 20);
            this.txtFirstValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Second Value";
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(12, 113);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(140, 20);
            this.txtSecondValue.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 170);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(140, 20);
            this.txtResult.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // frmCalc
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 273);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecondValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstValue);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCalc";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}

