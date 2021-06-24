using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace searchingBooksDatabase
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        SqlConnection booksConnection;
        String SQLAll;
        Button[] btnRolodex = new Button[26];
        private void frmBooks_Load(object sender, EventArgs e)
        {
            //conect to books database
            booksConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=C:\\Users\\thawkins022713\\source\\repos\\searchingBooksDatabase\\SQLBooksDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            booksConnection.Open();
            // create Rolodex buttons for searching
            int w, lStart, l, t;
            int buttonHeight = 33; // found by trial and error
            // search buttons
            // determine button width - 13 on a row
            w = Convert.ToInt32(this.ClientSize.Width / 14);
            // center buttons on form
            lStart = Convert.ToInt32(0.5 * (this.ClientSize.Width - 13 * w));
            l = lStart;
            t = grdBooks.Top + grdBooks.Height + 2;
            // create and position 26 buttons
            for (int i = 0; i < 26; i++)
            {
                // create new pushbutton
                btnRolodex[i] = new Button();
                btnRolodex[i].TabStop = false;
                // set text property
                btnRolodex[i].Text = ((char) (65 + i)).ToString();
                // position
                btnRolodex[i].Width = w;
                btnRolodex[i].Height = buttonHeight;
                btnRolodex[i].Left = l;
                btnRolodex[i].Top = t;
                // give cool colors
                btnRolodex[i].BackColor = Color.Blue;
                btnRolodex[i].ForeColor = Color.White;
                // add button to form
                this.Controls.Add(btnRolodex[i]);
                // add event handler
                btnRolodex[i].Click += new
            System.EventHandler(this.btnSQL_Click);
                // next left
                l += w;
                if (i == 12)
                {
                    // move to next row
                    l = lStart;
                    t += buttonHeight;
                }
            }
            // Build basic SQL statement
            SQLAll = "SELECT Authors.Author,Titles.Title,Publishers.Company_Name ";
            SQLAll += "FROM Authors, Titles, Publishers, Title_Author ";
            SQLAll += "WHERE Titles.ISBN = Title_Author.ISBN ";
            SQLAll += "AND Authors.Au_ID = Title_Author.Au_ID ";
            SQLAll += "AND Titles.PubID = Publishers.PubID ";
            // show from and click on all records initially
            this.Show();
            btnAll.PerformClick();
        }

        private void frmBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            booksConnection.Close();
            booksConnection.Dispose();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCommand = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            String SQLStatement;
            // determine which button was clicked and form SQL statement
            Button buttonClicked = (Button) sender;
            switch (buttonClicked.Text)
            {
                case "Show All Records":
                    SQLStatement = SQLAll;
                    break;
                case "Z":
                    // Z clicked
                    // Append to SQLAll to limit records to letter clicked
                    SQLStatement = SQLAll + "AND Authors.Author > 'Z' ";
                    break;
                default:
                    // Letter key other than Z clicked
                    // Append to SQLAll to limit records to letter clicked
                    int index = (int)
                (Convert.ToChar(buttonClicked.Text)) - 65;
                    SQLStatement = SQLAll + "AND Authors.Author > '" +
                        btnRolodex[index].Text + " ' ";
                    SQLStatement += "AND Authors.Author < '" +
                        btnRolodex[index + 1].Text + " ' ";
                    break;
            }
            SQLStatement += "ORDER BY Authors.Author";
            // apply SQL statement
            try
            {
                // establish command object and data adapter
                resultsCommand = new SqlCommand(SQLStatement, booksConnection);
                resultsAdapter.SelectCommand = resultsCommand;
                resultsAdapter.Fill(resultsTable);
                // bind grid view to data table
                grdBooks.DataSource = resultsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Processing SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            resultsCommand.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }
    }
}
