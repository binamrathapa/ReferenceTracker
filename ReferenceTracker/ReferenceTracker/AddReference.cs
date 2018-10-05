using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceTracker
{
    public partial class AddReference : Form
    {
        int UserId = 0;
        int ReferenceId = 0;

        public AddReference(int userId, int referenceId)
        {
            UserId = userId;
            ReferenceId = referenceId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert into [Reference] values('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + cbDocumentType.SelectedItem + "','" + txtYear.Text + "'," +
                    " '" + txtPublisher.Text + "','" + txtAbstract.Text + "','" + txtName.Text + "','" + txtIssue.Text + "'," + txtVolume.Text + ",'" + txtPageNumber.Text + "','" + txtNote.Text + "'," + UserId + ")";
                if (ReferenceId > 0)
                {
                    query = "Update set Title='" + txtTitle.Text + "',Author='" + txtAuthor.Text + "',DocumentType='" + cbDocumentType.SelectedItem + "',Year='" + txtYear.Text + "',Publisher='" + txtPublisher.Text + "'"+
                        ",Abstract='" + txtAbstract.Text + "', Name='"+txtName.Text+"',Issue='"+txtIssue.Text+"',Volume="+txtVolume.Text+",PageNumber='"+txtPageNumber.Text+"'"+
                        ",Notes='"+txtNote.Text+"' Where Id="+ReferenceId;
                }
                DBConnection db = new DBConnection(query);

                db.ExecuteQuery();
                MessageBox.Show("Added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddReference_Load(object sender, EventArgs e)
        {
            if (ReferenceId > 0)
            {
                LoadReference();
            }
        }

        private void LoadReference()
        {
            try
            {
                string query = "Select * from Reference where id=" + ReferenceId;
                DBConnection db = new DBConnection(query);
                DataTable dt = db.GetDataTable();

                if (dt.Rows.Count > 0)
                {
                    txtTitle.Text = (string)dt.Rows[0]["Title"];
                    txtAuthor.Text = (string)dt.Rows[0]["Author"];
                    cbDocumentType.SelectedItem = (object)dt.Rows[0]["DocumentType"];
                    txtYear.Text = dt.Rows[0]["Year"].ToString();
                    txtPublisher.Text = (string)dt.Rows[0]["Publisher"];
                    txtAbstract.Text = (string)dt.Rows[0]["Abstract"];
                    txtName.Text = (string)dt.Rows[0]["Name"];
                    txtIssue.Text = (string)dt.Rows[0]["Issue"]; 
                    txtVolume.Text = dt.Rows[0]["Volume"].ToString();
                    txtPageNumber.Text = (string)dt.Rows[0]["PageNumber"];
                    txtNote.Text = (string)dt.Rows[0]["Notes"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
