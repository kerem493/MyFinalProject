using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //class : sadece class olabilir demek değil; referans tip olailir demek.
    //IEntity : IEntity veya IEntity'nin implemente ettiği bir nesne olabilir.
    //new() : bu kod ile IEntity gibi new'lenemeyen soyut nesnelerin yazılmasına engel olunur.

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
