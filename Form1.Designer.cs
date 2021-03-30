namespace Calculator
{
    partial class Form1
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblMemory = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMemClear = new System.Windows.Forms.Button();
            this.btnMemReverse = new System.Windows.Forms.Button();
            this.btnMemSave = new System.Windows.Forms.Button();
            this.btnMemAdd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(16, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(337, 31);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutput.TextChanged += new System.EventHandler(this.Form1_Load);
            this.txtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOutput_KeyPress);
            // 
            // lblMemory
            // 
            this.lblMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMemory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.Location = new System.Drawing.Point(12, 57);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(55, 36);
            this.lblMemory.TabIndex = 1;
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(88, 57);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(203, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnMemClear
            // 
            this.btnMemClear.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemClear.Location = new System.Drawing.Point(15, 110);
            this.btnMemClear.Name = "btnMemClear";
            this.btnMemClear.Size = new System.Drawing.Size(52, 41);
            this.btnMemClear.TabIndex = 4;
            this.btnMemClear.Text = "MC";
            this.btnMemClear.UseVisualStyleBackColor = true;
            this.btnMemClear.Click += new System.EventHandler(this.BtnMemClear_Click);
            // 
            // btnMemReverse
            // 
            this.btnMemReverse.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemReverse.Location = new System.Drawing.Point(16, 157);
            this.btnMemReverse.Name = "btnMemReverse";
            this.btnMemReverse.Size = new System.Drawing.Size(52, 35);
            this.btnMemReverse.TabIndex = 5;
            this.btnMemReverse.Text = "MR";
            this.btnMemReverse.UseVisualStyleBackColor = true;
            this.btnMemReverse.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnMemSave
            // 
            this.btnMemSave.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemSave.Location = new System.Drawing.Point(16, 198);
            this.btnMemSave.Name = "btnMemSave";
            this.btnMemSave.Size = new System.Drawing.Size(54, 38);
            this.btnMemSave.TabIndex = 6;
            this.btnMemSave.Text = "MS";
            this.btnMemSave.UseVisualStyleBackColor = true;
            this.btnMemSave.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemAdd.Location = new System.Drawing.Point(15, 242);
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.Size = new System.Drawing.Size(55, 40);
            this.btnMemAdd.TabIndex = 7;
            this.btnMemAdd.Text = "M+";
            this.btnMemAdd.UseVisualStyleBackColor = true;
            this.btnMemAdd.Click += new System.EventHandler(this.BtnMemAdd_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(199, 108);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 41);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(198, 198);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 36);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(149, 109);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 41);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(88, 158);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 35);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(88, 198);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 38);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn1_KeyPress);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(199, 160);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 34);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button12_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(311, 110);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(47, 39);
            this.btnSqrt.TabIndex = 14;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(146, 197);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 38);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(90, 108);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 41);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Button15_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(254, 198);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(47, 37);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(255, 158);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(49, 34);
            this.btnMultiplication.TabIndex = 18;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.BtnMultiplication_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(148, 160);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 33);
            this.btn5.TabIndex = 19;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(253, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 39);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(88, 242);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 38);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn0_KeyDown);
            this.btn0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn0_KeyPress);
            // 
            // btnInvert
            // 
            this.btnInvert.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.Location = new System.Drawing.Point(145, 242);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(48, 38);
            this.btnInvert.TabIndex = 22;
            this.btnInvert.Text = "+/-";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.BtnInvert_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(203, 245);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(44, 35);
            this.btnDecimal.TabIndex = 23;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(308, 198);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(50, 82);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.Location = new System.Drawing.Point(310, 157);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(48, 35);
            this.btnReciprocal.TabIndex = 25;
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.Button24_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(254, 110);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 39);
            this.btnDivide.TabIndex = 26;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 293);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMemAdd);
            this.Controls.Add(this.btnMemSave);
            this.Controls.Add(this.btnMemReverse);
            this.Controls.Add(this.btnMemClear);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMemClear;
        private System.Windows.Forms.Button btnMemReverse;
        private System.Windows.Forms.Button btnMemSave;
        private System.Windows.Forms.Button btnMemAdd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnDivide;
    }
}

