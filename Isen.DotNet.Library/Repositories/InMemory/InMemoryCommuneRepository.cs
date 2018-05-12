using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryCommuneRepository : BaseInMemoryRepository<Commune>, ICommuneRepository
    {
        public InMemoryCommuneRepository(
            ILogger<InMemoryCommuneRepository> logger) : base(logger)
        {
        }

        public override IQueryable<Commune> ModelCollection
        {
            get
            {
                if (_modelCollection == null)
                {
                    _modelCollection = new List<Commune>
                    {
                        new Commune { 
                            Id = 1, 
                            Name = "Commune1" 
                            },
                        new Commune { 
                            Id = 2, 
                            Name = "Commune2" 
                            }
                    };
                }
                return _modelCollection.AsQueryable();
            }
        }

        
    }
}