using System;
using Isen.DotNet.Library.Models.Base;

namespace Isen.DotNet.Library.Models.Implementation
{
    public class Address : BaseModel
    {
        public string Text { get;set; }
        public int Code { get;set; }
        public Commune Commune { get;set; }
        public float Latitude { get;set; }
        public float Longitude { get;set; }
    }
}