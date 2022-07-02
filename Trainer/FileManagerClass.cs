using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    public class FileManagerClass
    {
        private string fileName = "main.bundle.js";
        private string sourcePath = @"\resources\app\.webpack\renderer";         //@"\resources\app\.webpack\renderer"
        private string targetPath = @"\resources\app\.webpack\renderer\Backup";  //@"\resources\app\.webpack\renderer\Backup";

        public void CriarBackup()
        {
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            System.IO.Directory.CreateDirectory(targetPath);
            System.IO.File.Copy(sourceFile, destFile, true);
        }
        public void RestaurarOriginal()
        {
            string sourceFile = System.IO.Path.Combine(targetPath, fileName);
            string destFile = System.IO.Path.Combine(sourcePath, fileName);
            System.IO.File.Copy(sourceFile, destFile, true);
        }
        public void PowerMax()
        {

        }
    }


}
