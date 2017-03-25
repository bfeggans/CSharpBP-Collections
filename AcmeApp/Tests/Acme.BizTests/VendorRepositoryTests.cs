using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod]
        public void RetrieveVendorsTest()
        {
            // Arrange
            var repo = new VendorRepository();

            // Act
            var vendors = repo.Retrieve();

            // Assert
            Assert.AreEqual(vendors.Count(), 2);
        }
    }
}