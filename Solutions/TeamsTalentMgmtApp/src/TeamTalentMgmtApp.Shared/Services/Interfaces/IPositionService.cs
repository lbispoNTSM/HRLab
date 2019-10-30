using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using TeamTalentMgmtApp.Shared.Models.Commands;
using TeamTalentMgmtApp.Shared.Models.DatabaseContext;

namespace TeamTalentMgmtApp.Shared.Services.Interfaces
{
    public interface IPositionService
    {
        Task<ReadOnlyCollection<Position>> GetAllPositions(CancellationToken cancellationToken);
        Task<ReadOnlyCollection<Position>> Search(string searchText, int maxResults, CancellationToken cancellationToken = default);
        Task<Position> GetById(int positionId, CancellationToken cancellationToken = default);
        Task<Position> AddNewPosition(PositionCreateCommand positionCreateCommand, CancellationToken cancellationToken = default);
        Task<ReadOnlyCollection<Position>> GetOpenPositions(string recruiterNameOrAlias, CancellationToken cancellationToken = default);
        Task<Position> GetByExternalId(string externalId, CancellationToken cancellationToken = default);
    }
}