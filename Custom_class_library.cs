using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfTimeMangementApp
{
    class Custom_class_library
    {
        public class UserModels
        {
            public int ID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
    public class LoginController : Controller
        public string Username;
    public string Password;

        public IActionResult Index()
    {
        return View();
    }
    public IActionResult ProcesLogin(UserModels userModels)
    {
        return View("LoginSuccess", userModels);

    }


    class Modules : IComparable
        {
            public int CODE = 0;
            private string username = "";
            private string modulecode = "";
            private int numbercredits;
            private int classHoursPerWeek;

            public string firstname { get => username; set => username = value; }
            public string module { get => modulecode; set => modulecode = value; }
            public int credits { get => numbercredits; set => numbercredits = value; }
            public int hoursperweek { get => classHoursPerWeek; set => classHoursPerWeek = value; }

            public Modules(int v)
            {

            }
            public Modules(int CODE, string username, string modulecode, string v, int numbercredits, int classHoursPerWeek)
            {
                this.CODE = CODE;
                username = username;
                modulecode = modulecode;
                numbercredits = numbercredits;
                classHoursPerWeek = classHoursPerWeek;

            }
            public int CompareTo(object obj)
            {
                return username.CompareTo(obj.ToString());
            }
            public override string ToString()
            {
                return username;
            }

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
        //Declare an ArrayList for the Modules
        List<Module> modules = new List<Module>()
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


        //StartDate
        // Create a DateTime from date and time  
        DateTime dob = new DateTime(2021, 7, 10, 7, 10, 24);

        // Create a DateTime from a String  
        string dateString = "14/02/2021 7:10:24 AM";




        // Empty DateTime  
        DateTime emptyDateTime = new DateTime();

        // Just date  
        DateTime justDate = new DateTime(2020, 10, 18);

        // DateTime from Ticks  
        DateTime justTime = new DateTime(1000000);

        // DateTime with localization  
        DateTime dateTimeWithKind = new DateTime(2019, 7, 10, 7, 10, 24, DateTimeKind.Local);

        // DateTime with date, time and milliseconds  
        DateTime dateTimeWithMilliseconds = new DateTime(2019, 12, 15, 5, 30, 45, 100);

    }


}









