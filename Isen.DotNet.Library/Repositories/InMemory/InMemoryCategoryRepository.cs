using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryCategoryRepository : BaseInMemoryRepository<Category>, ICategoryRepository
    {
        public InMemoryCategoryRepository(
            ILogger<InMemoryCategoryRepository> logger) : base(logger)
        {
        }

        public override IQueryable<Category> ModelCollection
        {
            get
            {
                if (_modelCollection == null)
                {
                    _modelCollection = new List<Category>
                    {
                        new Category { 
                            Id = 1, 
                            Name = "Category 1" 
                            },
                        new Category { 
                            Id = 2, 
                            Name = "Category 2" 
                            }
                    };
                }
                return _modelCollection.AsQueryable();
            }
        }

        
    }
}