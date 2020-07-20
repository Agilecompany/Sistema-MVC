using MySql.Data.MySqlClient;
using ProjetoTCM.Data.Command.General.Provider;
using ProjetoTCM.Data.Data.Base;
using ProjetoTCM.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Data.Data.General
{
    public class ProviderData: BaseData
    {
        public ProviderDomain Save(ProviderDomain provider)
        {
            String commandText = (IsNew(provider.ID)) ? ProviderResource.Insert : ProviderResource.Update;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);
                if (!IsNew(provider.ID)) command.Parameters.AddWithValue("@ID", provider.ID);
                command.Parameters.AddWithValue("@Name", provider.Name);
                command.Parameters.AddWithValue("@CNPJ", provider.CNPJ);
                command.Parameters.AddWithValue("@Address", provider.Address);
                command.Parameters.AddWithValue("@Email", provider.Email);
                
                connection.Open();
                if (IsNew(provider.ID))
                {
                    provider.ID = Convert.ToInt64(command.ExecuteScalar());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
            }
            return provider;
        }
        public ProviderDomain GetByID(long id)
        {
            ProviderDomain provider = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(ProviderResource.GetByID, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    provider = MountProviderDomain(reader);
                }
                reader.Close();
            }

            return provider;
        }

        public List<ProviderDomain> GetAll()
        {
            var providers = new List<ProviderDomain>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(ProviderResource.GetAll, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var client = MountProviderDomain(reader);

                    providers.Add(client);
                }
                reader.Close();
            }

            return providers;
        }

        private ProviderDomain MountProviderDomain(MySqlDataReader reader)
        {
            ProviderDomain provider = new ProviderDomain();
            provider.ID = (long)reader[0];
            provider.Name = (string)reader[1];
            provider.CNPJ = (string)reader[2];
            provider.Address = (string)reader[3];
            provider.Email = (string)reader[4];
          
            return provider;
        }

        public bool Delete(long id)
        {
            var resultado = false;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(ProviderResource.Delete, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                resultado = command.ExecuteNonQuery() > 0;
            }

            return resultado;
        }

    }
}
