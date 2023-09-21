using System;
using System.IO;
using System.Threading.Tasks;

public class TextSplitterAndIndenter
{
    public async Task Process(string input, int levelOfIndentation)
    {
        string[] elements = input.Split('|', (char)StringSplitOptions.RemoveEmptyEntries);
        int i,j,tabspace = 0;
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            foreach (string element in elements)
            {
                string indentedText = "";
                for (i = 1; i <= levelOfIndentation; i++) { 
                    for (j=0;j<tabspace;j++) indentedText += "\t";
                    indentedText = indentedText + element + i.ToString()+ '\n';
                }
                tabspace++;
                Console.WriteLine(indentedText);
                await writer.WriteLineAsync(indentedText);
            }
        }

    }
}
