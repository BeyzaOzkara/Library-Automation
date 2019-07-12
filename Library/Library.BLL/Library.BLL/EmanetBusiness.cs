using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.DAL;
using Library.DAL.Repositories.Concretes;

namespace Library.BLL
{
    public class EmanetBusiness : IDisposable
    {
        private static LibraryContext _context;

        public static LibraryContext Context
        {
            get
            {//context'in her koşulda dolu gelmesi sağlandı
                if (_context == null)
                    _context = new LibraryContext();
                return _context;
            }
            set { _context = value; }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

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

        public List<Emanet> Listele()
        {
            var responseEntities = new List<Emanet>();

            try
            {
                using (var repo = new EmanetRepository())
                {
                    foreach (var entity in repo.Listele())
                    {
                        responseEntities.Add(entity);
                    }
                }
                return responseEntities;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:EmanetBusiness::SelectAllEmanet::Error occured.", ex);
            }
        }

        public bool Sil(int id)
        {
            try
            {
                bool isSuccess;
                using (var repo = new EmanetRepository())
                {
                    isSuccess = repo.DeleteById(id);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:EmanetBusiness::DeleteEmanet::Error occured.", ex);
            }
        }
    }
}
