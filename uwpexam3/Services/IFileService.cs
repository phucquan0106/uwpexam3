using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace uwpexam3.Services
{
    interface IFileService
    {
        StorageFile WriteIntoTxtFile(string content,string filename);
        string ReadFromTxtFile(string fileName);
    }
}
