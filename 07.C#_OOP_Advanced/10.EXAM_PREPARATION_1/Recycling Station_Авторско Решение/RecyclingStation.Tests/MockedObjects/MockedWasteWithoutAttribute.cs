using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.Tests.MockedObjects
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class MockedWasteWithoutAttribute: IWaste
    {
        public MockedWasteWithoutAttribute()
        {
            
        }
        public string Name { get; }

        public double VolumePerKg { get; }

        public double Weight { get; }
    }
}
