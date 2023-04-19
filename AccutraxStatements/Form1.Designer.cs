namespace AccutraxStatements
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.dgvAllStatements = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNewStatement = new System.Windows.Forms.TextBox();
            this.btnAddStatement = new System.Windows.Forms.Button();
            this.dgvProductStatements = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStatements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatements)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(241, 102);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(277, 24);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(31, 32);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(277, 24);
            this.cmbProject.TabIndex = 2;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // dgvAllStatements
            // 
            this.dgvAllStatements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllStatements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllStatements.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllStatements.Location = new System.Drawing.Point(561, 42);
            this.dgvAllStatements.Name = "dgvAllStatements";
            this.dgvAllStatements.RowTemplate.Height = 24;
            this.dgvAllStatements.Size = new System.Drawing.Size(1317, 627);
            this.dgvAllStatements.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(989, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "All Accutrax Statements Not Attached to Current Product";
            // 
            // tbxNewStatement
            // 
            this.tbxNewStatement.Location = new System.Drawing.Point(691, 738);
            this.tbxNewStatement.Multiline = true;
            this.tbxNewStatement.Name = "tbxNewStatement";
            this.tbxNewStatement.Size = new System.Drawing.Size(748, 117);
            this.tbxNewStatement.TabIndex = 6;
            // 
            // btnAddStatement
            // 
            this.btnAddStatement.Location = new System.Drawing.Point(1458, 806);
            this.btnAddStatement.Name = "btnAddStatement";
            this.btnAddStatement.Size = new System.Drawing.Size(103, 49);
            this.btnAddStatement.TabIndex = 7;
            this.btnAddStatement.Text = "Add New Statement";
            this.btnAddStatement.UseVisualStyleBackColor = true;
            // 
            // dgvProductStatements
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductStatements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductStatements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductStatements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnRemove});
            this.dgvProductStatements.Location = new System.Drawing.Point(58, 177);
            this.dgvProductStatements.Name = "dgvProductStatements";
            this.dgvProductStatements.RowTemplate.Height = 24;
            this.dgvProductStatements.Size = new System.Drawing.Size(460, 729);
            this.dgvProductStatements.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.HeaderText = "";
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Statements ";
            // 
            // tbxUpdate
            // 
            this.tbxUpdate.Location = new System.Drawing.Point(691, 543);
            this.tbxUpdate.Multiline = true;
            this.tbxUpdate.Name = "tbxUpdate";
            this.tbxUpdate.Size = new System.Drawing.Size(748, 117);
            this.tbxUpdate.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1458, 611);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 49);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(1506, 675);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 49);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Add to Product";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProductStatements);
            this.Controls.Add(this.btnAddStatement);
            this.Controls.Add(this.tbxNewStatement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllStatements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStatements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNewStatement;
        private System.Windows.Forms.Button btnAddStatement;
        private System.Windows.Forms.DataGridView dgvProductStatements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemove;
        private System.Windows.Forms.TextBox tbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.DataGridView dgvAllStatements;
    }
}

