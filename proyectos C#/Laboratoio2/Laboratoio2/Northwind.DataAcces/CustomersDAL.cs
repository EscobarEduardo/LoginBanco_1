using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratoio2.Northwind.Entities;

namespace Laboratoio2.Northwind.DataAcces
{
    class CustomersDAL
    {
        public class Customers : Connection
        {
            private static CustomersDAL_instance

            public static CustomersDAL Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new CustomersDAL(); //0x77DD33
                    }

                    return _instance;
                }
            }

            public List<Customers> SelectAll()
            {
                List<Customers> result = null;

                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("spPaisSelectall", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                        {
                            if (dr != null)
                            {
                                result = new List<Customers>();
                                while (dr.Read())
                                {
                                    Customers entity = new Customers();
                                    entity.CustomerID = dr.GetInt32(0);
                                    entity.CompanyName = dr.GetString(1);
                                    entity.ContactName = dr.GetString(2);
                                    entity.ContactTitle = dr.GetString(3);
                                    entity.Address = dr.GetString(4);
                                    entity.City = dr.GetString(5);
                                    entity.Region = dr.GetString(6);
                                    entity.PostalCode = dr.GetString(7);
                                    entity.Country = dr.GetString(8);
                                    entity.Phone = dr.GetString(9);
                                    entity.Fax = dr.GetString(10);

                                    result.Add(entity);
                                }
                            }
                        }
                    }
                }
                return result;
            }

            public Customers SelectById(int id)
            {
                Customers entity = null;

                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("spPaisSelectById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("PaisId", id);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    Customers entity = new Customers();
                                    entity.CustomerID = dr.GetInt32(0);
                                    entity.CompanyName = dr.GetString(1);
                                    entity.ContactName = dr.GetString(2);
                                    entity.ContactTitle = dr.GetString(3);
                                    entity.Address = dr.GetString(4);
                                    entity.City = dr.GetString(5);
                                    entity.Region = dr.GetString(6);
                                    entity.PostalCode = dr.GetString(7);
                                    entity.Country = dr.GetString(8);
                                    entity.Phone = dr.GetString(9);
                                    entity.Fax = dr.GetString(10);

                                    result.Add(entity);
                                }
                            }
                        }
                    }
                }

                return entity;
            }

            public bool Insert(Customers entity)
            {
                bool result = false;

                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("spPaisInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("CustomerID", entity.CustomerID);
                        cmd.Parameters.AddWithValue("Cantidad", entity.Cantidad);
                        conn.Open();

                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
                return result;
            }

            public bool Update(Customers entity)
            {
                bool result = false;
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("spPaisUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("PaisId", entity.PaisId);
                        cmd.Parameters.AddWithValue("CompanyName", entity.CompanyName);
                        cmd.Parameters.AddWithValue("cantidad", entity.Cantidad);
                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
                return result;
            }

            public bool Delete(int id)
            {
                bool result = false;
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("spPaisDelete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("PaisId", id);
                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }

                return result;
            }
        }
    }
    }



