using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHouse
{
    class TeacherService
    {
        List<Teacher> listOfTeachers = new List<Teacher>();

        public List<Teacher> getTeacherlist()
        {
            var path = @"C:\List\Teacher1.json";
            string theJson = System.IO.File.ReadAllText(path);
            List<Teacher> newList = JsonConvert.DeserializeObject<List<Teacher>>(theJson);
            listOfTeachers.AddRange(newList);
            return listOfTeachers;
        }

        public void AddTeacher(string fname, string lname)
        {
            string flName = fname + " " + lname;
            listOfTeachers.Add(new Teacher() { firstName = fname, lastName = lname, fullName = flName });
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(listOfTeachers, Formatting.Indented);
        }

    }
}
