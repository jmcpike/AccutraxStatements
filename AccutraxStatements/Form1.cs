using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccutraxStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadAllStatements();
            loadProjectType();
        }
        private void loadAllStatements()
        {
    
            int productId=-1;
            string sql = string.Empty;
            dgvAllStatements .DataSource = null;
            string cn = ConfigurationManager.ConnectionStrings["Accutrax"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(cn))
            {
                try
                {
                    if (cmbProduct.SelectedIndex <=0 )
                    {
                        sql = @"SELECT distinct id, Terms, iseditable, isdefault FROM statements as s where company_code ='htc' and NOT EXISTS  (select id from productStatements as ps where ps.Id=s.id )";
                    }
                    else
                    {
                        productId = int.Parse(cmbProduct.SelectedValue.ToString());
                        sql = @"SELECT distinct id, Terms, iseditable, isdefault FROM statements as s where company_code ='htc' and NOT EXISTS  (select id from productStatements as ps where ps.Id=s.id and ps.productId=@productId )";
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@productId", productId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                     da.Fill(dt);
                    // create a new DataGridView
                    DataGridView dgvAllStatements = new DataGridView();

                    // bind the columns of the DataGridView to the columns of the DataTable
                    dgvAllStatements.AutoGenerateColumns = false;
                        dgvAllStatements.DataSource = dt;

                    // create columns for the DataGridView
                    DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
                    id.DataPropertyName = "id";
                    id.HeaderText = "ID";
                    dgvAllStatements.Columns.Add(id);

                    DataGridViewTextBoxColumn Terms = new DataGridViewTextBoxColumn();
                    Terms.DataPropertyName = "Terms";
                    Terms.HeaderText = "Statements";
                    dgvAllStatements.Columns.Add(Terms);
                 
               
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load All Statements " + ex.Message);
                    con.Close();
                }
            }
        }
        private void loadProjectType()
        {
            cmbProject.DataSource = null;
            string cn = ConfigurationManager.ConnectionStrings["Accutrax"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(cn))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"select Long_Desc as ProjectName,ProjectTypeId from ProjectType where company_code='HTC'", con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    DataRow r = dt.NewRow();
                    r["ProjectTypeId"] = -1;
                    r["ProjectName"] = "Select Project";
                    dt.Rows.InsertAt(r, 0);
                    cmbProject.DataSource = dt;
                    cmbProject.DisplayMember = "ProjectName";
                    cmbProject.ValueMember = "ProjectTypeId";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load ProjectTypes " + ex.Message);
                    con.Close();
                }
            }

        }
        private void loadProducts(int projectTypeId)
        {
            cmbProduct.DataSource = null;
            string cn = ConfigurationManager.ConnectionStrings["Accutrax"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(cn))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"select productId,ProductName from products where Company_Code='htc' and projectTypeId=@projectTypeId", con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@projectTypeId", projectTypeId);
                    da.Fill(dt);
                    DataRow r = dt.NewRow();
                    r["productId"] = -1;
                    r["ProductName"] = "Select Product";
                    dt.Rows.InsertAt(r, 0);
                    cmbProduct.DataSource = dt;
                    cmbProduct.DisplayMember = "ProductName";
                    cmbProduct.ValueMember = "productId";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load Products " + ex.Message);
                    con.Close();
                }
            }
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex > 0)
            {
                loadProducts(int.Parse(cmbProject.SelectedIndex.ToString()));
               
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAllStatements();
        }
    }
}
