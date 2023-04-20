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
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terms = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cmbProduct.Location = new System.Drawing.Point(138, 128);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(444, 28);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(35, 40);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(311, 28);
            this.cmbProject.TabIndex = 2;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // dgvAllStatements
            // 
            this.dgvAllStatements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllStatements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStatements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect,
            this.id,
            this.Terms});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllStatements.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllStatements.Location = new System.Drawing.Point(631, 52);
            this.dgvAllStatements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllStatements.Name = "dgvAllStatements";
            this.dgvAllStatements.RowTemplate.Height = 24;
            this.dgvAllStatements.Size = new System.Drawing.Size(1482, 784);
            this.dgvAllStatements.TabIndex = 4;
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Select";
            this.chkSelect.Name = "chkSelect";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "StatementId";
            this.id.Name = "id";
            this.id.Width = 62;
            // 
            // Terms
            // 
            this.Terms.DataPropertyName = "terms";
            this.Terms.HeaderText = "Statements";
            this.Terms.Name = "Terms";
            this.Terms.Width = 700;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1113, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "All Accutrax Statements Not Attached to Current Product";
            // 
            // tbxNewStatement
            // 
            this.tbxNewStatement.Location = new System.Drawing.Point(777, 922);
            this.tbxNewStatement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNewStatement.Multiline = true;
            this.tbxNewStatement.Name = "tbxNewStatement";
            this.tbxNewStatement.Size = new System.Drawing.Size(841, 145);
            this.tbxNewStatement.TabIndex = 6;
            // 
            // btnAddStatement
            // 
            this.btnAddStatement.Location = new System.Drawing.Point(1640, 1008);
            this.btnAddStatement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStatement.Name = "btnAddStatement";
            this.btnAddStatement.Size = new System.Drawing.Size(116, 61);
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
            this.dgvProductStatements.Location = new System.Drawing.Point(65, 221);
            this.dgvProductStatements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductStatements.Name = "dgvProductStatements";
            this.dgvProductStatements.RowTemplate.Height = 24;
            this.dgvProductStatements.Size = new System.Drawing.Size(518, 911);
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
            this.label4.Location = new System.Drawing.Point(280, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Statements ";
            // 
            // tbxUpdate
            // 
            this.tbxUpdate.Location = new System.Drawing.Point(777, 679);
            this.tbxUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUpdate.Multiline = true;
            this.tbxUpdate.Name = "tbxUpdate";
            this.tbxUpdate.Size = new System.Drawing.Size(841, 145);
            this.tbxUpdate.TabIndex = 10;
            this.tbxUpdate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1640, 764);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 61);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(1694, 844);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(84, 61);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Add to Product";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2140, 1291);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

