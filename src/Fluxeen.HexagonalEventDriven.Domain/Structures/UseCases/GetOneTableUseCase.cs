using Fluxeen.HexagonalEventDriven.Domain.Base;
using Fluxeen.HexagonalEventDriven.Domain.Structures.Entities;
using Fluxeen.HexagonalEventDriven.Domain.Structures.Repositories;

namespace Fluxeen.HexagonalEventDriven.Domain.Structures.UseCases
{
    public class GetOneTableUseCase : IUseCase<string, R01>
    {
        private readonly R01Repository _r01Repository;

        public GetOneTableUseCase(R01Repository r01Repository)
        {
            _r01Repository = r01Repository;
        }

        public ValueTask<R01> Execute(string id)
        {
            return this._r01Repository.GetOneTable(id);
        }
    }
}