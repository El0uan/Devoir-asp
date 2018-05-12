using System;
using Isen.DotNet.Library.Models.Base;

namespace Isen.DotNet.Library.Models.Implementation
{
    public class POI : BaseModel
    {
        public string Name { get;set; }
        public string Description { get;set; }
        public Category Category { get;set; }
        public Address Address { get;set; }
    }
}