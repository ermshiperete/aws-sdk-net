/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetIdentityPoolConfiguration Request Marshaller
    /// </summary>       
    public class GetIdentityPoolConfigurationRequestMarshaller : IMarshaller<IRequest, GetIdentityPoolConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetIdentityPoolConfigurationRequest)input);
        }

        public IRequest Marshall(GetIdentityPoolConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoSync");
            request.HttpMethod = "GET";

            string uriResourcePath = "/identitypools/{IdentityPoolId}/configuration";
            uriResourcePath = uriResourcePath.Replace("{IdentityPoolId}", publicRequest.IsSetIdentityPoolId() ? StringUtils.FromString(publicRequest.IdentityPoolId) : string.Empty);
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }


    }
}