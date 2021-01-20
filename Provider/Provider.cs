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

        List<string> GetForecastXML(string city, string parameter);

        List<string> GetForecastDays(string city);

        List<Bitmap> GetForecastIcon(string city);

        List<string> GetForecastTemp(string city, string apiParameter);

        string GetSelectedForecast(string city, int dayparameter, string apiParameter);

        string GetCurrentForecast(string city, string apiParameter);

        List<String> GetSuggestedCityCollection(string city);

    }

    public class Provider : WeatherApiProvider
    {
        private const string apikey = "34c5743e734243d99c5230222211601";

        public String GetCurrentXML(string city, string parameter)
        {
            string uri = string.Format("http://api.weatherapi.com/v1/current.xml?key=" + apikey + "&q=" + city);
            string parameterresponse = null;
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = client.GetAsync(uri).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    XDocument xdoc = XDocument.Parse(response.Content.ReadAsStringAsync().Result);

                    string currenttempResponse = (string)xdoc.Descendants(parameter).FirstOrDefault();

                    parameterresponse = currenttempResponse;
                }

            }
            
            return parameterresponse;


        }

        public List<string> GetForecastXML(string city, string parameter)
        {
            string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=" + apikey + "&q=" + city + "&days=3");
            List<string> parameterresponse = new List<string>();
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = client.GetAsync(uri).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    XDocument xdoc = XDocument.Parse(response.Content.ReadAsStringAsync().Result);

                    foreach (var npc in xdoc.Descendants("forecastday"))
                    {
                        string currenttempResponse = (string)npc.Descendants(parameter).FirstOrDefault();
                        parameterresponse.Add(currenttempResponse);
                    }

                }

                return parameterresponse;


            }
        }

        public List<String> GetSuggestedCityCollection(string city)
        {
            string uri = string.Format("http://api.weatherapi.com/v1/search.xml?key=" + apikey + "&q=" + city);
            List<string> parameterresponse = new List<string>();
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = client.GetAsync(uri).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    XDocument xdoc = XDocument.Parse(response.Content.ReadAsStringAsync().Result);


                    foreach (var npc in xdoc.Descendants("geo"))
                    {
                        string currenttempResponse = (string)npc.Descendants("name").FirstOrDefault();
                        parameterresponse.Add(currenttempResponse);
                    }
                }

            }

            return parameterresponse;


        }

        public Bitmap GetCurrentIcon(string city)
        {
            string currenticonUri = GetCurrentXML(city, "icon");

            WebClient client = new WebClient();

            byte[] image = client.DownloadData("http:" + currenticonUri);

            MemoryStream stream = new MemoryStream(image);

            Bitmap newBitMap = new Bitmap(stream);

            Bitmap icon = newBitMap;

            return icon;
        }

        public List<Bitmap> GetForecastIcon(string city)
        {
            List <string> currenticonUri = GetForecastXML(city, "icon");

            List<Bitmap> iconsList = new List<Bitmap>();

            foreach (string iconvalue in currenticonUri)
            {
                WebClient client = new WebClient();

                byte[] image = client.DownloadData("http:" + iconvalue);

                MemoryStream stream = new MemoryStream(image);

                Bitmap newBitMap = new Bitmap(stream);

                Bitmap icon = newBitMap;

                iconsList.Add(icon);
            }
            return iconsList;
        }

        public Bitmap GetSelectedForecastIcon(string city, int dayparameter)
        {
            List<Bitmap> selectedIconList = GetForecastIcon(city);
            Bitmap selectedIcon = selectedIconList[dayparameter];

            return selectedIcon;
        }

        public String GetCityCountry(string city)
        {
            string currentCity = GetCurrentXML(city, "name");
            string currentCountry = GetCurrentXML(city, "country");
            string result = currentCity + ", " + currentCountry;

            return result;
        }

        public String GetCurrentDay(string city)
        {
            string localtime = GetCurrentXML(city, "localtime");

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
            parameterresponse = GetForecastXML(city, "date");
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
            List<string> parameterresponse = GetForecastXML(city, apiParameter);
            List<string> daysTemp = new List<string>();
            foreach (string daytemp in parameterresponse)
            {
                daysTemp.Add(daytemp);
            }
            return daysTemp;
        }

        public string GetSelectedForecast(string city, int dayparameter, string apiParameter)
        {
            List<string> forecastList = GetForecastTemp(city, apiParameter);
            string forecastresult = forecastList[dayparameter];
            return forecastresult;
        }

        public string GetCurrentForecast(string city, string apiParameter)
        {
            string currentforecastresult = GetCurrentXML(city, apiParameter);
             
            return currentforecastresult;
        }


        string WeatherApiProvider.GetCurrentXML(string city)
        {
            throw new NotImplementedException();
        }
    }
}
