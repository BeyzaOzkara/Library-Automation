using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.DAL.Repositories.Abstractions;

namespace Library.DAL.Repositories.Concretes
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IDisposable
    {
        //singleton pattern kullanılarak tek bir context üzerinden gidilmesi sağlandı
        public static LibraryContext _context;

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

        public List<T> Listele()
        {
            return Context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public bool Ekle(T entity)
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Guncelle(T entity)
        {
            try
            {
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /*public bool Sil(T entity)
        {
            try
            {
                Context.Set<T>().Remove(entity);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }*/

        public bool DeleteById(int id)
        {
            try
            {
                Context.Set<T>().Remove(GetById(id));
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
