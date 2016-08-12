using System;
using System.Data.SqlClient;
using Dapper;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=Dapper;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            conn.Open();

            var cobs = conn.Query<Cbo>("select * from cbo");

            foreach(var cbo in cobs)
            {
                Console.WriteLine("{0} - {1}", cbo.Id, cbo.Descricao);
            }

            conn.Close();

            Console.ReadKey();
        }
    }
}
