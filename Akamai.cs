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
                string email ="genauthor@microsoft.com"+ textBox_Email.Text;
                
                string[] fileToPurge = new string[] { textBox_filePath.Text  }; //this is the item in 

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


            // Declare String constr
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox_Choose.Text +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            //Create the connection
            OleDbConnection conn = new OleDbConnection(constr);


            //Create Adapter and 

            OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + textBox_Load.Text + "$]", conn);
            
            DataTable data = new DataTable();
            sda.Fill(data); 
            dataGridView_XL.DataSource = data;




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

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Load.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Waiting Cursor
            Cursor.Current = Cursors.WaitCursor;



            try
            {
                string username = "genauthor@microsoft.com"; 	//use the username to access 
                //the control.akamai.com 
                string password = "L3tm3OutCQ2"; 	//use the password to access the control.
                //akamai.com 
                string email = "genauthor@microsoft.com" + textBox_Email2.Text;

                string[] fileToPurge = new string[] { textBox_Choose_File.Text }; //this is the item in 

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

        private void button_Choose_File_Click(object sender, EventArgs e)
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
                textBox_Choose_File.Text = explore.FileName;
            }
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
    }
}
