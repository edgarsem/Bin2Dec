namespace Bin2Dec
{
    partial class GUI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.warningLabelTooLong = new System.Windows.Forms.Label();
            this.warningLabelWrongFormat = new System.Windows.Forms.Label();
            this.warningLabelWrongLengthAndFormat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter binary number(only up to 8 digits)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(63, 153);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(176, 153);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // warningLabelTooLong
            // 
            this.warningLabelTooLong.AutoSize = true;
            this.warningLabelTooLong.Location = new System.Drawing.Point(63, 125);
            this.warningLabelTooLong.Name = "warningLabelTooLong";
            this.warningLabelTooLong.Size = new System.Drawing.Size(166, 16);
            this.warningLabelTooLong.TabIndex = 5;
            this.warningLabelTooLong.Text = "Binary number is too long!!!";
            // 
            // warningLabelWrongFormat
            // 
            this.warningLabelWrongFormat.AutoSize = true;
            this.warningLabelWrongFormat.Location = new System.Drawing.Point(60, 125);
            this.warningLabelWrongFormat.Name = "warningLabelWrongFormat";
            this.warningLabelWrongFormat.Size = new System.Drawing.Size(225, 16);
            this.warningLabelWrongFormat.TabIndex = 6;
            this.warningLabelWrongFormat.Text = "There are symbols other than 0 or 1!!!";
            this.warningLabelWrongFormat.Click += new System.EventHandler(this.label3_Click);
            // 
            // warningLabelWrongLengthAndFormat
            // 
            this.warningLabelWrongLengthAndFormat.AutoSize = true;
            this.warningLabelWrongLengthAndFormat.Location = new System.Drawing.Point(60, 125);
            this.warningLabelWrongLengthAndFormat.Name = "warningLabelWrongLengthAndFormat";
            this.warningLabelWrongLengthAndFormat.Size = new System.Drawing.Size(198, 16);
            this.warningLabelWrongLengthAndFormat.TabIndex = 7;
            this.warningLabelWrongLengthAndFormat.Text = "Text too long and wrong format!!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(63, 232);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(7, 16);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "\r\n";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 357);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.warningLabelWrongLengthAndFormat);
            this.Controls.Add(this.warningLabelWrongFormat);
            this.Controls.Add(this.warningLabelTooLong);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label warningLabelTooLong;
        private System.Windows.Forms.Label warningLabelWrongFormat;
        private System.Windows.Forms.Label warningLabelWrongLengthAndFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
    }
}

