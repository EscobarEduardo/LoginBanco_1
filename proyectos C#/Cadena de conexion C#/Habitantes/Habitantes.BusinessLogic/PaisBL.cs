using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Habitantes.Entities;
using Habitantes.DataAccess;

namespace Habitantes.BusinessLogic
{
    public class PaisBL
    {
        public List<Pais> SelectAll()
        {
            List<Pais> result;
            try
            {
                PaisDAL repo = new PaisDAL();
                result = repo.SelectAll();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }
    }
}
