using Microsoft.VisualStudio.TestTools.UnitTesting;
using test9510API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test9510API.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void DoWorkTest()
        {
            var service = new Service1();
            service.DeleteAMachine("Willi");
            Assert.Fail();
        }
    }
}