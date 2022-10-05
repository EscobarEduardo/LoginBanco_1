
namespace Laboratoio2.Northwind.WinForms
{
    partial class Territories
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TerritoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerritoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerritoryID,
            this.TerritoryDescription,
            this.RegionID});
            this.dataGridView1.Location = new System.Drawing.Point(79, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 115);
            this.dataGridView1.TabIndex = 0;
            // 
            // TerritoryID
            // 
            this.TerritoryID.DataPropertyName = "TerritoryID";
            this.TerritoryID.HeaderText = "TerritoryID";
            this.TerritoryID.Name = "TerritoryID";
            // 
            // TerritoryDescription
            // 
            this.TerritoryDescription.DataPropertyName = "TerritoryDescription";
            this.TerritoryDescription.HeaderText = "TerritoryDescription";
            this.TerritoryDescription.Name = "TerritoryDescription";
            // 
            // RegionID
            // 
            this.RegionID.DataPropertyName = "RegionID";
            this.RegionID.HeaderText = "RegionID";
            this.RegionID.Name = "RegionID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(403, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ordena segun el campo seleccionado";
            // 
            // Territories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Territories";
            this.Text = "Territories";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerritoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerritoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}