using Laboratoio2.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoio2.Northwind.BusinessLogic
{
    class CustomersBL
    {
        private static CustomersBL _instance;

        public static CustomersBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomersBL();
                return _instance;
            }
        }

        public bool ComprobarExistencia(string nombre)
        {
            bool result = false;
            List<Customers> _listado;
            try
            {
                _listado = SelectAll();
                //El Salvador
                //el salvador

                var query = _listado.Where(x => x.CompanyName.ToLower().Equals(nombre.ToLower())).ToList();
                if (query.Count > 0)
                    result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
        public List<Customers> SelectAll()
        {
            List<Customers> result;
            try
            {
                result = CustomersBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }


        public Customers SelectById(int id)
        {
            Customers result = null;
            try
            {
                result = CustomersBL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Insert(Customers entity)
        {
            bool result = false;
            try
            {
                if (!ComprobarExistencia(entity.CompanyName))
                    result = CustomersBL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Customers entity)
        {
            bool result = false;
            try
            {
                result = CustomersBL.Instance.Update(entity);
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
                result = CustomersBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}

    

