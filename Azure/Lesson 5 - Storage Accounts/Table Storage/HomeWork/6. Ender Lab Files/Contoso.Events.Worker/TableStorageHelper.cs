﻿using Contoso.Events.Models;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Events.Worker
{
    public sealed class TableStorageHelper : StorageHelper
    {
        private readonly CloudTableClient _tableClient;

        public TableStorageHelper()
            : base()
        {
            _tableClient = base.StorageAccount.CreateCloudTableClient();
        }

        
        public IEnumerable<string> GetRegistrantNames(string eventKey)
        {
            //Dolev Start
            CloudTable table = _tableClient.GetTableReference("EventRegistrations");

            string partitionKey = eventKey;
            string filter = TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey);

            TableQuery<Registration> query = new TableQuery<Registration>().Where(filter);
            IEnumerable<Registration> registrations = table.ExecuteQuery<Registration>(query);

            IEnumerable<string> names = registrations
                .OrderBy(r => r.LastName)
                .ThenBy(r => r.FirstName)
                .Select(r => String.Format("{1}, {0}", r.FirstName, r.LastName));

            return names;
            //Dolev End
        }
    }
}