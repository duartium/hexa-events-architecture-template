using Fluxeen.HexagonalEventDriven.Domain.RStructures.Entities;

namespace Fluxeen.HexagonalEventDriven.Domain.RStructures.Repositories
{
    public abstract class R01Repository
    {
        public abstract ValueTask<R01[]> GetTable();
        public abstract ValueTask<R01> GetOneTable(string id);
        public abstract ValueTask<R01> CreateTable(R01 table);
        public abstract ValueTask<R01> UpdateTable(string id);
        public abstract ValueTask<Boolean> DeleteTable(string id);
    }
}
