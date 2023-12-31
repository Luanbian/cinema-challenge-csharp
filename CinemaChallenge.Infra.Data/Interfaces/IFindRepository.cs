using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChallenge.Infra.Data.Interfaces
{
    public interface IFindRepository<T>
    {
        List<T> FindAll();
        List<T> FindBy(Expression<Func<T, bool>> filter);
    }
}
