using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Extensions;
using System.IO;

namespace PruebaImagenRes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {



            var client = new RestClient();


            client.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:40.0) Gecko/20100101 Firefox/40.0";

            client.BaseUrl = new Uri("http://127.0.0.1:8001"); //http://192.168.1.3
            var request = new RestRequest();
            //client.Authenticator = new  HttpBasicAuthenticator("admin", "admin");
            request.AddHeader("Authorization", "token " + "a35b94e2c013967424de4f7542603bcbb83f7a96");

            request.Method = Method.GET;
            //request.RequestFormat = DataFormat.Json;
            request.Resource =  txtUrl.Text ;
            var response2 = client.Execute(request);
            client.DownloadData(request).SaveAs(@"C:\Users\Jonatan\Documents\img.jpg");

        }
    }
}
