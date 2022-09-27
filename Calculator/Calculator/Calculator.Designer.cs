namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.calc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrRoot = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnEquall = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.darkMode = new System.Windows.Forms.CheckBox();
            this.scientific = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aboutme = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSine = new System.Windows.Forms.Button();
            this.btnCosine = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnXPower = new System.Windows.Forms.Button();
            this.calc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Controls.Add(this.tabPage1);
            this.calc.Controls.Add(this.tabPage2);
            this.calc.Location = new System.Drawing.Point(-2, -1);
            this.calc.Name = "calc";
            this.calc.SelectedIndex = 0;
            this.calc.Size = new System.Drawing.Size(413, 365);
            this.calc.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSqrRoot);
            this.tabPage1.Controls.Add(this.btnX);
            this.tabPage1.Controls.Add(this.btnPlusMinus);
            this.tabPage1.Controls.Add(this.btnDot);
            this.tabPage1.Controls.Add(this.btn0);
            this.tabPage1.Controls.Add(this.btnDivide);
            this.tabPage1.Controls.Add(this.btnMultiply);
            this.tabPage1.Controls.Add(this.btn3);
            this.tabPage1.Controls.Add(this.btn2);
            this.tabPage1.Controls.Add(this.btnEquall);
            this.tabPage1.Controls.Add(this.btnLog);
            this.tabPage1.Controls.Add(this.btnCosine);
            this.tabPage1.Controls.Add(this.btnXPower);
            this.tabPage1.Controls.Add(this.btnSine);
            this.tabPage1.Controls.Add(this.btnSubtract);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btn6);
            this.tabPage1.Controls.Add(this.btn5);
            this.tabPage1.Controls.Add(this.btn9);
            this.tabPage1.Controls.Add(this.btn4);
            this.tabPage1.Controls.Add(this.btn8);
            this.tabPage1.Controls.Add(this.btn7);
            this.tabPage1.Controls.Add(this.darkMode);
            this.tabPage1.Controls.Add(this.scientific);
            this.tabPage1.Controls.Add(this.standard);
            this.tabPage1.Controls.Add(this.output);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(202, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSqrRoot
            // 
            this.btnSqrRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrRoot.Location = new System.Drawing.Point(254, 287);
            this.btnSqrRoot.Name = "btnSqrRoot";
            this.btnSqrRoot.Size = new System.Drawing.Size(46, 43);
            this.btnSqrRoot.TabIndex = 4;
            this.btnSqrRoot.Text = "√";
            this.btnSqrRoot.UseVisualStyleBackColor = true;
            this.btnSqrRoot.Click += new System.EventHandler(this.btnSqrRoot_Click);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(202, 287);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(46, 43);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "1/X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(127, 287);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(46, 43);
            this.btnPlusMinus.TabIndex = 4;
            this.btnPlusMinus.Text = "-/+";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(75, 287);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(46, 43);
            this.btnDot.TabIndex = 4;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(23, 287);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(46, 43);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(254, 238);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(46, 43);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(202, 238);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(46, 43);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(127, 238);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 43);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, 238);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 43);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnEquall
            // 
            this.btnEquall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquall.Location = new System.Drawing.Point(306, 189);
            this.btnEquall.Name = "btnEquall";
            this.btnEquall.Size = new System.Drawing.Size(46, 141);
            this.btnEquall.TabIndex = 4;
            this.btnEquall.Text = "=";
            this.btnEquall.UseVisualStyleBackColor = true;
            this.btnEquall.Click += new System.EventHandler(this.btnEquall_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(254, 189);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(46, 43);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(23, 238);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 43);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(202, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(127, 189);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 43);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 189);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 43);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(127, 140);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 43);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(23, 189);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 43);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(75, 140);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 43);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Location = new System.Drawing.Point(23, 140);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 43);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // darkMode
            // 
            this.darkMode.AutoSize = true;
            this.darkMode.Location = new System.Drawing.Point(273, 88);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(79, 17);
            this.darkMode.TabIndex = 3;
            this.darkMode.Text = "&Dark Mode";
            this.darkMode.UseVisualStyleBackColor = true;
            this.darkMode.CheckedChanged += new System.EventHandler(this.darkMode_CheckedChanged);
            // 
            // scientific
            // 
            this.scientific.AutoSize = true;
            this.scientific.Location = new System.Drawing.Point(151, 88);
            this.scientific.Name = "scientific";
            this.scientific.Size = new System.Drawing.Size(68, 17);
            this.scientific.TabIndex = 2;
            this.scientific.TabStop = true;
            this.scientific.Text = "Scie&ntific";
            this.scientific.UseVisualStyleBackColor = true;
            this.scientific.CheckedChanged += new System.EventHandler(this.scientific_CheckedChanged);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Location = new System.Drawing.Point(23, 89);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(68, 17);
            this.standard.TabIndex = 1;
            this.standard.TabStop = true;
            this.standard.Text = "&Standard";
            this.standard.UseVisualStyleBackColor = true;
            this.standard.CheckedChanged += new System.EventHandler(this.standard_CheckedChanged);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(11, 7);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(386, 63);
            this.output.TabIndex = 0;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aboutme);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About me";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aboutme
            // 
            this.aboutme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutme.Location = new System.Drawing.Point(7, 263);
            this.aboutme.Multiline = true;
            this.aboutme.Name = "aboutme";
            this.aboutme.Size = new System.Drawing.Size(354, 52);
            this.aboutme.TabIndex = 2;
            this.aboutme.Text = "Hi, my names is Rupinder and \r\nmy student ID is 301242011.";
            this.aboutme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSine
            // 
            this.btnSine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSine.Location = new System.Drawing.Point(356, 189);
            this.btnSine.Name = "btnSine";
            this.btnSine.Size = new System.Drawing.Size(46, 43);
            this.btnSine.TabIndex = 4;
            this.btnSine.Text = "Sin";
            this.btnSine.UseVisualStyleBackColor = true;
            this.btnSine.Click += new System.EventHandler(this.btnSine_Click);
            // 
            // btnCosine
            // 
            this.btnCosine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosine.Location = new System.Drawing.Point(356, 235);
            this.btnCosine.Name = "btnCosine";
            this.btnCosine.Size = new System.Drawing.Size(46, 43);
            this.btnCosine.TabIndex = 4;
            this.btnCosine.Text = "Cos";
            this.btnCosine.UseVisualStyleBackColor = true;
            this.btnCosine.Click += new System.EventHandler(this.btnCosine_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(356, 284);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(46, 43);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Log(n)";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnXPower
            // 
            this.btnXPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPower.Location = new System.Drawing.Point(356, 140);
            this.btnXPower.Name = "btnXPower";
            this.btnXPower.Size = new System.Drawing.Size(46, 43);
            this.btnXPower.TabIndex = 4;
            this.btnXPower.Text = "X^2";
            this.btnXPower.UseVisualStyleBackColor = true;
            this.btnXPower.Click += new System.EventHandler(this.btnXPower_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(409, 361);
            this.Controls.Add(this.calc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.calc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl calc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.CheckBox darkMode;
        private System.Windows.Forms.RadioButton scientific;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSqrRoot;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnEquall;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.TextBox aboutme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCosine;
        private System.Windows.Forms.Button btnXPower;
        private System.Windows.Forms.Button btnSine;
    }
}

