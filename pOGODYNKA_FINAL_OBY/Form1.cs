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
using System.Net;


namespace pOGODYNKA_FINAL_OBY
{
    public partial class Pogodynka : Form
    {
        public Pogodynka()
        {
            InitializeComponent();
        }

        string APIKey = "d4cd9846ac476600922516c7c5b89eb5";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labDetails_Click(object sender, EventArgs e)
        {

        }

        private void WyszukiwanieButton_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", Wyszukiwanie.Text, APIKey);
                try
                {
                    var json = web.DownloadString(url);
                    PogodaInfo.Root Info = JsonConvert.DeserializeObject<PogodaInfo.Root>(json);
                    picIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labCondition.Text = Info.weather[0].main;
                    labDetails.Text = Info.weather[0].description;
                    labSunset.Text = convertDate(Info.sys.sunset).ToShortTimeString();
                    labSunrise.Text = convertDate(Info.sys.sunrise).ToShortTimeString();
                    labWindSpeed.Text = Info.wind.speed.ToString();
                    labPressure.Text = Info.main.pressure.ToString();
                    double temperatura =  Math.Round(Info.main.temp - 273.15, 1);  
                    labTemperature.Text = temperatura.ToString() + " C";
                    
                }
                catch
                {
                    labCondition.Text = "Nie znaleziono lokacji!";
                }
            }
        }

        DateTime convertDate(long s)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            return day.AddSeconds(s).ToLocalTime();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
