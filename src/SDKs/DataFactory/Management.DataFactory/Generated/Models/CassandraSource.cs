// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity source for a Cassandra database.
    /// </summary>
    public partial class CassandraSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the CassandraSource class.
        /// </summary>
        public CassandraSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CassandraSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="query">Database query. Should be a SQL-92 query
        /// expression or Cassandra Query Language (CQL) command. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="consistencyLevel">The consistency level specifies how
        /// many Cassandra servers must respond to a read request before
        /// returning data to the client application. Cassandra checks the
        /// specified number of Cassandra servers for data to satisfy the read
        /// request. Must be one of cassandraSourceReadConsistencyLevels. The
        /// default value is 'ONE'. It is case-insensitive. Possible values
        /// include: 'ALL', 'EACH_QUORUM', 'QUORUM', 'LOCAL_QUORUM', 'ONE',
        /// 'TWO', 'THREE', 'LOCAL_ONE', 'SERIAL', 'LOCAL_SERIAL'</param>
        public CassandraSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object query = default(object), string consistencyLevel = default(string))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait)
        {
            Query = query;
            ConsistencyLevel = consistencyLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database query. Should be a SQL-92 query expression or
        /// Cassandra Query Language (CQL) command. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets the consistency level specifies how many Cassandra
        /// servers must respond to a read request before returning data to the
        /// client application. Cassandra checks the specified number of
        /// Cassandra servers for data to satisfy the read request. Must be one
        /// of cassandraSourceReadConsistencyLevels. The default value is
        /// 'ONE'. It is case-insensitive. Possible values include: 'ALL',
        /// 'EACH_QUORUM', 'QUORUM', 'LOCAL_QUORUM', 'ONE', 'TWO', 'THREE',
        /// 'LOCAL_ONE', 'SERIAL', 'LOCAL_SERIAL'
        /// </summary>
        [JsonProperty(PropertyName = "consistencyLevel")]
        public string ConsistencyLevel { get; set; }

    }
}
