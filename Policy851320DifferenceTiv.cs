using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceFileAnalysis
{
    public class Policy851320DifferenceTiv
    {
        public static void GetDifferenceForPolicy851320(string filePathAppConfig)
        {
            using (StreamReader reader = new StreamReader(filePathAppConfig))
            {
                string strline = "";
                string[] _values = null;
                int x = 0;
                while (!reader.EndOfStream)
                {
                    x++;
                    strline = reader.ReadLine();
                    _values = strline.Split(',');
                    if (_values[0].Equals("851320"))
                    {
                        var a = Double.Parse(_values[8]) - Double.Parse(_values[7]);

                        Console.WriteLine("Difference between tiv 2011 and tiv 2012 for PolicyID: " + a); 
                    }
                }
                reader.Close();
            }
        }
    }
}
