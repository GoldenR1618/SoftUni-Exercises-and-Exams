using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.Tests.MockedObjects
{
    using RecyclingStation.WasteDisposal.Interfaces;

    [ThirdMockedDisposableAttribute]
    public class MockedWasteWithMockedAttribute : IWaste
    {
        public MockedWasteWithMockedAttribute()
        {
            
        }

        public string Name { get; }

        public double VolumePerKg { get; }

        public double Weight { get; }
    }
}
