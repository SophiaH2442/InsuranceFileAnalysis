using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InsuranceFileAnalysis
{
    public static class PercentageCalculator
    {
        public static double GetReinforcedConcreteCommercialProperties(string filePathAppConfig)
        {
            List<string> commercial2011 = new List<string>();
            List<string> commercial2012 = new List<string>();
            List<string> commercialReinforced2011 = new List<string>();
            List<string> commercialReinforced2012 = new List<string>();
            double percentage2011;
            double percentage2012;

            using (StreamReader reader = new StreamReader(filePathAppConfig))
            {
                string strline = "";
                string[] _values = null;
                while (!reader.EndOfStream)
                {
                    strline = reader.ReadLine();
                    _values = strline.Split(',');
                    if (_values[15].Equals("Commercial"))
                    {
                        commercial2011.Add(_values[7]);
                        commercial2011.Remove("tiv_2011");
                        commercial2012.Add(_values[8]);
                        commercial2012.Remove("tiv_2012");
                    }
                    if (_values[16].Equals("Reinforced Concrete") && _values[15].Equals("Commercial"))
                    {
                        commercialReinforced2011.Add(_values[7]);
                        commercialReinforced2011.Remove("tiv_2011");
                        commercialReinforced2012.Add(_values[8]);
                        commercialReinforced2012.Remove("tiv_2012");
                    }
                }
                double commercial2011Count = commercial2011.Count;

                double commercial2012Count = commercial2012.Count;

                double commReinforced2011Count = commercialReinforced2011.Count;

                double commReinforced2012Count = commercialReinforced2012.Count;

                percentage2011 = (commReinforced2011Count / (commercial2011Count) * 100);
                percentage2012 = (commReinforced2012Count / (commercial2012Count) * 100);

                Console.WriteLine("Percentage of Commercial Properties Constructed with Reinforced Concrete in 2011: " + (int)(percentage2011) + "%");
                Console.WriteLine("Percentage of Commercial Properties Constructed with Reinforced Concrete in 2012: " + (int)(percentage2012) + "%");
                Console.ReadLine();
                reader.Close();
            }
            return percentage2011;
        }
    }
}
