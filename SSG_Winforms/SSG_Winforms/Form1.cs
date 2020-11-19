using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using RestSharp;
using System.Web.UI.WebControls;

namespace SSG_Winforms
{
    public partial class Form1 : Form
    {
        //Settings which may be re-used
        public string apiBaseUrl = "https://the-one-api.dev/v2";
        private string apiToken = "x4IHDwrEg5b11yXtRQxj";
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Call API using CONTAINS operator (generally most user friendly)
            var client = new RestClient($"{apiBaseUrl}/book?name=/{txtBookName.Text}/i");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {apiToken}");
            IRestResponse response = client.Execute(request);

            books booksList = JsonConvert.DeserializeObject<books>(response.Content);

            //Put results into listbox
            lbBooksResult.Items.Clear();

            foreach (book b in booksList.docs)
            {
                ListItem item = new ListItem();
                item.Text = b.name;
                item.Value = b._id;
                lbBooksResult.Items.Add(item);
            }
        }

    
        #region Events
        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void lbBooksResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBooksResult.SelectedItem != null)
            {
                //Call API - Get chapters for book
                var client = new RestClient($"{apiBaseUrl}/chapter?book={lbBooksResult.SelectedValue}");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", $"Bearer {apiToken}");
                IRestResponse response = client.Execute(request);

                chapters chaptersList = JsonConvert.DeserializeObject<chapters>(response.Content);

                //Put results into listbox
                lbChaptersResult.Items.Clear();

                foreach (chapter c in chaptersList.docs)
                {
                    ListItem item = new ListItem();
                    item.Text = c.chapterName;
                    item.Value = c._id;
                    lbChaptersResult.Items.Add(item);
                }
            }
        }
        #endregion
    }

    #region ObjectDefinitions

    public class book
    {
        public string _id { get; set; }
        public string name { get; set; }
    }

    public class books
    {
        public List<book> docs { get; set; }
        public int total { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int page { get; set; }
        public int pages { get; set; }
    }

    public class chapter
    {
        public string _id { get; set; }
        public string chapterName { get; set; }
        public string book { get; set; }
    }

    public class chapters
    {
        public List<chapter> docs { get; set; }
        public int total { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int page { get; set; }
        public int pages { get; set; }
    }

    #endregion
}
