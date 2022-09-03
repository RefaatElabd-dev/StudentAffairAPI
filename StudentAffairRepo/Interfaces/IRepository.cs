using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairRepo.Interfaces
{
    public interface IRepository<T, I>
    {
        public void insert(T entity);
        public ICollection<T> GetAll();

        public T GetById(I ID);

        public void Update(T entity);

        public bool Delete(I index);
    }
}
