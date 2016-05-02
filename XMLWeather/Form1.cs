using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        List<day> days = new List<day>();
        string city, temperatureCurrent, winds, windDesc, windSpeed, minimum, maximum, clouds, rainType;
        string day3, day4, day5;
        Image picture;
        
        public Form1()
        {
            InitializeComponent();

            // get information about current and forecast weather from the internet
            GetData();

            // take info from the current weather file and display it to the screen
            ExtractCurrent();

            // take info from the forecast weather file and display it to the screen
            ExtractForecast();
            
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            //client.DownloadFile(currentFile, "WeatherData.xml");
            //client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "city")
                {
                    city = child.Attributes["name"].Value;
                }

                if (child.Name == "temperature")
                {
                    temperatureCurrent = child.Attributes["value"].Value;
                }

                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "speed")
                        {
                            winds = grandChild.Attributes["name"].Value;
                        }
                    }
                }
            }

            cityOutput.Text = city;
            currentTempOut.Text = temperatureCurrent + "°c";
            windDescOut.Text = winds;

            day3 = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            day4 = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            day5 = DateTime.Now.AddDays(4).DayOfWeek.ToString();

            daySelect.Items.Add(day3);
            daySelect.Items.Add(day4);
            daySelect.Items.Add(day5);
        }

        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;
            int day = 0;
            bool realDAy = false;
            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast") //goes into forecast
                {
                    foreach (XmlNode grandChild in child.ChildNodes) // for each day
                    {

                        switch (day) // this seems really unecessary but it works so it stays
                        {
                            case 0:
                                #region DATA 
                                if (grandChild.Name == "time")
                                {
                                    foreach (XmlNode greatGrandChild in grandChild.ChildNodes) //for each thing in the day
                                    {
                                        if (greatGrandChild.Name == "precipitation")
                                        {
                                            try { rainType = greatGrandChild.Attributes["type"].Value; }
                                            catch { rainType = ""; }
                                        }

                                        if (greatGrandChild.Name == "temperature")
                                        {
                                            minimum = greatGrandChild.Attributes["min"].Value;
                                            maximum = greatGrandChild.Attributes["max"].Value;
                                        }

                                        if (greatGrandChild.Name == "clouds")
                                        {
                                            clouds = greatGrandChild.Attributes["value"].Value;
                                            realDAy = true;
                                        }
                                    }
                                }
                                #endregion
                                day++;
                                break;
                            case 1:
                                #region DATA
                                if (grandChild.Name == "time")
                                {
                                    foreach (XmlNode greatGrandChild in grandChild.ChildNodes) //for each thing in the day
                                    {
                                        if (greatGrandChild.Name == "precipitation")
                                        {
                                            try { rainType = greatGrandChild.Attributes["type"].Value; }
                                            catch { rainType = ""; }
                                        }

                                        if (greatGrandChild.Name == "temperature")
                                        {
                                            minimum = greatGrandChild.Attributes["min"].Value;
                                            maximum = greatGrandChild.Attributes["max"].Value;
                                        }

                                        if (greatGrandChild.Name == "clouds")
                                        {
                                            clouds = greatGrandChild.Attributes["value"].Value;
                                            realDAy = true;
                                        }
                                    }
                                }
                                #endregion
                                day++;
                                break;
                            case 2:
                                #region DATA
                                if (grandChild.Name == "time")
                                {
                                    foreach (XmlNode greatGrandChild in grandChild.ChildNodes) //for each thing in the day
                                    {
                                        if (greatGrandChild.Name == "precipitation")
                                        {
                                            try { rainType = greatGrandChild.Attributes["type"].Value; }
                                            catch { rainType = ""; }
                                        }

                                        if (greatGrandChild.Name == "temperature")
                                        {
                                            minimum = greatGrandChild.Attributes["min"].Value;
                                            maximum = greatGrandChild.Attributes["max"].Value;
                                        }

                                        if (greatGrandChild.Name == "clouds")
                                        {
                                            clouds = greatGrandChild.Attributes["value"].Value;
                                            realDAy = true;
                                        }
                                    }
                                }
                                #endregion
                                day++;
                                break;
                            case 3:
                                #region DATA
                                if (grandChild.Name == "time")
                                {
                                    foreach (XmlNode greatGrandChild in grandChild.ChildNodes) //for each thing in the day
                                    {
                                        if (greatGrandChild.Name == "precipitation")
                                        {
                                            try { rainType = greatGrandChild.Attributes["type"].Value; }
                                            catch { rainType = ""; }
                                        }

                                        if (greatGrandChild.Name == "temperature")
                                        {
                                            minimum = greatGrandChild.Attributes["min"].Value;
                                            maximum = greatGrandChild.Attributes["max"].Value;
                                        }

                                        if (greatGrandChild.Name == "clouds")
                                        {
                                            clouds = greatGrandChild.Attributes["value"].Value;
                                            realDAy = true;
                                        }
                                    }
                                }
                                #endregion
                                day++;
                                break;
                            case 4:
                                #region DATA
                                if (grandChild.Name == "time")
                                {
                                    foreach (XmlNode greatGrandChild in grandChild.ChildNodes) //for each thing in the day
                                    {
                                        if (greatGrandChild.Name == "precipitation")
                                        {
                                            try { rainType = greatGrandChild.Attributes["type"].Value; }
                                            catch { rainType = ""; }
                                        }

                                        if (greatGrandChild.Name == "temperature")
                                        {
                                            minimum = greatGrandChild.Attributes["min"].Value;
                                            maximum = greatGrandChild.Attributes["max"].Value;
                                        }

                                        if (greatGrandChild.Name == "clouds")
                                        {
                                            clouds = greatGrandChild.Attributes["value"].Value;
                                            realDAy = true;
                                        }
                                    }
                                }
                                #endregion
                                day++;
                                break;
                            default:
                                break;
                        }

                        #region set picture
                        if (rainType == "light rain")
                        {
                            picture = Properties.Resources.light_rain;
                        }
                        else if (rainType == "heavy intensity rain")
                        {
                            picture = Properties.Resources.Heavy_Rain;
                        }
                        else if (clouds == "overcast clouds")
                        {
                            picture = Properties.Resources.heavy_cloud;
                        }
                        else if (clouds == "scattered clouds")
                        {
                            picture = Properties.Resources.light_cloud;
                        }
                        else if (clouds == "broken clouds")
                        {
                            picture = Properties.Resources.light_cloud;
                        }
                        else if (clouds == "few clouds")
                        {
                            picture = Properties.Resources.sun_and_cloud;
                        }
                        else
                        {
                            picture = Properties.Resources.sun;
                        }
                        #endregion

                        if (realDAy == true)
                        {
                            day d = new day(windDesc, windSpeed, minimum, maximum, clouds, picture);
                            days.Add(d);
                            realDAy = false;
                        }
                    }
                }
            }

            maxOutput.Text = days[0].maxTemp;
            minOutput.Text = days[0].minTemp;
            day1Clouds.Text = days[0].clouds;
            imageBox.Image = days[0].picture;

        }

        private void daySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point xy = new Point(10, 10);

            if  (daySelect.Text == "Today")
            {
                currentTempOut.Visible = true;
                windDescOut.Visible = true;
                xy = new Point(130, 10);

                maxOutput.Text = days[0].maxTemp;
                minOutput.Text = days[0].minTemp;
                day1Clouds.Text = days[0].clouds;
                imageBox.Image = days[0].picture;
            }
            else
            {
                currentTempOut.Visible = false;
                windDescOut.Visible = false;
                xy = new Point(70, 10);
            }

            imageBox.Location = xy;
            Refresh();

            if (daySelect.Text == "Tomorrow")
            {
                maxOutput.Text = days[1].maxTemp;
                minOutput.Text = days[1].minTemp;
                day1Clouds.Text = days[1].clouds;
                imageBox.Image = days[1].picture;
            }

            if(daySelect.Text == day3)
            {
                maxOutput.Text = days[2].maxTemp;
                minOutput.Text = days[2].minTemp;
                day1Clouds.Text = days[2].clouds;
                imageBox.Image = days[2].picture;
            }

            if (daySelect.Text == day4)
            {
                maxOutput.Text = days[3].maxTemp;
                minOutput.Text = days[3].minTemp;
                day1Clouds.Text = days[3].clouds;
                imageBox.Image = days[3].picture;
            }

            if (daySelect.Text == day5)
            {
                maxOutput.Text = days[4].maxTemp;
                minOutput.Text = days[4].minTemp;
                day1Clouds.Text = days[4].clouds;
                imageBox.Image = days[4].picture;
            }
        }
    }
}
