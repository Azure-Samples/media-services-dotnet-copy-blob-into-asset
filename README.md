---
services: media-services
platforms: dotnet
author: Juliako
---

# Copy blob into an Azure Media Services asset using .NET SDK

This sample shows how to copy existing blobs from a storage account into a new Azure Media Services asset.


## Prerequisites
* Two Media Services accounts in a new or existing Azure subscription. See the topic [How to Create a Media Services Account](media-services-portal-create-account.md).
* Operating Systems: Windows 10, Windows 7, Windows 2008 R2, or Windows 8.
* .NET Framework 4.5.
* Visual Studio 2010 SP1 (Professional, Premium, Ultimate, or Express) or later.

## Running this sample

1. Use [NuGet](https://www.nuget.org/packages/windowsazure.mediaservices.extensions) to install and add Azure Media Services .NET SDK Extensions (windowsazure.mediaservices.extensions). Installing this package, also installs Media Services .NET SDK and adds all other required dependencies.
	
	[Install-Package windowsazure.mediaservices](https://www.nuget.org/packages/windowsazure.mediaservices).
2. Add the appSettings section to the app.config file, and set the values for your Media Services account name and account key.
		
		<appSettings>
	          <add key="MediaServicesSourceAccountName" value="name"/>
	          <add key="MediaServicesSourceAccountKey" value="key"/>
	          <add key="MediaServicesDestAccountName" value="name"/>
	          <add key="MediaServicesDestAccountKey" value="key"/>
	          <add key="DestStorageAccountName" value="name"/>
	          <add key="DestStorageAccountKey" value="key"/>
	          <add key="SourceAssetID" value="nb:cid:UUID:assetID"/>       
		</appSettings>

## About the code

For more information, see the following topics:

- [Copying an Existing Blob into a Media Services Asset](http://azure.microsoft.com/documentation/articles/media-services-copying-existing-blob/) 

## Use tools to copy blobs into assets

You can also use the following tools to copy blobs into assets.

- The [Azure portal](http://manage.windowsazure.com/)
- The [Azure Media Services Explorer](https://github.com/Azure/Azure-Media-Services-Explorer) tool

## More information

You can view AMS learning paths here:

- [AMS Live Streaming Workflow](http://azure.microsoft.com/documentation/learning-paths/media-services-streaming-live/)
- [AMS on Demand Streaming Workflow](http://azure.microsoft.com/documentation/learning-paths/media-services-streaming-on-demand/)
