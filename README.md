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

The code sample in this repo shows how to connect using two authentication methods: a **User** (interactive)  authentication method and **Service principal** authentication method. 

>[!Note]
> **Interactive** authentication method is NOT suitable for server, web services, APIs type of applications. For these types of applications, use **Service principal** authentication method. For more information, see [Access the AMS API with Azure AD authentication](media-services-use-aad-auth-to-access-ams-api.md).
  

## Running this sample

>[!Note] 
> Make sure you have the latest Azure Media Services .NET SDK Install-Package windowsazure.mediaservices.extensions -Version 4.1.0.1 

1. Download the solution.
2. Clean the solution.
3. Rebuild the solution.
4. Update the values of elemens in the appSettings section of the app.config file. For more information, see [Access the Azure Media Services API with Azure AD authentication](https://docs.microsoft.com/azure/media-services/media-services-use-aad-auth-to-access-ams-api).

```
  <appSettings>
    <!--Used by "copy blobs between two AMS accounts" code. -->
    <add key="AMSSourceAADTenantDomain" value="AMSSourceAADTenantDomain"/>
    <add key="AMSSourceRESTAPIEndpoint" value="AMSSourceRESTAPIEndpoint"/>
    <add key="SourceAMSClientId" value="SourceAMSClientId"/>
    <add key="SourceAMSClientSecret" value="SourceAMSClientSecret"/>
    <add key="SourceAssetID" value="nb:cid:UUID:6dd1aaa0-5787-4a2a-9263-7bab9318bf49"/>

    <add key="AMSDestAADTenantDomain" value="AMSDestAADTenantDomain"/>
    <add key="AMSDestRESTAPIEndpoint" value="AMSDestRESTAPIEndpoint"/>
    <add key="DestAMSClientId" value="DestAMSClientId"/>
    <add key="DestAMSClientSecret" value="DestAMSClientSecret"/>
    <add key="DestStorageAccountName" value="DestStorageAccountName"/>
    <add key="DestStorageAccountKey" value="DestStorageAccountKey"/>
    
    <!-- Used by "copy blobs from a storage account into an AMS account" code. -->
    <add key="SourceStorageAccountName" value="name" />
    <add key="SourceStorageAccountKey" value="key" />
    <add key="AMSAADTenantDomain" value="tenant"/>
    <add key="AMSESTAPIEndpoint" value="endpoint"/>
    <add key="AMSStorageAccountName" value="name" />
    <add key="AMSStorageAccountKey" value="key" />
    
  </appSettings>
```

## About the code

You can find detailed information about this code in the [Copying an Existing Blob into a Media Services Asset](http://azure.microsoft.com/documentation/articles/media-services-copying-existing-blob/) topic.

## Use tools to copy blobs into assets

You can also use the following tools to copy blobs into assets.

- The [Azure portal](http://manage.windowsazure.com/)
- The [Azure Media Services Explorer](https://github.com/Azure/Azure-Media-Services-Explorer) tool

## More information

You can view AMS learning paths here:

- [AMS Live Streaming Workflow](http://azure.microsoft.com/documentation/learning-paths/media-services-streaming-live/)
- [AMS on Demand Streaming Workflow](http://azure.microsoft.com/documentation/learning-paths/media-services-streaming-on-demand/)
