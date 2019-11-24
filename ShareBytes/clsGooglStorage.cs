using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Storage.V1;
using System.IO;
using Google.Apis.Storage.v1.Data;
using System.Data;

namespace ShareBytes
{
    class clsGooglStorage
    {

        public int UploadFile(string bucketName, string localPath,string FolderName)
        {
            
                var storage = StorageClient.Create();
                string objectName = null;
                using (var f = File.OpenRead(localPath))
                {
                    objectName =FolderName+"/"+(objectName ?? Path.GetFileName(localPath));

                    storage.UploadObject(bucketName, objectName, null, f);
                }
                return 1;
            
        }
        public int CreateBucket(string bucketName)
        {
            try
            {
                clsDAL obj = new clsDAL();
                var storage = StorageClient.Create();
                Bucket bucket = new Bucket { Location = "asia-south1", Name = bucketName };
                storage.CreateBucket(obj.GoogleStorage_projectId, bucketName);
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public void DownloadObject(string bucketName, string objectName,
            string LocalObjectName)
        {
            try
            {
                string localPath = null;
                string sourceFile;
                string destinationFile;
                var storage = StorageClient.Create();
                localPath = localPath ?? Path.GetFileName(objectName);

                using (var outputFile = File.OpenWrite(localPath))
                {
                    storage.DownloadObject(bucketName, objectName, outputFile);
                    sourceFile = outputFile.Name;
                }
                destinationFile = "C:\\Users\\" + Environment.UserName + "\\Downloads\\Sharebytes\\" + clsValues.UserID + "\\" + LocalObjectName;
                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }
                File.Move(sourceFile, destinationFile);
            }
            catch(Exception ex) { }
        }
        public DataTable ListObjects(string prefix)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("File Name");

            try
            {
                var storage = StorageClient.Create();
                //var options = new ListObjectsOptions() { Delimiter = delimiter };
                foreach (var storageObject in storage.ListObjects(clsValues.UserID, prefix))
                {
                    DataRow dr = dt.NewRow();
                    dr["File Name"] = storageObject.Name.Substring(storageObject.Name.IndexOf("/")+1);
                    dt.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public void CopyObject(string sourceBucketName, string sourceObjectName,
    string destBucketName, string destObjectName)
        {
            var storage = StorageClient.Create();
            storage.CopyObject(sourceBucketName, sourceObjectName,
                destBucketName, destObjectName);
            
        }
    }
}
