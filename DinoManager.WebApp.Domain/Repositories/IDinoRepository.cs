using DinoManager.WebApp.Domain.Entities;
using DinoManager.WebApp.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace DinoManager.WebApp.Domain.Repositories
{
    public interface IDinoRepository :
        IQueryHandler<GetAllDinoQuery, IEnumerable<Dino>>
    {
    }
}
