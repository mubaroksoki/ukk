
namespace BetaMartsiSyauqi
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabeldataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pakabetaDataSet = new BetaMartsiSyauqi.pakabetaDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hargapokok = new System.Windows.Forms.TextBox();
            this.stokbarang = new System.Windows.Forms.TextBox();
            this.namabarang = new System.Windows.Forms.TextBox();
            this.kodebarang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargapokokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabeldataTableAdapter = new BetaMartsiSyauqi.pakabetaDataSetTableAdapters.tabeldataTableAdapter();
            this.btncancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabeldataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakabetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hargapokok);
            this.panel1.Controls.Add(this.stokbarang);
            this.panel1.Controls.Add(this.namabarang);
            this.panel1.Controls.Add(this.kodebarang);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 295);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabeldataBindingSource, "expdate", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabeldataBindingSource
            // 
            this.tabeldataBindingSource.DataMember = "tabeldata";
            this.tabeldataBindingSource.DataSource = this.pakabetaDataSet;
            // 
            // pakabetaDataSet
            // 
            this.pakabetaDataSet.DataSetName = "pakabetaDataSet";
            this.pakabetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harga Pokok ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exp Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stok Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kode Barang";
            // 
            // hargapokok
            // 
            this.hargapokok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabeldataBindingSource, "hargapokok", true));
            this.hargapokok.Location = new System.Drawing.Point(171, 233);
            this.hargapokok.Name = "hargapokok";
            this.hargapokok.Size = new System.Drawing.Size(152, 20);
            this.hargapokok.TabIndex = 4;
            this.hargapokok.TabStop = false;
            this.hargapokok.TextChanged += new System.EventHandler(this.hargapokok_TextChanged);
            // 
            // stokbarang
            // 
            this.stokbarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabeldataBindingSource, "stokbarang", true));
            this.stokbarang.Location = new System.Drawing.Point(171, 137);
            this.stokbarang.Name = "stokbarang";
            this.stokbarang.Size = new System.Drawing.Size(152, 20);
            this.stokbarang.TabIndex = 2;
            this.stokbarang.TabStop = false;
            this.stokbarang.TextChanged += new System.EventHandler(this.stokbarang_TextChanged);
            // 
            // namabarang
            // 
            this.namabarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabeldataBindingSource, "namabarang", true));
            this.namabarang.Location = new System.Drawing.Point(171, 85);
            this.namabarang.Name = "namabarang";
            this.namabarang.Size = new System.Drawing.Size(152, 20);
            this.namabarang.TabIndex = 1;
            this.namabarang.TabStop = false;
            this.namabarang.TextChanged += new System.EventHandler(this.namabarang_TextChanged);
            // 
            // kodebarang
            // 
            this.kodebarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabeldataBindingSource, "kodebarang", true));
            this.kodebarang.Location = new System.Drawing.Point(171, 37);
            this.kodebarang.Name = "kodebarang";
            this.kodebarang.Size = new System.Drawing.Size(152, 20);
            this.kodebarang.TabIndex = 0;
            this.kodebarang.TabStop = false;
            this.kodebarang.TextChanged += new System.EventHandler(this.kodebarang_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kodebarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.stokbarangDataGridViewTextBoxColumn,
            this.expdateDataGridViewTextBoxColumn,
            this.hargapokokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabeldataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(419, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 295);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // kodebarangDataGridViewTextBoxColumn
            // 
            this.kodebarangDataGridViewTextBoxColumn.DataPropertyName = "kodebarang";
            this.kodebarangDataGridViewTextBoxColumn.HeaderText = "kodebarang";
            this.kodebarangDataGridViewTextBoxColumn.Name = "kodebarangDataGridViewTextBoxColumn";
            this.kodebarangDataGridViewTextBoxColumn.Width = 130;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "namabarang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "namabarang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.Width = 130;
            // 
            // stokbarangDataGridViewTextBoxColumn
            // 
            this.stokbarangDataGridViewTextBoxColumn.DataPropertyName = "stokbarang";
            this.stokbarangDataGridViewTextBoxColumn.HeaderText = "stokbarang";
            this.stokbarangDataGridViewTextBoxColumn.Name = "stokbarangDataGridViewTextBoxColumn";
            this.stokbarangDataGridViewTextBoxColumn.Width = 130;
            // 
            // expdateDataGridViewTextBoxColumn
            // 
            this.expdateDataGridViewTextBoxColumn.DataPropertyName = "expdate";
            this.expdateDataGridViewTextBoxColumn.HeaderText = "expdate";
            this.expdateDataGridViewTextBoxColumn.Name = "expdateDataGridViewTextBoxColumn";
            this.expdateDataGridViewTextBoxColumn.Width = 130;
            // 
            // hargapokokDataGridViewTextBoxColumn
            // 
            this.hargapokokDataGridViewTextBoxColumn.DataPropertyName = "hargapokok";
            this.hargapokokDataGridViewTextBoxColumn.HeaderText = "hargapokok";
            this.hargapokokDataGridViewTextBoxColumn.Name = "hargapokokDataGridViewTextBoxColumn";
            this.hargapokokDataGridViewTextBoxColumn.Width = 130;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(985, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(901, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 39);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(733, 428);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 39);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pencatatan Stok Barang";
            // 
            // tabeldataTableAdapter
            // 
            this.tabeldataTableAdapter.ClearBeforeFill = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(817, 428);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(78, 39);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabeldataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakabetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hargapokok;
        private System.Windows.Forms.TextBox stokbarang;
        private System.Windows.Forms.TextBox namabarang;
        private System.Windows.Forms.TextBox kodebarang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private pakabetaDataSet pakabetaDataSet;
        private System.Windows.Forms.BindingSource tabeldataBindingSource;
        private pakabetaDataSetTableAdapters.tabeldataTableAdapter tabeldataTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargapokokDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

