using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

WorkingWithFiles();

static void WorkingWithFiles()
{
    //define a directory path to output files
    //starting with user's folder
    string dir = Combine(GetFolderPath(SpecialFolder.Personal), "Code", "OutputFiles");

    CreateDirectory(dir);

    //define file paths
    string textFile = Combine(dir, "Dummy.text");
    string backupFile = Combine(dir, "Dummy.bak");
    WriteLine($"Working with: {textFile}");

    //check if the file exists
    WriteLine($"Does it exist? {File.Exists(textFile)}");

    //create a new text file and write a line to it
    StreamWriter textWriter = File.CreateText(textFile);
    textWriter.WriteLine("Hello!");
    textWriter.Close();
    WriteLine($"Does it exist? {File.Exists(textFile)}");

    //copy the file and overwrite if it already exists
    File.Copy(textFile, backupFile, true);
    WriteLine($"Does {backupFile} exist? {File.Exists(textFile)}");
    Write("Confirm the files exist and then press ENTER: ");
    ReadLine();

    //delete file
    File.Delete(textFile);
    WriteLine($"Does it exist? {File.Exists(textFile)}");

    //read from the text file backup
    WriteLine($"Reading contents of {backupFile}:");
    StreamReader textReader = File.OpenText(backupFile);
    WriteLine(textReader.ReadToEnd());
    textReader.Close();

    //Managing Paths
    WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
    WriteLine($"File Name: {GetFileName(textFile)}");
    WriteLine($"File Name without Extension: {GetFileNameWithoutExtension(textFile)}");
    WriteLine($"File Extension: {GetExtension(textFile)}");
    WriteLine($"Random File Name: {GetRandomFileName()}");
    WriteLine($"Temporary File Name: {GetTempFileName()}");

    //Getting File Information
    FileInfo info = new(backupFile);
    WriteLine($"{backupFile}");
    WriteLine($"Contains {info.Length} bytes");
    WriteLine($"Last accessed {info.LastAccessTime}");
    WriteLine($"Has readonly set to {info.IsReadOnly}");
}
