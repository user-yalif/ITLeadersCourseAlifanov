namespace NUnitFramework.Utils
{
    using System;
    using System.IO;

    public static class PathUtils
    {
        public static string Combine(params string[] args) => Path.Combine(args);

        public static string ConfigurePathToBaseDirectory(string pathToCombine) =>
            Combine(AppDomain.CurrentDomain.BaseDirectory, pathToCombine);
    }
}
