using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SchoolHouse
{
    [Serializable]
    public class Student2
    {
        public int studentId { get; set; } = -1;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string grade { get; set; }
        public string[] HourId { get; set; }
        public string[] HourDescription { get; set; }
        
        private List<string> AllLines = new List<string>();
        List<Student2> listOfUsers = new List<Student2>();
        
        public List<Student2> FromJson()
        {
            var path = @"C:\Users\bernieyeater\Students6.json";
            string userJson = System.IO.File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Student2>>(userJson);
        }
    }

    public static class UserExtensions
    {
        /*
         * These are "Extension methods" and they work as if they were methods defined in the class,
         * but they are done at a later time, so to speak. These do things with List<User> objects.
         */


    }
}
