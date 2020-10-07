using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////WEb Api Veri Çekmek için kullandığımız kod parcacığı
            var client = new RestClient("https://localhost:44340/api/Kisi");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token","5e158554-1c60-41c8-867f-58dde746979f");
            request.AddHeader("cache-control","no-cache");
            IRestResponse response = client.Execute(request);

            //Json formatında çıktı oluşturmak için JToken kellanırız
            JToken j = JToken.Parse(response.Content);
            rtbGetData.Text = j.ToString();
        }
    }
}
