using Azure.Storage.Blobs;

namespace BlobStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uploading file");

            string azureAccountConnectionString = "YOUR CONNECTIONSTRING";
            string containerName = "upload";
            BlobContainerClient container = new BlobContainerClient(azureAccountConnectionString, containerName);
            container.CreateIfNotExists();


            string blobName = "sample.txt";
            string filePath = $"myfiles/{blobName}";

            BlobClient blob = container.GetBlobClient(filePath);

            blob.Upload(File.OpenRead("MY LOCAL PATH"));

            Console.WriteLine("Upload done");

        }
    }
}