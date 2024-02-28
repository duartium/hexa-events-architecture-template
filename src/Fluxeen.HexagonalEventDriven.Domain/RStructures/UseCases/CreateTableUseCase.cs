using Fluxeen.HexagonalEventDriven.Domain.Base;
using Fluxeen.HexagonalEventDriven.Domain.RStructures.Entities;
using Fluxeen.HexagonalEventDriven.Domain.RStructures.Repositories;

namespace Fluxeen.HexagonalEventDriven.Domain.RStructures.UseCases
{
    public class CreateTableUseCase : IUseCase<R01, R01>
    {
        private readonly R01Repository _r01Repository;

        public CreateTableUseCase(R01Repository r01Repository)
        {
            _r01Repository = r01Repository;
        }

        public ValueTask<R01> Execute(R01 param)
        {
            return this._r01Repository.CreateTable(param);
        }
    }
}