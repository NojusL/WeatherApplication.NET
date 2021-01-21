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
        public string city ="";
        Provider.Provider prov = new Provider.Provider();




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

            

            prov.GetCurrentXML(city);
            prov.GetForecastXML(city);

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
            foreach (Bitmap forecastIcon in prov.GetForecastIcon())
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


            forecastminamxtemp.Text = $"{prov.GetSelectedForecast(city, 0, "mintemp_c")}°C / {prov.GetSelectedForecast(city, 0, "maxtemp_c")}°C";
            windspeed.Text = prov.GetSelectedForecast(city, 0, "maxwind_kph");
            percipitation.Text = prov.GetSelectedForecast(city, 0, "totalprecip_mm");
            humidity.Text = prov.GetSelectedForecast(city, 0, "avghumidity");
            uvrating.Text = prov.GetSelectedForecast(city, 0, "uv");
            forecastdaypicture.Image = prov.GetSelectedForecastIcon(0);
            sunrise.Text = prov.GetSelectedForecast(city, 0, "sunrise");
            sunset.Text = prov.GetSelectedForecast(city, 0, "sunset");
            moonrise.Text = prov.GetSelectedForecast(city, 0, "moonrise");
            moonset.Text = prov.GetSelectedForecast(city, 0, "moonset");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            currentday = 0;

            temperature.Visible = false;
            forecastminamxtemp.Visible = false;
            fellslike.Visible = true;
            feelslikelabel.Visible = true;
            forecastdaypicture.Visible = false;

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
            currentday = 1;
            temperature.Visible = true;
            forecastminamxtemp.Visible = true;
            fellslike.Visible = false;
            feelslikelabel.Visible = false;
            forecastdaypicture.Visible = true;


            forecastminamxtemp.Text = $"{prov.GetSelectedForecast(city, 1, "mintemp_c")}°C / {prov.GetSelectedForecast(city, 1, "maxtemp_c")}°C";
            windspeed.Text = prov.GetSelectedForecast(city, 1, "maxwind_kph");
            percipitation.Text = prov.GetSelectedForecast(city, 1, "totalprecip_mm");
            humidity.Text = prov.GetSelectedForecast(city, 1, "avghumidity");
            uvrating.Text = prov.GetSelectedForecast(city, 1, "uv");
            forecastdaypicture.Image = prov.GetSelectedForecastIcon( 1);
            sunrise.Text = prov.GetSelectedForecast(city, 1, "sunrise");
            sunset.Text = prov.GetSelectedForecast(city, 1, "sunset");
            moonrise.Text = prov.GetSelectedForecast(city, 1, "moonrise");
            moonset.Text = prov.GetSelectedForecast(city, 1, "moonset");

        }

        private void dayboxThird_Click(object sender, EventArgs e)
        {

            currentday = 2;

            

            temperature.Visible = true;
            forecastminamxtemp.Visible = true;
            fellslike.Visible = false;
            feelslikelabel.Visible = false;
            forecastdaypicture.Visible = true;

            forecastminamxtemp.Text = $"{prov.GetSelectedForecast(city, 2, "mintemp_c")}°C / {prov.GetSelectedForecast(city, 2, "maxtemp_c")}°C";
            windspeed.Text = prov.GetSelectedForecast(city, 2, "maxwind_kph");
            percipitation.Text = prov.GetSelectedForecast(city, 2, "totalprecip_mm");
            humidity.Text = prov.GetSelectedForecast(city, 2, "avghumidity");
            uvrating.Text = prov.GetSelectedForecast(city, 2, "uv");
            forecastdaypicture.Image = prov.GetSelectedForecastIcon(2);
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

            pictureBoxHour0.Visible = true;
            pictureBoxHour3.Visible = true;
            pictureBoxHour6.Visible = true;
            pictureBoxHour9.Visible = true;
            pictureBoxHour12.Visible = true;
            pictureBoxHour15.Visible = true;
            pictureBoxHour18.Visible = true;
            pictureBoxHour21.Visible = true;

            HourLabel0.Visible = true;
            HourLabel3.Visible = true;
            HourLabel6.Visible = true;
            HourLabel9.Visible = true;
            HourLabel12.Visible = true;
            HourLabel15.Visible = true;
            HourLabel18.Visible = true;
            HourLabel21.Visible = true;

            Hour0.Visible = true;
            Hour3.Visible = true;
            Hour6.Visible = true;
            Hour9.Visible = true;
            Hour12.Visible = true;
            Hour15.Visible = true;
            Hour18.Visible = true;
            Hour21.Visible = true;



            int labelset = 0;
            int caseswith = 0;

            foreach (var hourtemp in prov.GetHourlyResults("temp_c", currentday))
            {
                switch (caseswith)
                {
                    case 0:
                        HourLabel0.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    case 1:
                        HourLabel3.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    case 2:
                        HourLabel6.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    case 3:
                        HourLabel9.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    case 4:
                        HourLabel12.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    case 5:
                        HourLabel15.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    case 6:
                        HourLabel18.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    case 7:
                        HourLabel21.Text = $"{hourtemp} °C";
                        caseswith++;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            caseswith = 0;
            prov.GetHourlyResults("icon", currentday);
            foreach (Bitmap forecastIcon in prov.GetHourlyIcon())
            {
                switch (caseswith)
                {
                    case 0:
                        pictureBoxHour0.Image = forecastIcon;
                        caseswith++;
                        break;
                    case 1:
                        pictureBoxHour3.Image = forecastIcon;
                        caseswith++;
                        break;
                    case 2:
                        pictureBoxHour6.Image = forecastIcon;
                        caseswith++;
                        break;
                    case 3:
                        pictureBoxHour9.Image = forecastIcon;
                        caseswith++;
                        break;
                    case 4:
                        pictureBoxHour12.Image = forecastIcon;
                        caseswith++;
                        break;
                    case 5:
                        pictureBoxHour15.Image = forecastIcon;
                        caseswith++;
                        break;
                    case 6:
                        pictureBoxHour18.Image = forecastIcon;
                        caseswith++;
                        break;
                    case 7:
                        pictureBoxHour21.Image = forecastIcon;
                        caseswith++;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelhourly.Visible = true;
            pictureBoxHour0.Visible = false;
            pictureBoxHour3.Visible = false;
            pictureBoxHour6.Visible = false;
            pictureBoxHour9.Visible = false;
            pictureBoxHour12.Visible = false;
            pictureBoxHour15.Visible = false;
            pictureBoxHour18.Visible = false;
            pictureBoxHour21.Visible = false;

            HourLabel0.Visible = false;
            HourLabel3.Visible = false;
            HourLabel6.Visible = false;
            HourLabel9.Visible = false;
            HourLabel12.Visible = false;
            HourLabel15.Visible = false;
            HourLabel18.Visible = false;
            HourLabel21.Visible = false;

            Hour0.Visible = false;
            Hour3.Visible = false;
            Hour6.Visible = false;
            Hour9.Visible = false;
            Hour12.Visible = false;
            Hour15.Visible = false;
            Hour18.Visible = false;
            Hour21.Visible = false;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
