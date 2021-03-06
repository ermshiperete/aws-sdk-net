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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS
{
    /// <summary>
    /// Implementation for accessing RDS
    ///
    /// Amazon Relational Database Service 
    /// <para>
    ///  Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier
    /// to set up, operate, and scale a relational database in the cloud. It provides cost-efficient,
    /// resizable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their
    /// applications and businesses unique. 
    /// </para>
    ///  
    /// <para>
    ///  Amazon RDS gives you access to the capabilities of a MySQL, PostgreSQL, Microsoft
    /// SQL Server, or Oracle database server. This means the code, applications, and tools
    /// you already use today with your existing databases work with Amazon RDS without modification.
    /// Amazon RDS automatically backs up your database and maintains the database software
    /// that powers your DB instance. Amazon RDS is flexible: you can scale your database
    /// instance's compute resources and storage capacity to meet your application's demand.
    /// As with all Amazon Web Services, there are no up-front investments, and you pay only
    /// for the resources you use. 
    /// </para>
    ///  
    /// <para>
    ///  This is an interface reference for Amazon RDS. It contains documentation for a programming
    /// or command line interface you can use to manage Amazon RDS. Note that Amazon RDS is
    /// asynchronous, which means that some interfaces may require techniques such as polling
    /// or callback functions to determine when a command has been applied. In this reference,
    /// the parameter descriptions indicate whether a command is applied immediately, on the
    /// next instance reboot, or during the maintenance window. For a summary of the Amazon
    /// RDS interfaces, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonRDSClient : AmazonServiceClient, IAmazonRDS
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRDSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig()) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AmazonRDSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRDSClient(AWSCredentials credentials)
            : this(credentials, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRDSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials and an
        /// AmazonRDSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AWSCredentials credentials, AmazonRDSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddSourceIdentifierToSubscription

        /// <summary>
        /// Adds a source identifier to an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by RDS.</returns>
        /// <exception cref="SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        public AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionRequest,AddSourceIdentifierToSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddSourceIdentifierToSubscriptionRequest,AddSourceIdentifierToSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        /// <summary>
        /// Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost
        /// allocation reporting to track cost associated with Amazon RDS resources, or used in
        /// Condition statement in IAM policy for Amazon RDS.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging Amazon RDS resources, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        public AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeDBSecurityGroupIngress

        /// <summary>
        /// Enables ingress to a DBSecurityGroup using one of two forms of authorization. First,
        /// EC2 or VPC security groups can be added to the DBSecurityGroup if the application
        /// using the database is running on EC2 or VPC instances. Second, IP ranges are available
        /// if the application accessing your database is running on the Internet. Required parameters
        /// for this API are one of CIDR range, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId
        /// and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC). 
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="AuthorizationAlreadyExistsException">
        /// The specified CIDRIP or EC2 security group is already authorized for the specified
        /// DB security group.
        /// </exception>
        /// <exception cref="AuthorizationQuotaExceededException">
        /// DB security group authorization quota has been reached.
        /// </exception>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        public AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeDBSecurityGroupIngressRequest,AuthorizeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeDBSecurityGroupIngressRequest,AuthorizeDBSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBParameterGroup

        /// <summary>
        /// Copies the specified DBParameterGroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        public CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupRequest,CopyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBParameterGroupRequest,CopyDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBSnapshot

        /// <summary>
        /// Copies the specified DBSnapshot. The source DBSnapshot must be in the "available"
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        public CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
        {
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBSnapshotRequest,CopyDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBSnapshotRequest,CopyDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyOptionGroup

        /// <summary>
        /// Copies the specified Option Group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup service method.</param>
        /// 
        /// <returns>The response from the CopyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this AWS account.
        /// </exception>
        public CopyOptionGroupResponse CopyOptionGroup(CopyOptionGroupRequest request)
        {
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var unmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CopyOptionGroupRequest,CopyOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyOptionGroupResponse> CopyOptionGroupAsync(CopyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var unmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyOptionGroupRequest,CopyOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstance

        /// <summary>
        /// Creates a new DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group. 
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not
        /// all in a common VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceRequest,CreateDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceRequest,CreateDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstanceReadReplica

        /// <summary>
        /// Creates a DB instance that acts as a read replica of a source DB instance. 
        /// 
        ///  
        /// <para>
        ///  All read replica DB instances are created as Single-AZ deployments with backups disabled.
        /// All other DB instance attributes (including DB security groups and DB parameter groups)
        /// are inherited from the source DB instance, except as specified below. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  The source DB instance must have backup retention enabled. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="DBSubnetGroupNotAllowedException">
        /// Indicates that the DBSubnetGroup should not be specified while creating read replicas
        /// that lie in the same region as the source instance.
        /// </exception>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidDBSubnetGroupException">
        /// Indicates the DBSubnetGroup does not belong to the same VPC as that of an existing
        /// cross region read replica of the same source instance.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not
        /// all in a common VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        public CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
        {
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceReadReplicaRequest,CreateDBInstanceReadReplicaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceReadReplicaRequest,CreateDBInstanceReadReplicaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBParameterGroup

        /// <summary>
        /// Creates a new DB parameter group. 
        /// 
        ///  
        /// <para>
        ///  A DB parameter group is initially created with the default parameters for the database
        /// engine used by the DB instance. To provide custom values for any of the parameters,
        /// you must modify the group after creating it using <i>ModifyDBParameterGroup</i>. Once
        /// you've created a DB parameter group, you need to associate it with your DB instance
        /// using <i>ModifyDBInstance</i>. When you associate a new DB parameter group with a
        /// running DB instance, you need to reboot the DB instance without failover for the new
        /// DB parameter group and associated settings to take effect. 
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the create action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        public CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBParameterGroupRequest,CreateDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBParameterGroupRequest,CreateDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSecurityGroup

        /// <summary>
        /// Creates a new DB security group. DB security groups control access to a DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBSecurityGroupAlreadyExistsException">
        /// A DB security group with the name specified in <i>DBSecurityGroupName</i> already
        /// exists.
        /// </exception>
        /// <exception cref="DBSecurityGroupNotSupportedException">
        /// A DB security group is not allowed for this action.
        /// </exception>
        /// <exception cref="DBSecurityGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB security groups.
        /// </exception>
        public CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSecurityGroupRequest,CreateDBSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSecurityGroupRequest,CreateDBSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSnapshot

        /// <summary>
        /// Creates a DBSnapshot. The source DBInstance must be in "available" state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        public CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBSnapshotRequest,CreateDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSnapshotRequest,CreateDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSubnetGroup

        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBSubnetGroupAlreadyExistsException">
        /// <i>DBSubnetGroupName</i> is already used by an existing DB subnet group.
        /// </exception>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="DBSubnetGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB subnet groups.
        /// </exception>
        /// <exception cref="DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not
        /// all in a common VPC.
        /// </exception>
        public CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupRequest,CreateDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSubnetGroupRequest,CreateDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription

        /// <summary>
        /// Creates an RDS event notification subscription. This action requires a topic ARN (Amazon
        /// Resource Name) created by either the RDS console, the SNS console, or the SNS API.
        /// To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe to
        /// the topic. The ARN is displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (SourceType) you want to be notified of, provide
        /// a list of RDS sources (SourceIds) that triggers the events, and provide a list of
        /// event categories (EventCategories) for events you want to be notified of. For example,
        /// you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2
        /// and EventCategories = Availability, Backup.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the SourceType and SourceIds, such as SourceType = db-instance
        /// and SourceIdentifier = myDBInstance1, you will be notified of all the db-instance
        /// events for the specified source. If you specify a SourceType but do not specify a
        /// SourceIdentifier, you will receive notice of the events for that source type for all
        /// your RDS sources. If you do not specify either the SourceType nor the SourceIdentifier,
        /// you will be notified of events generated from all RDS sources belonging to your customer
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SND topic specified.
        /// </exception>
        /// <exception cref="SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="SubscriptionAlreadyExistException">
        /// The supplied subscription name already exists.
        /// </exception>
        /// <exception cref="SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        public CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateOptionGroup

        /// <summary>
        /// Creates a new option group. You can create up to 20 option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this AWS account.
        /// </exception>
        public CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
        {
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateOptionGroupRequest,CreateOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOptionGroupRequest,CreateOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBInstance

        /// <summary>
        /// The DeleteDBInstance action deletes a previously provisioned DB instance. A successful
        /// response from the web service indicates the request was received correctly. When you
        /// delete a DB instance, all automated backups for that instance are deleted and cannot
        /// be recovered. Manual DB snapshots of the DB instance to be deleted are not deleted.
        /// 
        /// 
        ///  
        /// <para>
        ///  If a final DB snapshot is requested the status of the RDS instance will be "deleting"
        /// until the DB snapshot is created. The API action <code>DescribeDBInstance</code> is
        /// used to monitor the status of this operation. The action cannot be canceled or reverted
        /// once submitted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceRequest,DeleteDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBInstanceRequest,DeleteDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBParameterGroup

        /// <summary>
        /// Deletes a specified DBParameterGroup. The DBParameterGroup to be deleted cannot be
        /// associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        public DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBParameterGroupRequest,DeleteDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBParameterGroupRequest,DeleteDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSecurityGroup

        /// <summary>
        /// Deletes a DB security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        public DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSecurityGroupRequest,DeleteDBSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSecurityGroupRequest,DeleteDBSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSnapshot

        /// <summary>
        /// Deletes a DBSnapshot. If the snapshot is being copied, the copy operation is terminated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        public DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSnapshotRequest,DeleteDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSnapshotRequest,DeleteDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSubnetGroup

        /// <summary>
        /// Deletes a DB subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="InvalidDBSubnetStateException">
        /// The DB subnet is not in the <i>available</i> state.
        /// </exception>
        public DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupRequest,DeleteDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSubnetGroupRequest,DeleteDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription

        /// <summary>
        /// Deletes an RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="InvalidEventSubscriptionStateException">
        /// This error can occur if someone else is modifying a subscription. You should retry
        /// the action.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        public DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteOptionGroup

        /// <summary>
        /// Deletes an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="InvalidOptionGroupStateException">
        /// The option group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        public DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
        {
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteOptionGroupRequest,DeleteOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOptionGroupRequest,DeleteOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBEngineVersions

        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        public DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }

        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        public DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsRequest,DescribeDBEngineVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBEngineVersionsRequest,DescribeDBEngineVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBInstances

        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        public DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }

        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesRequest,DescribeDBInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBInstancesRequest,DescribeDBInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBLogFiles

        /// <summary>
        /// Returns a list of DB log files for the DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles service method.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        public DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
        {
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBLogFilesRequest,DescribeDBLogFilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBLogFilesRequest,DescribeDBLogFilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameterGroups

        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        public DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }

        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        public DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsRequest,DescribeDBParameterGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParameterGroupsRequest,DescribeDBParameterGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameters

        /// <summary>
        /// Returns the detailed parameter list for a particular DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        public DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParametersRequest,DescribeDBParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParametersRequest,DescribeDBParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSecurityGroups

        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }

        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSecurityGroupsRequest,DescribeDBSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSecurityGroupsRequest,DescribeDBSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshots

        /// <summary>
        /// Returns information about DB snapshots. This API supports pagination.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        public DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }

        /// <summary>
        /// Returns information about DB snapshots. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        public DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotsRequest,DescribeDBSnapshotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSnapshotsRequest,DescribeDBSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSubnetGroups

        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup. 
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }

        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup. 
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsRequest,DescribeDBSubnetGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSubnetGroupsRequest,DescribeDBSubnetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters

        /// <summary>
        /// Returns the default engine and system parameter information for the specified database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by RDS.</returns>
        public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersRequest,DescribeEngineDefaultParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultParametersRequest,DescribeEngineDefaultParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> topic in the Amazon RDS User Guide.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        public DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }

        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> topic in the Amazon RDS User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        public DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB
        /// parameter groups for the past 14 days. Events specific to a particular DB instance,
        /// DB security group, database snapshot, or DB parameter group can be obtained by providing
        /// the name as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }

        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB
        /// parameter groups for the past 14 days. Events specific to a particular DB instance,
        /// DB security group, database snapshot, or DB parameter group can be obtained by providing
        /// the name as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status. 
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }

        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status. 
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroupOptions

        /// <summary>
        /// Describes all available options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by RDS.</returns>
        public DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
        {
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupOptionsRequest,DescribeOptionGroupOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupOptionsRequest,DescribeOptionGroupOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroups

        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        public DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }

        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        public DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
        {
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupsRequest,DescribeOptionGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupsRequest,DescribeOptionGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        /// <summary>
        /// Returns a list of orderable DB instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by RDS.</returns>
        public DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsRequest,DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableDBInstanceOptionsRequest,DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstances

        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        public DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }

        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        public DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
        {
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesRequest,DescribeReservedDBInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesRequest,DescribeReservedDBInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstancesOfferings

        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }

        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
        {
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesOfferingsRequest,DescribeReservedDBInstancesOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesOfferingsRequest,DescribeReservedDBInstancesOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DownloadDBLogFilePortion

        /// <summary>
        /// Downloads all or a portion of the specified log file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        public DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
        {
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return Invoke<DownloadDBLogFilePortionRequest,DownloadDBLogFilePortionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return InvokeAsync<DownloadDBLogFilePortionRequest,DownloadDBLogFilePortionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBInstance

        /// <summary>
        /// Modify settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group. 
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on could not be modified.
        /// </exception>
        /// <exception cref="InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        public ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceRequest,ModifyDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBInstanceRequest,ModifyDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBParameterGroup

        /// <summary>
        /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
        /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request. 
        /// 
        ///  <important> 
        /// <para>
        /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the modify action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        public ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupRequest,ModifyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBParameterGroupRequest,ModifyDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup

        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one
        /// subnet in at least two AZs in the region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not
        /// all in a common VPC.
        /// </exception>
        /// <exception cref="SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        public ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupRequest,ModifyDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSubnetGroupRequest,ModifyDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription

        /// <summary>
        /// Modifies an existing RDS event notification subscription. Note that you cannot modify
        /// the source identifiers using this call; to change source identifiers for a subscription,
        /// use the <a>AddSourceIdentifierToSubscription</a> and <a>RemoveSourceIdentifierFromSubscription</a>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given SourceType in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// topic in the Amazon RDS User Guide or by using the <b>DescribeEventCategories</b>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SND topic specified.
        /// </exception>
        /// <exception cref="SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        public ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyOptionGroup

        /// <summary>
        /// Modifies an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="InvalidOptionGroupStateException">
        /// The option group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        public ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
        {
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyOptionGroupRequest,ModifyOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyOptionGroupRequest,ModifyOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplica

        /// <summary>
        /// Promotes a read replica DB instance to a standalone DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        public PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
        {
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaRequest,PromoteReadReplicaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteReadReplicaRequest,PromoteReadReplicaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedDBInstancesOffering

        /// <summary>
        /// Purchases a reserved DB instance offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by RDS.</returns>
        /// <exception cref="ReservedDBInstanceAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="ReservedDBInstanceQuotaExceededException">
        /// Request would exceed the user's DB Instance quota.
        /// </exception>
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        public PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
        {
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedDBInstancesOfferingRequest,PurchaseReservedDBInstancesOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedDBInstancesOfferingRequest,PurchaseReservedDBInstancesOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootDBInstance

        /// <summary>
        /// Rebooting a DB instance restarts the database engine service. A reboot also applies
        /// to the DB instance any modifications to the associated DB parameter group that were
        /// pending. Rebooting a DB instance results in a momentary outage of the instance, during
        /// which the DB instance status is set to rebooting. If the RDS instance is configured
        /// for MultiAZ, it is possible that the reboot will be conducted through a failover.
        /// An Amazon RDS event is created when the reboot is completed. 
        /// 
        ///  
        /// <para>
        ///  If your DB instance is deployed in multiple Availability Zones, you can force a failover
        /// from one AZ to the other during the reboot. You might force a failover to test the
        /// availability of your DB instance deployment or to restore operations to the original
        /// AZ after a failover occurs. 
        /// </para>
        ///  
        /// <para>
        ///  The time required to reboot is a function of the specific database engine's crash
        /// recovery process. To improve the reboot time, we recommend that you reduce database
        /// activities as much as possible during the reboot process to reduce rollback activity
        /// for in-transit transactions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        public RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceRequest,RebootDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDBInstanceRequest,RebootDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        /// <summary>
        /// Removes a source identifier from an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by RDS.</returns>
        /// <exception cref="SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        public RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionRequest,RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveSourceIdentifierFromSubscriptionRequest,RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes metadata tags from an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by RDS.</returns>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        public RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetDBParameterGroup

        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters submit a list of the following: <code>ParameterName</code>
        /// and <code>ApplyMethod</code>. To reset the entire DB parameter group, specify the
        /// <code>DBParameterGroup</code> name and <code>ResetAllParameters</code> parameters.
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <code>RebootDBInstance</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        public ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupRequest,ResetDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBParameterGroupRequest,ResetDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromDBSnapshot

        /// <summary>
        /// Creates a new DB instance from a DB snapshot. The target database is created from
        /// the source database restore point with the same configuration as the original source
        /// database, except that the new RDS instance is created with the default security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group. 
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not
        /// all in a common VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        public RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromDBSnapshotRequest,RestoreDBInstanceFromDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceFromDBSnapshotRequest,RestoreDBInstanceFromDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceToPointInTime

        /// <summary>
        /// Restores a DB instance to an arbitrary point-in-time. Users can restore to any point
        /// in time before the latestRestorableTime for up to backupRetentionPeriod days. The
        /// target database is created from the source database with the same configuration as
        /// the original database except that the DB instance is created with the default DB security
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group. 
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not
        /// all in a common VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="PointInTimeRestoreNotEnabledException">
        /// <i>SourceDBInstanceIdentifier</i> refers to a DB instance with <i>BackupRetentionPeriod</i>
        /// equal to 0.
        /// </exception>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        public RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceToPointInTimeRequest,RestoreDBInstanceToPointInTimeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceToPointInTimeRequest,RestoreDBInstanceToPointInTimeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeDBSecurityGroupIngress

        /// <summary>
        /// Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2
        /// or VPC Security Groups. Required parameters for this API are one of CIDRIP, EC2SecurityGroupId
        /// for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group. 
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        public RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeDBSecurityGroupIngressRequest,RevokeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeDBSecurityGroupIngressRequest,RevokeDBSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}