using Microsoft.VisualStudio.TestTools.UnitTesting;
using Car_Unit_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Unit_Test.Tests
{
    [TestClass()]

    public class CarTests
    {
        Car myBadCar = new() { Id = 1, Model = "BMW", Price = -11, LicensePlate = "AAX98292" };
        Car myPerfectCar = new() { Id = 2, Model = "B66jj", Price = 11, LicensePlate = "AAX9829" };
        [TestMethod()]
        public void ValidateModelTest()
        {            
            myPerfectCar.ValidateModel();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { myBadCar.ValidateModel(); });
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { new Car { Model = null }.ValidateModel(); });
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            myPerfectCar.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { myBadCar.ValidatePrice(); });
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            myPerfectCar.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { myBadCar.ValidateLicensePlate(); });
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { new Car { LicensePlate = "X"}.ValidateLicensePlate(); });
        }
    }
}