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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CreateReusableDelegationSetResult : AmazonWebServiceResponse
    {
        private DelegationSet _delegationSet;
        private string _location;

        /// <summary>
        /// Gets and sets the property DelegationSet. 
        /// <para>
        /// A complex type that contains name server information.
        /// </para>
        /// </summary>
        public DelegationSet DelegationSet
        {
            get { return this._delegationSet; }
            set { this._delegationSet = value; }
        }

        // Check to see if DelegationSet property is set
        internal bool IsSetDelegationSet()
        {
            return this._delegationSet != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The unique URL representing the new reusbale delegation set.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}