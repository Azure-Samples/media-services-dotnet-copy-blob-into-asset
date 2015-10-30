---
services: media-services
platforms: dotnet
author: Juliako
---

# Copy blob into an Azure Media Services asset using .NET SDK

This sample shows how to copy existing blobs from a storage account into a new Azure Media Services asset.

## Running this sample


1. Use Nuget to install the latest Azure Media Services .NET SDK.
	
	[Install-Package windowsazure.mediaservices](https://www.nuget.org/packages/windowsazure.mediaservices).
2. Add the appSettings section to the app.config file, and set the values for your Media Services account name and account key.
		
		<?xml version="1.0"?>
		<configuration>
		  <appSettings>
		    <add key="MediaServicesAccountName" value="MediaServicesAccountName" />
		    <add key="MediaServicesAccountKey" value="MediaServicesAccountKey" />
		    <add key="MediaServicesStorageAccountName" value="MediaServicesStorageAccountName" />
		    <add key="MediaServicesStorageAccountKey" value="MediaServicesStorageAccountKey" />
		    <add key="ExternalStorageAccountName" value="ExternalStorageAccountName" />
		    <add key="ExternalStorageAccountKey" value="ExternalStorageAccountKey" />
		  </appSettings>
		</configuration>

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