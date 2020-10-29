namespace CarFinerByMake
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.honestRalphsUsedCarsDataSet = new CarFinerByMake.HonestRalphsUsedCarsDataSet();
            this.tblCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarsTableAdapter = new CarFinerByMake.HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ford = new System.Windows.Forms.Button();
            this.chev = new System.Windows.Forms.Button();
            this.cad = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.modelYearDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCarsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(136, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // honestRalphsUsedCarsDataSet
            // 
            this.honestRalphsUsedCarsDataSet.DataSetName = "HonestRalphsUsedCarsDataSet";
            this.honestRalphsUsedCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarsBindingSource
            // 
            this.tblCarsBindingSource.DataMember = "tblCars";
            this.tblCarsBindingSource.DataSource = this.honestRalphsUsedCarsDataSet;
            // 
            // tblCarsTableAdapter
            // 
            this.tblCarsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            this.modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // ford
            // 
            this.ford.Location = new System.Drawing.Point(55, 112);
            this.ford.Name = "ford";
            this.ford.Size = new System.Drawing.Size(75, 23);
            this.ford.TabIndex = 1;
            this.ford.Text = "Ford";
            this.ford.UseVisualStyleBackColor = true;
            this.ford.Click += new System.EventHandler(this.ford_Click);
            // 
            // chev
            // 
            this.chev.Location = new System.Drawing.Point(55, 141);
            this.chev.Name = "chev";
            this.chev.Size = new System.Drawing.Size(75, 23);
            this.chev.TabIndex = 2;
            this.chev.Text = "Chevrolet";
            this.chev.UseVisualStyleBackColor = true;
            this.chev.Click += new System.EventHandler(this.chev_Click);
            // 
            // cad
            // 
            this.cad.Location = new System.Drawing.Point(55, 170);
            this.cad.Name = "cad";
            this.cad.Size = new System.Drawing.Size(75, 23);
            this.cad.TabIndex = 3;
            this.cad.Text = "Cadillac";
            this.cad.UseVisualStyleBackColor = true;
            this.cad.Click += new System.EventHandler(this.cad_Click);
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(55, 83);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(75, 23);
            this.all.TabIndex = 4;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(132, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehicle type being shown will be displayed here.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.all);
            this.Controls.Add(this.cad);
            this.Controls.Add(this.chev);
            this.Controls.Add(this.ford);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HonestRalphsUsedCarsDataSet honestRalphsUsedCarsDataSet;
        private System.Windows.Forms.BindingSource tblCarsBindingSource;
        private HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter tblCarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ford;
        private System.Windows.Forms.Button chev;
        private System.Windows.Forms.Button cad;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Label label1;
    }
}

