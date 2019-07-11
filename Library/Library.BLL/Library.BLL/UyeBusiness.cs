using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL.Repositories.Concretes;
using Library.Models;

namespace Library.BLL
{
    public class UyeBusiness : IDisposable
    {
        public bool Ekle(Uye entity)
        {
            try
            {
                bool isSuccess;
                using (var repo = new UyeRepository())
                {
                    isSuccess = repo.Ekle(entity);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:UyeBusiness::InsertUye::Error occured.", ex);
            }
        }


        public Uye GetById(int id)
        {
            try
            {
                Uye responseEntitiy;
                using (var repo = new UyeRepository())
                {
                    responseEntitiy = repo.GetById(id);
                    if (responseEntitiy == null)
                        throw new NullReferenceException("Böyle bir üye yok!");
                }
                return responseEntitiy;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:UyeBusiness::SelectUyeById::Error occured.", ex);
            }
        }

        public List<Uye> Listele()
        {
            var responseEntities = new List<Uye>();

            try
            {
                using (var repo = new UyeRepository())
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
                throw new Exception("BusinessLogic:UyeBusiness::SelectAllUye::Error occured.", ex);
            }
        }
        

        public bool Sil(int id)
        {
            try
            {
                bool isSuccess;
                using (var repo = new UyeRepository())
                {
                    isSuccess = repo.DeleteById(id);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:UyeBusiness::DeleteUye::Error occured.", ex);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
