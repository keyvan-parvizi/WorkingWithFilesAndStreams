using static System.Console;
using static System.IO.Path;
using static System.Environment;
using System.Xml;

WorkingWithXml();

static void WorkingWithXml()
{
    //define an array
    var names = new string[] { "X", "Y", "Z" };

    //define a file to write to
    string xmlFile = Combine(GetFolderPath(SpecialFolder.Personal), "streams.xml");

    //create a file stream
    FileStream xmlFileStream = File.Create(xmlFile);

    //wrap the file stream in an XML writer helper
    XmlWriter xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings { Indent = true});

    //write the xml declaration
    xml.WriteStartDocument();

    //write a root element
    xml.WriteStartElement("Names");

    //enumerate the strings writing each one to the stream
    foreach (string name in names)
    {
        xml.WriteElementString("name",name);
    }

    //write the close root element
    xml.WriteEndElement();

    //close helper and stream
    xml.Close();
    xmlFileStream.Close();

    //output all the contents of the file
    WriteLine($"{xmlFile} contains {new FileInfo(xmlFile).Length} bytes.");

    WriteLine(File.ReadAllText(xmlFile));
}