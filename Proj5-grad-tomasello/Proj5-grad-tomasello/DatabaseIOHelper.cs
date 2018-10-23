using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proj5_grad_tomasello
{
    public class PaymentInfo
    {
        public float Principle { get; set; }

        public float Rate { get; set; }

        public float Years { get; set; }

        public string MonthlyPayment { get; set; }

    }
    public class DatabaseIOHelper : IIOHelper
    {
        const string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Mortgages; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void AddMortgages(string formattedTempString, float formattedPrinciple, float formattedYears, float formattedRate)
        {
            string insertCommand = "insert into mortgages (Principle, InterestRate, DurationYears, MonthlyPayment)" +
                "values (@formattedPrinciple, @formattedRate, @formattedYears, @formattedString)";

            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);
                sqlCommand.Parameters.Add("@formattedPrinciple", SqlDbType.Float).Value = formattedPrinciple;
                sqlCommand.Parameters.Add("@formattedRate", SqlDbType.Float).Value = formattedRate;
                sqlCommand.Parameters.Add("@formattedYears", SqlDbType.Float).Value = formattedYears;
                sqlCommand.Parameters.Add("@formattedString", SqlDbType.NVarChar).Value = formattedTempString;


                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (result != 1) throw new Exception("Unable to add data to database");
            }
        }

        /* Had trouble putting in separtate rows on the gridview but was still able to use the database
         * 
         * 
         * */
        //public void AddPrinc(double principle)
        //{
        //    string insertCommand = "insert into mortgages values (@Principle)";

        //    using (SqlConnection sqlConnection = new SqlConnection(conString))
        //    {
        //        SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);
        //        sqlCommand.Parameters.Add("@Principle", SqlDbType.Decimal).Value = principle;

        //        sqlConnection.Open();
        //        int result = sqlCommand.ExecuteNonQuery();
        //        sqlConnection.Close();

        //        if (result != 1) throw new Exception("Unable to add data to database");
        //    }
        //}

        //public void Addrate(double rate)
        //{
        //    string insertCommand = "insert into mortgages values (@InterestRate)";

        //    using (SqlConnection sqlConnection = new SqlConnection(conString))
        //    {
        //        SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);
        //        sqlCommand.Parameters.Add("@InterestRate", SqlDbType.Decimal).Value = rate;

        //        sqlConnection.Open();
        //        int result = sqlCommand.ExecuteNonQuery();
        //        sqlConnection.Close();

        //        if (result != 1) throw new Exception("Unable to add data to database");
        //    }
        //}

        //public void Addyear(double years)
        //{
        //    string insertCommand = "insert into mortgages values (@DurationYears)";

        //    using (SqlConnection sqlConnection = new SqlConnection(conString))
        //    {
        //        SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);
        //        sqlCommand.Parameters.Add("@DurationYears", SqlDbType.Int).Value = years;

        //        sqlConnection.Open();
        //        int result = sqlCommand.ExecuteNonQuery();
        //        sqlConnection.Close();

        //        if (result != 1) throw new Exception("Unable to add data to database");
        //    }
        //}

        public void ClearAllMortgages()
        {
            const string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Mortgages; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string deleteCommand = "delete from mortgages";

            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCommand = new SqlCommand(deleteCommand, sqlConnection);

                sqlConnection.Open();

                int result = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

            }
        }

        public List<PaymentInfo> ListAllMortgages()
        {
            List<PaymentInfo> list = new List<PaymentInfo>();

            const string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Mortgages; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string selectCommand = "select * from mortgages";

            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCommand = new SqlCommand(selectCommand, sqlConnection);

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                    PaymentInfo paymentInfo = new PaymentInfo()
                    {
                        Principle = (float)Convert.ToDouble((sqlDataReader["Principle"])),
                        Rate = (float)Convert.ToDouble((sqlDataReader["InterestRate"])),
                        Years = (float)Convert.ToDouble((sqlDataReader["DurationYears"])),
                        MonthlyPayment = (string)sqlDataReader["MonthlyPayment"]
                    };
                        //float formattedPrinc = (float)Convert.ToDouble(("Principle"]));
                        //float formattedRate = (float)Convert.ToDouble((sqlDataReader["InterestRate"]));
                        //float formattedYears = (float)Convert.ToDouble(("DurationYears"]));
                        //string formattedTempString = (string)sqlDataReader["MonthlyPayment"];
                        list.Add(paymentInfo);
                    }
                }

                sqlConnection.Close();

            }

            return list;
        }
    }
}