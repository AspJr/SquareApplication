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

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44313/");
            HttpResponseMessage response = client.GetAsync("api/Test?color=black").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync();
                var str = result.Result;
                if (str != "")
                {
                    panelBox.BackColor = Color.FromName(str); 
                }
            }
        }
    }
}
