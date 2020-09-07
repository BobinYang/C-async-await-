using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    WebClient webClient = new WebClient();
        //    string result = webClient.DownloadString("https://www.youtube.com");
        //    textBox1.Text = result;

        //}

        private async void button1_Click(object sender, EventArgs e)
        {
            await GetData2();
            string result = await GetData3();
            Console.WriteLine(result);

            //HttpClient httpClient = new HttpClient();
            //string result = await httpClient.GetStringAsync("https://www.youtube.com");
            //textBox1.Text = result;
        }

        public async void GetData1()
        { }

        public async Task GetData2()
        {
            await Task.Delay(10000);
        }

        public async Task<string> GetData3()
        {
            await Task.Delay(1000);
            return "123";
        }
    }
}