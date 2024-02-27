using Fluxeen.HexagonalEventDriven.Domain.Base;
using Fluxeen.HexagonalEventDriven.Domain.Structures.Entities;
using Fluxeen.HexagonalEventDriven.Domain.Structures.Repositories;

namespace Fluxeen.HexagonalEventDriven.Domain.Structures.UseCases
{
    public class GetTableUseCase : IUseCase<R01, R01[]>
    {
        private readonly R01Repository _r01Repository;

        public GetTableUseCase(R01Repository r01Repository)
        {
            _r01Repository = r01Repository;
        }

        public ValueTask<R01[]> Execute(R01? param = null)
        {
            return this._r01Repository.GetTable();
        }
    }
}