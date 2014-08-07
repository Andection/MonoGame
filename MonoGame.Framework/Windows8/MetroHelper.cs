using System.IO;

namespace Microsoft.Xna.Framework
{
    public static class MetroHelper
    {
        public static bool AppDataFileExists(string fileName)
        {
            var fullFileName = Path.Combine(Windows.ApplicationModel.Package.Current.InstalledLocation.Path, fileName);
            return File.Exists(fullFileName);

/*            var result = Task.Run( async () => {

                try
                {
                    var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(fileName);
                    return file == null ? false : true;
                }
                catch (FileNotFoundException)
                {
                    return false;
                }
            }).Result;

            return result;*/
        }
    }
}