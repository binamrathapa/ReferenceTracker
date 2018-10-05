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
    public partial class Dashboard : Form
    {
        public int UserId
        {
            get; set;
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                LoadReferences("", "");
                // LoadReferencesByBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadReferences(string pCitationStyle, string pQuery)
        {
            string query = "";
            if (!string.IsNullOrEmpty(pQuery))
            {
                query = pQuery;
            }
            else
            {
                query = "select * from Reference where userid=" + UserId;
            }
            DBConnection db = new DBConnection(query);

            DataTable dtReferences = db.GetDataTable();
            string citationStyle3 = "";
            panel1.Controls.Clear();
            int count = 0;

            foreach (DataRow drReference in dtReferences.Rows)
            {
                if (pCitationStyle == "Harvard")
                {

                    Panel pnl = new Panel();
                    pnl.AutoScroll = true;
                    pnl.Width = 685;
                    pnl.Height = 30;
                    pnl.Location = new Point(20, 10 + (count * 30));

                    Label lblAuthor = new Label();
                    lblAuthor.Text = (string)drReference["Author"] + ". (" + (string)drReference["Year"] + ")";
                    lblAuthor.AutoSize = true;
                    lblAuthor.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular);
                    lblAuthor.Location = new Point(10, 0);
                    pnl.Controls.Add(lblAuthor);

                    Label lblTitle = new Label();
                    lblTitle.Text = (string)drReference["Title"];
                    lblTitle.AutoSize = true;
                    lblTitle.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Italic);
                    lblTitle.Location = new Point(10 + lblAuthor.Width, 0);
                    pnl.Controls.Add(lblTitle);

                    citationStyle3 = (string)drReference["Publisher"];
                    Label lblPublisher = new Label();
                    lblPublisher.Text = citationStyle3;
                    lblPublisher.AutoSize = true;
                    lblPublisher.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular);
                    lblPublisher.Location = new Point(lblAuthor.Width + lblPublisher.Width, 0);
                    pnl.Controls.Add(lblPublisher);

                    panel1.Controls.Add(pnl);
                }
                else if (pCitationStyle == "APA")
                {
                    //code here for APA citation
                }
                else if (pCitationStyle == "Chicago")
                {
                    //code here for Chicago citation
                }
                count++;
            }
        }

        private void addReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReference addRerence = new AddReference(UserId, 0);
            addRerence.Show();
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenceList references = new ReferenceList(UserId);
            references.Show();
        }

        private void exportReferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenceList references = new ReferenceList(UserId);
            references.Show();
        }

        private void tagArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagArticles ta = new TagArticles();
            ta.Show();
        }

        private void addTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTag t = new AddTag(UserId);
            t.Show();
        }

        private void displayTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagList tl = new TagList(UserId);
            tl.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            string query = "Select * from Reference Where UserId="+UserId+" And Author like '%" + searchText + "%' OR Title like '%" + searchText + "%' OR DocumentType like '%" + searchText + "%'";
           
            if (cbCitationStyle.SelectedItem != null)
                LoadReferences(cbCitationStyle.SelectedItem.ToString(), query);
            else
                LoadReferences("", query);

        }

        private void cbCitationStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReferences(cbCitationStyle.SelectedItem.ToString(), "");
        }

        private void cbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Reference Where UserId=" + UserId + " Order By " + cbSorting.Text;
            if (cbCitationStyle.SelectedItem != null)
                LoadReferences(cbCitationStyle.SelectedItem.ToString(), query);
            else
                LoadReferences("", query);
        }
    }
}
