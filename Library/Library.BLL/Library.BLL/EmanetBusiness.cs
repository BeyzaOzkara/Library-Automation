using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.DAL.Repositories.Concretes;

namespace Library.BLL
{
    public class EmanetBusiness
    {
        public bool Ekle(Emanet entity)
        {
            try
            {
                bool isSuccess;
                using (var repo = new EmanetRepository())
                {
                    isSuccess = repo.Ekle(entity);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:EmanetBusiness::InsertEmanet::Error occured.", ex);
            }
        }
    }
}
