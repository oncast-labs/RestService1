using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using RestService1.Entities;

namespace RestService1.Service
{
    // Start the service and browse to http://<machine_name>:<port>/SampleService/help to view the service's generated help page
    [ServiceContract]
    public interface ISampleService
    {
        [WebGet(UriTemplate = "")]
        List<SampleItem> GetCollection();

        [WebInvoke(UriTemplate = "", Method = "POST")]
        SampleItem Create(SampleItem instance);

        [WebGet(UriTemplate = "?id={id}")]
        SampleItem Get(int id);

        [WebInvoke(UriTemplate = "?id={id}", Method = "PUT")]
        SampleItem Update(int id, SampleItem instance);

        [WebInvoke(UriTemplate = "?id={id}", Method = "DELETE")]
        void Delete(int id);
    }
}
