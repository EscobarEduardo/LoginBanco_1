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
    }
}
