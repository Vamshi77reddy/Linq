using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;

namespace LinquImp
{
    internal class PatientMain
    {
        public void PatientDetails()
        {
            List<Patient> pat = new List<Patient>();

            Patient p1 = new Patient();
            p1.PatientName = "vamshi";
            p1.Age = 30;
            p1.Gender = "Male";
            p1.City = "New York";
            pat.Add(p1);

            pat.Add(new Patient { PatientName = "Roshni", Age = 25, Gender = "Female", City = "Los Angeles" });
            pat.Add(new Patient { PatientName = "Rahul", Age = 40, Gender = "Male", City = "Chicago" });
            pat.Add(new Patient { PatientName = "Vidhya", Age = 18, Gender = "Female", City = "Houston" });
            pat.Add(new Patient { PatientName = "Rohith", Age = 28, Gender = "Male", City = "San Francisco" });

            /*  List<Patient> Patients = pat
           .Where(patient => patient.Age > 19)  // Filter patients older than 19
           .OrderBy(patient => patient.Age)     // Sort patients by age
           .ToList();


              foreach (Patient patient in pat)
              {
                  Console.WriteLine($"Name: {patient.PatientName}");
                  Console.WriteLine($"Age: {patient.Age}");
                  Console.WriteLine($"Gender: {patient.Gender}");
                  Console.WriteLine($"City: {patient.City}");
                  Console.WriteLine();
              }

          }*/

            var patient = from pa in pat
                            where pa.Age > 20
                            orderby pa.PatientName, pa.Gender, pa.Age
                            select pa;
            foreach (var pp in patient)
            {
                Console.WriteLine($"Name: {pp.PatientName}");
                Console.WriteLine($"Age: {pp.Age}");
                Console.WriteLine($"Gender: {pp.Gender}");
                Console.WriteLine($"City: {pp.City}");
                Console.WriteLine();
            }
            int patientCount = (from pa in pat
                                where pa.Age > 20
                                orderby pa.PatientName, pa.Gender, pa.Age
                                select pa).Count();
            Console.WriteLine(patientCount.ToString());
        }
    }
}