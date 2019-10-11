namespace Exam_4
{
    partial class Home
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
            this.saveCustomerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.priceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // saveCustomerLinkLabel
            // 
            this.saveCustomerLinkLabel.AutoSize = true;
            this.saveCustomerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustomerLinkLabel.Location = new System.Drawing.Point(237, 97);
            this.saveCustomerLinkLabel.Name = "saveCustomerLinkLabel";
            this.saveCustomerLinkLabel.Size = new System.Drawing.Size(192, 20);
            this.saveCustomerLinkLabel.TabIndex = 0;
            this.saveCustomerLinkLabel.TabStop = true;
            this.saveCustomerLinkLabel.Text = "Save Mobile Handset Info";
            this.saveCustomerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveCustomerLinkLabel_LinkClicked);
            // 
            // priceLinkLabel
            // 
            this.priceLinkLabel.AutoSize = true;
            this.priceLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLinkLabel.Location = new System.Drawing.Point(247, 134);
            this.priceLinkLabel.Name = "priceLinkLabel";
            this.priceLinkLabel.Size = new System.Drawing.Size(173, 20);
            this.priceLinkLabel.TabIndex = 0;
            this.priceLinkLabel.TabStop = true;
            this.priceLinkLabel.Text = "Search By Price Range";
            this.priceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.transectionLinkLabel_LinkClicked);
            // 
            // searchLinkLabel
            // 
            this.searchLinkLabel.AutoSize = true;
            this.searchLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLinkLabel.Location = new System.Drawing.Point(270, 168);
            this.searchLinkLabel.Name = "searchLinkLabel";
            this.searchLinkLabel.Size = new System.Drawing.Size(120, 20);
            this.searchLinkLabel.TabIndex = 0;
            this.searchLinkLabel.TabStop = true;
            this.searchLinkLabel.Text = "Search By IMEI";
            this.searchLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.searchLinkLabel_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchLinkLabel);
            this.Controls.Add(this.priceLinkLabel);
            this.Controls.Add(this.saveCustomerLinkLabel);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel saveCustomerLinkLabel;
        private System.Windows.Forms.LinkLabel priceLinkLabel;
        private System.Windows.Forms.LinkLabel searchLinkLabel;
    }
}

