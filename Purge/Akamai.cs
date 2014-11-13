using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;



namespace Purge
{
    public partial class Akamai : Form
    {

        public Akamai()
        {
            InitializeComponent();
        }

        private void button_purge_Click(object sender, EventArgs e)
        {

            // Waiting Cursor
            Cursor.Current = Cursors.WaitCursor;



            try
            {
                string username = "genauthor@microsoft.com"; 	//use the username to access 
                //the control.akamai.com 
                string password = "L3tm3OutCQ2"; 	//use the password to access the control.
                //akamai.com 
                string email = "genauthor@microsoft.com" + textBox_Email.Text;

                string[] fileToPurge = new string[] { textBox_filePath.Text }; //this is the item in 

                string action = "";

                //akamai proxy that you want to purge
                if (radioButton_Purge.Checked)
                {
                    action = "action=remove";
                }
                else
                {
                    action = "action=invalidate";

                }
                string domain = "";

                if (radioButton_Purge.Checked)
                {
                    domain = "domain=production";

                }
                else
                {
                    domain = "domain=staging;";
                }


                //other value is action=invalidate 


                //type: type=cpcode or type=arl >> arl: akamai resource locator. 
                //url: uniform resource locator. 
                //To use the type cpcode option, your administrator must enable 
                //purge-by-cpcode access for your username 
                //through Akamai EdgeControl. 
                string purgeType = "type=arl"; //other value is type=cpcode 

                string[] options = new string[] { action, domain, email, purgeType };
                AkamaiPurgeCache.PurgeApi purgeAPI = new AkamaiPurgeCache.PurgeApiClient();
                AkamaiPurgeCache.PurgeResult purgeResult = purgeAPI.purgeRequest
                (username, password, string.Empty, options, fileToPurge);

                if (purgeResult.resultCode >= 300)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.AppendFormat("Error Code: {0}", purgeResult.resultCode);
                    sb.AppendFormat("Error Message: {0}", purgeResult.resultMsg);
                    sb.AppendFormat("Session ID: {0}", purgeResult.sessionID);
                    sb.AppendFormat("URI Index: {0}", purgeResult.uriIndex);
                    throw new Exception(sb.ToString());
                }
            }

            catch (Exception E)
            { //exception code here.. } 
            }



        }

        private void textBox_filePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_quite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quite?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {

            textBox_Email.Text = "";
        }

        private void button_xlFile_Click(object sender, EventArgs e)
        {



            // Waiting Cursor
            Cursor.Current = Cursors.WaitCursor;
            listView1.Items.Clear();
            string extension = System.IO.Path.GetExtension(textBox_Choose.Text);
            if (extension == ".txt")
                dotxt();
            else if (extension == ".xlsx")
                doexcel();
            else if (extension == ".csv")
                docsv();
            else
            {
                MessageBox.Show("Error, Please select another file");
            }



        }



        public void doexcel()
        {
            OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox_Choose.Text +
                                                         ";Extended Properties='Excel 12.0 XML;HDR=YES;';");

            OleDbCommand oconn = new OleDbCommand("SELECT * from [" + "Sheet1$" + "]", cnn);
            cnn.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter(oconn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }
        }




        public void dotxt()
        {
            string[] lines = System.IO.File.ReadAllLines(textBox_Choose.Text);
            foreach (string line in lines)
            {
                listView1.Items.Add(line);
            }



            //string filepath = textBox_Choose.Text;
            //FileStream yaNew = File.Open(filepath, FileMode.Open, FileAccess.Read);
            //StreamReader yaRead = new StreamReader(yaNew);
            //string yaView = yaRead.ReadToEnd();


            //yaRead.Close();
            //yaNew.Close();
            //String[] yaArray = yaView.Split(new char[] { '\n' });
            //foreach (string ya in yaArray)
            //{
            //    listView1.Items.Add(ya);
            //}

        }
        public void docsv()
        {

            string filepath = textBox_Choose.Text;
            FileStream yaNew = File.Open(filepath, FileMode.Open, FileAccess.Read);
            StreamReader yaRead = new StreamReader(yaNew);
            string yaView = yaRead.ReadToEnd();

            yaRead.Close();
            yaNew.Close();
            String[] yaArray = yaView.Split(new char[] { ',' });
            foreach (string ya in yaArray)
            {
                listView1.Items.Add(ya);
            }

        }

        private void button_Choose_Click(object sender, EventArgs e)
        {
            //Call the OpenFileDialog Object and name it 
            OpenFileDialog explore = new OpenFileDialog();

            //Set the directory path 
            explore.InitialDirectory = @"c:\MyProject";

            //set the file types 
            explore.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            explore.FilterIndex = 2;
            explore.RestoreDirectory = true;


            //show result in the textbox 
            if (explore.ShowDialog() == DialogResult.OK)
            {
                textBox_Choose.Text = explore.FileName;
            }

            // Waiting Cursor
            Cursor.Current = Cursors.WaitCursor;
            listView1.Items.Clear();
            string extension = System.IO.Path.GetExtension(textBox_Choose.Text);
            if (extension == ".txt")
                dotxt();
            else if (extension == ".xlsx")
                doexcel();
            else if (extension == ".csv")
                docsv();
            else
            {
                MessageBox.Show("Error, Please select another file");
            }

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_filePath.Text = "";
        }

        private void radioButton_Purge_CheckedChanged(object sender, EventArgs e)
        {


        }


        private void radioButton_Invalidate_CheckedChanged(object sender, EventArgs e)
        {


        }

      


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Path_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_Email2.Text = "";
        }

        private void Akamai_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void radioButton_Excel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Excel.Checked)
            {
                panel1.Visible = true;
                panelLoadTxt.Visible = false;
            }
            else if (radioButton_text.Checked)
            {
                panel1.Visible = false;
                panelLoadTxt.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowseTxt_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object.
            OpenFileDialog openFile1 = new OpenFileDialog();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
