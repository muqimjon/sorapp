namespace SorApp.Infrastructure.Services;

using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.Extensions.Configuration;

public class StorageService(IAmazonS3 s3, IConfiguration config) : IStorageService
{
    private readonly string _bucket = config["AWS:BucketName"]!;

    public async Task<string> UploadFileAsync(
        Stream fs, string fileName, string contentType)
    {
        var upload = new TransferUtility(s3);
        var key = $"{Guid.NewGuid()}_{fileName}";
        await upload.UploadAsync(new TransferUtilityUploadRequest
        {
            BucketName = _bucket,
            Key = key,
            InputStream = fs,
            ContentType = contentType
        });
        return $"https://{_bucket}.s3.amazonaws.com/{key}";
    }
}