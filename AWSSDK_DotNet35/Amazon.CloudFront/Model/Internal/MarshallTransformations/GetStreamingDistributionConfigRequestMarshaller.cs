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
 * Do not modify this file. This file is generated from the cloudfront-2014-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetStreamingDistributionConfig Request Marshaller
    /// </summary>       
    public class GetStreamingDistributionConfigRequestMarshaller : IMarshaller<IRequest, GetStreamingDistributionConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetStreamingDistributionConfigRequest)input);
        }

        public IRequest Marshall(GetStreamingDistributionConfigRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "GET";
            string uriResourcePath = "/2014-10-21/streaming-distribution/{Id}/config";
            uriResourcePath = uriResourcePath.Replace("{Id}", publicRequest.IsSetId() ? StringUtils.FromString(publicRequest.Id) : string.Empty);
            request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }

        
    }    
}