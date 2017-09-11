using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace InsuranceFileAnalysis
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var filePathAppConfig = ConfigurationManager.AppSettings["FilePath"];

            try
            {
                Policy851320DifferenceTiv.GetDifferenceForPolicy851320(filePathAppConfig);
                AverageDifference.GetAverageDifferenceTiv(filePathAppConfig);
                MasonryAverageDifference.GetMasonryAverageDifference(filePathAppConfig);
                PercentageCalculator.GetReinforcedConcreteCommercialProperties(filePathAppConfig);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e);
                Console.ReadLine();
            }
            //try
            //{
                
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e);
            //    Console.ReadLine();
            //}
            //try
            //{
                
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e);
            //    Console.ReadLine();
            //}
            

            //try
            //{
                
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e);
            //    Console.ReadLine();
            //}


        }

 
        

    }
}



