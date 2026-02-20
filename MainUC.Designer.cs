namespace ScannerEmulator
{
    partial class MainUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBarcode = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(17, 55);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(242, 23);
            txtBarcode.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(107, 103);
            button3.Name = "button3";
            button3.Size = new Size(98, 44);
            button3.TabIndex = 5;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(txtBarcode);
            Name = "MainUC";
            Size = new Size(312, 250);
            Load += MainUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBarcode;
        private Button button3;
    }
}
