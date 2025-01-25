namespace WinForms
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
            dataGridView1 = new DataGridView();
            CongViec = new DataGridViewTextBoxColumn();
            HoanThanh = new DataGridViewCheckBoxColumn();
            ThaoTac = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CongViec, HoanThanh, ThaoTac });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CongViec
            // 
            CongViec.HeaderText = "Công việc";
            CongViec.MinimumWidth = 8;
            CongViec.Name = "CongViec";
            // 
            // HoanThanh
            // 
            HoanThanh.HeaderText = "Hoàn thành";
            HoanThanh.MinimumWidth = 8;
            HoanThanh.Name = "HoanThanh";
            HoanThanh.Resizable = DataGridViewTriState.True;
            HoanThanh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ThaoTac
            // 
            ThaoTac.HeaderText = "Thao tác";
            ThaoTac.MinimumWidth = 8;
            ThaoTac.Name = "ThaoTac";
            ThaoTac.Text = "";
            ThaoTac.ToolTipText = "Thao tác";
            ThaoTac.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CongViec;
        private DataGridViewCheckBoxColumn HoanThanh;
        private DataGridViewButtonColumn ThaoTac;
    }
}
