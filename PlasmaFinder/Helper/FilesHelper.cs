using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PlasmaFinder.Helper
{
    public class FilesHelper
    {
        public static bool UploadPhoto(System.IO.MemoryStream memoryStream,String folderName,String fileName)
        {
            try {
                memoryStream.Position = 0;
                var path = VirtualPathUtility.Combine(HttpContext.Current.Server.MapPath(folderName), fileName);
                File.WriteAllBytes(path, memoryStream.ToArray());
                
            }
            catch
            {
                return false;
            }

            return true;
            
        }
    }
}