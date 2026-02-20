namespace ScannerEmulator
{
    partial class SetupUC
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
            label12 = new Label();
            label10 = new Label();
            cmbHand = new ComboBox();
            cmbStop = new ComboBox();
            cmbLength = new ComboBox();
            label8 = new Label();
            cmbParity = new ComboBox();
            label6 = new Label();
            cmbBaudrate = new ComboBox();
            label4 = new Label();
            cmbCom = new ComboBox();
            label2 = new Label();
            txtSend = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            richTextBox2 = new RichTextBox();
            textBoxCustomPrefix = new TextBox();
            comboBoxSuffix = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            comboBoxPrefix = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            textBoxCustomSuffix = new TextBox();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 205);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 3;
            label12.Text = "Handshake";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 176);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 4;
            label10.Text = "Stop bit";
            // 
            // cmbHand
            // 
            cmbHand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHand.FormattingEnabled = true;
            cmbHand.Location = new Point(88, 204);
            cmbHand.Name = "cmbHand";
            cmbHand.Size = new Size(121, 23);
            cmbHand.TabIndex = 11;
            // 
            // cmbStop
            // 
            cmbStop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStop.FormattingEnabled = true;
            cmbStop.Location = new Point(88, 176);
            cmbStop.Name = "cmbStop";
            cmbStop.Size = new Size(121, 23);
            cmbStop.TabIndex = 12;
            // 
            // cmbLength
            // 
            cmbLength.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLength.FormattingEnabled = true;
            cmbLength.Location = new Point(88, 144);
            cmbLength.Name = "cmbLength";
            cmbLength.Size = new Size(121, 23);
            cmbLength.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 147);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 5;
            label8.Text = "Data length";
            // 
            // cmbParity
            // 
            cmbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(88, 115);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(121, 23);
            cmbParity.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 118);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 6;
            label6.Text = "Parity";
            // 
            // cmbBaudrate
            // 
            cmbBaudrate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaudrate.FormattingEnabled = true;
            cmbBaudrate.Location = new Point(88, 86);
            cmbBaudrate.Name = "cmbBaudrate";
            cmbBaudrate.Size = new Size(121, 23);
            cmbBaudrate.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 89);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Baud rate";
            // 
            // cmbCom
            // 
            cmbCom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCom.FormattingEnabled = true;
            cmbCom.Location = new Point(88, 57);
            cmbCom.Name = "cmbCom";
            cmbCom.Size = new Size(121, 23);
            cmbCom.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "COM Port";
            // 
            // txtSend
            // 
            txtSend.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSend.Location = new Point(299, 20);
            txtSend.Multiline = true;
            txtSend.Name = "txtSend";
            txtSend.Size = new Size(305, 70);
            txtSend.TabIndex = 22;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(103, 44);
            button4.TabIndex = 23;
            button4.Text = "Open\r\nPort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(107, 3);
            button5.Name = "button5";
            button5.Size = new Size(103, 44);
            button5.TabIndex = 23;
            button5.Text = "Close\r\nPort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(610, 20);
            button6.Name = "button6";
            button6.Size = new Size(119, 44);
            button6.TabIndex = 24;
            button6.Text = "Send";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(216, 96);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox2.Size = new Size(513, 184);
            richTextBox2.TabIndex = 25;
            richTextBox2.Text = "";
            // 
            // textBoxCustomPrefix
            // 
            textBoxCustomPrefix.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomPrefix.Location = new Point(216, 20);
            textBoxCustomPrefix.Name = "textBoxCustomPrefix";
            textBoxCustomPrefix.Size = new Size(77, 27);
            textBoxCustomPrefix.TabIndex = 26;
            // 
            // comboBoxSuffix
            // 
            comboBoxSuffix.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuffix.FormattingEnabled = true;
            comboBoxSuffix.Location = new Point(89, 261);
            comboBoxSuffix.Name = "comboBoxSuffix";
            comboBoxSuffix.Size = new Size(121, 23);
            comboBoxSuffix.TabIndex = 11;
            comboBoxSuffix.SelectedIndexChanged += comboBoxSuffix_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 265);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Suffix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 235);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Prefix";
            // 
            // comboBoxPrefix
            // 
            comboBoxPrefix.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrefix.FormattingEnabled = true;
            comboBoxPrefix.Location = new Point(88, 232);
            comboBoxPrefix.Name = "comboBoxPrefix";
            comboBoxPrefix.Size = new Size(121, 23);
            comboBoxPrefix.TabIndex = 27;
            comboBoxPrefix.SelectedIndexChanged += comboBoxPrefix_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 2);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 28;
            label5.Text = "Prefix";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 3);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 28;
            label7.Text = "Send data";
            // 
            // textBoxCustomSuffix
            // 
            textBoxCustomSuffix.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomSuffix.Location = new Point(216, 64);
            textBoxCustomSuffix.Name = "textBoxCustomSuffix";
            textBoxCustomSuffix.Size = new Size(77, 27);
            textBoxCustomSuffix.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(216, 49);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 28;
            label9.Text = "Suffix";
            // 
            // button1
            // 
            button1.Location = new Point(609, 71);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 29;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SetupUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(comboBoxPrefix);
            Controls.Add(textBoxCustomSuffix);
            Controls.Add(textBoxCustomPrefix);
            Controls.Add(richTextBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(txtSend);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(comboBoxSuffix);
            Controls.Add(cmbHand);
            Controls.Add(cmbStop);
            Controls.Add(cmbLength);
            Controls.Add(label8);
            Controls.Add(cmbParity);
            Controls.Add(label6);
            Controls.Add(cmbBaudrate);
            Controls.Add(label4);
            Controls.Add(cmbCom);
            Controls.Add(label2);
            Name = "SetupUC";
            Size = new Size(740, 288);
            Load += SetupUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Label label10;
        private ComboBox cmbHand;
        private ComboBox cmbStop;
        private ComboBox cmbLength;
        private Label label8;
        private ComboBox cmbParity;
        private Label label6;
        private ComboBox cmbBaudrate;
        private Label label4;
        private ComboBox cmbCom;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private TextBox txtSend;
        private Button button4;
        private Button button5;
        private Button button6;
        private RichTextBox richTextBox2;
        private TextBox textBoxCustomPrefix;
        private ComboBox comboBoxSuffix;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxPrefix;
        private Label label5;
        private Label label7;
        private TextBox textBoxCustomSuffix;
        private Label label9;
    }
}
