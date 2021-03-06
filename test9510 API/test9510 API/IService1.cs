﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace test9510API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "machines")]
        test9510API.Models.Machine[] GetAllMachines();


        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "machines")]
        Models.CreateMachineResult CreateMachine(test9510API.Models.Machine machine);

        [OperationContract]
        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "machines/{name}")]
        test9510API.Models.Machine GetAMachine(string name);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
         UriTemplate = "machines/{name}")]
        void DeleteAMachine(string name);
    }
}
