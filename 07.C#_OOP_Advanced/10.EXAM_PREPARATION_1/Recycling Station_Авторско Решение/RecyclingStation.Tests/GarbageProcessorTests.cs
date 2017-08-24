using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Tests
{
    using System.Collections.Generic;

    using RecyclingStation.Tests.MockedObjects;

    [TestClass]
    public class GarbageProcessorTests
    {
        private IGarbageProcessor garbageProcessor;
        private Mock<IStrategyHolder> mockedStrategyHolder;

        private Mock<IGarbageDisposalStrategy> mockedStrategy;
        private Mock<IGarbageDisposalStrategy> mockedStrategy2;

        private Type mockedDisposableAttribute;
        private Type mockedDisposableAttribute2;

        private Mock<IProcessingData> mockedProcessData;
        private Mock<IProcessingData> mockedProcessData2;

        [TestInitialize]
        public void Initialize()
        {
            this.mockedStrategyHolder = new Mock<IStrategyHolder>();
            Dictionary<Type,IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();

            var mockStrategy = new Mock<IGarbageDisposalStrategy>();
            var mockStrategy2 = new Mock<IGarbageDisposalStrategy>();
            var mockProcessData = new Mock<IProcessingData>();
            var mockProcessData2 = new Mock<IProcessingData>();
            this.mockedDisposableAttribute = typeof(MockedDisposableAttribute);
            this.mockedDisposableAttribute2 = typeof(SecondMockedDisposableAttribute);
            mockProcessData.Setup(x => x.CapitalBalance).Returns(10d);
            mockProcessData.Setup(x => x.EnergyBalance).Returns(20d);
            mockProcessData2.Setup(x => x.CapitalBalance).Returns(-50d);
            mockProcessData2.Setup(x => x.EnergyBalance).Returns(-100d);
            mockStrategy.Setup(x => x.ProcessGarbage(It.IsAny<IWaste>())).Returns(mockProcessData.Object);
            mockStrategy2.Setup(x => x.ProcessGarbage(It.IsAny<IWaste>())).Returns(mockProcessData2.Object);

            this.mockedProcessData = mockProcessData;
            this.mockedProcessData2 = mockProcessData2;
            this.mockedStrategy = mockStrategy;
            this.mockedStrategy2 = mockStrategy2;

            strategies.Add(this.mockedDisposableAttribute,this.mockedStrategy.Object);
            strategies.Add(this.mockedDisposableAttribute2,this.mockedStrategy2.Object);

            this.mockedStrategyHolder.Setup(x => x.GetDisposalStrategies)
                .Returns(strategies);
            this.garbageProcessor = new GarbageProcessor(this.mockedStrategyHolder.Object);
        }

        [TestMethod]
        public void GetStrategyHolder_WithAPassedInStrategyHolderInTheConstructor_ShouldReturnSameStrategyHolder()
        {
            Assert.AreEqual(this.mockedStrategyHolder.Object,this.garbageProcessor.StrategyHolder,"The method did not return the expected object!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProcessWaste_WithAWasteObjectThatDoesNotImplementAnDisposableAttribute_ShouldThrowAnArgumentException()
        {
            var fakeWaste = new MockedWasteWithoutAttribute();
            this.garbageProcessor.ProcessWaste(fakeWaste);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProcessWaste_WithAWasteObjectWhoseAttributeIsNotPresentInTheStrategyHolder_ShouldThrowAnArgumentException()
        {
            var fakeWaste = new MockedWasteWithMockedAttribute();
            this.garbageProcessor.ProcessWaste(fakeWaste);
        }

        [TestMethod]
        public void ProcessWaste_WithACorrectWasteObject_ShouldCallCorrectStrategy()
        {
            var fakeWaste = new MockedWasteWithPresentAttribute();
            this.garbageProcessor.ProcessWaste(fakeWaste);

            this.mockedStrategy.Verify(x=>x.ProcessGarbage(It.IsAny<IWaste>()),Times.Exactly(1));
        }

        [TestMethod]
        public void ProcessWaste_WithACorrectWasteObject_ShouldCallCorrectStrategyWithCorrectWaste()
        {
            var fakeWaste = new MockedWasteWithPresentAttribute();
            this.garbageProcessor.ProcessWaste(fakeWaste);

            this.mockedStrategy.Verify(x => x.ProcessGarbage(fakeWaste), Times.Exactly(1));
        }

        [TestMethod]
        public void ProcessWaste_WithACorrectWasteObject_ShouldReturnCorrectProcessDataObject()
        {
            var fakeWaste = new MockedWasteWithPresentAttribute();
            var result = this.garbageProcessor.ProcessWaste(fakeWaste);

            Assert.AreEqual(this.mockedProcessData.Object,result,"Expected object did not match!");
        }
    }
}
