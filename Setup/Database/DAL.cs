using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Setup.Database
{
    internal class DAL<T> where T : class 
    {
        private readonly KhoraContext _context = new KhoraContext();

        public IEnumerable<T> ObterRegistros()
        {
            return _context.Set<T>().ToList();
        }

        public void AdicionarRegistro(T objeto)
        {
            _context.Set<T>().Add(objeto);
            _context.SaveChanges();
        }

        public void AtualizarRegistro(T objeto)
        {
            _context.Set<T>().Update(objeto);
            _context.SaveChanges();
        }

        public void DeletaRegistro(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            _context.SaveChanges();
        }

        public T? ObterRegistroPor(Func<T, bool> func)
        {
            return _context.Set<T>().FirstOrDefault(func);
        }

        public IEnumerable<T> ObterListaPor(Func<T, bool> func)
        {
            return _context.Set<T>().Where(func).ToList();
        }
    }
}
