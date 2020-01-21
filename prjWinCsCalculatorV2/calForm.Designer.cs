namespace prjWinCsCalculatorV2
{
    partial class calForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnMult = new System.Windows.Forms.RadioButton();
            this.radioBtnDiv = new System.Windows.Forms.RadioButton();
            this.radioBtnSubs = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.lblResoult = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioBtnMult);
            this.panel1.Controls.Add(this.radioBtnDiv);
            this.panel1.Controls.Add(this.radioBtnSubs);
            this.panel1.Controls.Add(this.radioBtnAdd);
            this.panel1.Location = new System.Drawing.Point(16, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 168);
            this.panel1.TabIndex = 0;
            // 
            // radioBtnMult
            // 
            this.radioBtnMult.AutoSize = true;
            this.radioBtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMult.Location = new System.Drawing.Point(242, 111);
            this.radioBtnMult.Name = "radioBtnMult";
            this.radioBtnMult.Size = new System.Drawing.Size(179, 33);
            this.radioBtnMult.TabIndex = 3;
            this.radioBtnMult.TabStop = true;
            this.radioBtnMult.Text = "Multiplication";
            this.radioBtnMult.UseVisualStyleBackColor = true;
            // 
            // radioBtnDiv
            // 
            this.radioBtnDiv.AutoSize = true;
            this.radioBtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnDiv.Location = new System.Drawing.Point(50, 111);
            this.radioBtnDiv.Name = "radioBtnDiv";
            this.radioBtnDiv.Size = new System.Drawing.Size(123, 33);
            this.radioBtnDiv.TabIndex = 2;
            this.radioBtnDiv.TabStop = true;
            this.radioBtnDiv.Text = "Division";
            this.radioBtnDiv.UseVisualStyleBackColor = true;
            // 
            // radioBtnSubs
            // 
            this.radioBtnSubs.AutoSize = true;
            this.radioBtnSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSubs.Location = new System.Drawing.Point(242, 53);
            this.radioBtnSubs.Name = "radioBtnSubs";
            this.radioBtnSubs.Size = new System.Drawing.Size(171, 33);
            this.radioBtnSubs.TabIndex = 1;
            this.radioBtnSubs.TabStop = true;
            this.radioBtnSubs.Text = "Substraction";
            this.radioBtnSubs.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAdd.Location = new System.Drawing.Point(50, 53);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(126, 33);
            this.radioBtnAdd.TabIndex = 0;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Addition";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // lblResoult
            // 
            this.lblResoult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResoult.Location = new System.Drawing.Point(16, 296);
            this.lblResoult.Name = "lblResoult";
            this.lblResoult.Size = new System.Drawing.Size(462, 72);
            this.lblResoult.TabIndex = 1;
            this.lblResoult.Text = "your answer";
            this.lblResoult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVal1
            // 
            this.txtVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal1.Location = new System.Drawing.Point(16, 52);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(182, 35);
            this.txtVal1.TabIndex = 2;
            // 
            // txtVal2
            // 
            this.txtVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal2.Location = new System.Drawing.Point(300, 52);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(178, 35);
            this.txtVal2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(296, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblResoult);
            this.panel2.Controls.Add(this.txtVal2);
            this.panel2.Controls.Add(this.txtVal1);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 459);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 54);
            this.label4.TabIndex = 7;
            this.label4.Text = "CALCULATOR 2.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "BASIC OPPERATIONS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calForm";
            this.Text = "CAL 2.0";
            this.Load += new System.EventHandler(this.calForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnMult;
        private System.Windows.Forms.RadioButton radioBtnDiv;
        private System.Windows.Forms.RadioButton radioBtnSubs;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.Label lblResoult;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

