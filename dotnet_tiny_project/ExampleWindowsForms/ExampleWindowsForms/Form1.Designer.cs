namespace ExampleWindowsForms
{
    partial class Form1
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
            btnSave = new Button();
            textBox = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(589, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 46);
            btnSave.TabIndex = 0;
            btnSave.Text = "Thêm nhắc nhở mới";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(561, 46);
            textBox.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 374);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(textBox);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "To-do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox textBox;
        private ListView listView1;
    }
}
