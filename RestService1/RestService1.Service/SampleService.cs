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
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SampleService : ISampleService
    {
        public List<SampleItem> GetCollection()
        {
            return Database.Items.Values.ToList();
        }

        public SampleItem Create(SampleItem instance)
        {
            // Add the new instance of SampleItem to the collection
            Database.Items.Add(instance.Id, instance);
            return Database.Items[instance.Id];
        }

        public SampleItem Get(int id)
        {
            // Return the instance of SampleItem with the given id
            return Database.Items[id];
        }

        public SampleItem Update(int id, SampleItem instance)
        {
            // Update the given instance of SampleItem in the collection
            SampleItem item;
            if (Database.Items.TryGetValue(id, out item))
            {
                item.StringValue = instance.StringValue;
            }
            return instance;
        }

        public void Delete(int id)
        {
            // Remove the instance of SampleItem with the given id from the collection
            SampleItem item;
            if (Database.Items.TryGetValue(id, out item))
            {
                Database.Items.Remove(id);
            }
        }
    }
}
