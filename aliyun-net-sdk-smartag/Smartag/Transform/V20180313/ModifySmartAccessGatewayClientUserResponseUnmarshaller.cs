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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class ModifySmartAccessGatewayClientUserResponseUnmarshaller
    {
        public static ModifySmartAccessGatewayClientUserResponse Unmarshall(UnmarshallerContext context)
        {
			ModifySmartAccessGatewayClientUserResponse modifySmartAccessGatewayClientUserResponse = new ModifySmartAccessGatewayClientUserResponse();

			modifySmartAccessGatewayClientUserResponse.HttpResponse = context.HttpResponse;
			modifySmartAccessGatewayClientUserResponse.RequestId = context.StringValue("ModifySmartAccessGatewayClientUser.RequestId");
			modifySmartAccessGatewayClientUserResponse.SmartAGId = context.StringValue("ModifySmartAccessGatewayClientUser.SmartAGId");
			modifySmartAccessGatewayClientUserResponse.ClientIp = context.StringValue("ModifySmartAccessGatewayClientUser.ClientIp");
			modifySmartAccessGatewayClientUserResponse.UserMail = context.StringValue("ModifySmartAccessGatewayClientUser.UserMail");
			modifySmartAccessGatewayClientUserResponse.UserName = context.StringValue("ModifySmartAccessGatewayClientUser.UserName");
			modifySmartAccessGatewayClientUserResponse.IsStaticIp = context.BooleanValue("ModifySmartAccessGatewayClientUser.IsStaticIp");
			modifySmartAccessGatewayClientUserResponse.IsSharedUser = context.BooleanValue("ModifySmartAccessGatewayClientUser.IsSharedUser");
			modifySmartAccessGatewayClientUserResponse.Bandwidth = context.IntegerValue("ModifySmartAccessGatewayClientUser.Bandwidth");
        
			return modifySmartAccessGatewayClientUserResponse;
        }
    }
}
