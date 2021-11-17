using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserLogin
{
    List<Module> Module = new List<Module>()
        {
            new Module() { Code = "DATA6212", Name = "Database Introduction", Credits = 12m, Hours = TimeSpan.FromHours(2.0) },
            new Module() { Code = "HCIN6212", Name = "Human Computer Interaction", Credits = 15m, Hours = TimeSpan.FromHours(4.0) },
            new Module() { Code = "IMPA6212", Name = "IT Project Management", Credits =10, Hours = TimeSpan.FromHours(3.0) },
            new Module() { Code = "PROG6211", Name = "Programming 2A", Credits = 15m, Hours = TimeSpan.FromHours(5.0) },
            new Module() { Code = "PROG212", Name = "Programming 2B", Credits =15m, Hours = TimeSpan.FromHours(5.0) },
            new Module() { Code = "WEDE5010", Name = "Web Development", Credits = 10m, Hours = TimeSpan.FromMinutes(3.0) },
            new Module() { Code = "SAND6211", Name = "System Anaylsis and design ", Credits = 12m, Hours = TimeSpan.FromHours(3.0)},
            new Module() { Code = "XISD5219", Name = "work Integrated Learning", Credits = 10m, Hours = TimeSpan.FromMinutes(4.0) },
        };



    public class UserModels
        {
            public int ID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
    public class Module
    {
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal Credits { get; set; }
    public TimeSpan Hours { get; set; }
    public int NoOfWeeks { get; set; }
    public DateTime date { get; set; }

}




