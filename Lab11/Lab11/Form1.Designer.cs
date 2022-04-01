namespace Lab11
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
            this.startValue = new System.Windows.Forms.TextBox();
            this.endValue = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.RichTextBox();
            this.graphButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startValue
            // 
            this.startValue.Location = new System.Drawing.Point(504, 44);
            this.startValue.Name = "startValue";
            this.startValue.Size = new System.Drawing.Size(38, 20);
            this.startValue.TabIndex = 0;
            this.startValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startValue_KeyDown);
            // 
            // endValue
            // 
            this.endValue.Location = new System.Drawing.Point(612, 44);
            this.endValue.Name = "endValue";
            this.endValue.Size = new System.Drawing.Size(39, 20);
            this.endValue.TabIndex = 1;
            this.endValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startValue_KeyDown);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(466, 47);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(32, 13);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Start:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(577, 47);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "End:";
            // 
            // headerText
            // 
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.headerText.Location = new System.Drawing.Point(364, 12);
            this.headerText.Name = "headerText";
            this.headerText.ReadOnly = true;
            this.headerText.Size = new System.Drawing.Size(477, 26);
            this.headerText.TabIndex = 4;
            this.headerText.Text = "Enter the Start and End value to plot the SINE function";
            
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(690, 42);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(75, 23);
            this.graphButton.TabIndex = 5;
            this.graphButton.Text = "Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 843);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endValue);
            this.Controls.Add(this.startValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startValue;
        private System.Windows.Forms.TextBox endValue;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.RichTextBox headerText;
        private System.Windows.Forms.Button graphButton;
    }
}
