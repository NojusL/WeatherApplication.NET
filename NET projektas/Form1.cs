using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Globalization;


namespace NET_projektas
{
    public partial class Form1 : Form
    {
        public int currentday = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCityCountry_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string city;

            city = txtCity.Text;
            currentday = 0;


            panelhourly.Visible = true;

            temperature.Visible = false;
            forecastminamxtemp.Visible = false;
            fellslike.Visible = true;
            feelslikelabel.Visible = true;
            forecastdaypicture.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            sunrise.Visible = true;
            sunset.Visible = true;
            moonrise.Visible = true;
            moonset.Visible = true;
            txtCurrentTemp.Visible = true;

            var prov = new Provider.Provider();

            txtCurrentTemp.Text = $"{prov.GetCurrentForecast(city, "temp_c")}°C";
            pictureBox1.Image = prov.GetCurrentIcon(city);
            txtCityCountry.Text = prov.GetCityCountry(city);
            button1.Text = prov.GetCurrentDay(city);
            windspeed.Text = prov.GetCurrentForecast(city, "wind_kph");
            percipitation.Text = prov.GetCurrentForecast(city, "precip_mm");
            humidity.Text = prov.GetCurrentForecast(city, "humidity");
            uvrating.Text = prov.GetCurrentForecast(city, "uv");
            fellslike.Text = $"{prov.GetCurrentForecast(city, "feelslike_c")}°C";
            sunrise.Text = prov.GetSelectedForecast(city, 0, "sunrise");
            sunset.Text = prov.GetSelectedForecast(city, 0, "sunset");
            moonrise.Text = prov.GetSelectedForecast(city, 0, "moonrise");
            moonset.Text = prov.GetSelectedForecast(city, 0, "moonset");

            int caseSwitch = 0;
            foreach (string formattedday in prov.GetForecastDays(city))
            {
                switch (caseSwitch)
                {
                    case 0:
                        dayboxFirst.Text = formattedday;
                        caseSwitch++;
                        break;
                    case 1:
                        dayboxSecond.Text = formattedday;
                        caseSwitch++;
                        break;
                    case 2:
                        dayboxThird.Text = formattedday;
                        caseSwitch = 0;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            foreach (Bitmap forecastIcon in prov.GetForecastIcon(city))
            {
                switch (caseSwitch)
                {
                    case 0:
                        pictureBoxFirst.Image = forecastIcon;
                        caseSwitch++;
                        break;
                    case 1:
                        pictureBoxSecond.Image = forecastIcon;
                        caseSwitch++;
                        break;
                    case 2:
                        pictureBoxThird.Image = forecastIcon;
                        caseSwitch = 0;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            foreach (string forecasttemp in prov.GetForecastTemp(city, "maxtemp_c"))
            {
                switch (caseSwitch)
                {
                    case 0:
                        Temp1.Text = $"{forecasttemp}°C";
                        caseSwitch++;
                        break;
                    case 1:
                        Temp2.Text = $"{forecasttemp}°C";
                        caseSwitch++;
                        break;
                    case 2:
                        Temp3.Text = $"{forecasttemp}°C";
                        caseSwitch++;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrentTemp_Click(object sender, EventArgs e)
        {

        }

        private void Temp1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFirst_Click(object sender, EventArgs e)
        {

        }

        private void dayboxFirst_Click(object sender, EventArgs e)
        {
            string city;

            city = txtCity.Text;

            currentday = 0;


            temperature.Visible = true;
            forecastminamxtemp.Visible = true;
            fellslike.Visible = false;
            feelslikelabel.Visible = false;
            forecastdaypicture.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            sunrise.Visible = true;
            sunset.Visible = true;
            moonrise.Visible = true;
            moonset.Visible = true;
            var prov = new Provider.Provider();

            forecastminamxtemp.Text = $"{prov.GetSelectedForecast(city, 0, "mintemp_c")}°C / {prov.GetSelectedForecast(city, 0, "maxtemp_c")}°C";
            windspeed.Text = prov.GetSelectedForecast(city, 0, "maxwind_kph");
            percipitation.Text = prov.GetSelectedForecast(city, 0, "totalprecip_mm");
            humidity.Text = prov.GetSelectedForecast(city, 0, "avghumidity");
            uvrating.Text = prov.GetSelectedForecast(city, 0, "uv");
            forecastdaypicture.Image = prov.GetSelectedForecastIcon(city, 0);
            sunrise.Text = prov.GetSelectedForecast(city, 0, "sunrise");
            sunset.Text = prov.GetSelectedForecast(city, 0, "sunset");
            moonrise.Text = prov.GetSelectedForecast(city, 0, "moonrise");
            moonset.Text = prov.GetSelectedForecast(city, 0, "moonset");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string city;

            city = txtCity.Text;

            currentday = 1; 

            temperature.Visible = false;
            forecastminamxtemp.Visible = false;
            fellslike.Visible = true;
            feelslikelabel.Visible = true;
            forecastdaypicture.Visible = false;

            var prov = new Provider.Provider();
            txtCurrentTemp.Text = $"{prov.GetCurrentForecast(city, "temp_c")}°C";
            pictureBox1.Image = prov.GetCurrentIcon(city);
            windspeed.Text = prov.GetCurrentForecast(city, "wind_kph");
            percipitation.Text = prov.GetCurrentForecast(city, "precip_mm");
            humidity.Text = prov.GetCurrentForecast(city, "humidity");
            uvrating.Text = prov.GetCurrentForecast(city, "uv");
            fellslike.Text = $"{prov.GetCurrentForecast(city, "feelslike_c")}°C";
        }

        private void dayboxSecond_Click(object sender, EventArgs e)
        {
            string city;

            city = txtCity.Text;

            
            temperature.Visible = true;
            forecastminamxtemp.Visible = true;
            fellslike.Visible = false;
            feelslikelabel.Visible = false;
            forecastdaypicture.Visible = true;
            var prov = new Provider.Provider();

            forecastminamxtemp.Text = $"{prov.GetSelectedForecast(city, 1, "mintemp_c")}°C / {prov.GetSelectedForecast(city, 1, "maxtemp_c")}°C";
            windspeed.Text = prov.GetSelectedForecast(city, 1, "maxwind_kph");
            percipitation.Text = prov.GetSelectedForecast(city, 1, "totalprecip_mm");
            humidity.Text = prov.GetSelectedForecast(city, 1, "avghumidity");
            uvrating.Text = prov.GetSelectedForecast(city, 1, "uv");
            forecastdaypicture.Image = prov.GetSelectedForecastIcon(city, 1);
            sunrise.Text = prov.GetSelectedForecast(city, 1, "sunrise");
            sunset.Text = prov.GetSelectedForecast(city, 1, "sunset");
            moonrise.Text = prov.GetSelectedForecast(city, 1, "moonrise");
            moonset.Text = prov.GetSelectedForecast(city, 1, "moonset");

        }

        private void dayboxThird_Click(object sender, EventArgs e)
        {
            string city;

            city = txtCity.Text;

            currentday = 2;

            temperature.Visible = true;
            forecastminamxtemp.Visible = true;
            fellslike.Visible = false;
            feelslikelabel.Visible = false;
            forecastdaypicture.Visible = true;
            var prov = new Provider.Provider();

            forecastminamxtemp.Text = $"{prov.GetSelectedForecast(city, 2, "mintemp_c")}°C / {prov.GetSelectedForecast(city, 2, "maxtemp_c")}°C";
            windspeed.Text = prov.GetSelectedForecast(city, 2, "maxwind_kph");
            percipitation.Text = prov.GetSelectedForecast(city, 2, "totalprecip_mm");
            humidity.Text = prov.GetSelectedForecast(city, 2, "avghumidity");
            uvrating.Text = prov.GetSelectedForecast(city, 2, "uv");
            forecastdaypicture.Image = prov.GetSelectedForecastIcon(city, 2);
            sunrise.Text = prov.GetSelectedForecast(city, 2, "sunrise");
            sunset.Text = prov.GetSelectedForecast(city, 2, "sunset");
            moonrise.Text = prov.GetSelectedForecast(city, 2, "moonrise");
            moonset.Text = prov.GetSelectedForecast(city, 2, "moonset");

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string city;

            city = txtCity.Text;

            var prov = new Provider.Provider();

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (var suggestion in prov.GetSuggestedCityCollection(city))
            {
                col.Add(suggestion);
            }

            txtCity.AutoCompleteCustomSource = col;
            txtCity.Focus();
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelhourly.Visible = false;
            panel1.Visible = true;
            tempreturebutton.Visible = true;
            percipitationbutton.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelhourly.Visible = true;
            tempreturebutton.Visible = false;
            percipitationbutton.Visible = false;
          //  panel1.Visible = false;
        }
    }
}
