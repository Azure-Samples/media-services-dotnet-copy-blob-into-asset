using System;
using System.Linq;
using System.Configuration;
using Microsoft.WindowsAzure.MediaServices.Client;
using Microsoft.WindowsAzure.Storage.Auth;

namespace ConsoleApplication1
{
    class Program
    {
        static string _sourceAaccountName = ConfigurationManager.AppSettings["MediaServicesSourceAccountName"];
        static string _sourceAccountKey = ConfigurationManager.AppSettings["MediaServicesSourceAccountKey"];
        static string _destAccountName = ConfigurationManager.AppSettings["MediaServicesDestAccountName"];
        static string _destAccountKey = ConfigurationManager.AppSettings["MediaServicesDestAccountKey"];
        static string _destStorageAccountName = ConfigurationManager.AppSettings["DestStorageAccountName"];
        static string _destStorageAccountKey = ConfigurationManager.AppSettings["DestStorageAccountKey"];
        static string _sourceAssetID = ConfigurationManager.AppSettings["SourceAssetID"];
        

        private static CloudMediaContext _sourceContext = null;
        private static CloudMediaContext _destContext = null;

        static void Main(string[] args)
        {
            // Create the context for your source Media Services account.

            // Use the cached credentials to create CloudMediaContext.
            _sourceContext = new CloudMediaContext(new MediaServicesCredentials(
                _sourceAaccountName,
                _sourceAccountKey));
            // Create the context for your destination Media Services account.
            _destContext = new CloudMediaContext(new MediaServicesCredentials(
                _destAccountName,
                _destAccountKey));

            // Get the credentials of the default Storage account bound to your destination Media Services account.
            StorageCredentials destinationStorageCredentials =
                new StorageCredentials(_destStorageAccountName, _destStorageAccountKey);

            // Get a reference to the source asset in the source context.
            IAsset sourceAsset = _sourceContext.Assets.Where(a => a.Id == _sourceAssetID).First();

            // Create an empty destination asset in the destination context.
            IAsset destinationAsset = _destContext.Assets.Create(sourceAsset.Name, AssetCreationOptions.None);

            // Copy the files in the source asset instance into the destination asset instance.
            sourceAsset.Copy(destinationAsset, destinationStorageCredentials);
        }
    }
}
