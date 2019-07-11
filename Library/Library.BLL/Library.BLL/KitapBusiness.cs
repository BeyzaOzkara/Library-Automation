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
    public class KitapBusiness : IDisposable
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

        public bool Ekle(Kitap entity)
        {
            /*try
            {
                Context.Set<Kitap>().Add(entity);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Business:KitapBusiness::KitapEkle::Error occured.", ex);
            }*/

            try
            {
                bool isSuccess;
                using (var repo = new KitapRepository())
                {
                    isSuccess = repo.Ekle(entity);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:KitapBusiness::InsertCustomer::Error occured.", ex);
            }
        }
        public bool Guncelle(Kitap entity)
        {
            try
            {
                bool isSuccess;
                using (var repo = new KitapRepository())
                {
                    isSuccess = repo.Guncelle(entity);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:KitapBusiness::GuncelleKitap::Error occured.", ex);
            }
        }
        public bool Sil(int id)
        {
            try
            {
                bool isSuccess;
                using (var repo = new KitapRepository())
                {
                    isSuccess = repo.DeleteById(id);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:CustomerBusiness::DeleteCustomer::Error occured.", ex);
            }
        }

        public Kitap GetById(int id)
        {
            try
            {
                Kitap responseEntitiy;
                using (var repo = new KitapRepository())
                {
                    responseEntitiy = repo.GetById(id);
                    if (responseEntitiy == null)
                        throw new NullReferenceException("Boyle bir kitap yok!");
                }
                return responseEntitiy;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:CustomerBusiness::SelectCustomerById::Error occured.", ex);
            }
        }

        public List<Kitap> Listele()
        {
            var responseEntities = new List<Kitap>();

            try
            {
                using (var repo = new KitapRepository())
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
                throw new Exception("BusinessLogic:CustomerBusiness::SelectAllCustomers::Error occured.", ex);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
