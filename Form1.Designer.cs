namespace exceltorixml
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
            this.input_source_file = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.processExcelButton = new System.Windows.Forms.Button();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_source_file
            // 
            this.input_source_file.Location = new System.Drawing.Point(49, 37);
            this.input_source_file.Name = "input_source_file";
            this.input_source_file.Size = new System.Drawing.Size(366, 20);
            this.input_source_file.TabIndex = 0;
            this.input_source_file.Tag = "Label";
            this.input_source_file.TextChanged += new System.EventHandler(this.input_source_file_TextChanged);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(436, 33);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // processExcelButton
            // 
            this.processExcelButton.Location = new System.Drawing.Point(49, 81);
            this.processExcelButton.Name = "processExcelButton";
            this.processExcelButton.Size = new System.Drawing.Size(99, 23);
            this.processExcelButton.TabIndex = 2;
            this.processExcelButton.Text = "Create RiXML";
            this.processExcelButton.UseVisualStyleBackColor = true;
            this.processExcelButton.Click += new System.EventHandler(this.processExcelButton_Click);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(436, 81);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(75, 23);
            this.closeFormButton.TabIndex = 3;
            this.closeFormButton.Text = "Close";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 219);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.processExcelButton);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.input_source_file);
            this.Name = "Form1";
            this.Text = "Convert Excel to RiXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_source_file;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button processExcelButton;
        private System.Windows.Forms.Button closeFormButton;
    }
}

