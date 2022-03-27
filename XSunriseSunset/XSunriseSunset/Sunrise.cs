﻿/// <summary>
/// Name:
/// File:
/// Project:
/// Revision Date:
/// </summary>
namespace XSunriseSunset
{
    /// <summary>
    /// 
    /// </summary>
    public class Sunrise
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string solar_noon { get; set; }
        public string day_length { get; set; }
        public string civil_twilight_begin { get; set; }
        public string civil_twilight_end { get; set; }
        public string nautical_twilight_begin { get; set; }
        public string nautical_twilight_end { get; set; }
        public string astronomical_twilight_begin { get; set; }
        public string astronomical_twilight_end { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Sunrises
    {
        public Sunrise results { get; set; }
        public string status { get; set; }
    }
}
