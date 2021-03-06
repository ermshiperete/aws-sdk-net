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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Implementation for accessing SimpleNotificationService
    ///
    /// Amazon Simple Notification Service        
    /// <para>
    /// Amazon Simple Notification Service (Amazon SNS) is a web service that enables you
    /// to build distributed web-enabled applications.         Applications can use Amazon SNS
    /// to easily push real-time notification messages         to interested subscribers over
    /// multiple delivery protocols. For more information about this product        see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
    /// For detailed information about Amazon SNS features and their associated API calls,        see
    /// the <a href="http://docs.aws.amazon.com/sns/latest/dg/">Amazon SNS Developer Guide</a>.    
    /// </para>
    ///     
    /// <para>
    /// We also provide SDKs that enable you to access Amazon SNS from your preferred programming
    /// language.       The SDKs contain functionality that automatically takes care of tasks
    /// such as: cryptographically signing your service requests,       retrying requests,
    /// and handling error responses. For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.      
    /// </para>
    /// </summary>
    public partial class AmazonSimpleNotificationServiceClient : AmazonServiceClient, IAmazonSimpleNotificationService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleNotificationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleNotificationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AmazonSimpleNotificationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials and an
        /// AmazonSimpleNotificationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleNotificationServiceConfig clientConfig)
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

        
        #region  AddPermission

        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// AWS accounts to the specified actions.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">A unique identifier for the new policy statement.</param>
        /// <param name="awsAccountId">The AWS account IDs of the users (principals) who will be given access to the specified actions. The users must have AWS accounts, but do not need to be signed up  for this service. </param>
        /// <param name="actionName">The action you want to allow for the specified principal(s). Valid values: any Amazon SNS action name.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public AddPermissionResponse AddPermission(string topicArn, string label, List<string> awsAccountId, List<string> actionName)
        {
            var request = new AddPermissionRequest();
            request.TopicArn = topicArn;
            request.Label = label;
            request.AWSAccountId = awsAccountId;
            request.ActionName = actionName;
            return AddPermission(request);
        }

        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// AWS accounts to the specified actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return Invoke<AddPermissionRequest,AddPermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AddPermissionRequest,AddPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConfirmSubscription

        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating      the token
        /// sent to the endpoint by an earlier <code>Subscribe</code> action. If the      token
        /// is valid, the action creates a new subscription and returns its      Amazon Resource
        /// Name (ARN). This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        /// <param name="authenticateOnUnsubscribe">Disallows unauthenticated unsubscribes of the subscription.  If the value of this parameter is <code>true</code> and the request has an AWS signature, then only the topic owner and the subscription owner can unsubscribe the endpoint.  The unsubscribe action requires AWS authentication. </param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        public ConfirmSubscriptionResponse ConfirmSubscription(string topicArn, string token, string authenticateOnUnsubscribe)
        {
            var request = new ConfirmSubscriptionRequest();
            request.TopicArn = topicArn;
            request.Token = token;
            request.AuthenticateOnUnsubscribe = authenticateOnUnsubscribe;
            return ConfirmSubscription(request);
        }

        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating      the token
        /// sent to the endpoint by an earlier <code>Subscribe</code> action. If the      token
        /// is valid, the action creates a new subscription and returns its      Amazon Resource
        /// Name (ARN). This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        public ConfirmSubscriptionResponse ConfirmSubscription(string topicArn, string token)
        {
            var request = new ConfirmSubscriptionRequest();
            request.TopicArn = topicArn;
            request.Token = token;
            return ConfirmSubscription(request);
        }

        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating      the token
        /// sent to the endpoint by an earlier <code>Subscribe</code> action. If the      token
        /// is valid, the action creates a new subscription and returns its      Amazon Resource
        /// Name (ARN). This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription service method.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        public ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            var marshaller = new ConfirmSubscriptionRequestMarshaller();
            var unmarshaller = ConfirmSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ConfirmSubscriptionRequest,ConfirmSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmSubscriptionRequestMarshaller();
            var unmarshaller = ConfirmSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmSubscriptionRequest,ConfirmSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePlatformApplication

        /// <summary>
        /// Creates a platform application object for one of the supported push notification services,
        ///       such as APNS and GCM, to which devices and mobile apps may register. You must
        /// specify PlatformPrincipal and PlatformCredential attributes when using       the <code>CreatePlatformApplication</code>
        /// action. The PlatformPrincipal is received from the notification service. For APNS/APNS_SANDBOX,
        /// PlatformPrincipal is "SSL certificate".       For GCM, PlatformPrincipal is not applicable.
        /// For ADM, PlatformPrincipal is "client id". The PlatformCredential is also received
        /// from the notification service.       For APNS/APNS_SANDBOX, PlatformCredential is
        /// "private key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential
        /// is "client secret".            The PlatformApplicationArn that is returned when using
        /// <code>CreatePlatformApplication</code> is then used as an attribute for the <code>CreatePlatformEndpoint</code>
        /// action.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            var marshaller = new CreatePlatformApplicationRequestMarshaller();
            var unmarshaller = CreatePlatformApplicationResponseUnmarshaller.Instance;

            return Invoke<CreatePlatformApplicationRequest,CreatePlatformApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePlatformApplicationResponse> CreatePlatformApplicationAsync(CreatePlatformApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlatformApplicationRequestMarshaller();
            var unmarshaller = CreatePlatformApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlatformApplicationRequest,CreatePlatformApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePlatformEndpoint

        /// <summary>
        /// Creates an endpoint for a device and mobile app on one of the supported push notification
        /// services, such as GCM and APNS.       <code>CreatePlatformEndpoint</code> requires
        /// the PlatformApplicationArn that is returned from <code>CreatePlatformApplication</code>.
        /// The EndpointArn that is      returned when using <code>CreatePlatformEndpoint</code>
        /// can then be used by the <code>Publish</code> action to send a message to a mobile
        /// app or by the <code>Subscribe</code>       action for subscription to a topic. The
        /// <code>CreatePlatformEndpoint</code> action is idempotent, so if the requester already
        /// owns an endpoint with the same device token and attributes,       that endpoint's
        /// ARN is returned without creating a new endpoint.       For more information, see <a
        /// href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS
        /// Mobile Push Notifications</a>.    
        /// 
        ///     
        /// <para>
        /// When using <code>CreatePlatformEndpoint</code> with Baidu, two attributes must be
        /// provided: ChannelId and UserId. The token field must also contain the ChannelId. 
        ///      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePushBaiduEndpoint.html">Creating
        /// an Amazon SNS Endpoint for Baidu</a>.          
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            var marshaller = new CreatePlatformEndpointRequestMarshaller();
            var unmarshaller = CreatePlatformEndpointResponseUnmarshaller.Instance;

            return Invoke<CreatePlatformEndpointRequest,CreatePlatformEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePlatformEndpointResponse> CreatePlatformEndpointAsync(CreatePlatformEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlatformEndpointRequestMarshaller();
            var unmarshaller = CreatePlatformEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlatformEndpointRequest,CreatePlatformEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTopic

        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create     at most
        /// 3000 topics. For more information, see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
        ///      This action is idempotent, so if the requester already owns a topic with the
        /// specified name, that topic's ARN is      returned without creating a new topic.
        /// </summary>
        /// <param name="name">The name of the topic you want to create. Constraints: Topic names must be made up of  only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be  between 1 and 256 characters long. </param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        public CreateTopicResponse CreateTopic(string name)
        {
            var request = new CreateTopicRequest();
            request.Name = name;
            return CreateTopic(request);
        }

        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create     at most
        /// 3000 topics. For more information, see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
        ///      This action is idempotent, so if the requester already owns a topic with the
        /// specified name, that topic's ARN is      returned without creating a new topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            var marshaller = new CreateTopicRequestMarshaller();
            var unmarshaller = CreateTopicResponseUnmarshaller.Instance;

            return Invoke<CreateTopicRequest,CreateTopicResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTopicRequestMarshaller();
            var unmarshaller = CreateTopicResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTopicRequest,CreateTopicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        /// <summary>
        /// Deletes the endpoint from Amazon SNS. This action is idempotent.       For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var marshaller = new DeleteEndpointRequestMarshaller();
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEndpointRequestMarshaller();
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePlatformApplication

        /// <summary>
        /// Deletes a platform application object for one of the supported push notification services,
        ///       such as APNS and GCM.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication service method.</param>
        /// 
        /// <returns>The response from the DeletePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request)
        {
            var marshaller = new DeletePlatformApplicationRequestMarshaller();
            var unmarshaller = DeletePlatformApplicationResponseUnmarshaller.Instance;

            return Invoke<DeletePlatformApplicationRequest,DeletePlatformApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePlatformApplicationResponse> DeletePlatformApplicationAsync(DeletePlatformApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePlatformApplicationRequestMarshaller();
            var unmarshaller = DeletePlatformApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlatformApplicationRequest,DeletePlatformApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTopic

        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might      prevent some
        /// messages previously sent to the topic from being delivered to      subscribers. This
        /// action is idempotent, so deleting a topic that does not      exist does not result
        /// in an error.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to delete.<examples> <queryrequest>  http://sns.us-east-1.amazonaws.com/  ?TopicArn=arn%3Aaws%3Asns%3Aus-east-1%3A123456789012%3AMy-Topic  &amp;Action=DeleteTopic  &amp;SignatureVersion=2  &amp;SignatureMethod=HmacSHA256  &amp;Timestamp=2010-03-31T12%3A00%3A00.000Z  &amp;AWSAccessKeyId=(AWS Access Key ID)  &amp;Signature=DjHBa%2BbYCKQAzctOPnLP7MbHnrHT3%2FK3kFEZjwcf9%2FU%3D </queryrequest> <queryresponse>  &lt;DeleteTopicResponse xmlns="http://sns.amazonaws.com/doc/2010-03-31/"&gt;  &lt;ResponseMetadata&gt; &lt;RequestId&gt;fba800b9-3765-11df-8cf3-c58c53254dfb&lt;/RequestId&gt;  &lt;/ResponseMetadata&gt;&lt;/DeleteTopicResponse&gt;   </queryresponse></examples></param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public DeleteTopicResponse DeleteTopic(string topicArn)
        {
            var request = new DeleteTopicRequest();
            request.TopicArn = topicArn;
            return DeleteTopic(request);
        }

        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might      prevent some
        /// messages previously sent to the topic from being delivered to      subscribers. This
        /// action is idempotent, so deleting a topic that does not      exist does not result
        /// in an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            var marshaller = new DeleteTopicRequestMarshaller();
            var unmarshaller = DeleteTopicResponseUnmarshaller.Instance;

            return Invoke<DeleteTopicRequest,DeleteTopicResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTopicRequestMarshaller();
            var unmarshaller = DeleteTopicResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTopicRequest,DeleteTopicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEndpointAttributes

        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification
        /// services, such as GCM and APNS.       For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the GetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            var marshaller = new GetEndpointAttributesRequestMarshaller();
            var unmarshaller = GetEndpointAttributesResponseUnmarshaller.Instance;

            return Invoke<GetEndpointAttributesRequest,GetEndpointAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetEndpointAttributesResponse> GetEndpointAttributesAsync(GetEndpointAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetEndpointAttributesRequestMarshaller();
            var unmarshaller = GetEndpointAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEndpointAttributesRequest,GetEndpointAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPlatformApplicationAttributes

        /// <summary>
        /// Retrieves the attributes of the platform application object for the supported push
        /// notification services,       such as APNS and GCM.      For more information, see
        /// <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            var marshaller = new GetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = GetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetPlatformApplicationAttributesRequest,GetPlatformApplicationAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetPlatformApplicationAttributesResponse> GetPlatformApplicationAttributesAsync(GetPlatformApplicationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = GetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlatformApplicationAttributesRequest,GetPlatformApplicationAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionAttributes

        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription whose properties you want to get.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(string subscriptionArn)
        {
            var request = new GetSubscriptionAttributesRequest();
            request.SubscriptionArn = subscriptionArn;
            return GetSubscriptionAttributes(request);
        }

        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            var marshaller = new GetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = GetSubscriptionAttributesResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionAttributesRequest,GetSubscriptionAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = GetSubscriptionAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionAttributesRequest,GetSubscriptionAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTopicAttributes

        /// <summary>
        /// Returns all of the properties of a topic.     Topic properties returned might differ
        /// based on the authorization of the user.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose properties you want to get.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public GetTopicAttributesResponse GetTopicAttributes(string topicArn)
        {
            var request = new GetTopicAttributesRequest();
            request.TopicArn = topicArn;
            return GetTopicAttributes(request);
        }

        /// <summary>
        /// Returns all of the properties of a topic.     Topic properties returned might differ
        /// based on the authorization of the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            var marshaller = new GetTopicAttributesRequestMarshaller();
            var unmarshaller = GetTopicAttributesResponseUnmarshaller.Instance;

            return Invoke<GetTopicAttributesRequest,GetTopicAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTopicAttributesRequestMarshaller();
            var unmarshaller = GetTopicAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTopicAttributesRequest,GetTopicAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEndpointsByPlatformApplication

        /// <summary>
        /// Lists the endpoints and endpoint attributes for devices in a supported push notification
        /// service, such as GCM and APNS.       The results for <code>ListEndpointsByPlatformApplication</code>
        /// are paginated and return a limited list of endpoints, up to 100.      If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned.       To receive the next page, you call <code>ListEndpointsByPlatformApplication</code>
        /// again using the NextToken string received from the previous call.       When there
        /// are no more records to return, NextToken will be null.      For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication service method.</param>
        /// 
        /// <returns>The response from the ListEndpointsByPlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            var marshaller = new ListEndpointsByPlatformApplicationRequestMarshaller();
            var unmarshaller = ListEndpointsByPlatformApplicationResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsByPlatformApplicationRequest,ListEndpointsByPlatformApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListEndpointsByPlatformApplicationResponse> ListEndpointsByPlatformApplicationAsync(ListEndpointsByPlatformApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEndpointsByPlatformApplicationRequestMarshaller();
            var unmarshaller = ListEndpointsByPlatformApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointsByPlatformApplicationRequest,ListEndpointsByPlatformApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPlatformApplications

        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        ///       such as APNS and GCM. The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100.      If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned.       To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call.       When there are no
        /// more records to return, NextToken will be null.            For more information, see
        /// <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListPlatformApplicationsResponse ListPlatformApplications()
        {
            return ListPlatformApplications(new ListPlatformApplicationsRequest());
        }

        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        ///       such as APNS and GCM. The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100.      If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned.       To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call.       When there are no
        /// more records to return, NextToken will be null.            For more information, see
        /// <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications service method.</param>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            var marshaller = new ListPlatformApplicationsRequestMarshaller();
            var unmarshaller = ListPlatformApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListPlatformApplicationsRequest,ListPlatformApplicationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPlatformApplicationsResponse> ListPlatformApplicationsAsync(ListPlatformApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPlatformApplicationsRequestMarshaller();
            var unmarshaller = ListPlatformApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlatformApplicationsRequest,ListPlatformApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptions

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        ///      of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListSubscriptionsResponse ListSubscriptions()
        {
            return ListSubscriptions(new ListSubscriptionsRequest());
        }

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        ///      of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptions</code> request.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListSubscriptionsResponse ListSubscriptions(string nextToken)
        {
            var request = new ListSubscriptionsRequest();
            request.NextToken = nextToken;
            return ListSubscriptions(request);
        }

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        ///      of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var marshaller = new ListSubscriptionsRequestMarshaller();
            var unmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsRequest,ListSubscriptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionsRequestMarshaller();
            var unmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionsRequest,ListSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionsByTopic

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns       a
        /// limited list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code>       parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptionsByTopic</code> request.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(string topicArn, string nextToken)
        {
            var request = new ListSubscriptionsByTopicRequest();
            request.TopicArn = topicArn;
            request.NextToken = nextToken;
            return ListSubscriptionsByTopic(request);
        }

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns       a
        /// limited list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code>       parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(string topicArn)
        {
            var request = new ListSubscriptionsByTopicRequest();
            request.TopicArn = topicArn;
            return ListSubscriptionsByTopic(request);
        }

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns       a
        /// limited list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code>       parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            var marshaller = new ListSubscriptionsByTopicRequestMarshaller();
            var unmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsByTopicRequest,ListSubscriptionsByTopicResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionsByTopicRequestMarshaller();
            var unmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionsByTopicRequest,ListSubscriptionsByTopicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTopics

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If      there are more topics, a <code>NextToken</code> is also returned.
        /// Use the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to
        /// get      further results.
        /// </summary>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListTopicsResponse ListTopics()
        {
            return ListTopics(new ListTopicsRequest());
        }

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If      there are more topics, a <code>NextToken</code> is also returned.
        /// Use the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to
        /// get      further results.
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListTopics</code> request.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListTopicsResponse ListTopics(string nextToken)
        {
            var request = new ListTopicsRequest();
            request.NextToken = nextToken;
            return ListTopics(request);
        }

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If      there are more topics, a <code>NextToken</code> is also returned.
        /// Use the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to
        /// get      further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            var marshaller = new ListTopicsRequestMarshaller();
            var unmarshaller = ListTopicsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsRequest,ListTopicsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTopicsRequestMarshaller();
            var unmarshaller = ListTopicsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicsRequest,ListTopicsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Publish

        /// <summary>
        /// Sends a message to all of a topic's subscribed endpoints. When a    <code>messageId</code>
        /// is returned, the message has been saved and Amazon SNS will attempt to deliver it
        ///       to the topic's subscribers shortly. The format of the outgoing message to each
        ///      subscribed endpoint depends on the notification protocol selected.
        /// 
        ///     
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone,       you must specify the EndpointArn.
        /// The EndpointArn is returned when making a call with the <code>CreatePlatformEndpoint</code>
        /// action.       The second example below shows a request and response for publishing
        /// to a mobile endpoint.    
        /// </para>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to.</param>
        /// <param name="message">The message you want to send to the topic. If you want to send the same message to all transport protocols,    include the text of the message as a String value. If you want to send different messages for each transport protocol,    set the value of the <code>MessageStructure</code> parameter to <code>json</code>    and use a JSON object for the <code>Message</code> parameter.    See the Examples section for the format of the JSON object.  Constraints: Messages must be UTF-8 encoded   strings at most 256 KB in size (262144 bytes, not 262144 characters). JSON-specific constraints:   <ul>  <li>Keys in the JSON object that correspond to supported transport   protocols must have simple JSON string values. </li>  <li>The values will be parsed (unescaped)  before they are used in outgoing messages.</li>  <li>Outbound notifications are JSON  encoded (meaning that the characters will be reescaped for sending).</li>  <li>Values have a minimum length of 0 (the empty string, "", is allowed).</li>  <li>Values have a maximum length bounded by the overall message size (so, including  multiple protocols may limit message sizes).</li>  <li>Non-string values will cause the key  to be ignored.</li>  <li>Keys that do not correspond to supported transport protocols are ignored.</li>  <li>Duplicate keys are not allowed.</li>  <li>Failure to parse or validate any key or    value in the message will cause the <code>Publish</code> call to return an error (no partial   delivery).</li>   </ul>  </param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        public PublishResponse Publish(string topicArn, string message)
        {
            var request = new PublishRequest();
            request.TopicArn = topicArn;
            request.Message = message;
            return Publish(request);
        }

        /// <summary>
        /// Sends a message to all of a topic's subscribed endpoints. When a    <code>messageId</code>
        /// is returned, the message has been saved and Amazon SNS will attempt to deliver it
        ///       to the topic's subscribers shortly. The format of the outgoing message to each
        ///      subscribed endpoint depends on the notification protocol selected.
        /// 
        ///     
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone,       you must specify the EndpointArn.
        /// The EndpointArn is returned when making a call with the <code>CreatePlatformEndpoint</code>
        /// action.       The second example below shows a request and response for publishing
        /// to a mobile endpoint.    
        /// </para>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to.</param>
        /// <param name="message">The message you want to send to the topic. If you want to send the same message to all transport protocols,    include the text of the message as a String value. If you want to send different messages for each transport protocol,    set the value of the <code>MessageStructure</code> parameter to <code>json</code>    and use a JSON object for the <code>Message</code> parameter.    See the Examples section for the format of the JSON object.  Constraints: Messages must be UTF-8 encoded   strings at most 256 KB in size (262144 bytes, not 262144 characters). JSON-specific constraints:   <ul>  <li>Keys in the JSON object that correspond to supported transport   protocols must have simple JSON string values. </li>  <li>The values will be parsed (unescaped)  before they are used in outgoing messages.</li>  <li>Outbound notifications are JSON  encoded (meaning that the characters will be reescaped for sending).</li>  <li>Values have a minimum length of 0 (the empty string, "", is allowed).</li>  <li>Values have a maximum length bounded by the overall message size (so, including  multiple protocols may limit message sizes).</li>  <li>Non-string values will cause the key  to be ignored.</li>  <li>Keys that do not correspond to supported transport protocols are ignored.</li>  <li>Duplicate keys are not allowed.</li>  <li>Failure to parse or validate any key or    value in the message will cause the <code>Publish</code> call to return an error (no partial   delivery).</li>   </ul>  </param>
        /// <param name="subject">Optional parameter to be used as the "Subject" line when the message is   delivered to email endpoints. This field will also be included, if present,    in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that begins with a letter, number,    or punctuation mark; must not include line breaks or control characters; and    must be less than 100 characters long.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        public PublishResponse Publish(string topicArn, string message, string subject)
        {
            var request = new PublishRequest();
            request.TopicArn = topicArn;
            request.Message = message;
            request.Subject = subject;
            return Publish(request);
        }

        /// <summary>
        /// Sends a message to all of a topic's subscribed endpoints. When a    <code>messageId</code>
        /// is returned, the message has been saved and Amazon SNS will attempt to deliver it
        ///       to the topic's subscribers shortly. The format of the outgoing message to each
        ///      subscribed endpoint depends on the notification protocol selected.
        /// 
        ///     
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone,       you must specify the EndpointArn.
        /// The EndpointArn is returned when making a call with the <code>CreatePlatformEndpoint</code>
        /// action.       The second example below shows a request and response for publishing
        /// to a mobile endpoint.    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Publish service method.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        public PublishResponse Publish(PublishRequest request)
        {
            var marshaller = new PublishRequestMarshaller();
            var unmarshaller = PublishResponseUnmarshaller.Instance;

            return Invoke<PublishRequest,PublishResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PublishResponse> PublishAsync(PublishRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PublishRequestMarshaller();
            var unmarshaller = PublishResponseUnmarshaller.Instance;

            return InvokeAsync<PublishRequest,PublishResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">The unique label of the statement you want to remove.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public RemovePermissionResponse RemovePermission(string topicArn, string label)
        {
            var request = new RemovePermissionRequest();
            request.TopicArn = topicArn;
            request.Label = label;
            return RemovePermission(request);
        }

        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetEndpointAttributes

        /// <summary>
        /// Sets the attributes for an endpoint for a device on one of the supported push notification
        /// services, such as GCM and APNS.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the SetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request)
        {
            var marshaller = new SetEndpointAttributesRequestMarshaller();
            var unmarshaller = SetEndpointAttributesResponseUnmarshaller.Instance;

            return Invoke<SetEndpointAttributesRequest,SetEndpointAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetEndpointAttributesResponse> SetEndpointAttributesAsync(SetEndpointAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetEndpointAttributesRequestMarshaller();
            var unmarshaller = SetEndpointAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetEndpointAttributesRequest,SetEndpointAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetPlatformApplicationAttributes

        /// <summary>
        /// Sets the attributes of the platform application object for the supported push notification
        /// services,       such as APNS and GCM.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the SetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request)
        {
            var marshaller = new SetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = SetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return Invoke<SetPlatformApplicationAttributesRequest,SetPlatformApplicationAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetPlatformApplicationAttributesResponse> SetPlatformApplicationAttributesAsync(SetPlatformApplicationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = SetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetPlatformApplicationAttributesRequest,SetPlatformApplicationAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetSubscriptionAttributes

        /// <summary>
        /// Allows a subscription owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to modify.</param>
        /// <param name="attributeName">The name of the attribute you want to set. Only a subset of the subscriptions attributes are mutable. Valid values: <code>DeliveryPolicy</code> | <code>RawMessageDelivery</code></param>
        /// <param name="attributeValue">The new value for the attribute in JSON format.</param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(string subscriptionArn, string attributeName, string attributeValue)
        {
            var request = new SetSubscriptionAttributesRequest();
            request.SubscriptionArn = subscriptionArn;
            request.AttributeName = attributeName;
            request.AttributeValue = attributeValue;
            return SetSubscriptionAttributes(request);
        }

        /// <summary>
        /// Allows a subscription owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            var marshaller = new SetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = SetSubscriptionAttributesResponseUnmarshaller.Instance;

            return Invoke<SetSubscriptionAttributesRequest,SetSubscriptionAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = SetSubscriptionAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetSubscriptionAttributesRequest,SetSubscriptionAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTopicAttributes

        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic to modify.</param>
        /// <param name="attributeName">The name of the attribute you want to set. Only a subset of the topic's attributes are mutable. Valid values: <code>Policy</code> | <code>DisplayName</code> | <code>DeliveryPolicy</code></param>
        /// <param name="attributeValue">The new value for the attribute.</param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public SetTopicAttributesResponse SetTopicAttributes(string topicArn, string attributeName, string attributeValue)
        {
            var request = new SetTopicAttributesRequest();
            request.TopicArn = topicArn;
            request.AttributeName = attributeName;
            request.AttributeValue = attributeValue;
            return SetTopicAttributes(request);
        }

        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            var marshaller = new SetTopicAttributesRequestMarshaller();
            var unmarshaller = SetTopicAttributesResponseUnmarshaller.Instance;

            return Invoke<SetTopicAttributesRequest,SetTopicAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTopicAttributesRequestMarshaller();
            var unmarshaller = SetTopicAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetTopicAttributesRequest,SetTopicAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Subscribe

        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// To actually create a      subscription, the endpoint owner must call the <code>ConfirmSubscription</code>
        ///      action with the token from the confirmation message. Confirmation tokens are
        ///      valid for three days.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to subscribe to.</param>
        /// <param name="protocol">The protocol you want to use. Supported protocols include: <ul>   <li><code>http</code> -- delivery of JSON-encoded message via HTTP POST</li>   <li><code>https</code> -- delivery of JSON-encoded message via HTTPS POST</li>   <li><code>email</code> -- delivery of message via SMTP</li>   <li><code>email-json</code> -- delivery of JSON-encoded message via SMTP</li>   <li><code>sms</code> -- delivery of message via SMS</li>   <li><code>sqs</code> -- delivery of JSON-encoded message to an Amazon SQS queue</li>   <li><code>application</code> -- delivery of JSON-encoded message to an EndpointArn for a mobile app and device.</li> </ul></param>
        /// <param name="endpoint">The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul>   <li>For the <code>http</code> protocol, the endpoint is an URL beginning with "http://"</li>   <li>For the <code>https</code> protocol, the endpoint is a URL beginning with "https://"</li>   <li>For the <code>email</code> protocol, the endpoint is an email address</li>   <li>For the <code>email-json</code> protocol, the endpoint is an email address</li>   <li>For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled device</li>   <li>For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue</li>   <li>For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile app and device.</li> </ul></param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        public SubscribeResponse Subscribe(string topicArn, string protocol, string endpoint)
        {
            var request = new SubscribeRequest();
            request.TopicArn = topicArn;
            request.Protocol = protocol;
            request.Endpoint = endpoint;
            return Subscribe(request);
        }

        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// To actually create a      subscription, the endpoint owner must call the <code>ConfirmSubscription</code>
        ///      action with the token from the confirmation message. Confirmation tokens are
        ///      valid for three days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            var marshaller = new SubscribeRequestMarshaller();
            var unmarshaller = SubscribeResponseUnmarshaller.Instance;

            return Invoke<SubscribeRequest,SubscribeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Subscribe operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SubscribeRequestMarshaller();
            var unmarshaller = SubscribeResponseUnmarshaller.Instance;

            return InvokeAsync<SubscribeRequest,SubscribeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Unsubscribe

        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for       deletion,
        /// only the owner of the subscription or the topic's owner       can unsubscribe, and
        /// an AWS signature is required. If the       <code>Unsubscribe</code> call does not
        /// require authentication and the requester is not       the subscription owner, a final
        /// cancellation message is delivered to the       endpoint, so that the endpoint owner
        /// can easily resubscribe to the topic if       the <code>Unsubscribe</code> request
        /// was unintended.
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to be deleted.</param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public UnsubscribeResponse Unsubscribe(string subscriptionArn)
        {
            var request = new UnsubscribeRequest();
            request.SubscriptionArn = subscriptionArn;
            return Unsubscribe(request);
        }

        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for       deletion,
        /// only the owner of the subscription or the topic's owner       can unsubscribe, and
        /// an AWS signature is required. If the       <code>Unsubscribe</code> call does not
        /// require authentication and the requester is not       the subscription owner, a final
        /// cancellation message is delivered to the       endpoint, so that the endpoint owner
        /// can easily resubscribe to the topic if       the <code>Unsubscribe</code> request
        /// was unintended.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            var marshaller = new UnsubscribeRequestMarshaller();
            var unmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeRequest,UnsubscribeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnsubscribeRequestMarshaller();
            var unmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return InvokeAsync<UnsubscribeRequest,UnsubscribeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}