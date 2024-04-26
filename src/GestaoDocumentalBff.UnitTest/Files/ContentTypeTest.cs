using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xunit;

public class ContentTypeTest
{
    [Theory]
    [InlineData("Api")]
    [InlineData("Application")]
    [InlineData("CrossCutting")]
    [InlineData("Domain")]
    public void LayerDomainUFT8WithBomTest(string layer)
    {
        var path = Path
            .GetDirectoryName(
                Uri
                    .UnescapeDataString(
                        new UriBuilder(
                            Assembly
                                .GetExecutingAssembly()
                                .CodeBase
                        )
                        .Path
                    )
            );

        do
        {
            path = Directory.GetParent(path).FullName;
        } while (!path.EndsWith("BIN", StringComparison.InvariantCultureIgnoreCase));
        path = Directory.GetParent(path).FullName.Replace("UnitTest", layer);
        IEnumerable<KeyValuePair<string, Encoding>> streamReaderEnumerable;
        streamReaderEnumerable = Directory
           .EnumerateFiles(
               path,
               "*.*",
               SearchOption.AllDirectories
           )
            .Where(w =>
                !w.Contains($@"{layer}\obj\", StringComparison.InvariantCultureIgnoreCase) &&
                !w.Contains($@"{layer}\bin\", StringComparison.InvariantCultureIgnoreCase) &&
                (
                    w.EndsWith(".cs") ||
                    w.EndsWith(".config") ||
                    w.EndsWith(".json")
                )
            )
           .Select(fileName =>
           {
               return new KeyValuePair<string, Encoding>(fileName, GetEncoding(fileName));
           })
           .Where(item => Encoding.UTF8 != item.Value);

        Assert
            .False(
                streamReaderEnumerable.Any(),
                $"files {string.Join(Environment.NewLine, streamReaderEnumerable.Select(s => s.Key))} expected is {Encoding.UTF8} encoding"
             );
    }

    public static Encoding GetEncoding(string filename)
    {
        // Read the BOM
        var bom = new byte[4];
        using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
        {
            file.Read(bom, 0, 4);
        }

        // Analyze the BOM
        if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
        if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
        if (bom[0] == 0xff && bom[1] == 0xfe && bom[2] == 0 && bom[3] == 0) return Encoding.UTF32; //UTF-32LE
        if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
        if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
        if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return new UTF32Encoding(true, true);  //UTF-32BE

        // We actually have no idea what the encoding is if we reach this point, so
        // you may wish to return null instead of defaulting to ASCII
        return Encoding.ASCII;
    }

}
