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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeInstanceSpecInfoResponseUnmarshaller
    {
        public static DescribeInstanceSpecInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceSpecInfoResponse describeInstanceSpecInfoResponse = new DescribeInstanceSpecInfoResponse();

			describeInstanceSpecInfoResponse.HttpResponse = context.HttpResponse;
			describeInstanceSpecInfoResponse.RequestId = context.StringValue("DescribeInstanceSpecInfo.RequestId");
			describeInstanceSpecInfoResponse.InstanceId = context.StringValue("DescribeInstanceSpecInfo.InstanceId");
			describeInstanceSpecInfoResponse.Version = context.StringValue("DescribeInstanceSpecInfo.Version");
			describeInstanceSpecInfoResponse.ExpireTime = context.LongValue("DescribeInstanceSpecInfo.ExpireTime");

			List<DescribeInstanceSpecInfoResponse.DescribeInstanceSpecInfo_InstanceSpecInfo> describeInstanceSpecInfoResponse_instanceSpecInfos = new List<DescribeInstanceSpecInfoResponse.DescribeInstanceSpecInfo_InstanceSpecInfo>();
			for (int i = 0; i < context.Length("DescribeInstanceSpecInfo.InstanceSpecInfos.Length"); i++) {
				DescribeInstanceSpecInfoResponse.DescribeInstanceSpecInfo_InstanceSpecInfo instanceSpecInfo = new DescribeInstanceSpecInfoResponse.DescribeInstanceSpecInfo_InstanceSpecInfo();
				instanceSpecInfo._Value = context.StringValue("DescribeInstanceSpecInfo.InstanceSpecInfos["+ i +"].Value");
				instanceSpecInfo.Code = context.StringValue("DescribeInstanceSpecInfo.InstanceSpecInfos["+ i +"].Code");

				describeInstanceSpecInfoResponse_instanceSpecInfos.Add(instanceSpecInfo);
			}
			describeInstanceSpecInfoResponse.InstanceSpecInfos = describeInstanceSpecInfoResponse_instanceSpecInfos;
        
			return describeInstanceSpecInfoResponse;
        }
    }
}
