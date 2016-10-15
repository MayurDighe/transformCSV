namespace transformCSV
{
    partial class frmCSVtoDT
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
            this.btnSelectCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radSemiCol = new System.Windows.Forms.RadioButton();
            this.radTab = new System.Windows.Forms.RadioButton();
            this.radColon = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.radPipe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSelectCSV
            // 
            this.btnSelectCSV.Location = new System.Drawing.Point(372, 32);
            this.btnSelectCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectCSV.Name = "btnSelectCSV";
            this.btnSelectCSV.Size = new System.Drawing.Size(112, 26);
            this.btnSelectCSV.TabIndex = 0;
            this.btnSelectCSV.Text = "Select CSV";
            this.btnSelectCSV.UseVisualStyleBackColor = true;
            this.btnSelectCSV.Click += new System.EventHandler(this.btnSelectCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input :";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtInput.Location = new System.Drawing.Point(89, 33);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(277, 26);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(89, 74);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(277, 26);
            this.txtOutput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output :";
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(372, 73);
            this.btnOutputPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(112, 26);
            this.btnOutputPath.TabIndex = 5;
            this.btnOutputPath.Text = "Output Path";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Options :";
            // 
            // radSemiCol
            // 
            this.radSemiCol.AutoSize = true;
            this.radSemiCol.Location = new System.Drawing.Point(126, 155);
            this.radSemiCol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radSemiCol.Name = "radSemiCol";
            this.radSemiCol.Size = new System.Drawing.Size(142, 22);
            this.radSemiCol.TabIndex = 12;
            this.radSemiCol.Text = "Semi-Colon [;]";
            this.radSemiCol.UseVisualStyleBackColor = true;
            this.radSemiCol.CheckedChanged += new System.EventHandler(this.changeExtension_CheckedChanged);
            // 
            // radTab
            // 
            this.radTab.AutoSize = true;
            this.radTab.Checked = true;
            this.radTab.Location = new System.Drawing.Point(400, 155);
            this.radTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radTab.Name = "radTab";
            this.radTab.Size = new System.Drawing.Size(86, 22);
            this.radTab.TabIndex = 13;
            this.radTab.TabStop = true;
            this.radTab.Text = "Tab [\\t]";
            this.radTab.UseVisualStyleBackColor = true;
            this.radTab.CheckedChanged += new System.EventHandler(this.changeExtension_CheckedChanged);
            // 
            // radColon
            // 
            this.radColon.AutoSize = true;
            this.radColon.Location = new System.Drawing.Point(285, 155);
            this.radColon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radColon.Name = "radColon";
            this.radColon.Size = new System.Drawing.Size(98, 22);
            this.radColon.TabIndex = 14;
            this.radColon.Text = "Colon [:]";
            this.radColon.UseVisualStyleBackColor = true;
            this.radColon.CheckedChanged += new System.EventHandler(this.changeExtension_CheckedChanged);
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(285, 183);
            this.radOther.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(141, 22);
            this.radOther.TabIndex = 15;
            this.radOther.Text = "Other Delimiter";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.changeExtension_CheckedChanged);
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(424, 182);
            this.txtDelimiter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDelimiter.MaxLength = 1;
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(49, 26);
            this.txtDelimiter.TabIndex = 16;
            this.txtDelimiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelimiter.TextChanged += new System.EventHandler(this.txtDelimiter_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConvert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnConvert.Location = new System.Drawing.Point(492, 32);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(113, 67);
            this.btnConvert.TabIndex = 17;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // radPipe
            // 
            this.radPipe.AutoSize = true;
            this.radPipe.Location = new System.Drawing.Point(126, 183);
            this.radPipe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radPipe.Name = "radPipe";
            this.radPipe.Size = new System.Drawing.Size(85, 22);
            this.radPipe.TabIndex = 18;
            this.radPipe.Text = "Pipe [|]";
            this.radPipe.UseVisualStyleBackColor = true;
            this.radPipe.CheckedChanged += new System.EventHandler(this.changeExtension_CheckedChanged);
            // 
            // frmCSVtoDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 229);
            this.Controls.Add(this.radPipe);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtDelimiter);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.radColon);
            this.Controls.Add(this.radTab);
            this.Controls.Add(this.radSemiCol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectCSV);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCSVtoDT";
            this.Text = "CSV to Delimited Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radSemiCol;
        private System.Windows.Forms.RadioButton radTab;
        private System.Windows.Forms.RadioButton radColon;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton radPipe;
    }
}

