using DinoManager.WebApp.Domain.Entities;
using DinoManager.WebApp.Domain.Queries;
using Tools.Cqs.Queries;

namespace DinoManager.WebApp.Domain.Repositories
{
    public interface IDinoRepository :
        IQueryHandler<GetAllDinoQuery, IEnumerable<Dino>>
    {
    }
}
