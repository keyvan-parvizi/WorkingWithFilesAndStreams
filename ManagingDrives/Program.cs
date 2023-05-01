using static System.Console;

WorkingWithDrives();

static void WorkingWithDrives()
{
    WriteLine($"{0, -30} | {1, -10} | {2, -7} | {3, 18} | {4, 18}",
        "Name", "Type", "Format", "Size (Bytes)", "Free Space");

    foreach (DriveInfo drive in DriveInfo.GetDrives())
    {
        if (drive.IsReady)
        {
            WriteLine($"{0,-30} | {1,-10} | {2,-7} | {3,18:NO} | {4,18:NO}",
                drive.Name, drive.DriveType, drive.DriveFormat, drive.TotalSize, drive.AvailableFreeSpace);
        }
        else
        {
            WriteLine($"{0, -30} | {1, -10}", drive.Name, drive.DriveType);
        }
    }
}