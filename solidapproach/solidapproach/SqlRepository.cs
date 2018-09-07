using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class SqlRepository:IRepository
    {
        public void Add(IProduct product,int fare)
        {
            History.Instance.AddToLogFile("Adding Product Details to Database.");
            SqlConnection connectionobject = new SqlConnection();
            
            connectionobject.ConnectionString = "Data Source=TAVDESK087;Initial Catalog=Product;Integrated Security=True";
            connectionobject.Open();
            string query = "insert into " +product.ProductType+" values(@name,@fare,@isbooked)";
            SqlCommand cmd = new SqlCommand(query,connectionobject);
            cmd.Parameters.Add(new SqlParameter("@name", product.ProductName));
            cmd.Parameters.Add(new SqlParameter("@fare",fare));
            cmd.Parameters.Add(new SqlParameter("@isbooked", product.IsBooked));


            cmd.ExecuteNonQuery();
            connectionobject.Close();
        }
    }
}
