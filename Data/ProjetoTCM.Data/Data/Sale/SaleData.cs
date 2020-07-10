using MySql.Data.MySqlClient;
using ProjetoTCM.Data.Command.Sale.Sale;
using ProjetoTCM.Data.Data.Base;
using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoTCM.Data.Data.Sale
{
    public class SaleData : BaseData
    {
        public SaleDomain Save(SaleDomain sale)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SaleResource.Insert, connection);
                command.Parameters.AddWithValue("@Payment", sale.Payment);
                command.Parameters.AddWithValue("@Date", sale.Date);
                command.Parameters.AddWithValue("@SalesmanID", sale.SalesmanID);
                command.Parameters.AddWithValue("@ClientID", sale.ClientID);
                command.Parameters.AddWithValue("@UserID", sale.UserID);
                command.Parameters.AddWithValue("@ClientName", sale.ClientName);
                command.Parameters.AddWithValue("@ClientCPF", sale.ClientCPF);
                command.Parameters.AddWithValue("@SalesmanName", sale.SalesmanName);
                command.Parameters.AddWithValue("@Excluded", sale.Excluded);

                connection.Open();
                sale.ID = Convert.ToInt64(command.ExecuteScalar());

            }
            return sale;
        }

        public SaleDomain GetByID(long ID)
        {
            SaleDomain Sale = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(SaleResource.GetByID, connection);
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Sale = MountSaleDomain(reader);
                }
                reader.Close();
            }

            return Sale;

        }

        private SaleDomain MountSaleDomain(MySqlDataReader reader)
        {
            SaleDomain sale = new SaleDomain();
            sale.ID = (long)reader[0];
            sale.Payment = (EnumPayment)reader[1];
            sale.Date = (DateTime)reader[2];
            sale.SalesmanID = (long)reader[3];
            sale.ClientID = (long)reader[4];
            sale.UserID = (long)reader[5];
            sale.ClientName = (string)reader[6];
            sale.ClientCPF = (string)reader[7];
            sale.SalesmanName = (string)reader[8];
            return sale;
        }

        public List<SaleDomain> GetAll()
        {
            var Sales = new List<SaleDomain>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SaleResource.GetAll, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var sale = MountSaleDomain(reader);

                    Sales.Add(sale);
                }
                reader.Close();
            }

            return Sales;
        }

        public bool Delete(long ID)
        {
            var resultado = false;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SaleResource.Delete, connection);
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                resultado = command.ExecuteNonQuery() > 0;
            }

            return resultado;
        }

    }

}