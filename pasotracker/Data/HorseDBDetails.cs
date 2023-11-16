using System;

namespace pasotracker.Data
{
    public class HorseDBDetails
    {
        public string Registration { get; set; }
        public string HorseName { get; set; }
        public string DOB { get; set; }
        public string Age { get; set; }
        public string OwnerName { get; set; }
        public string Origin { get; set; }
        public string OtherDetails { get; set; }
    }
    public class HorseCast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
