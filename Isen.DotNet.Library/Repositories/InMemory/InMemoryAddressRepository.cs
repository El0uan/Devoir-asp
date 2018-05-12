using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryAddressRepository : 
        BaseInMemoryRepository<Address>, IAddressRepository
    {
        private ICommuneRepository _communeRepository;
        // Constructeur avec pattern d'injection de dépendances (DI)
        public InMemoryAddressRepository(
            ILogger<InMemoryAddressRepository> logger,
            ICommuneRepository communeRepository) : base(logger)
        {
            _communeRepository = communeRepository;
        }

        public override IQueryable<Address> ModelCollection
        {
            get
            {
                if (_modelCollection == null)
                {
                    _modelCollection = new List<Address>
                    {
                        new Address
                        {
                            Id = 1,
                            Text="1 Avenue du Chocolat",
                            Code=06200,
                            Commune=_communeRepository.Single(1),
                            Latitude=2,
                            Longitude=3
                        },
                        new Address
                        {
                            Id = 2,
                            Text="9 Avenue du Gateau",
                            Code=07200,
                            Commune=_communeRepository.Single(2),
                            Latitude=6,
                            Longitude=9
                        }
                        
                    };
                }
                return _modelCollection.AsQueryable();
            }
        }
    }
}