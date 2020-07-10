using MySql.Data.MySqlClient;
using ProjetoTCM.Data.Command.Salesman;
using ProjetoTCM.Data.Data.Base;
using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.General;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Data.Data.General
{
    public class SalesmanData : BaseData
    {
        public SalesmanDomain Save(SalesmanDomain salesman)
        {
            String commandText = (IsNew(salesman.ID)) ? SalesmanResource.Insert : SalesmanResource.Update;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);
                if (!IsNew(salesman.ID)) command.Parameters.AddWithValue("@ID", salesman.ID);
                command.Parameters.AddWithValue("@Name", salesman.Name);
                command.Parameters.AddWithValue("@Email", salesman.Email);
                command.Parameters.AddWithValue("@Address", salesman.Address);
                command.Parameters.AddWithValue("@CPF", salesman.CPF);
                command.Parameters.AddWithValue("@Sex", salesman.Sex);
                command.Parameters.AddWithValue("@Phone", salesman.Phone);
                command.Parameters.AddWithValue("@Excluded", salesman.Excluded);

                connection.Open();
                if (IsNew(salesman.ID))
                {
                    salesman.ID = Convert.ToInt64(command.ExecuteScalar());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
            }
            return salesman;
        }



        public SalesmanDomain GetByID(long id)
        {
            SalesmanDomain Salesman = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(SalesmanResource.GetByID, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Salesman = MountSalesmanDomain(reader);
                }
                reader.Close();
            }

            return Salesman;
        }

        public List<SalesmanDomain> GetAll()
        {
            var salesmen = new List<SalesmanDomain>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SalesmanResource.GetAll, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var salesman = MountSalesmanDomain(reader);

                    salesmen.Add(salesman);
                }
                reader.Close();
            }

            return salesmen;
        }

        private SalesmanDomain MountSalesmanDomain(MySqlDataReader reader)
        {
            SalesmanDomain salesman = new SalesmanDomain();
            salesman.ID = (long)reader[0];
            salesman.Name = (string)reader[1];
            salesman.CPF = (string)reader[2];
            salesman.Address = (string)reader[3];
            salesman.Phone = (string)reader[4];
            salesman.Email = (string)reader[5];
            salesman.Sex = (EnumSex)reader[6];

            return salesman;
        }

        public bool Delete(long id)
        {
            var resultado = false;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SalesmanResource.Delete, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                resultado = command.ExecuteNonQuery() > 0;
            }

            return resultado;
        }
    }
}
