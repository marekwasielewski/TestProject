using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using test9510API.Models;

namespace test9510API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public CreateMachineResult CreateMachine(Machine machine)
        {
            if (machine != null && machine.type == "bulldozer")
            {
                var context = WebOperationContext.Current;
                context.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Accepted;
                return new CreateMachineResult() { message = "Accepted" };
            }
            else
                return new CreateMachineResult() { message = "Error" };

        }

        public void DeleteAMachine(string name)
        {
            var context = WebOperationContext.Current;
            context.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.NoContent;

        }

        public test9510API.Models.Machine[] GetAllMachines()
        {
            return new test9510API.Models.Machine[]
                {
                    new test9510API.Models.Machine()
                    {
                        _id = "52341870ed55224b15ff07ef", type="bulldozer", name="willy"
                    }
                };

        }

        public Machine GetAMachine(string name)
        {
            if (name == "willy")
                return new Machine()
                {
                    type = "bulldozer",
                    name = "willy",
                    _id = "5229c6e8e4b0bd7dbb07e29c"
                };
            else
                return null;
        }
    }
}
