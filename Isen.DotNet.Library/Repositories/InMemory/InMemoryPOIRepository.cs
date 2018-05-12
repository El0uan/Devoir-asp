using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryPOIRepository : 
        BaseInMemoryRepository<POI>, IPOIRepository
    {
        private ICategoryRepository _categoryRepository;
        private IAddressRepository _addressRepository;
        // Constructeur avec pattern d'injection de dépendances (DI)
        public InMemoryPOIRepository(
            ILogger<InMemoryPOIRepository> logger,
            ICategoryRepository categoryRepository,IAddressRepository addressRepository) : base(logger)
        {
            _categoryRepository = categoryRepository;
            _addressRepository=addressRepository;
        }
        

        public override IQueryable<POI> ModelCollection
        {
            get
            {
                if (_modelCollection == null)
                {
                    _modelCollection = new List<POI>
                    {
                        new POI
                        {
                            Id = 1,
                            Name="POI1",
                            Description="C'est le 1e POI",
                            Category=_categoryRepository.Single(1),
                            Address=_addressRepository.Single(1)
                        },
                        new POI
                        {
                            Id = 2,
                            Name="POI2",
                            Description="C'est le 2e POI",
                            Category=_categoryRepository.Single(2),
                            Address=_addressRepository.Single(2)
                        }
                        
                    };
                }
                return _modelCollection.AsQueryable();
            }
        }
    }
}