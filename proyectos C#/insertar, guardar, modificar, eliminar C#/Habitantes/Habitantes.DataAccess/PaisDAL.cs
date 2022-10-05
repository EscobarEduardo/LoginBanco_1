using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Habitantes.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Habitantes.DataAccess
{
    public class PaisDAL:Connection
    {
        private static PaisDAL _instance;

        public static PaisDAL Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new PaisDAL(); //0x77DD33
                }

                return _instance;
            }
        }

        public List<Pais> SelectAll()
        {
            List<Pais> result = null;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spPaisSelectall", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            result = new List<Pais>();
                            while (dr.Read())
                            {
                                Pais entity = new Pais();
                                entity.PaisId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Cantidad = dr.GetInt32(2);
                                result.Add(entity);
                            }
                        }
                    }
                }                                                
            }
            return result;            
        }

        public Pais SelectById(int id)
        {
            Pais entity = null;

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
                                entity = new Pais();
                                entity.PaisId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Cantidad = dr.GetInt32(2);                                
                            }
                        }
                    }
                }   
            }

            return entity;            
        }

        public bool Insert(Pais entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spPaisInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("Cantidad", entity.Cantidad);
                    conn.Open();

                    result = cmd.ExecuteNonQuery()>0;
                }
            }
            return result;
        }

        public bool Update(Pais entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spPaisUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("PaisId", entity.PaisId);
                    cmd.Parameters.AddWithValue("Nombre", entity.Nombre);
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
            using(SqlConnection conn = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spPaisDelete",conn))
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
