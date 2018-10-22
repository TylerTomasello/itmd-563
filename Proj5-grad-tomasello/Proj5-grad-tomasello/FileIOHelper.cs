using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Proj5_grad_tomasello
{
    public class FileIOHelper : IIOHelper
    {
        //Add mortgages to the file
        public void AddMortgages(string formattedTempString)
        {
            try
            {
                string fileLocation = HttpContext.Current.Server.MapPath("~/app_data/log.txt");
                using (var fileStream = File.AppendText(fileLocation))
                {
                    fileStream.WriteLine(formattedTempString);
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
                string fileLocation = HttpContext.Current.Server.MapPath("~/app_data/log.txt");
                File.Delete(fileLocation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Display the mortgages list from the file
        public List<string> ListAllMortgages()
        {
            List<string> Data = new List<string>();
            string fileLocation = HttpContext.Current.Server.MapPath("~/app_data/log.txt");

            if (File.Exists(fileLocation))
            {
                string[] TempStringArray = File.ReadAllLines(fileLocation);
                Data = new List<string>(TempStringArray);
            }
            return Data;
        }
    }
}