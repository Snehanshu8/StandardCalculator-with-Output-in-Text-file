namespace StandardCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPClr = new System.Windows.Forms.Button();
            this.btnAclr = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 91);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(63, 91);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(114, 91);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(165, 91);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 45);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnPClr
            // 
            this.btnPClr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClr.Location = new System.Drawing.Point(216, 91);
            this.btnPClr.Name = "btnPClr";
            this.btnPClr.Size = new System.Drawing.Size(45, 45);
            this.btnPClr.TabIndex = 4;
            this.btnPClr.Text = "CE";
            this.btnPClr.UseVisualStyleBackColor = true;
            this.btnPClr.Click += new System.EventHandler(this.ClearOperator);
            // 
            // btnAclr
            // 
            this.btnAclr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAclr.Location = new System.Drawing.Point(216, 152);
            this.btnAclr.Name = "btnAclr";
            this.btnAclr.Size = new System.Drawing.Size(45, 45);
            this.btnAclr.TabIndex = 9;
            this.btnAclr.Text = "C";
            this.btnAclr.UseVisualStyleBackColor = true;
            this.btnAclr.Click += new System.EventHandler(this.ClearAll);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(165, 152);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(45, 45);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(114, 152);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(63, 152);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 152);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(165, 216);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(45, 45);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(114, 216);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(63, 216);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 216);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(216, 216);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(45, 107);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(165, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalPoint.Location = new System.Drawing.Point(114, 278);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(45, 45);
            this.btnDecimalPoint.TabIndex = 17;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 278);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 45);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 44);
            this.textBox1.TabIndex = 20;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnAclr);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPClr);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPClr;
        private System.Windows.Forms.Button btnAclr;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox textBox1;
    }
}

