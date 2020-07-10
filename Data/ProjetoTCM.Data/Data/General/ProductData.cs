using MySql.Data.MySqlClient;
using ProjetoTCM.Data.Command.General.Product;
using ProjetoTCM.Data.Data.Base;
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
    public class ProductData: BaseData
    {
        public ProductDomain Save(ProductDomain product)
        {
            String commandText = (IsNew(product.ID)) ? ProductResource.Insert : ProductResource.Update;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);
                if (!IsNew(product.ID)) command.Parameters.AddWithValue("@ID", product.ID);
                command.Parameters.AddWithValue("@ExternalCode", product.ExternalCode);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Brand", product.Brand);
                command.Parameters.AddWithValue("@Model", product.Model);
                command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                command.Parameters.AddWithValue("@Excluded", product.Excluded);

                connection.Open();
                if (IsNew(product.ID))
                {
                    product.ID = Convert.ToInt64(command.ExecuteScalar());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
            }
            return product;
        }


        public ProductDomain GetByID(long id)
        {
            ProductDomain client = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(ProductResource.GetByID, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    client = MountProductDomain(reader);
                }
                reader.Close();
            }

            return client;
        }
        public List<ProductDomain> GetAll()
        {
            var products = new List<ProductDomain>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(ProductResource.GetAll, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var client = MountProductDomain(reader);

                    products.Add(client);
                }
                reader.Close();
            }

            return products;
        }

        private ProductDomain MountProductDomain(MySqlDataReader reader)
        {
            //[ID],[ExternalCode] ,[Name]  ,[Description],[Brand],[Model],[Price],[UnitPrice]
            ProductDomain product = new ProductDomain();
            product.ID = (long)reader[0];
            product.ExternalCode = (string)reader[1];
            product.Name = (string)reader[2];
            product.Description = (string)reader[3];
            product.Brand = (string)reader[4];
            product.Model = (string)reader[5];
            product.UnitPrice = (decimal)reader[6];

            return product;
        }

        public bool Delete(long id)
        {
            var resultado = false;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(ProductResource.Delete, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                resultado = command.ExecuteNonQuery() > 0;
            }

            return resultado;
        }

       
    }
}
