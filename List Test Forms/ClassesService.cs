using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SchoolHouse
{

    class ClassesService
    {
        List<ClassesTaught> listOfClasses = new List<ClassesTaught>();

        public List<ClassesTaught> getClasslist()
        {
            var path = @"C:\List\Classes1.json";
            string theJson = System.IO.File.ReadAllText(path);
            List<ClassesTaught> newListc = JsonConvert.DeserializeObject<List<ClassesTaught>>(theJson);
            listOfClasses.AddRange(newListc);
            return listOfClasses;
        }

        public void AddClassTaught(string cDept, string cID, string cDescript, string cTeacher)
        { listOfClasses.Add(new ClassesTaught() { classDept = cDept, classID = cID, classDescription = cDescript, classTeacher = cTeacher });
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(listOfClasses, Formatting.Indented);
        }
    }
}
