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
using System.Net;

namespace SquareApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
        }

        //Trigger change color by calling API
        private void btnTrigger_Click(object sender, EventArgs e)
        {
            //Pointing to API
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44313/");
            HttpResponseMessage response = client.GetAsync("api/Test?color=yellow").Result;
            if (response.IsSuccessStatusCode)
            {
                //panelBox.BackColor = Color.Yellow;
                var result = response.Content.ReadAsStringAsync();
                var str = result.Result;
                if (str != "")
                {
                    panelBox.BackColor = Color.FromName(str); ;
                }
            }
        }
    }
}
