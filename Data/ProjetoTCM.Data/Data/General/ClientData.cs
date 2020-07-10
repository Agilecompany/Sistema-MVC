using MySql.Data.MySqlClient;
using ProjetoTCM.Data.Command.General.Client;
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
    public class ClientData: BaseData
    {
        public ClientDomain Save(ClientDomain client)
        {
            String commandText = (IsNew(client.ID)) ? ClientResource.Insert : ClientResource.Update;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);
                if (!IsNew(client.ID)) command.Parameters.AddWithValue("@ID", client.ID);
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@Email", client.Email);
                command.Parameters.AddWithValue("@CPF", client.CPF);
                command.Parameters.AddWithValue("@Sex", client.Sex);
                command.Parameters.AddWithValue("@Phone", client.Phone);
                command.Parameters.AddWithValue("@CellPhone", client.CellPhone);
                command.Parameters.AddWithValue("@Excluded", client.Excluded);

                connection.Open();
                if (IsNew(client.ID))
                {
                    client.ID = Convert.ToInt64(command.ExecuteScalar());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
            }
            return client;
        }


        public ClientDomain GetByID(long id)
        {
            ClientDomain client = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(ClientResource.GetByID, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    client = MountClientDomain(reader);
                }
                reader.Close();
            }

            return client;
        }

        public List<ClientDomain> GetAll()
        {
            var clients = new List<ClientDomain>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(ClientResource.GetAll, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var client = MountClientDomain(reader);

                    clients.Add(client);
                }
                reader.Close();
            }

            return clients;
        }

        private ClientDomain MountClientDomain(MySqlDataReader reader)
        {
            ClientDomain client = new ClientDomain();
            client.ID = (long)reader[0];
            client.Name = (string)reader[1];
            client.CPF = (string)reader[2];
            client.Sex = (EnumSex)reader[3];
            client.Email = (string)reader[4];
            client.Phone = (string)reader[5];
            client.CellPhone = (string)reader[6];

            return client;
        }

        public bool Delete(long id)
        {
            var resultado = false;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(ClientResource.Delete, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                resultado = command.ExecuteNonQuery() > 0;
            }

            return resultado;
        }
    }
}
