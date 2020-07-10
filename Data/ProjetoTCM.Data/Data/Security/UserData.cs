using ProjetoTCM.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Data.Command.Security.User;
using System.Configuration;
using ProjetoTCM.Data.Data.Base;
using MySql.Data.MySqlClient;

namespace ProjetoTCM.Data.Data.Security
{
    public class UserData: BaseData
    {
        public UserDomain Authentication(string login, string password)
        {
            UserDomain result = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(UserResource.GetByLoginPassword, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = MountUserDomain(reader);
                }
                reader.Close();
            }

            return result;
        }

        public UserDomain Save(UserDomain user)
        {
            String commandText = (IsNew(user.ID)) ? UserResource.Insert : UserResource.Update;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);
                if (!IsNew(user.ID)) command.Parameters.AddWithValue("@ID", user.ID);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Login", user.Login);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Profile", user.Profile);

                connection.Open();
                if (IsNew(user.ID))
                {
                    user.ID = Convert.ToInt64(command.ExecuteScalar());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
            }

            return user;
        }

        public bool Delete(long id)
        {
            var resultado = false;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(UserResource.Delete, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                resultado = command.ExecuteNonQuery() > 0;
            }

            return resultado;
        }

        public List<UserDomain> GetAll()
        {
            var users = new List<UserDomain>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(UserResource.GetAll, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = MountUserDomain(reader);

                    users.Add(user);
                }
                reader.Close();
            }

            return users;
        }

        public UserDomain GetByID(long id)
        {
            UserDomain user = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(UserResource.GetByID, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user = MountUserDomain(reader);
                }
                reader.Close();
            }

            return user;
        }

        private static UserDomain MountUserDomain(MySqlDataReader reader)
        {
            UserDomain user = new UserDomain();
            user.ID = (long)reader[0];
            user.Name = (string)reader[1];
            user.Email = (string)reader[2];
            user.Login = (string)reader[3];
            user.Password = (string)reader[4];
            user.Profile = (EnumProfile)reader[5];
            return user;
        }
    }
}
