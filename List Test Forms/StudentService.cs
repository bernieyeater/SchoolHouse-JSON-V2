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
    public class StudentService
    {
        List<Student2> listOfUsers = new List<Student2>();

        public string theJson { get; set; }

        public List<Student2> getStudentlist()
        {
            var path = @"C:\List\Students1.json";
            try
            {

                theJson = System.IO.File.ReadAllText(path);

                List<Student2> newList = JsonConvert.DeserializeObject<List<Student2>>(theJson);
                listOfUsers.AddRange(newList);
            }
            catch
            {
                theJson = "File Not Found";

            }
            return listOfUsers;
       }

        public void AddStudents(int sID, string fname, string lname, string sgrade, string[] hid, string[] hdesc)
        {
            listOfUsers.Add(new Student2() { studentId = sID, firstName = fname, lastName = lname, grade = sgrade, HourId = hid, HourDescription = hdesc });
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(listOfUsers, Formatting.Indented);
        }          
    }
}
