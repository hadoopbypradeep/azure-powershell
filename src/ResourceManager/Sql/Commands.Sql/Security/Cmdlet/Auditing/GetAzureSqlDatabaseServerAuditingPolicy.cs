﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Sql.Security.Model;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Sql.Security.Cmdlet.Auditing
{
    /// <summary>
    /// Returns the auditing policy of a specific database server.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureSqlDatabaseServerAuditingPolicy"), OutputType(typeof(ServerAuditingPolicyModel))]
    public class GetAzureSqlDatabaseServerAuditingPolicy : SqlDatabaseServerAuditingCmdletBase
    {
        /// <summary>
        /// No sending is needed as this is a Get cmdlet
        /// </summary>
        /// <param name="model">The model object with the data to be sent to the REST endpoints</param>
        protected override ServerAuditingPolicyModel PersistChanges(ServerAuditingPolicyModel model)
        {
            return null;
        }
    }
}