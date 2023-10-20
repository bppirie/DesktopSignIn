using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_174CS.Helpers
{
    internal class CSVHelper
    {
        private static string SignInFolderName = "174CS-SignIn";
        private static string SignInFolderPath = Path.Combine(Environment.SystemDirectory, SignInFolderName);
        private static string SignInCSVName = "SignInData.csv";
        private static string SignInCSVPath = Path.Combine(SignInFolderPath, SignInCSVName);
        private static string CSVHeader = "Guid,TimeIn,TimeOut,IsCSL,CSLName,First,Last,Rank,Phone,Email,Description";
        private static int GuidIndex = CSVHeader.Split(',').ToList().IndexOf("Guid");
        private static int TimeOutIndex = CSVHeader.Split(',').ToList().IndexOf("TimeOut");

        private static void EnsureCSVExists()
        {
            if (!Directory.Exists(SignInFolderPath))
            {
                Directory.CreateDirectory(SignInFolderPath);
            }

            if (!File.Exists(SignInCSVPath))
            {
                File.WriteAllText(SignInCSVPath, CSVHeader);
            }
        }

        public static void AddToCSV(string lastName, string description, string cslName = "", string firstName = "", string rank = "", string phone = "", string email = "", bool isCSL = false)
        {
            EnsureCSVExists();
            Guid guid = Guid.NewGuid();
            File.AppendAllText(SignInCSVPath, Environment.NewLine + string.Join(",", guid.ToString(), DateTime.Now.ToString(), "" , isCSL, cslName, firstName, lastName, rank, phone, email, description));
        }

        public static void UpdateCSV(string guid, string timeIn, string last)
        {
            EnsureCSVExists();
            List<string> lines = File.ReadAllLines(SignInCSVPath).ToList();
            int index = lines.FindIndex(line => string.Equals(line.Split(',')[GuidIndex], guid, StringComparison.OrdinalIgnoreCase));

            if (index == -1)
            {
                Debug.WriteLine("Could not find guid: " + guid);
                return;
            }

            string[] lineSplit = lines[index].Split(',');
            lineSplit[TimeOutIndex] = DateTime.Now.ToString();
            lines[index] = string.Join(",", lineSplit);
            File.WriteAllLines(SignInCSVPath, lines);
        }
    }
}
