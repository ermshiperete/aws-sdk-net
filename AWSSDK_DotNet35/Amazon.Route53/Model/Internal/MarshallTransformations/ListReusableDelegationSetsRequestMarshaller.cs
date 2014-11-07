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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListReusableDelegationSets Request Marshaller
    /// </summary>       
    public class ListReusableDelegationSetsRequestMarshaller : IMarshaller<IRequest, ListReusableDelegationSetsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListReusableDelegationSetsRequest)input);
        }

        public IRequest Marshall(ListReusableDelegationSetsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            string uriResourcePath = "/2013-04-01/delegationset";
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("maxitems", StringUtils.FromString(publicRequest.MaxItems));
            request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }

        
    }    
}