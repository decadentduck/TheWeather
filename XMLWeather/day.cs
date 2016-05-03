using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace XMLWeather
{
    public class day
    {
        public string clouds, windSpeed, minTemp, maxTemp;
        public Image picture;

        public day(string _windSpeed, string _min, string _max, string _clouds, Image _picture)
        {
            windSpeed = _windSpeed;
            minTemp = _min;
            maxTemp = _max;
            clouds = _clouds;
            picture = _picture;
        }
    }
    
}
