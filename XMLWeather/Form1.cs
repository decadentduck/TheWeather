﻿using System;
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
        string city, temperatureCurrent, winds, windSpeed, minimum, maximum, clouds, windDirection;
        string day3, day4, day5;
        Image picture;

        int i = 0;
        

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
                if (child.Name == "city")
                {
                    city = child.Attributes["name"].Value;
                }

                if (child.Name == "temperature")
                {
                    temperatureCurrent = Convert.ToString(
                        Math.Round(Convert.ToDouble(child.Attributes["value"].Value)));
                }

                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "speed")
                        {
                            winds = grandChild.Attributes["name"].Value;
                            windSpeed = Convert.ToString(
                                Math.Round(Convert.ToDouble(grandChild.Attributes["value"].Value)*3.6));
                        }
                        if (grandChild.Name == "direction")
                        {
                            windDirection = grandChild.Attributes["name"].Value;
                        }
                    }
                }
            }

            cityOutput.Text = city;
            currentTempOut.Text = temperatureCurrent + "°c";
            windDescOut.Text = winds;
            windSpeedOutput.Text = windSpeed + " km/h " + windDirection;
            dateOutput.Text = DateTime.Now.ToString("dd-MM-yy");

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
            //int day = 0;
            bool realDAy = false;
            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast") //goes into forecast
                {
                    foreach (XmlNode grandChild in child.ChildNodes) // for each day
                    {
                        #region DATA
                        if (grandChild.Name == "time")
                        {
                            foreach (XmlNode greatGrandChild in grandChild.ChildNodes) //for each thing in the day
                            {
                                if (greatGrandChild.Name == "symbol")
                                {
                                    clouds = greatGrandChild.Attributes["name"].Value;
                                }

                                if (greatGrandChild.Name == "temperature")
                                {
                                    minimum = "low of " + Convert.ToString(
                                        Math.Round(Convert.ToDouble(greatGrandChild.Attributes["min"].Value)));
                                    maximum = "high of " + Convert.ToString(
                                        Math.Round(Convert.ToDouble(greatGrandChild.Attributes["max"].Value)));
                                    realDAy = true;
                                }
                            }
                        }
                        #endregion

                        #region set picture
                        if (clouds == "light rain")
                        {
                            picture = Properties.Resources.light_rain;
                        }
                        else if (clouds == "thunderstorm")
                        {
                            picture = Properties.Resources.thunderstorm;
                        }
                        else if (clouds == "heavy intensity rain")
                        {
                            picture = Properties.Resources.Heavy_Rain;
                        }
                        else if (clouds == "moderate rain")
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
                        else if (clouds == "clear sky")
                        {
                            picture = Properties.Resources.sun;
                        }
                        else if (clouds == "fog")
                        {
                            picture = Properties.Resources.fog;
                        }
                        else if (clouds == "light snow")
                        {
                            picture = Properties.Resources.light_snow;
                        }
                        else if (clouds == "heavy snow")
                        {
                            picture = Properties.Resources.heavy_snow;
                        }
                        else
                        {
                            picture = Properties.Resources.hail;
                        }
                        #endregion

                        if (realDAy == true)
                        {
                            day d = new day(windSpeed, minimum, maximum, clouds, picture);
                            days.Add(d);
                            realDAy = false;
                        }
                    }
                }
            }
            
            maxOutput.Text = days[i].maxTemp + "°c";
            minOutput.Text = days[i].minTemp + "°c";
            day1Clouds.Text = days[i].clouds;
            imageBox.Image = days[i].picture;

        }

        private void daySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point xy = new Point(10, 10);
            
            if  (daySelect.Text == "Today")
            {
                i = 0;
                currentTempOut.Visible = true;
                windDescOut.Visible = true;
                windSpeedOutput.Visible = true;
                xy = new Point(130, 10);
            }
            else
            {
                currentTempOut.Visible = false;
                windDescOut.Visible = false;
                windSpeedOutput.Visible = false;
                xy = new Point(90, 10);
            }

            imageBox.Location = xy;
            Refresh();

            if (daySelect.Text == "Tomorrow") { i = 1; }

            if (daySelect.Text == day3) { i = 2; }

            if (daySelect.Text == day4) { i = 3; }

            if (daySelect.Text == day5) { i = 4; }

            maxOutput.Text = days[i].maxTemp + "°c";
            minOutput.Text = days[i].minTemp + "°c";
            day1Clouds.Text = days[i].clouds;
            imageBox.Image = days[i].picture;
        }
    }
}
