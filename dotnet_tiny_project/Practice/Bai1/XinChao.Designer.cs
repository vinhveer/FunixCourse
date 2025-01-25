namespace Bai1
{
    partial class XinChao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxHoTen = new TextBox();
            buttonMessageBox = new Button();
            buttonLabel = new Button();
            buttonTextBox = new Button();
            label1 = new Label();
            labelXinChao = new Label();
            textBoxXinChao = new TextBox();
            SuspendLayout();
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxHoTen.Location = new Point(12, 40);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(776, 34);
            textBoxHoTen.TabIndex = 0;
            textBoxHoTen.TextChanged += textBoxHoTen_TextChanged;
            // 
            // buttonMessageBox
            // 
            buttonMessageBox.Location = new Point(12, 80);
            buttonMessageBox.Name = "buttonMessageBox";
            buttonMessageBox.Size = new Size(273, 34);
            buttonMessageBox.TabIndex = 1;
            buttonMessageBox.Text = "Hiện lời chào qua MessageBox";
            buttonMessageBox.UseVisualStyleBackColor = true;
            buttonMessageBox.Click += buttonMessageBox_Click;
            // 
            // buttonLabel
            // 
            buttonLabel.Location = new Point(291, 80);
            buttonLabel.Name = "buttonLabel";
            buttonLabel.Size = new Size(227, 34);
            buttonLabel.TabIndex = 2;
            buttonLabel.Text = "Hiện lời chào qua Label";
            buttonLabel.UseVisualStyleBackColor = true;
            buttonLabel.Click += buttonLabel_Click;
            // 
            // buttonTextBox
            // 
            buttonTextBox.Location = new Point(12, 120);
            buttonTextBox.Name = "buttonTextBox";
            buttonTextBox.Size = new Size(273, 34);
            buttonTextBox.TabIndex = 3;
            buttonTextBox.Text = "Hiện lời chào qua TextBox";
            buttonTextBox.UseVisualStyleBackColor = true;
            buttonTextBox.Click += buttonTextBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 4;
            label1.Text = "Nhập họ và tên của bạn";
            // 
            // labelXinChao
            // 
            labelXinChao.AutoSize = true;
            labelXinChao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelXinChao.Location = new Point(12, 206);
            labelXinChao.Name = "labelXinChao";
            labelXinChao.Size = new Size(0, 45);
            labelXinChao.TabIndex = 5;
            // 
            // textBoxXinChao
            // 
            textBoxXinChao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxXinChao.Location = new Point(12, 305);
            textBoxXinChao.Name = "textBoxXinChao";
            textBoxXinChao.Size = new Size(776, 45);
            textBoxXinChao.TabIndex = 6;
            // 
            // XinChao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxXinChao);
            Controls.Add(labelXinChao);
            Controls.Add(label1);
            Controls.Add(buttonTextBox);
            Controls.Add(buttonLabel);
            Controls.Add(buttonMessageBox);
            Controls.Add(textBoxHoTen);
            Name = "XinChao";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHoTen;
        private Button buttonMessageBox;
        private Button buttonLabel;
        private Button buttonTextBox;
        private Label label1;
        private Label labelXinChao;
        private TextBox textBoxXinChao;
    }
}
