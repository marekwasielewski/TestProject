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
        public void DeleteAMachine()
        {
            var service = new Service1();
            service.DeleteAMachine("Willi");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetAMachine()
        {
            var service = new Service1();
            var machine = service.GetAMachine("willy");
            if(machine.type == "bulldozer" && machine.name == "willy" && machine._id == "5229c6e8e4b0bd7dbb07e29c")
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }

        [TestMethod()]
        public void GetAllMachines()
        {
            var service = new Service1();
            var machines = service.GetAllMachines();
            if (machines.Count() == 1
                && machines.First().type == "bulldozer"
                && machines.First().name == "willy"
                && machines.First()._id == "52341870ed55224b15ff07ef")
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }


    }
}