namespace AcmeScrubber
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
            this.processButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rawDataButton = new System.Windows.Forms.Button();
            this.rawDataBox = new System.Windows.Forms.TextBox();
            this.codeListBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(15, 97);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(181, 75);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load from file";
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(112, 19);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(84, 23);
            this.pathButton.TabIndex = 2;
            this.pathButton.Text = "Use file";
            this.pathButton.UseVisualStyleBackColor = true;
            // 
            // pathBox
            // 
            this.pathBox.Enabled = false;
            this.pathBox.Location = new System.Drawing.Point(202, 19);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(558, 22);
            this.pathBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raw data";
            // 
            // rawDataButton
            // 
            this.rawDataButton.Location = new System.Drawing.Point(112, 57);
            this.rawDataButton.Name = "rawDataButton";
            this.rawDataButton.Size = new System.Drawing.Size(84, 23);
            this.rawDataButton.TabIndex = 5;
            this.rawDataButton.Text = "Input Data";
            this.rawDataButton.UseVisualStyleBackColor = true;
            // 
            // rawDataBox
            // 
            this.rawDataBox.Enabled = false;
            this.rawDataBox.Location = new System.Drawing.Point(202, 57);
            this.rawDataBox.Multiline = true;
            this.rawDataBox.Name = "rawDataBox";
            this.rawDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawDataBox.Size = new System.Drawing.Size(558, 115);
            this.rawDataBox.TabIndex = 6;
            // 
            // codeListBox
            // 
            this.codeListBox.Location = new System.Drawing.Point(202, 193);
            this.codeListBox.Multiline = true;
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.ReadOnly = true;
            this.codeListBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeListBox.Size = new System.Drawing.Size(168, 245);
            this.codeListBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codes extracted";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeListBox);
            this.Controls.Add(this.rawDataBox);
            this.Controls.Add(this.rawDataButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rawDataButton;
        private System.Windows.Forms.TextBox rawDataBox;
        private System.Windows.Forms.TextBox codeListBox;
        private System.Windows.Forms.Label label3;
    }
}