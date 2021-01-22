using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace Provider
{

    public interface WeatherApiProvider
    {
        string GetCurrentXML(string city);
        Bitmap GetCurrentIcon(string city);
        string GetCityCountry(string city);
        string GetCurrentDay(string city);

        List<string> GetForecastDays(string city);

        List<Bitmap> GetForecastIcon();
       
        List<string> GetForecastTemp(string city, string apiParameter);

        string GetSelectedForecast(string city, int dayparameter, string apiParameter);

        string GetCurrentForecast(string city, string apiParameter);
        
    }

    public class Provider : WeatherApiProvider
    {
        private const string apikey = "34c5743e734243d99c5230222211601";
        public string currenttempretaru = "";
        public XDocument currentforecastXMLDocument;
        public XDocument forecastXMLDocument;
        public List<string> Hourlyparameterresponse = new List<string>();

        public void GetCurrentXML(string city)
        {
            string uri = string.Format("http://api.weatherapi.com/v1/current.xml?key=" + apikey + "&q=" + city);

            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = client.GetAsync(uri).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    XDocument xDocument = XDocument.Parse(response.Content.ReadAsStringAsync().Result);
                    currentforecastXMLDocument = xDocument;
                }

            }



        }

        public void GetForecastXML(string city)
        {
            string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=" + apikey + "&q=" + city + "&days=3");
            List<string> parameterresponse = new List<string>();
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = client.GetAsync(uri).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    XDocument xdoc = XDocument.Parse(response.Content.ReadAsStringAsync().Result);

                    forecastXMLDocument = xdoc;

                }
            }
        }



        public Bitmap GetCurrentIcon(string city)
        {
            string currenticonUri = (string)currentforecastXMLDocument.Descendants("icon").FirstOrDefault();

            Bitmap icon = GetIconFromWeb(currenticonUri);

            return icon;
        }

        public List<Bitmap> GetForecastIcon()
        {
            List<string> parameterrespose = new List<string>();
            foreach (var npc in forecastXMLDocument.Descendants("forecastday"))
            {
                string currenttempResponse = (string)npc.Descendants("icon").FirstOrDefault();
                parameterrespose.Add(currenttempResponse);
            }
            List<string> currenticonUri = parameterrespose;

            List<Bitmap> iconsList = new List<Bitmap>();

            foreach (string iconvalue in currenticonUri)
            {
                iconsList.Add(GetIconFromWeb(iconvalue));
            }
            return iconsList;
        }

        public List<Bitmap> GetHourlyIcon()
        {

            List<Bitmap> iconsList = new List<Bitmap>();

            foreach (string iconvalue in Hourlyparameterresponse)
            {
                iconsList.Add(GetIconFromWeb(iconvalue));
            }
            return iconsList;
        }

        public Bitmap GetIconFromWeb(string iconlink)
        {
            WebClient client = new WebClient();

            byte[] image = client.DownloadData("http:" + iconlink);

            MemoryStream stream = new MemoryStream(image);

            Bitmap newBitMap = new Bitmap(stream);

            Bitmap icon = newBitMap;

            return icon;

        }

        public Bitmap GetSelectedForecastIcon(int dayparameter)
        {
            List<Bitmap> selectedIconList = GetForecastIcon();
            Bitmap selectedIcon = selectedIconList[dayparameter];

            return selectedIcon;
        }

        public String GetCityCountry(string city)
        {

            string currentCity =  (string)currentforecastXMLDocument.Descendants("name").FirstOrDefault();
            string currentCountry = (string)currentforecastXMLDocument.Descendants("country").FirstOrDefault();
            string result = currentCity + ", " + currentCountry;

            return result;
        }

        public String GetCurrentDay(string city)
        {
            
            string localtime = (string)currentforecastXMLDocument.Descendants("localtime").FirstOrDefault();

            string[] vs1 = localtime.Split(' ');
            string[] vs = vs1[0].Split('-');

            string year = vs[0];
            string month = vs[1];
            string day = vs[2];
            DateTime dateValue = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            string currentDay = dateValue.ToString("dddd", new CultureInfo("en-EN"));

            return currentDay;
        }

        public List<string> GetForecastDays(string city)
        {
            List<string> parameterresponse = new List<string>();

            List<string> parameterrespose = new List<string>();
            foreach (var npc in forecastXMLDocument.Descendants("forecastday"))
            {
                string currenttempResponse = (string)npc.Descendants("date").FirstOrDefault();
                parameterresponse.Add(currenttempResponse);
            }
            List<string> formatteddays = new List<string>();
            foreach (string dayvalue in parameterresponse)
            {
                string[] vs1 = dayvalue.Split(' ');
                string[] vs = vs1[0].Split('-');

                string year = vs[0];
                string month = vs[1];
                string day = vs[2];
                DateTime dateValue = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                formatteddays.Add(dateValue.ToString("ddd", new CultureInfo("en-EN")));
            }
            return formatteddays;
        }
        public List<string> GetForecastTemp(string city, string apiParameter)
        {
           
            List<string> parameterrespose = new List<string>();
            foreach (var npc in forecastXMLDocument.Descendants("forecastday"))
            {
                string currenttempResponse = (string)npc.Descendants(apiParameter).FirstOrDefault();
                parameterrespose.Add(currenttempResponse);
            }
            List<string> daysTemp = new List<string>();
            foreach (string daytemp in parameterrespose)
            {
                daysTemp.Add(daytemp);
            }
            return daysTemp;
        }

        public List<string> GetHourlyResults( string apiParameter, int day)
        {
            Hourlyparameterresponse.Clear();

            int dayswitch = 0;
            int hourswitch = 3;
            foreach (var npc in forecastXMLDocument.Descendants("forecastday"))
            {
                if(day != dayswitch)
                {
                    dayswitch++;
                    continue;
                    
                }
                        foreach (var tparameter in npc.Descendants("hour"))
                        {
                                if(hourswitch == 3)
                                { 
                                Hourlyparameterresponse.Add((string)tparameter.Descendants(apiParameter).FirstOrDefault());
                                hourswitch = 0;
                                }
                    hourswitch++;

                }

            }


            return Hourlyparameterresponse;
        }

        public string GetSelectedForecast(string city, int dayparameter, string apiParameter)
        {
            List<string> forecastList = GetForecastTemp(city, apiParameter);
            string forecastresult = forecastList[dayparameter];
            return forecastresult;
        }

        public string GetCurrentForecast(string city, string apiParameter)
        {
            string currenttempResponse = (string)currentforecastXMLDocument.Descendants(apiParameter).FirstOrDefault();

            return currenttempResponse;
        }


        string WeatherApiProvider.GetCurrentXML(string city)
        {
            throw new NotImplementedException();
        }
    }
}