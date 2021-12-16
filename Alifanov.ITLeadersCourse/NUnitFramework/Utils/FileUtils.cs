namespace NUnitFramework.Utils
{
    using System.IO;
    using System.Linq;

    public static class FileUtils
    {
        public static bool Exists(string pathToFile) => File.Exists(pathToFile);

        public static void RemoveAll(string pathToDirectory) =>
            Directory.GetFiles(pathToDirectory)
            .ToList()
            .ForEach(file => File.Delete(file));
    }
}
