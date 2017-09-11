using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceFileAnalysis
{
    public class MasonryAverageDifference
    {
        public static void GetMasonryAverageDifference(string filePathAppConfig)
        {
            List<string> masonry2011 = new List<string>();
            List<double> masonryDouble2011 = new List<double>();
            List<string> masonry2012 = new List<string>();
            List<double> masonryDouble2012 = new List<double>();

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
                    if (_values[16].Equals("Masonry"))
                    {
                        masonry2011.Add(_values[7]);
                        masonry2011.Remove("tiv_2011");
                        masonry2012.Add(_values[8]);
                        masonry2012.Remove("tiv_2012");
                    }
                }
                foreach (var element in masonry2011)
                    masonryDouble2011.Add(Double.Parse(element));

                foreach (var element in masonry2012)
                    masonryDouble2012.Add(Double.Parse(element));

                Console.WriteLine("Average Difference for all Masonry tiv policies: " + ((masonryDouble2012.Average()) - (masonryDouble2011.Average())));
                Console.ReadLine();
                reader.Close();
            }
        }
    }
}
