﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Porj4_Tomasello
{
    public class FileIOHelper : IIOHelper
    {
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

        public List<string> ListAllMortgages()
        {
            List<string> allData = new List<string>();
            string fileLocation = HttpContext.Current.Server.MapPath("~/app_data/log.txt");

            if (File.Exists(fileLocation))
            {
                string[] allTempStringArray = File.ReadAllLines(fileLocation);
                allData = new List<string>(allTempStringArray);
            }
            return allData;
        }
    }
}