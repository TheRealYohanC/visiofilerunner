using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
class Program
{
    static void Main(string[] args)
    {
        string startPath = @"sampleflow";
        string zipPath = @"sampleflow.zip";

        ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Fastest, false);

        File.Move("sampleflow.zip", Path.ChangeExtension("sampleflow.zip", ".vsdx"));   

        var p = new Process();
        p.StartInfo = new ProcessStartInfo(@"C:\Users\YOHAN-DESKTOP\source\repos\testvdsx\testvdsx\bin\Debug\netcoreapp3.0\sampleflow.vsdx")
        {
            UseShellExecute = true
        };
        p.Start();

    }
}