using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

WorkingWithText();

static void WorkingWithText()
{
    var names = new string[] { "X", "Y", "Z" };

    //define a file to write to
    string textFile = Combine(GetFolderPath(SpecialFolder.Personal), "streams.text");

    //create a text file and return a helper writer
    StreamWriter text = File.CreateText(textFile);

    //enumarate the strings, writing each one to the stream on a sparate line
    foreach (var name in names)
    {
        text.WriteLine(name);
    }
    text.Close();

    WriteLine($"{textFile} contains {new FileInfo(textFile).Length} bytes.");

    WriteLine(File.ReadAllText(textFile));
}