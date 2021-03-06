﻿/*
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Util;
using Amazon.Util;

namespace Amazon.S3.Internal
{
    public class AmazonS3RedirectHandler : RedirectHandler
    {
        protected override void FinalizeForRedirect(IExecutionContext executionContext, string redirectedLocation)
        {
            var request = executionContext.RequestContext.Request;
            if (request.UseChunkEncoding)
            {
                if (request.Headers.ContainsKey(HeaderKeys.XAmzDecodedContentLengthHeader))
                {
                    request.Headers[HeaderKeys.ContentLengthHeader] =
                        request.Headers[HeaderKeys.XAmzDecodedContentLengthHeader];
                }
            }

            if (request.Headers.ContainsKey(HeaderKeys.HostHeader))
            {
                request.Headers.Remove(HeaderKeys.HostHeader);
            }


            base.FinalizeForRedirect(executionContext, redirectedLocation);

            var redirect = new AmazonS3Uri(redirectedLocation);
            if (AWSConfigs.S3Config.UseSignatureVersion4 ||                
                redirect.Region.GetEndpointForService("s3").SignatureVersionOverride == "4")
            {
                // Resign if sigV4 is enabled or if the redirected region mandates sigV4.
                // resign appropriately for the redirected region, re-instating the user's client 
                // config to original state when done
                var oldAuthRegion = executionContext.RequestContext.ClientConfig.AuthenticationRegion;
                executionContext.RequestContext.ClientConfig.AuthenticationRegion = redirect.Region.SystemName;
                try
                {
                    Signer.SignRequest(executionContext.RequestContext);
                }
                finally
                {
                    executionContext.RequestContext.ClientConfig.AuthenticationRegion = oldAuthRegion;
                }
            }
        }
    }
}
