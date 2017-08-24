using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.Tests.MockedObjects
{
    using RecyclingStation.WasteDisposal.Interfaces;
    [MockedDisposable]
    public class MockedWasteWithPresentAttribute : IWaste
    {
        public MockedWasteWithPresentAttribute()
        {
            
        }

        public string Name { get; }

        public double VolumePerKg { get; }

        public double Weight { get; }
    }
}
