using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReferenceTracker
{
    public partial class ReferenceList : Form
    {
        int userId = 0;
        public ReferenceList(int pUserId)
        {
            userId = pUserId;
            InitializeComponent();
        }

        private void ReferenceList_Load(object sender, EventArgs e)
        {
            LoadReferences();
        }

        private void LoadReferences()
        {
            string query = "select * from Reference where UserId=" + userId;
            DBConnection db = new DBConnection(query);
            dataGridView1.DataSource = db.GetDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                SaveFileDialog fd = new SaveFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    fd.DefaultExt = ".txt";
                    string selectedStyle = comboBox1.SelectedItem.ToString();
                    StreamWriter sw = new StreamWriter(fd.FileName+"."+fd.DefaultExt);
                    try
                    {
                        bool isSelected = false;

                        foreach (DataGridViewRow drv in dataGridView1.Rows)
                        {
                            var chk = Convert.ToBoolean(drv.Cells["Export"].Value);
                            string citationStyle = "";

                            if (chk)
                            {
                                isSelected = true;
                                if (selectedStyle == "Harvard")
                                {
                                    citationStyle = drv.Cells["Author"].Value + ". " + drv.Cells["Year"].Value + drv.Cells["Title"].Value;
                                }
                                else if(selectedStyle=="APA")
                                {
                                    //code here for APA style
                                }
                                else if(selectedStyle == "Chicago")
                                {
                                    //code here for APA style
                                }
                            }
                            sw.WriteLine(citationStyle);
                        }
                        if (isSelected)
                            MessageBox.Show("References are successfull exported into " + selectedStyle + " citation in File location: " + fd.FileName + fd.DefaultExt);
                        else
                            MessageBox.Show("There is no reference selected");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sw.Flush();
                        sw.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select citation style.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command.ToLower() == "delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure to Delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query = "delete from Reference where id=" + id; ;
                        DBConnection db = new DBConnection(query);
                        db.ExecuteQuery();
                        MessageBox.Show("Reference Successfully deleted");
                        LoadReferences();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (command.ToLower() == "edit")
            {
                AddReference r = new AddReference(userId, id);
                r.Show();
            }
        }
    }
}
