/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// <para>Identifiers for the temporary security credentials that the <c>AssumeRole</c> action returns.</para>
    /// </summary>
    public class AssumedRoleUser  
    {
        
        private string assumedRoleId;
        private string arn;

        /// <summary>
        /// A unique identifier that contains the role ID and the role session name of the role that is being assumed. The role ID was generated by AWS
        /// when the role was created.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 96</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@:-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AssumedRoleId
        {
            get { return this.assumedRoleId; }
            set { this.assumedRoleId = value; }
        }

        /// <summary>
        /// Sets the AssumedRoleId property
        /// </summary>
        /// <param name="assumedRoleId">The value to set for the AssumedRoleId property </param>
        /// <returns>this instance</returns>
        public AssumedRoleUser WithAssumedRoleId(string assumedRoleId)
        {
            this.assumedRoleId = assumedRoleId;
            return this;
        }
            

        // Check to see if AssumedRoleId property is set
        internal bool IsSetAssumedRoleId()
        {
            return this.assumedRoleId != null;       
        }

        /// <summary>
        /// The ARN of the temporary security credentials that are returned from the AssumeRole action. For more information about ARNs and how to use
        /// them in policies, see <a href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/Using_Identifiers.html" target="_blank"> Identifiers
        /// for IAM Entities</a> in <i>Using IAM</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        public AssumedRoleUser WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;       
        }
    }
}
