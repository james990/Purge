using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Purge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_purge_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "genauthor@microsoft.com"; 	//use the username to access 
                //the control.akamai.com 
                string password = "L3tm3OutCQ2"; 	//use the password to access the control.
                //akamai.com 
                string email = "email-notification=james.cosgrave@lionbridge.com";
                
                

                string[] fileToPurge = new string[] { textBox_filePath.Text  }; //this is the item in 
                
                
                
                //akamai proxy that you want to purge
                string action = "action=remove"; 	//other value is action=invalidate 
                string domain = "domain=production";//other value is domain=staging 

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
    }
}
