using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using GoodHands.Domain.Model.Interfaces.Infrastructure;

namespace GoodHands.Infra.Services.Blob
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;
        private const string Container = "goodhandscontainer";

        public BlobService(string storageAccount)
        {
            _blobServiceClient = new BlobServiceClient(storageAccount);
        }

        public async Task<string> UploadAsync(Stream stream)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(Container);

            if (!await containerClient.ExistsAsync())
            {
                await containerClient.CreateIfNotExistsAsync();
                await containerClient.SetAccessPolicyAsync(Azure.Storage.Blobs.Models.PublicAccessType.BlobContainer);
            }

            var blobClient = containerClient.GetBlobClient($"{Guid.NewGuid()}.jpg");

            await blobClient.UploadAsync(stream, true);

            return blobClient.Uri.ToString();
        }

        public async Task DeleteAsync(string blobName)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(Container);

            var blob = new BlobClient(new Uri(blobName));

            var blobClient = containerClient.GetBlobClient(blob.Name);

            await blobClient.DeleteIfExistsAsync();
        }
    }
}
