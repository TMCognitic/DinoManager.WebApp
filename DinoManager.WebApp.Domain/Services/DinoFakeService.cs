using DinoManager.WebApp.Domain.Entities;
using DinoManager.WebApp.Domain.Queries;
using DinoManager.WebApp.Domain.Repositories;

namespace DinoManager.WebApp.Domain.Services
{
    public class DinoFakeService : IDinoRepository
    {
        private readonly IList<Dino> _dinos;

        public DinoFakeService(IList<Dino> dinos)
        {
            _dinos = dinos;
        }

        public IEnumerable<Dino> Execute(GetAllDinoQuery query)
        {
            return _dinos;
        }
    }
}
