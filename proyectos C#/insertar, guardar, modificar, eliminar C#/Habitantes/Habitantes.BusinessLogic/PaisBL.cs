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
        private static PaisBL _instance;

        public static PaisBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PaisBL();
                return _instance;
            }
        }

        public bool ComprobarExistencia(string nombre)
        {
            bool result = false;
            List<Pais> _listado;
            try
            {
                _listado = SelectAll();
                //El Salvador
                //el salvador

                var query = _listado.Where(x => x.Nombre.ToLower().Equals(nombre.ToLower())).ToList();
                if (query.Count >0)
                    result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
        public List<Pais> SelectAll()
        {
            List<Pais> result;
            try
            {                
                result = PaisDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }


        public Pais SelectById(int id)
        {
            Pais result = null;
            try
            {
                result = PaisDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);                
            }
            return result;
        }

        public bool Insert(Pais entity)
        {
            bool result = false;
            try
            {
                if(!ComprobarExistencia(entity.Nombre))
                    result = PaisDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Pais entity)
        {
            bool result = false;
            try
            {                
                result = PaisDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                result = PaisDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
