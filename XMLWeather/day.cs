using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace XMLWeather
{
    public class day
    {
        public string windDescription, clouds, windSpeed, minTemp, maxTemp;
        public Image picture;

        public day(string _windDesc, string _windSpeed, string _min, string _max, string _clouds, Image _picture)
        {
            windDescription = _windDesc;
            windSpeed = _windSpeed;
            minTemp = _min;
            maxTemp = _max;
            clouds = _clouds;
            picture = _picture;
        }
    }
    
}
