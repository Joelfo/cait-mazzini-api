using CaitMazziniApp.Models.Charts;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IScannedChartMetadataRepository : IGenericRepository<ScannedChartMetadata, int>
    {
        public Task<ScannedChartMetadata> GetByPatient(int patientId);
    }
}
