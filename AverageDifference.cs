using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceFileAnalysis
{
    public class AverageDifference
    {
        public static void GetAverageDifferenceTiv(string filePathAppConfig)
        {
            List<string> column1 = new List<string>();
            List<double> column2 = new List<double>();
            List<string> column3 = new List<string>();
            List<double> column4 = new List<double>();
            using (StreamReader reader = new StreamReader(filePathAppConfig))
            {
                while (!reader.EndOfStream)
                {
                    var splits = reader.ReadLine().Split(',');

                    column1.Add(splits[7]);
                    column1.Remove("tiv_2011");
                    column3.Add(splits[8]);
                    column3.Remove("tiv_2012");
                }
                reader.Close();
            }
            foreach (var element in column1)
                column2.Add(Double.Parse(element));

            foreach (var element in column3)
                column4.Add(Double.Parse(element));

            Console.WriteLine("Average Difference between tiv 2011 and tiv 2012: " + (column4.Average() - column2.Average()));
            Console.ReadLine();
        }
    }
}
