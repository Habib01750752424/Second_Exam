namespace Exam_4
{
    partial class SearchByPriceUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toPriceTextBox = new System.Windows.Forms.TextBox();
            this.fromPriceTextBox = new System.Windows.Forms.TextBox();
            this.mobileDataGridView = new System.Windows.Forms.DataGridView();
            this.mobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toPriceTextBox);
            this.groupBox1.Controls.Add(this.fromPriceTextBox);
            this.groupBox1.Location = new System.Drawing.Point(127, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By price Range";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(428, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Range From";
            // 
            // toPriceTextBox
            // 
            this.toPriceTextBox.Location = new System.Drawing.Point(303, 40);
            this.toPriceTextBox.Name = "toPriceTextBox";
            this.toPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.toPriceTextBox.TabIndex = 0;
            // 
            // fromPriceTextBox
            // 
            this.fromPriceTextBox.Location = new System.Drawing.Point(135, 40);
            this.fromPriceTextBox.Name = "fromPriceTextBox";
            this.fromPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromPriceTextBox.TabIndex = 0;
            // 
            // mobileDataGridView
            // 
            this.mobileDataGridView.AllowUserToAddRows = false;
            this.mobileDataGridView.AllowUserToDeleteRows = false;
            this.mobileDataGridView.AutoGenerateColumns = false;
            this.mobileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mobileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SERIAL,
            this.idDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.iMEIDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.mobileDataGridView.DataSource = this.mobileBindingSource;
            this.mobileDataGridView.Location = new System.Drawing.Point(168, 183);
            this.mobileDataGridView.Name = "mobileDataGridView";
            this.mobileDataGridView.ReadOnly = true;
            this.mobileDataGridView.Size = new System.Drawing.Size(444, 150);
            this.mobileDataGridView.TabIndex = 1;
            // 
            // mobileBindingSource
            // 
            this.mobileBindingSource.DataSource = typeof(Exam_4.Models.Mobile);
            // 
            // SERIAL
            // 
            this.SERIAL.HeaderText = "SL";
            this.SERIAL.Name = "SERIAL";
            this.SERIAL.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            this.modelNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMEIDataGridViewTextBoxColumn
            // 
            this.iMEIDataGridViewTextBoxColumn.DataPropertyName = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.HeaderText = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.Name = "iMEIDataGridViewTextBoxColumn";
            this.iMEIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SearchByPriceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mobileDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchByPriceUI";
            this.Text = "Search By Price";
            this.Load += new System.EventHandler(this.SearchByPriceUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toPriceTextBox;
        private System.Windows.Forms.TextBox fromPriceTextBox;
        private System.Windows.Forms.DataGridView mobileDataGridView;
        private System.Windows.Forms.BindingSource mobileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}