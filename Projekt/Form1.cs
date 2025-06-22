
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;          
using System.Net.Http;          
namespace Projekt 
{
    public partial class Form1 : Form
    {
        
        string apiKey = "a3ae503556eda100e86ab492a2505817";

        public class WeatherInfo
        {
            public class Main
            {
                public double temp { get; set; }         
                public double feels_like { get; set; }   
                public int pressure { get; set; }         
                public int humidity { get; set; }         
            }

            public class Weather
            {
                public string description { get; set; }
                public string icon { get; set; }
            }

            public class Wind
            {
                public double speed { get; set; }         
            }

            public class Root
            {
                public Main main { get; set; }
                public List<Weather> weather { get; set; }
                public Wind wind { get; set; }           
                public string name { get; set; }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSprawdzPogode_Click(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;
          
            if (string.IsNullOrWhiteSpace(txtMiasto.Text))
            {
                MessageBox.Show("Proszę wpisać nazwę miasta.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                lblStatus.Text = "Status: Pobieram dane...";
               
                using (HttpClient client = new HttpClient())
                {
                   
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={txtMiasto.Text}&appid={apiKey}&units=metric&lang=pl";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {

                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        WeatherInfo.Root info = JsonConvert.DeserializeObject<WeatherInfo.Root>(jsonResponse);

                        lblNazwaMiasta.Text = info.name.ToUpper();
                        lblTemperatura.Text = $"{Math.Round(info.main.temp)}°C"; 
                        lblWarunki.Text = info.weather[0].description; 
                        string szczegoly = $"Odczuwalna: {Math.Round(info.main.feels_like)}°C{Environment.NewLine}" +
                   $"Ciśnienie: {info.main.pressure} hPa{Environment.NewLine}" +
                   $"Wilgotność: {info.main.humidity}%{Environment.NewLine}" +
                   $"Wiatr: {info.wind.speed} m/s";

                        lblSzczegoly.Text = szczegoly;
                        
                        string iconUrl = $"http://openweathermap.org/img/wn/{info.weather[0].icon}@2x.png";
                        byte[] imageData = await client.GetByteArrayAsync(iconUrl);
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            picIkonaPogody.Image = System.Drawing.Image.FromStream(ms);
                        }

                        lblStatus.Text = "Status: Gotowe.";
                    }
                    else
                    {
                       
                        MessageBox.Show("Nie znaleziono miasta lub wystąpił błąd API.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = "Status: Błąd.";
                    }
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Wystąpił błąd połączenia: " + ex.Message, "Błąd Krytyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Błąd połączenia.";
            }
        }
    }
}