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
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn07 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPow2 = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnPow3 = new System.Windows.Forms.Button();
            this.btnPlus_Minus = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnM_Plus = new System.Windows.Forms.Button();
            this.btnM_Minus = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSqrt.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(283, 160);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(64, 43);
            this.btnSqrt.TabIndex = 41;
            this.btnSqrt.TabStop = false;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResult.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(213, 356);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(134, 43);
            this.btnResult.TabIndex = 39;
            this.btnResult.TabStop = false;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(73, 356);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 43);
            this.btn0.TabIndex = 38;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoint.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(3, 356);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(64, 43);
            this.btnPoint.TabIndex = 37;
            this.btnPoint.TabStop = false;
            this.btnPoint.Text = ",";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMin.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(213, 307);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(64, 43);
            this.btnMin.TabIndex = 36;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btn03
            // 
            this.btn03.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn03.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn03.Location = new System.Drawing.Point(143, 307);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(64, 43);
            this.btn03.TabIndex = 35;
            this.btn03.TabStop = false;
            this.btn03.Text = "3";
            this.btn03.UseVisualStyleBackColor = false;
            this.btn03.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn02
            // 
            this.btn02.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn02.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(73, 307);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(64, 43);
            this.btn02.TabIndex = 34;
            this.btn02.TabStop = false;
            this.btn02.Text = "2";
            this.btn02.UseVisualStyleBackColor = false;
            this.btn02.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn01
            // 
            this.btn01.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn01.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(3, 307);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(64, 43);
            this.btn01.TabIndex = 33;
            this.btn01.TabStop = false;
            this.btn01.Text = "1";
            this.btn01.UseVisualStyleBackColor = false;
            this.btn01.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(213, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 43);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btn06
            // 
            this.btn06.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn06.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn06.Location = new System.Drawing.Point(143, 258);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(64, 43);
            this.btn06.TabIndex = 31;
            this.btn06.TabStop = false;
            this.btn06.Text = "6";
            this.btn06.UseVisualStyleBackColor = false;
            this.btn06.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn05
            // 
            this.btn05.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn05.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn05.Location = new System.Drawing.Point(73, 258);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(64, 43);
            this.btn05.TabIndex = 30;
            this.btn05.TabStop = false;
            this.btn05.Text = "5";
            this.btn05.UseVisualStyleBackColor = false;
            this.btn05.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn04
            // 
            this.btn04.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn04.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn04.Location = new System.Drawing.Point(3, 258);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(64, 43);
            this.btn04.TabIndex = 29;
            this.btn04.TabStop = false;
            this.btn04.Text = "4";
            this.btn04.UseVisualStyleBackColor = false;
            this.btn04.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMulti.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(213, 209);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(64, 43);
            this.btnMulti.TabIndex = 28;
            this.btnMulti.TabStop = false;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btn09
            // 
            this.btn09.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn09.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn09.Location = new System.Drawing.Point(143, 209);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(64, 43);
            this.btn09.TabIndex = 27;
            this.btn09.TabStop = false;
            this.btn09.Text = "9";
            this.btn09.UseVisualStyleBackColor = false;
            this.btn09.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn08
            // 
            this.btn08.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn08.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn08.Location = new System.Drawing.Point(73, 209);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(64, 43);
            this.btn08.TabIndex = 26;
            this.btn08.TabStop = false;
            this.btn08.Text = "8";
            this.btn08.UseVisualStyleBackColor = false;
            this.btn08.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn07
            // 
            this.btn07.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn07.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn07.Location = new System.Drawing.Point(3, 209);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(64, 43);
            this.btn07.TabIndex = 25;
            this.btn07.TabStop = false;
            this.btn07.Text = "7";
            this.btn07.UseVisualStyleBackColor = false;
            this.btn07.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiv.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(213, 160);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(64, 43);
            this.btnDiv.TabIndex = 24;
            this.btnDiv.TabStop = false;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCE.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(73, 160);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(64, 43);
            this.btnCE.TabIndex = 23;
            this.btnCE.TabStop = false;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnC.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(3, 160);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(64, 43);
            this.btnC.TabIndex = 22;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPow2
            // 
            this.btnPow2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPow2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow2.Location = new System.Drawing.Point(283, 209);
            this.btnPow2.Name = "btnPow2";
            this.btnPow2.Size = new System.Drawing.Size(64, 43);
            this.btnPow2.TabIndex = 46;
            this.btnPow2.TabStop = false;
            this.btnPow2.Text = "x²";
            this.btnPow2.UseVisualStyleBackColor = false;
            this.btnPow2.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReciprocal.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.Location = new System.Drawing.Point(283, 307);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(64, 43);
            this.btnReciprocal.TabIndex = 47;
            this.btnReciprocal.TabStop = false;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = false;
            this.btnReciprocal.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btnPow3
            // 
            this.btnPow3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPow3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow3.Location = new System.Drawing.Point(283, 258);
            this.btnPow3.Name = "btnPow3";
            this.btnPow3.Size = new System.Drawing.Size(64, 43);
            this.btnPow3.TabIndex = 48;
            this.btnPow3.TabStop = false;
            this.btnPow3.Text = "x³";
            this.btnPow3.UseVisualStyleBackColor = false;
            this.btnPow3.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btnPlus_Minus
            // 
            this.btnPlus_Minus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlus_Minus.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus_Minus.Location = new System.Drawing.Point(143, 356);
            this.btnPlus_Minus.Name = "btnPlus_Minus";
            this.btnPlus_Minus.Size = new System.Drawing.Size(64, 43);
            this.btnPlus_Minus.TabIndex = 51;
            this.btnPlus_Minus.TabStop = false;
            this.btnPlus_Minus.Text = "±";
            this.btnPlus_Minus.UseVisualStyleBackColor = false;
            this.btnPlus_Minus.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPercent.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Location = new System.Drawing.Point(143, 160);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(64, 43);
            this.btnPercent.TabIndex = 52;
            this.btnPercent.TabStop = false;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(3, 2);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(344, 106);
            this.lblResult.TabIndex = 40;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMC.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(3, 111);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(54, 43);
            this.btnMC.TabIndex = 42;
            this.btnMC.TabStop = false;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMR.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(61, 111);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(54, 43);
            this.btnMR.TabIndex = 43;
            this.btnMR.TabStop = false;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMS.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(235, 111);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(54, 43);
            this.btnMS.TabIndex = 44;
            this.btnMS.TabStop = false;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnM_Plus
            // 
            this.btnM_Plus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnM_Plus.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_Plus.Location = new System.Drawing.Point(119, 111);
            this.btnM_Plus.Name = "btnM_Plus";
            this.btnM_Plus.Size = new System.Drawing.Size(54, 43);
            this.btnM_Plus.TabIndex = 45;
            this.btnM_Plus.TabStop = false;
            this.btnM_Plus.Text = "M+";
            this.btnM_Plus.UseVisualStyleBackColor = false;
            this.btnM_Plus.Click += new System.EventHandler(this.btnM_Plus_Click);
            // 
            // btnM_Minus
            // 
            this.btnM_Minus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnM_Minus.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_Minus.Location = new System.Drawing.Point(177, 111);
            this.btnM_Minus.Name = "btnM_Minus";
            this.btnM_Minus.Size = new System.Drawing.Size(54, 43);
            this.btnM_Minus.TabIndex = 49;
            this.btnM_Minus.TabStop = false;
            this.btnM_Minus.Text = "M-";
            this.btnM_Minus.UseVisualStyleBackColor = false;
            this.btnM_Minus.Click += new System.EventHandler(this.btnM_Minus_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnM.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(293, 111);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(54, 43);
            this.btnM.TabIndex = 50;
            this.btnM.TabStop = false;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 405);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnPlus_Minus);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnM_Minus);
            this.Controls.Add(this.btnPow3);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnPow2);
            this.Controls.Add(this.btnM_Plus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn09);
            this.Controls.Add(this.btn08);
            this.Controls.Add(this.btn07);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPow2;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnPow3;
        private System.Windows.Forms.Button btnPlus_Minus;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnM_Plus;
        private System.Windows.Forms.Button btnM_Minus;
        private System.Windows.Forms.Button btnM;
    }
}

