using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace uwpexam3.Services
{
    class FileService:IFileService
    {
        public StorageFile WriteIntoTxtFile(string content,string fileName)
        {
            Windows.Storage.StorageFolder storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;

            Windows.Storage.StorageFile sampleFile =
                storageFolder.CreateFileAsync(fileName,
                    Windows.Storage.CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();

            Windows.Storage.FileIO.WriteTextAsync(sampleFile, content).GetAwaiter().GetResult();
            return sampleFile;
        }

        public string ReadFromTxtFile(string fileName)
        {
            Windows.Storage.StorageFolder storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                storageFolder.GetFileAsync(fileName).GetAwaiter().GetResult();

            string text = Windows.Storage.FileIO.ReadTextAsync(sampleFile).GetAwaiter().GetResult();
            return text;
        }

    }
}
