using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RecyclingStation.WasteDisposal;

using RecyclingStation.WasteDisposal.Interfaces;
using RecyclingStation.Tests.MockedObjects;

namespace RecyclingStation.Tests
{
    [TestClass]
    public class StrategyHolderTests
    {
        private IStrategyHolder strategyHolder;

        private Mock<IGarbageDisposalStrategy> mockedStrategy;
        private Mock<IGarbageDisposalStrategy> mockedStrategy2;

        private Type mockedDisposableAttribute;
        private Type mockedDisposableAttribute2;
        private Type abstractDisposableAttribute;

        [TestInitialize]
        public void Initialize()
        {
            this.strategyHolder = new StrategyHolder();
            var mockStrategy = new Mock<IGarbageDisposalStrategy>();
            var mockStrategy2 = new Mock<IGarbageDisposalStrategy>();
            this.mockedDisposableAttribute = typeof(MockedDisposableAttribute);
            this.mockedDisposableAttribute2 = typeof(SecondMockedDisposableAttribute);
            this.abstractDisposableAttribute = typeof (AbstractDisposableAttribute);
            this.mockedStrategy = mockStrategy;
            this.mockedStrategy2 = mockStrategy2;
        }

        [TestMethod]
        public void GetDisposalStrategies_WithANewInstance_ShouldReturnAnEmptyCollection()
        {
            var strategies = this.strategyHolder.GetDisposalStrategies;
            Assert.AreEqual(0, strategies.Count, "Operation returned incorrect result!");
        }

        [TestMethod]
        public void GetDisposalStrategies_ShouldReturnAReadOnlyCollection()
        {
            var strategies = this.strategyHolder.GetDisposalStrategies;
            Assert.IsInstanceOfType(strategies, typeof(IReadOnlyDictionary<Type, IGarbageDisposalStrategy>), "Received object was not of expected type!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStrategy_WithATypeThatDoesNotInheritDisposableAttribute_ShouldThrowArgumentException()
        {
            this.strategyHolder.AddStrategy(typeof(string), this.mockedStrategy.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStrategy_WithATypeThatIsAbstract_ShouldThrowArgumentException()
        {
            this.strategyHolder.AddStrategy(this.abstractDisposableAttribute, this.mockedStrategy.Object);
        }

        [TestMethod]
        public void AddStrategy_WithAnAlreadyExistingAttributeClass_ShouldReturnFalse()
        {
            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);
            var result = this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);

            Assert.AreEqual(false, result, "Operation returned incorrect result!");
        }

        [TestMethod]
        public void AddStrategy_WithAnAlreadyExistingAttributeClass_ShouldNotAddItToTheExistingStrategies()
        {
            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);
            var result = this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);

            var strategies = this.strategyHolder.GetDisposalStrategies;
            Assert.AreEqual(1, strategies.Count, "Strategies count did not match!");
        }

        [TestMethod]
        public void AddStrategy_WithCorrectNonExistingValues_ShouldAddStrategyToCollection()
        {
            var strategies = this.strategyHolder.GetDisposalStrategies;
            Assert.AreEqual(0, strategies.Count, "Strategies count did not match!");

            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);

            Assert.AreEqual(1, strategies.Count, "Strategies count did not match!");
        }

        [TestMethod]
        public void AddStrategy_WithCorrectNonExistingValues_ShouldAddCorrectStrategy()
        {
            var strategies = this.strategyHolder.GetDisposalStrategies;

            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);

            var result = strategies[this.mockedDisposableAttribute];
            var expected = this.mockedStrategy.Object;
            Assert.AreEqual(expected, result, "Expected strategy did not match!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStrategy_WithATypeThatDoesNotInheritDisposableAttribute_ShouldThrowArgumentException()
        {
            this.strategyHolder.RemoveStrategy(typeof(string));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStrategy_WithATypeThatIsAbstract_ShouldThrowArgumentException()
        {
            this.strategyHolder.RemoveStrategy(this.abstractDisposableAttribute);
        }

        [TestMethod]
        public void RemoveStrategy_WithAnNonExistingAttributeClass_ShouldReturnFalse()
        {
            var result = this.strategyHolder.RemoveStrategy(this.mockedDisposableAttribute);

            Assert.AreEqual(false, result, "Operation returned incorrect result!");
        }

        [TestMethod]
        public void RemoveStrategy_WithAnNonExistingAttributeClass_ShouldNotRemoveItemsFromTheCollection()
        {
            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);

            var strategies = this.strategyHolder.GetDisposalStrategies;
            Assert.AreEqual(1, strategies.Count, "Strategies count did not match!");

            this.strategyHolder.RemoveStrategy(this.mockedDisposableAttribute2);

            Assert.AreEqual(1, strategies.Count, "Strategies count did not match!");
        }

        [TestMethod]
        public void RemoveStrategy_WithCorrectExistingAttributeClass_ShouldRemoveEntryFromTheCollection()
        {
            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);
            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute2, this.mockedStrategy2.Object);

            var strategies = this.strategyHolder.GetDisposalStrategies;
            Assert.AreEqual(2, strategies.Count, "Strategies count did not match!");

            this.strategyHolder.RemoveStrategy(this.mockedDisposableAttribute);

            Assert.AreEqual(1, strategies.Count, "Strategies count did not match!");
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void RemoveStrategy_WithCorrectExistingValueWithMultipleEntries_ShouldRemoveCorrectEntry()
        {
            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute, this.mockedStrategy.Object);
            this.strategyHolder.AddStrategy(this.mockedDisposableAttribute2, this.mockedStrategy2.Object);

            var strategies = this.strategyHolder.GetDisposalStrategies;

            this.strategyHolder.RemoveStrategy(this.mockedDisposableAttribute);

            var strategy = strategies[this.mockedDisposableAttribute];
        }
    }
}
