using System;
using System.Linq;
using System.Threading.Tasks;

namespace pasotracker.Data
{
    public class HorseService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Registration = new[]
       {
            "1001", "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009", "1010"
        };
        private static readonly string[] HorseName = new[]
        {
            "Horse-01", "Horse-02", "Horse-03", "Horse-04", "Horse-05", "Horse-06", "Horse-07", "Horse-08", "Horse-09", "Horse-10"
        };

        private static readonly string[] Origin = new[]
        {
            "Louisville", "Chicago", "W Virgenia", "Texas", "Germany", "Indian", "African", "Chicago", "African", "Germany"
        };

        private static readonly string[] OwnerName = new[]
        {
            "Monty", "Dan jakson", "Monty", "Eric Elwin", "Monty", "Teressa Wilson", "Markus Bell", "Jhon Doe", "Jenny P", "Thomas Clinton"
        };

        public Task<HorseCast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new HorseCast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }


        public Task<HorseDBDetails[]> GetHorseDetailsAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new HorseDBDetails
            {
                Registration = Registration[index - 1],
                HorseName = HorseName[index - 1],
                Origin = Origin[index - 1],
                OwnerName = OwnerName[index - 1],
                DOB = DateTime.Now.AddDays(-800).ToShortDateString(),
                Age = (DateTime.Today.Year - DateTime.Now.AddDays(-8000).Year + index * 2).ToString(),
                OtherDetails = "Click Here"
            }).ToArray());
        }
    }
}
