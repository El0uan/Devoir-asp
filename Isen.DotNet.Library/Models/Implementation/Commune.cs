using System;
using Isen.DotNet.Library.Models.Base;

namespace Isen.DotNet.Library.Models.Implementation
{
    public class Commune : BaseModel
    {
        public string Name { get;set; }
        public float Latitude { get;set; }
        public float Longitude { get;set; }
    }
}