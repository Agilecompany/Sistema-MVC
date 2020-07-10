using MySql.Data.MySqlClient;
using ProjetoTCM.Data.Command.Sale.SaleProduct;
using ProjetoTCM.Data.Data.Base;
using ProjetoTCM.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Data.Data.Sale
{
    public class saleProductData : BaseData
    {
        public SaleProductDomain Save(SaleProductDomain saleProduct)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SaleProductResouce.Insert, connection);
                command.Parameters.AddWithValue("@SaleID", saleProduct.SaleID);
                command.Parameters.AddWithValue("@ProductID", saleProduct.ProductID);
                command.Parameters.AddWithValue("@ProductName", saleProduct.ProductName);
                command.Parameters.AddWithValue("@ExternalCode", saleProduct.ExternalCode);
                command.Parameters.AddWithValue("@UnitPrice", saleProduct.UnitPrice);
                command.Parameters.AddWithValue("@Quantity", saleProduct.Quantity);

                connection.Open();
                command.ExecuteNonQuery();

            }
            return saleProduct;
        }

        public SaleProductDomain GetByID(long ID)
        {
            SaleProductDomain SaleProduct = null;

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand(SaleProductResouce.GetByID, connection);
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SaleProduct = MountSaleDomain(reader);
                }
                reader.Close();
            }

            return SaleProduct;


        }

        private SaleProductDomain MountSaleDomain(MySqlDataReader reader)
        {
            SaleProductDomain saleProduct = new SaleProductDomain();
            saleProduct.SaleID = (long)reader[0];
            saleProduct.ProductID = (long)reader[1];
            saleProduct.ExternalCode = (string)reader[2];
            saleProduct.UnitPrice = (decimal)reader[3];
            saleProduct.Quantity = (int)reader[4];
            saleProduct.ProductName = (string)reader[5];
            return saleProduct;
        }

        public List<SaleProductDomain> GetAll()
        {
            var saleProducts = new List<SaleProductDomain>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SaleProductResouce.GetAll, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var saleProduct = MountSaleDomain(reader);

                    saleProducts.Add(saleProduct);
                }
                reader.Close();
            }

            return saleProducts;
        }

        public bool Delete(long ID)
        {
            var resultado = false;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SaleProductResouce.Delete, connection);
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                resultado = command.ExecuteNonQuery() > 0;
            }

            return resultado;
        }
    }
}
