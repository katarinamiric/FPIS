using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IUgovorRepository
    {
        Task<List<UgovorOOsiguranju>> FilterUgovori(Expression<Func<UgovorOOsiguranju, bool>> filter); 
    }
}