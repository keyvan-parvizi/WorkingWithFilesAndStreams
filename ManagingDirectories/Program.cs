using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

WorkingWithDirectories();

static void WorkingWithDirectories()
{
    //define a directory path for a new folder
    //starting in the user's folder
    string newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "Code", "NewFolder");

    WriteLine($"Working with: {newFolder}");

    //check if it exists
    WriteLine($"Does it exist? {Exists(newFolder)}");

    //create directory
    WriteLine("Creating it...");
    CreateDirectory(newFolder);
    WriteLine($"Does it exist? {Exists(newFolder)}");
    Write("Confirm the directory exists, and then press ENTER: ");
    ReadLine();

    //delete directory
    WriteLine("Deleting it...");
    Delete(newFolder, true);
    WriteLine($"Does it exist? {Exists(newFolder)}");
}