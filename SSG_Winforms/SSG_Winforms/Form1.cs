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

namespace SSG_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // API token x4IHDwrEg5b11yXtRQxj
            var client = new RestClient("https://the-one-api.dev/v2/book");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer x4IHDwrEg5b11yXtRQxj");
            IRestResponse response = client.Execute(request);
            txtTest.Text = response.Content;

            books booksList = JsonConvert.DeserializeObject<books>(response.Content);

            MessageBox.Show($"found {booksList.docs.Count} books");
        }
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

    #endregion
}
