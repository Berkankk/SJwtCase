using SJwtCase.Catalog.Context;
using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Repositories;

namespace SJwtCase.Catalog.Services.FeatureServices
{
    public class FeatureService : Repository<Feature>, IFeatureService
    {
        public FeatureService(CatalogContext catalogContext) : base(catalogContext)
        {
        }
    }
}
