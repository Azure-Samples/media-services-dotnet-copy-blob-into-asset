---
services: media-services
platforms: dotnet
author: Juliako
---

# Copy blobs into an Azure Media Services asset 

This sample shows how to copy existing blobs from a storage account into a new Azure Media Services asset.

The sample shows two ways to copy blobs into assets:

* Copy blobs from an asset in one AMS account into a new asset in another AMS account.
* Copy blobs from some storage account into a new asset in an AMS account.

The code sample in this repo shows how to connect using two authentication methods:  A **User** (interactive) authentication method and **Service principal** authentication method. 

**NOTE** The **User** authentication method is NOT suitable for server, web services, APIs type of applications. For these types of applications, use **Service principal** authentication method. For more information, see [Access the AMS API with Azure AD authentication](media-services-use-aad-auth-to-access-ams-api.md).
  

## Running this sample

**NOTE** Make sure you use the latest [Azure Media Services .NET SDK](https://www.nuget.org/packages/windowsazure.mediaservices.extensions).

1. Download the solution.
2. Clean the solution.
3. Rebuild the solution.
4. Update the values of elements in the appSettings section of the app.config file. For more information, see [Access the Azure Media Services API with Azure AD authentication](https://docs.microsoft.com/azure/media-services/media-services-use-aad-auth-to-access-ams-api).

``` 
 <appSettings>
    <!--Used by "copy blobs between two AMS accounts" code. -->
    
    <add key="AMSSourceAADTenantDomain" value="tenant"/>
    <add key="AMSSourceRESTAPIEndpoint" value="endpoint"/>

    <add key="SourceAMSClientId" value="clientID"/>
    <add key="SourceAMSClientSecret" value="clientSecret"/>

    <add key="SourceAssetID" value="nb:cid:UUID:6dd1aaa0-5787-4a2a-9263-7bab9318bf49"/>

    <add key="AMSDestAADTenantDomain" value="tenant"/>
    <add key="AMSDestRESTAPIEndpoint" value="endpoint"/>

    <add key="DestAMSClientId" value="clientID"/>
    <add key="DestAMSClientSecret" value="clientSecret"/>

    <add key="DestStorageAccountName" value="name"/>
    <add key="DestStorageAccountKey" value="key"/>

    <!-- Used by "copy blobs from a storage account into an AMS account" code. -->
    
    <add key="SourceStorageAccountName" value="name" />
    <add key="SourceStorageAccountKey" value="key" />
    <add key="NameOfBlobContainerYouWantToCopy" value="BlobContainerName"/>
    
    <add key="AMSAADTenantDomain" value="tenant"/>
    <add key="AMSRESTAPIEndpoint" value="endpoint"/>
    <add key="AMSClientId" value="clientID"/>
    <add key="AMSClientSecret" value="clientSecret"/>
    <add key="AMSStorageAccountName" value="name"/>
    <add key="AMSStorageAccountKey" value="key"/>
    
  </appSettings>
```

## About the code

You can find detailed information about this code in the [Copying an Existing Blob into a Media Services Asset](http://azure.microsoft.com/documentation/articles/media-services-copying-existing-blob/) article.

## Use tools to copy blobs into assets

You can also use the following tools to copy blobs into assets.

- The [Azure portal](http://manage.windowsazure.com/)
- The [Azure Media Services Explorer](https://github.com/Azure/Azure-Media-Services-Explorer) tool

## More information

You can view AMS learning paths here:

- [AMS Live Streaming Workflow](http://azure.microsoft.com/documentation/learning-paths/media-services-streaming-live/)
- [AMS on Demand Streaming Workflow](http://azure.microsoft.com/documentation/learning-paths/media-services-streaming-on-demand/)
