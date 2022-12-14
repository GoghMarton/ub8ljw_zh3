namespace ub8ljw_zh3
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurzusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teremDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idősávDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(61, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 349);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kurzusDataGridViewTextBoxColumn,
            this.teremDataGridViewTextBoxColumn,
            this.idősávDataGridViewTextBoxColumn,
            this.napDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orakBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(321, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(609, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // orakBindingSource
            // 
            this.orakBindingSource.DataSource = typeof(ub8ljw_zh3.Orak);
            // 
            // kurzusDataGridViewTextBoxColumn
            // 
            this.kurzusDataGridViewTextBoxColumn.DataPropertyName = "Kurzus";
            this.kurzusDataGridViewTextBoxColumn.HeaderText = "Kurzus";
            this.kurzusDataGridViewTextBoxColumn.Name = "kurzusDataGridViewTextBoxColumn";
            // 
            // teremDataGridViewTextBoxColumn
            // 
            this.teremDataGridViewTextBoxColumn.DataPropertyName = "Terem";
            this.teremDataGridViewTextBoxColumn.HeaderText = "Terem";
            this.teremDataGridViewTextBoxColumn.Name = "teremDataGridViewTextBoxColumn";
            // 
            // idősávDataGridViewTextBoxColumn
            // 
            this.idősávDataGridViewTextBoxColumn.DataPropertyName = "Idősáv";
            this.idősávDataGridViewTextBoxColumn.HeaderText = "Idősáv";
            this.idősávDataGridViewTextBoxColumn.Name = "idősávDataGridViewTextBoxColumn";
            // 
            // napDataGridViewTextBoxColumn
            // 
            this.napDataGridViewTextBoxColumn.DataPropertyName = "Nap";
            this.napDataGridViewTextBoxColumn.HeaderText = "Nap";
            this.napDataGridViewTextBoxColumn.Name = "napDataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1038, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kurzusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teremDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idősávDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napDataGridViewTextBoxColumn;
        private BindingSource orakBindingSource;
    }
}
