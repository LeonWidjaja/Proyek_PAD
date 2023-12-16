namespace Proyek_PAD
{
    partial class FormDetailSalesPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJumSales = new System.Windows.Forms.Label();
            this.lblTotSales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTeritorry = new System.Windows.Forms.ComboBox();
            this.btnGanti = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "SalesPerson";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(-2, -1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(588, 77);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "<name>";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Sales :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Sales :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJumSales
            // 
            this.lblJumSales.AutoSize = true;
            this.lblJumSales.Location = new System.Drawing.Point(104, 94);
            this.lblJumSales.Name = "lblJumSales";
            this.lblJumSales.Size = new System.Drawing.Size(65, 13);
            this.lblJumSales.TabIndex = 2;
            this.lblJumSales.Text = "<jum_sales>";
            this.lblJumSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotSales
            // 
            this.lblTotSales.AutoSize = true;
            this.lblTotSales.Location = new System.Drawing.Point(104, 122);
            this.lblTotSales.Name = "lblTotSales";
            this.lblTotSales.Size = new System.Drawing.Size(69, 13);
            this.lblTotSales.TabIndex = 3;
            this.lblTotSales.Text = "<total_sales>";
            this.lblTotSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Teritorry :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTeritorry
            // 
            this.cmbTeritorry.FormattingEnabled = true;
            this.cmbTeritorry.Location = new System.Drawing.Point(107, 161);
            this.cmbTeritorry.Name = "cmbTeritorry";
            this.cmbTeritorry.Size = new System.Drawing.Size(180, 21);
            this.cmbTeritorry.TabIndex = 4;
            // 
            // btnGanti
            // 
            this.btnGanti.Location = new System.Drawing.Point(318, 161);
            this.btnGanti.Name = "btnGanti";
            this.btnGanti.Size = new System.Drawing.Size(75, 23);
            this.btnGanti.TabIndex = 5;
            this.btnGanti.Text = "Ganti";
            this.btnGanti.UseVisualStyleBackColor = true;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(26, 228);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.Size = new System.Drawing.Size(536, 127);
            this.dgvSales.TabIndex = 6;
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToAddRows = false;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Location = new System.Drawing.Point(26, 394);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.ReadOnly = true;
            this.dgvStores.RowHeadersVisible = false;
            this.dgvStores.Size = new System.Drawing.Size(536, 127);
            this.dgvStores.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "List Sales :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "List Store :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormSalesPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 540);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvStores);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnGanti);
            this.Controls.Add(this.cmbTeritorry);
            this.Controls.Add(this.lblTotSales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblJumSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Name = "FormSalesPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalesPerson";
            this.Load += new System.EventHandler(this.FormSalesPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblJumSales;
        private System.Windows.Forms.Label lblTotSales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTeritorry;
        private System.Windows.Forms.Button btnGanti;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}