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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Glacier.Model;
using Amazon.Glacier.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Glacier
{
    /// <summary>
    /// Implementation for accessing Glacier
    ///
    /// Amazon Glacier is a storage solution for "cold data."
    /// 
    ///  
    /// <para>
    /// Amazon Glacier is an extremely low-cost storage service that provides secure, durable,
    /// and easy-to-use storage for data backup and archival. With Amazon Glacier, customers
    /// can store their data cost effectively for months, years, or decades. Amazon Glacier
    /// also enables customers to offload the administrative burdens of operating and scaling
    /// storage to AWS, so they don't have to worry about capacity planning, hardware provisioning,
    /// data replication, hardware failure and recovery, or time-consuming hardware migrations.
    /// </para>
    ///  
    /// <para>
    /// Amazon Glacier is a great storage choice when low storage cost is paramount, your
    /// data is rarely retrieved, and retrieval latency of several hours is acceptable. If
    /// your application requires fast or frequent access to your data, consider using Amazon
    /// S3. For more information, go to <a href="http://aws.amazon.com/s3/">Amazon Simple
    /// Storage Service (Amazon S3)</a>.
    /// </para>
    ///  
    /// <para>
    /// You can store any kind of data in any format. There is no maximum limit on the total
    /// amount of data you can store in Amazon Glacier. 
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Glacier, we recommend that you begin by reading
    /// the following sections in the <i>Amazon Glacier Developer Guide</i>:
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/introduction.html">What
    /// is Amazon Glacier</a> - This section of the Developer Guide describes the underlying
    /// data model, the operations it supports, and the AWS SDKs that you can use to interact
    /// with the service.
    /// </para>
    /// </li> <li>
    /// <para>
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/amazon-glacier-getting-started.html">Getting
    /// Started with Amazon Glacier</a> - The Getting Started section walks you through the
    /// process of creating a vault, uploading archives, creating jobs to download archives,
    /// retrieving the job output, and deleting archives.
    /// </para>
    /// </li> </ul>
    /// </summary>
    public partial class AmazonGlacierClient : AmazonServiceClient, IAmazonGlacier
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
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
        public AmazonGlacierClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlacierConfig()) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
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
        public AmazonGlacierClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlacierConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(AmazonGlacierConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlacierClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlacierConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials and an
        /// AmazonGlacierClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(AWSCredentials credentials, AmazonGlacierConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlacierConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlacierClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlacierConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlacierConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlacierClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlacierConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.Glacier.Internal.ProcessRequestHandler());
        }    

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AbortMultipartUpload

        /// <summary>
        /// This operation aborts a multipart upload identified by the upload ID.
        /// 
        ///  
        /// <para>
        /// After the Abort Multipart Upload request succeeds, you cannot upload any more parts
        /// to the multipart upload or complete the multipart upload. Aborting a completed upload
        /// fails. However, aborting an already-aborted upload will succeed, for a short time.
        /// For more information about uploading a part and completing a multipart upload, see
        /// <a>UploadMultipartPart</a> and <a>CompleteMultipartUpload</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-abort-upload.html">Abort
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        /// <summary>
        /// You call this operation to inform Amazon Glacier that all the archive parts have been
        /// uploaded and that Amazon Glacier can now assemble the archive from the uploaded parts.
        /// After assembling and saving the archive to the vault, Amazon Glacier returns the URI
        /// path of the newly created archive resource. Using the URI path, you can then access
        /// the archive. After you upload an archive, you should save the archive ID returned
        /// to retrieve the archive at a later point. You can also get the vault inventory to
        /// obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        ///  
        /// <para>
        /// In the request, you must include the computed SHA256 tree hash of the entire archive
        /// you have uploaded. For information about computing a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. On the server side, Amazon Glacier also constructs the SHA256 tree
        /// hash of the assembled archive. If the values match, Amazon Glacier saves the archive
        /// to the vault; otherwise, it returns an error, and the operation fails. The <a>ListParts</a>
        /// operation returns a list of parts uploaded for a specific multipart upload. It includes
        /// checksum information for each uploaded part that can be used to debug a bad checksum
        /// issue.
        /// </para>
        ///  
        /// <para>
        /// Additionally, Amazon Glacier also checks for any missing content ranges when assembling
        /// the archive, if missing content ranges are found, Amazon Glacier returns an error
        /// and the operation fails. 
        /// </para>
        ///  
        /// <para>
        /// Complete Multipart Upload is an idempotent operation. After your first successful
        /// complete multipart upload, if you call the operation again within a short period,
        /// the operation will succeed and return the same archive ID. This is useful in the event
        /// you experience a network issue that causes an aborted connection or receive a 500
        /// server error, in which case you can repeat your Complete Multipart Upload request
        /// and get the same archive ID without creating duplicate archives. Note, however, that
        /// after the multipart upload completes, you cannot call the List Parts operation and
        /// the multipart upload will not appear in List Multipart Uploads response, even if idempotent
        /// complete is possible.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-complete-upload.html">Complete
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVault

        /// <summary>
        /// This operation creates a new vault with the specified name. The name of the vault
        /// must be unique within a region for an AWS account. You can create up to 1,000 vaults
        /// per account. If you need to create more vaults, contact Amazon Glacier.
        /// 
        ///  
        /// <para>
        /// You must use the following guidelines when naming a vault. 
        /// </para>
        ///  
        /// <para>
        ///  <ul> <li> 
        /// <para>
        ///  Names can be between 1 and 255 characters long. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed characters are a-z, A-Z, 0-9, '_' (underscore), '-' (hyphen), and '.' (period).
        /// </para>
        ///  </li> </ul> 
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/creating-vaults.html">Creating
        /// a Vault in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-put.html">Create
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVault service method.</param>
        /// 
        /// <returns>The response from the CreateVault service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public CreateVaultResponse CreateVault(CreateVaultRequest request)
        {
            var marshaller = new CreateVaultRequestMarshaller();
            var unmarshaller = CreateVaultResponseUnmarshaller.Instance;

            return Invoke<CreateVaultRequest,CreateVaultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVault operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVaultRequestMarshaller();
            var unmarshaller = CreateVaultResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVaultRequest,CreateVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteArchive

        /// <summary>
        /// This operation deletes an archive from a vault. Subsequent requests to initiate a
        /// retrieval of this archive will fail. Archive retrievals that are in progress for this
        /// archive ID may or may not succeed according to the following scenarios:
        /// 
        ///  <ul> <li>If the archive retrieval job is actively preparing the data for download
        /// when Amazon Glacier receives the delete archive request, the archival retrieval operation
        /// might fail. </li> <li>If the archive retrieval job has successfully prepared the archive
        /// for download when Amazon Glacier receives the delete archive request, you will be
        /// able to download the output. </li> </ul> 
        /// <para>
        /// This operation is idempotent. Attempting to delete an already-deleted archive does
        /// not result in an error. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-an-archive.html">Deleting
        /// an Archive in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request)
        {
            var marshaller = new DeleteArchiveRequestMarshaller();
            var unmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveRequest,DeleteArchiveResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchive operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteArchiveRequestMarshaller();
            var unmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteArchiveRequest,DeleteArchiveResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVault

        /// <summary>
        /// This operation deletes a vault. Amazon Glacier will delete a vault only if there are
        /// no archives in the vault as of the last inventory and there have been no writes to
        /// the vault since the last inventory. If either of these conditions is not satisfied,
        /// the vault deletion fails (that is, the vault is not removed) and Amazon Glacier returns
        /// an error. You can use <a>DescribeVault</a> to return the number of archives in a vault,
        /// and you can use <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job (POST jobs)</a> to initiate a new inventory retrieval for a vault. The inventory
        /// contains the archive IDs you use to delete archives using <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive (DELETE archive)</a>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-vaults.html">Deleting
        /// a Vault in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-delete.html">Delete
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault service method.</param>
        /// 
        /// <returns>The response from the DeleteVault service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public DeleteVaultResponse DeleteVault(DeleteVaultRequest request)
        {
            var marshaller = new DeleteVaultRequestMarshaller();
            var unmarshaller = DeleteVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultRequest,DeleteVaultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVault operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVaultRequestMarshaller();
            var unmarshaller = DeleteVaultResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultRequest,DeleteVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVaultNotifications

        /// <summary>
        /// This operation deletes the notification configuration set for a vault. The operation
        /// is eventually consistent;that is, it might take some time for Amazon Glacier to completely
        /// disable the notifications and you might still receive some notifications for a short
        /// time after you send the delete request. 
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-delete.html">Delete
        /// Vault Notification Configuration </a> in the Amazon Glacier Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the DeleteVaultNotifications service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public DeleteVaultNotificationsResponse DeleteVaultNotifications(DeleteVaultNotificationsRequest request)
        {
            var marshaller = new DeleteVaultNotificationsRequestMarshaller();
            var unmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultNotificationsRequest,DeleteVaultNotificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVaultNotificationsResponse> DeleteVaultNotificationsAsync(DeleteVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVaultNotificationsRequestMarshaller();
            var unmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultNotificationsRequest,DeleteVaultNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob

        /// <summary>
        /// This operation returns information about a job you previously initiated, including
        /// the job initiation date, the user who initiated the job, the job status code/message
        /// and the Amazon SNS topic to notify after Amazon Glacier completes the job. For more
        /// information about initiating a job, see <a>InitiateJob</a>. 
        /// 
        ///  <note>
        /// <para>
        /// This operation enables you to check the status of your job. However, it is strongly
        /// recommended that you set up an Amazon SNS topic and specify it in your initiate job
        /// request so that Amazon Glacier can notify the topic after it completes the job. 
        /// </para>
        /// </note> 
        /// <para>
        /// A job ID will not expire for at least 24 hours after Amazon Glacier completes the
        /// job. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For information about the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-describe-job-get.html">Working
        /// with Archives in Amazon Glacier</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var marshaller = new DescribeJobRequestMarshaller();
            var unmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobRequest,DescribeJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeJobRequestMarshaller();
            var unmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobRequest,DescribeJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVault

        /// <summary>
        /// This operation returns information about a vault, including the vault's Amazon Resource
        /// Name (ARN), the date the vault was created, the number of archives it contains, and
        /// the total size of all the archives in the vault. The number of archives and their
        /// total size are as of the last inventory generation. This means that if you add or
        /// remove an archive from a vault, and then immediately use Describe Vault, the change
        /// in contents will not be immediately reflected. If you want to retrieve the latest
        /// inventory of the vault, use <a>InitiateJob</a>. Amazon Glacier generates vault inventories
        /// approximately daily. For more information, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory in Amazon Glacier</a>. 
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-get.html">Describe
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault service method.</param>
        /// 
        /// <returns>The response from the DescribeVault service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public DescribeVaultResponse DescribeVault(DescribeVaultRequest request)
        {
            var marshaller = new DescribeVaultRequestMarshaller();
            var unmarshaller = DescribeVaultResponseUnmarshaller.Instance;

            return Invoke<DescribeVaultRequest,DescribeVaultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVault operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVaultResponse> DescribeVaultAsync(DescribeVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVaultRequestMarshaller();
            var unmarshaller = DescribeVaultResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVaultRequest,DescribeVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobOutput

        /// <summary>
        /// This operation downloads the output of the job you initiated using <a>InitiateJob</a>.
        /// Depending on the job type you specified when you initiated the job, the output will
        /// be either the content of an archive or a vault inventory.
        /// 
        ///  
        /// <para>
        /// A job ID will not expire for at least 24 hours after Amazon Glacier completes the
        /// job. That is, you can download the job output within the 24 hours period after Amazon
        /// Glacier completes the job.
        /// </para>
        ///  
        /// <para>
        /// If the job output is large, then you can use the <code>Range</code> request header
        /// to retrieve a portion of the output. This allows you to download the entire output
        /// in smaller chunks of bytes. For example, suppose you have 1 GB of job output you want
        /// to download and you decide to download 128 MB chunks of data at a time, which is a
        /// total of eight Get Job Output requests. You use the following process to download
        /// the job output:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Download a 128 MB chunk of output by specifying the appropriate byte range using the
        /// <code>Range</code> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Along with the data, the response includes a SHA256 tree hash of the payload. You
        /// compute the checksum of the payload on the client and compare it with the checksum
        /// you received in the response to ensure you received all the expected data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Repeat steps 1 and 2 for all the eight 128 MB chunks of output data, each time specifying
        /// the appropriate byte range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After downloading all the parts of the job output, you have a list of eight checksum
        /// values. Compute the tree hash of these values to find the checksum of the entire output.
        /// Using the <a>DescribeJob</a> API, obtain job information of the job that provided
        /// you the output. The response includes the checksum of the entire archive stored in
        /// Amazon Glacier. You compare this value with the checksum you computed to ensure you
        /// have downloaded the entire archive content with no errors.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory</a>, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/downloading-an-archive.html">Downloading
        /// an Archive</a>, and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-job-output-get.html">Get
        /// Job Output </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput service method.</param>
        /// 
        /// <returns>The response from the GetJobOutput service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public GetJobOutputResponse GetJobOutput(GetJobOutputRequest request)
        {
            var marshaller = new GetJobOutputRequestMarshaller();
            var unmarshaller = GetJobOutputResponseUnmarshaller.Instance;

            return Invoke<GetJobOutputRequest,GetJobOutputResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobOutput operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetJobOutputResponse> GetJobOutputAsync(GetJobOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobOutputRequestMarshaller();
            var unmarshaller = GetJobOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobOutputRequest,GetJobOutputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetVaultNotifications

        /// <summary>
        /// This operation retrieves the <code class="code">notification-configuration</code>
        /// subresource of the specified vault.
        /// 
        ///  
        /// <para>
        /// For information about setting a notification configuration on a vault, see <a>SetVaultNotifications</a>.
        /// If a notification configuration for a vault is not set, the operation returns a <code
        /// class="code">404 Not Found</code> error. For more information about vault notifications,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a>. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-get.html">Get
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the GetVaultNotifications service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public GetVaultNotificationsResponse GetVaultNotifications(GetVaultNotificationsRequest request)
        {
            var marshaller = new GetVaultNotificationsRequestMarshaller();
            var unmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<GetVaultNotificationsRequest,GetVaultNotificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetVaultNotificationsResponse> GetVaultNotificationsAsync(GetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetVaultNotificationsRequestMarshaller();
            var unmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetVaultNotificationsRequest,GetVaultNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateJob

        /// <summary>
        /// This operation initiates a job of the specified type. In this release, you can initiate
        /// a job to retrieve either an archive or a vault inventory (a list of archives in a
        /// vault). 
        /// 
        ///  
        /// <para>
        /// Retrieving data from Amazon Glacier is a two-step process: 
        /// </para>
        ///  <ol> <li>
        /// <para>
        /// Initiate a retrieval job.
        /// </para>
        /// </li> <li>
        /// <para>
        /// After the job completes, download the bytes.
        /// </para>
        /// </li> </ol> 
        /// <para>
        /// The retrieval request is executed asynchronously. When you initiate a retrieval job,
        /// Amazon Glacier creates a job and returns a job ID in the response. When Amazon Glacier
        /// completes the job, you can get the job output (archive or inventory data). For information
        /// about getting job output, see <a>GetJobOutput</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The job must complete before you can get its output. To determine when a job is complete,
        /// you have the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <b>Use Amazon SNS Notification</b> You can specify an Amazon Simple Notification Service
        /// (Amazon SNS) topic to which Amazon Glacier can post a notification after the job is
        /// completed. You can specify an SNS topic per job request. The notification is sent
        /// only after Amazon Glacier completes the job. In addition to specifying an SNS topic
        /// per job request, you can configure vault notifications for a vault so that job notifications
        /// are always sent. For more information, see <a>SetVaultNotifications</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Get job details</b> You can make a <a>DescribeJob</a> request to obtain job status
        /// information while a job is in progress. However, it is more efficient to use an Amazon
        /// SNS notification to determine when a job is complete.
        /// </para>
        ///  </li> </ul> <note>
        /// <para>
        /// The information you get via notification is same that you get by calling <a>DescribeJob</a>.
        /// </para>
        /// </note> 
        /// <para>
        /// If for a specific event, you add both the notification configuration on the vault
        /// and also specify an SNS topic in your initiate job request, Amazon Glacier sends both
        /// notifications. For more information, see <a>SetVaultNotifications</a>.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// <b>About the Vault Inventory</b>
        /// </para>
        ///  
        /// <para>
        /// Amazon Glacier prepares an inventory for each vault periodically, every 24 hours.
        /// When you initiate a job for a vault inventory, Amazon Glacier returns the last inventory
        /// for the vault. The inventory data you get might be up to a day or two days old. Also,
        /// the initiate inventory job might take some time to complete before you can download
        /// the vault inventory. So you do not want to retrieve a vault inventory for each vault
        /// operation. However, in some scenarios, you might find the vault inventory useful.
        /// For example, when you upload an archive, you can provide an archive description but
        /// not an archive name. Amazon Glacier provides you a unique archive ID, an opaque string
        /// of characters. So, you might maintain your own database that maps archive names to
        /// their corresponding Amazon Glacier assigned archive IDs. You might find the vault
        /// inventory useful in the event you need to reconcile information in your database with
        /// the actual vault inventory. 
        /// </para>
        ///  
        /// <para>
        /// <b>Range Inventory Retrieval</b>
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of inventory items retrieved by filtering on the archive
        /// creation date or by setting a limit.
        /// </para>
        ///  
        /// <para>
        /// <i>Filtering by Archive Creation Date</i>
        /// </para>
        ///  
        /// <para>
        /// You can retrieve inventory items for archives created between <code>StartDate</code>
        /// and <code>EndDate</code> by specifying values for these parameters in the <b>InitiateJob</b>
        /// request. Archives created on or after the <code>StartDate</code> and before the <code>EndDate</code>
        /// will be returned. If you only provide the <code>StartDate</code> without the <code>EndDate</code>,
        /// you will retrieve the inventory for all archives created on or after the <code>StartDate</code>.
        /// If you only provide the <code>EndDate</code> without the <code>StartDate</code>, you
        /// will get back the inventory for all archives created before the <code>EndDate</code>.
        /// </para>
        ///  
        /// <para>
        /// <i>Limiting Inventory Items per Retrieval</i>
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of inventory items returned by setting the <code>Limit</code>
        /// parameter in the <b>InitiateJob</b> request. The inventory job output will contain
        /// inventory items up to the specified <code>Limit</code>. If there are more inventory
        /// items available, the result is paginated. After a job is complete you can use the
        /// <a>DescribeJob</a> operation to get a marker that you use in a subsequent <b>InitiateJob</b>
        /// request. The marker will indicate the starting point to retrieve the next set of inventory
        /// items. You can page through your entire inventory by repeatedly making <b>InitiateJob</b>
        /// requests with the marker from the previous <b>DescribeJob</b> output, until you get
        /// a marker from <b>DescribeJob</b> that returns null, indicating that there are no more
        /// inventory items available.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>Limit</code> parameter together with the date range parameters.
        /// </para>
        ///  
        /// <para>
        /// <b>About Ranged Archive Retrieval</b>
        /// </para>
        ///  
        /// <para>
        ///  You can initiate an archive retrieval for the whole archive or a range of the archive.
        /// In the case of ranged archive retrieval, you specify a byte range to return or the
        /// whole archive. The range specified must be megabyte (MB) aligned, that is the range
        /// start value must be divisible by 1 MB and range end value plus 1 must be divisible
        /// by 1 MB or equal the end of the archive. If the ranged archive retrieval is not megabyte
        /// aligned, this operation returns a 400 response. Furthermore, to ensure you get checksum
        /// values for data you download using Get Job Output API, the range must be tree hash
        /// aligned. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob service method.</param>
        /// 
        /// <returns>The response from the InitiateJob service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public InitiateJobResponse InitiateJob(InitiateJobRequest request)
        {
            var marshaller = new InitiateJobRequestMarshaller();
            var unmarshaller = InitiateJobResponseUnmarshaller.Instance;

            return Invoke<InitiateJobRequest,InitiateJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateJob operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InitiateJobResponse> InitiateJobAsync(InitiateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateJobRequestMarshaller();
            var unmarshaller = InitiateJobResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateJobRequest,InitiateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        /// <summary>
        /// This operation initiates a multipart upload. Amazon Glacier creates a multipart upload
        /// resource and returns its ID in the response. The multipart upload ID is used in subsequent
        /// requests to upload parts of an archive (see <a>UploadMultipartPart</a>).
        /// 
        ///  
        /// <para>
        /// When you initiate a multipart upload, you specify the part size in number of bytes.
        /// The part size must be a megabyte (1024 KB) multiplied by a power of 2-for example,
        /// 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum
        /// allowable part size is 1 MB, and the maximum is 4 GB.
        /// </para>
        ///  
        /// <para>
        /// Every part you upload to this resource (see <a>UploadMultipartPart</a>), except the
        /// last one, must have the same size. The last one can be the same size or smaller. For
        /// example, suppose you want to upload a 16.2 MB file. If you initiate the multipart
        /// upload with a part size of 4 MB, you will upload four parts of 4 MB each and one part
        /// of 0.2 MB. 
        /// </para>
        ///  <note>
        /// <para>
        /// You don't need to know the size of the archive when you start a multipart upload because
        /// Amazon Glacier does not require you to specify the overall archive size.
        /// </para>
        /// </note> 
        /// <para>
        /// After you complete the multipart upload, Amazon Glacier removes the multipart upload
        /// resource referenced by the ID. Amazon Glacier also removes the multipart upload resource
        /// if you cancel the multipart upload or it may be removed if there is no activity for
        /// a period of 24 hours.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-initiate-upload.html">Initiate
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// This operation lists jobs for a vault, including jobs that are in-progress and jobs
        /// that have recently finished. 
        /// 
        ///  <note>
        /// <para>
        /// Amazon Glacier retains recently completed jobs for a period before deleting them;
        /// however, it eventually removes completed jobs. The output of completed jobs can be
        /// retrieved. Retaining completed jobs for a period of time after they have completed
        /// enables you to get a job output in the event you miss the job completion notification
        /// or your first attempt to download it fails. For example, suppose you start an archive
        /// retrieval job to download an archive. After the job completes, you start to download
        /// the archive but encounter a network error. In this scenario, you can retry and download
        /// the archive while the job exists. 
        /// </para>
        /// </note> 
        /// <para>
        /// To retrieve an archive or retrieve a vault inventory from Amazon Glacier, you first
        /// initiate a job, and after the job completes, you download the data. For an archive
        /// retrieval, the output is the archive data, and for an inventory retrieval, it is the
        /// inventory list. The List Job operation returns a list of these jobs sorted by job
        /// initiation time.
        /// </para>
        ///  
        /// <para>
        /// This List Jobs operation supports pagination. By default, this operation returns up
        /// to 1,000 jobs in the response. You should always check the response for a <code>marker</code>
        /// at which to continue the list; if there are no more items the <code>marker</code>
        /// is <code>null</code>. To return a list of jobs that begins at a specific job, set
        /// the <code>marker</code> request parameter to the value you obtained from a previous
        /// List Jobs request. You can also limit the number of jobs returned in the response
        /// by specifying the <code>limit</code> parameter in the request.
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can filter the jobs list returned by specifying an optional <code>statuscode</code>
        /// (InProgress, Succeeded, or Failed) and <code>completed</code> (true, false) parameter.
        /// The <code>statuscode</code> allows you to specify that only jobs that match a specified
        /// status are returned. The <code>completed</code> parameter allows you to specify that
        /// only jobs in a specific completion state are returned.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-jobs-get.html">List
        /// Jobs </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsRequest,ListJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsRequest,ListJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads

        /// <summary>
        /// This operation lists in-progress multipart uploads for the specified vault. An in-progress
        /// multipart upload is a multipart upload that has been initiated by an <a>InitiateMultipartUpload</a>
        /// request, but has not yet been completed or aborted. The list returned in the List
        /// Multipart Upload response has no guaranteed order. 
        /// 
        ///  
        /// <para>
        /// The List Multipart Uploads operation supports pagination. By default, this operation
        /// returns up to 1,000 multipart uploads in the response. You should always check the
        /// response for a <code>marker</code> at which to continue the list; if there are no
        /// more items the <code>marker</code> is <code>null</code>. To return a list of multipart
        /// uploads that begins at a specific upload, set the <code>marker</code> request parameter
        /// to the value you obtained from a previous List Multipart Upload request. You can also
        /// limit the number of uploads returned in the response by specifying the <code>limit</code>
        /// parameter in the request.
        /// </para>
        ///  
        /// <para>
        /// Note the difference between this operation and listing parts (<a>ListParts</a>). The
        /// List Multipart Uploads operation lists all multipart uploads for a vault and does
        /// not require a multipart upload ID. The List Parts operation requires a multipart upload
        /// ID since parts are associated with a single upload.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-uploads.html">List
        /// Multipart Uploads </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListParts

        /// <summary>
        /// This operation lists the parts of an archive that have been uploaded in a specific
        /// multipart upload. You can make this request at any time during an in-progress multipart
        /// upload before you complete the upload (see <a>CompleteMultipartUpload</a>. List Parts
        /// returns an error for completed uploads. The list returned in the List Parts response
        /// is sorted by part range. 
        /// 
        ///  
        /// <para>
        /// The List Parts operation supports pagination. By default, this operation returns up
        /// to 1,000 uploaded parts in the response. You should always check the response for
        /// a <code class="code">marker</code> at which to continue the list; if there are no
        /// more items the <code class="code">marker</code> is <code class="code">null</code>.
        /// To return a list of parts that begins at a specific part, set the <code>marker</code>
        /// request parameter to the value you obtained from a previous List Parts request. You
        /// can also limit the number of parts returned in the response by specifying the <code>limit</code>
        /// parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-parts.html">List
        /// Parts</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public ListPartsResponse ListParts(ListPartsRequest request)
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsRequest,ListPartsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartsRequest,ListPartsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVaults

        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name. 
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 1,000 items. If there are more vaults to
        /// list, the response <code class="code">marker</code> field contains the vault Amazon
        /// Resource Name (ARN) at which to continue the list with a new List Vaults request;
        /// otherwise, the <code class="code">marker</code> field is <code class="code">null</code>.
        /// To return a list of vaults that begins at a specific vault, set the <code class="code">marker</code>
        /// request parameter to the vault ARN you obtained from a previous List Vaults request.
        /// You can also limit the number of vaults returned in the response by specifying the
        /// <code class="code">limit</code> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public ListVaultsResponse ListVaults()
        {
            return ListVaults(new ListVaultsRequest());
        }

        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name. 
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 1,000 items. If there are more vaults to
        /// list, the response <code class="code">marker</code> field contains the vault Amazon
        /// Resource Name (ARN) at which to continue the list with a new List Vaults request;
        /// otherwise, the <code class="code">marker</code> field is <code class="code">null</code>.
        /// To return a list of vaults that begins at a specific vault, set the <code class="code">marker</code>
        /// request parameter to the vault ARN you obtained from a previous List Vaults request.
        /// You can also limit the number of vaults returned in the response by specifying the
        /// <code class="code">limit</code> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaults service method.</param>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public ListVaultsResponse ListVaults(ListVaultsRequest request)
        {
            var marshaller = new ListVaultsRequestMarshaller();
            var unmarshaller = ListVaultsResponseUnmarshaller.Instance;

            return Invoke<ListVaultsRequest,ListVaultsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVaults operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVaults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListVaultsResponse> ListVaultsAsync(ListVaultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVaultsRequestMarshaller();
            var unmarshaller = ListVaultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVaultsRequest,ListVaultsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetVaultNotifications

        /// <summary>
        /// This operation configures notifications that will be sent when specific events happen
        /// to a vault. By default, you don't get any notifications. 
        /// 
        ///  
        /// <para>
        /// To configure vault notifications, send a PUT request to the <code class="code">notification-configuration</code>
        /// subresource of the vault. The request should include a JSON document that provides
        /// an Amazon SNS topic and specific events for which you want Amazon Glacier to send
        /// notifications to the topic.
        /// </para>
        ///  
        /// <para>
        /// Amazon SNS topics must grant permission to the vault to be allowed to publish notifications
        /// to the topic. You can configure a vault to publish a notification for the following
        /// vault events:
        /// </para>
        ///  <ul> <li> <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was
        /// initiated for an archive retrieval is completed (<a>InitiateJob</a>). The status of
        /// the completed job can be "Succeeded" or "Failed". The notification sent to the SNS
        /// topic is the same output as returned from <a>DescribeJob</a>. </li> <li> <b>InventoryRetrievalCompleted</b>
        /// This event occurs when a job that was initiated for an inventory retrieval is completed
        /// (<a>InitiateJob</a>). The status of the completed job can be "Succeeded" or "Failed".
        /// The notification sent to the SNS topic is the same output as returned from <a>DescribeJob</a>.
        /// </li> </ul> 
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-put.html">Set
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the SetVaultNotifications service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public SetVaultNotificationsResponse SetVaultNotifications(SetVaultNotificationsRequest request)
        {
            var marshaller = new SetVaultNotificationsRequestMarshaller();
            var unmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<SetVaultNotificationsRequest,SetVaultNotificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetVaultNotificationsResponse> SetVaultNotificationsAsync(SetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetVaultNotificationsRequestMarshaller();
            var unmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<SetVaultNotificationsRequest,SetVaultNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadArchive

        /// <summary>
        /// This operation adds an archive to a vault. This is a synchronous operation, and for
        /// a successful upload, your data is durably persisted. Amazon Glacier returns the archive
        /// ID in the <code class="code">x-amz-archive-id</code> header of the response. 
        /// 
        ///  
        /// <para>
        /// You must use the archive ID to access your data in Amazon Glacier. After you upload
        /// an archive, you should save the archive ID returned so that you can retrieve or delete
        /// the archive later. Besides saving the archive ID, you can also index it and give it
        /// a friendly name to allow for better searching. You can also use the optional archive
        /// description field to specify how the archive is referred to in an external index of
        /// archives, such as you might create in Amazon DynamoDB. You can also get the vault
        /// inventory to obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must provide a SHA256 tree hash of the data you are uploading. For information
        /// about computing a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify an archive description of up to 1,024 printable ASCII characters.
        /// You can get the archive description when you either retrieve the archive or get the
        /// vault inventory. For more information, see <a>InitiateJob</a>. Amazon Glacier does
        /// not interpret the description in any way. An archive description does not need to
        /// be unique. You cannot use the description to retrieve or sort the archive list. 
        /// </para>
        ///  
        /// <para>
        /// Archives are immutable. After you upload an archive, you cannot edit the archive or
        /// its description. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-an-archive.html">Uploading
        /// an Archive in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-post.html">Upload
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive service method.</param>
        /// 
        /// <returns>The response from the UploadArchive service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon Glacier times out while receiving the
        /// upload.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public UploadArchiveResponse UploadArchive(UploadArchiveRequest request)
        {
            var marshaller = new UploadArchiveRequestMarshaller();
            var unmarshaller = UploadArchiveResponseUnmarshaller.Instance;

            return Invoke<UploadArchiveRequest,UploadArchiveResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadArchive operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadArchiveResponse> UploadArchiveAsync(UploadArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadArchiveRequestMarshaller();
            var unmarshaller = UploadArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<UploadArchiveRequest,UploadArchiveResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadMultipartPart

        /// <summary>
        /// This operation uploads a part of an archive. You can upload archive parts in any order.
        /// You can also upload them in parallel. You can upload up to 10,000 parts for a multipart
        /// upload.
        /// 
        ///  
        /// <para>
        /// Amazon Glacier rejects your upload part request if any of the following conditions
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <b>SHA256 tree hash does not match</b>To ensure that part data is not corrupted in
        /// transmission, you compute a SHA256 tree hash of the part and include it in your request.
        /// Upon receiving the part data, Amazon Glacier also computes a SHA256 tree hash. If
        /// these hash values don't match, the operation fails. For information about computing
        /// a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Part size does not match</b>The size of each part except the last must match the
        /// size specified in the corresponding <a>InitiateMultipartUpload</a> request. The size
        /// of the last part must be the same size as, or smaller than, the specified size.
        /// </para>
        ///  <note>
        /// <para>
        /// If you upload a part whose size is smaller than the part size you specified in your
        /// initiate multipart upload request and that part is not the last part, then the upload
        /// part request will succeed. However, the subsequent Complete Multipart Upload request
        /// will fail.
        /// </para>
        /// </note> </li> <li> <b>Range does not align</b>The byte range value in the request
        /// does not align with the part size specified in the corresponding initiate request.
        /// For example, if you specify a part size of 4194304 bytes (4 MB), then 0 to 4194303
        /// bytes (4 MB - 1) and 4194304 (4 MB) to 8388607 (8 MB - 1) are valid part ranges. However,
        /// if you set a range value of 2 MB to 6 MB, the range does not align with the part size
        /// and the upload will fail. </li> </ul> 
        /// <para>
        /// This operation is idempotent. If you upload the same part multiple times, the data
        /// included in the most recent request overwrites the previously uploaded data.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-upload-part.html">Upload
        /// Part </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart service method.</param>
        /// 
        /// <returns>The response from the UploadMultipartPart service method, as returned by Glacier.</returns>
        /// <exception cref="InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon Glacier times out while receiving the
        /// upload.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public UploadMultipartPartResponse UploadMultipartPart(UploadMultipartPartRequest request)
        {
            var marshaller = new UploadMultipartPartRequestMarshaller();
            var unmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;

            return Invoke<UploadMultipartPartRequest,UploadMultipartPartResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadMultipartPart operation.
        /// <seealso cref="Amazon.Glacier.IAmazonGlacier"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadMultipartPartResponse> UploadMultipartPartAsync(UploadMultipartPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadMultipartPartRequestMarshaller();
            var unmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadMultipartPartRequest,UploadMultipartPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}