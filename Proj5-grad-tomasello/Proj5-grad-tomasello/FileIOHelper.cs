using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Proj5_grad_tomasello
{
    public class FileIOHelper : IIOHelper
    {
        private string pathandfile;

        public FileIOHelper(string pathAndFile)
        {
            pathandfile = pathAndFile;
        }

        //public void AddPrinc(double principle)
        //{
        //    try
        //    {
        //        string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt")
        //        using (var fileStream = File.AppendText(fileLocation))
        //        {
        //            fileStream.WriteLine(principle);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void Addyear(double years)
        //{
        //    try
        //    {
        //        string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt")
        //        using (var fileStream = File.AppendText(fileLocation))
        //        {
        //            fileStream.WriteLine(years);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void Addrate(double rate)
        //{
        //    try
        //    {
        //        string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt")
        //        using (var fileStream = File.AppendText(fileLocation))
        //        {
        //            fileStream.WriteLine(rate);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //Add mortgages to the file
        public void AddMortgages(string formattedTempString, float formattedPrinciple, float formattedYears, float formattedRate)
        {
            try
            {
                string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt")
                using (var fileStream = File.AppendText(fileLocation))
                {
                    fileStream.WriteLine(formattedPrinciple, formattedRate, formattedYears,formattedTempString);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Clear the mortgages from the file
        public void ClearAllMortgages()
        {
            try
            {
                string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt");
                File.Delete(fileLocation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Display the mortgages list from the file
        public List<PaymentInfo> ListAllMortgages()
        {
            List<PaymentInfo> Data = new List<PaymentInfo>();
            string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt");

            if (File.Exists(fileLocation))
            {
                string[] TempStringArray = File.ReadAllLines(fileLocation);
                Data = new List<PaymentInfo>(TempStringArray);
            }
            return Data;
        }
    }
}