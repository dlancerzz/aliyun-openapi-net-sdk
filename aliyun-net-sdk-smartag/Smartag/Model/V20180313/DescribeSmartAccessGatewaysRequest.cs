/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class DescribeSmartAccessGatewaysRequest : RpcAcsRequest<DescribeSmartAccessGatewaysResponse>
    {
        public DescribeSmartAccessGatewaysRequest()
            : base("Smartag", "2018-03-13", "DescribeSmartAccessGateways", "smartag", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string aclIds;

		private string unboundAclIds;

		private string pageNumber;

		private string pageSize;

		private string instanceType;

		private string serialNumber;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string associatedCcnId;

		private long? ownerId;

		private string name;

		private string smartAGId;

		private string status;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string AclIds
		{
			get
			{
				return aclIds;
			}
			set	
			{
				aclIds = value;
				DictionaryUtil.Add(QueryParameters, "AclIds", value);
			}
		}

		public string UnboundAclIds
		{
			get
			{
				return unboundAclIds;
			}
			set	
			{
				unboundAclIds = value;
				DictionaryUtil.Add(QueryParameters, "UnboundAclIds", value);
			}
		}

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string SerialNumber
		{
			get
			{
				return serialNumber;
			}
			set	
			{
				serialNumber = value;
				DictionaryUtil.Add(QueryParameters, "SerialNumber", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string AssociatedCcnId
		{
			get
			{
				return associatedCcnId;
			}
			set	
			{
				associatedCcnId = value;
				DictionaryUtil.Add(QueryParameters, "AssociatedCcnId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGId", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override DescribeSmartAccessGatewaysResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSmartAccessGatewaysResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
