// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input file");
string file = Console.ReadLine();
string output = "";
StreamReader reader = new StreamReader(File.OpenRead(file));

while (!reader.EndOfStream)
{
    output += reader.ReadLine() + ',';
}

reader.Close();

Console.WriteLine("Output File");
string outFile = Console.ReadLine();

StreamWriter writer = new StreamWriter(File.Create(outFile));
writer.WriteLine(output);
writer.Close();
