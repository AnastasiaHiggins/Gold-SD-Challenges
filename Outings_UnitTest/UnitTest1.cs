using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Outings_ClassLibrary;

namespace Outings_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            Outings _outing1 = new Outings(29, EventType.Bowling, new DateTime(2020, 01, 30), 25.00d, 781.00d);
            Outings _outing2 = new Outings(37, EventType.Golf, new DateTime(2020, 10, 26), 50.00d, 1234.50d);
            Outings_Repository _repo = new Outings_Repository();

            [TestMethod]
            void AddNewOuting_ReturnTrue()
            {
                //Arrange

                //Act
                bool wasAdded = _repo.AddNewOuting(_outing1);
                //Assert
                Assert.IsTrue(wasAdded);
            }

            [TestMethod]
            void SeeAllOutings_ShouldShowAll()
            {
                //Arrange
                _repo.CreateNewOuting(_outing1);
                _repo.CreateNewOuting(_outing2);

                //Act
                List<Outings> contents = _repo.SeeAllOutings();
                bool OutingOne = contents.Contains(_outing1);
                bool OutingTwo = contents.Contains(_outing2);

                //Assert
                Assert.IsTrue(OutingOne);
                Assert.IsTrue(OutingTwo);
            }

            [TestMethod]
            void CostOfOutings_ShouldBeEqual()
            {
                //Arrange
                _repo.AddNewOuting(_outing1);
                _repo.AddNewOuting(_outing2);

                double total = 2812.89d;
                //Act

                //Assert
                Assert.AreEqual(_repo.CombinedCost(), total);
            }

            [TestMethod]
            void CostsByType_ShouldShowCosts()
            {
                //Arrange
                _repo.AddNewOuting(_outing1);
                _repo.AddNewOuting(_outing2);
                double total = 2712.85d;
                //Act

                //Assert
                Assert.AreEqual(_repo.CostsByType(EventType.Bowling), total);
            }
        }
    }
}
