using Xunit;
public class TestSplitterAppTests
{
    [Fact]
    public async Task Test1()
    {
        // Arrange
        string inputString = "this|is";
        int levelOfIndentation = 2;
        var textSplitterAndIndenter = new TextSplitterAndIndenter();

        // Act
        await textSplitterAndIndenter.Process(inputString, levelOfIndentation);

        // Assert
        string[] outputLines = File.ReadAllLines("output.txt");
        Assert.Equal("this1", outputLines[0]);
        Assert.Equal("this2", outputLines[1]);
        Assert.Equal("", outputLines[2]);
        Assert.Equal("\tis1", outputLines[3]);
        Assert.Equal("\tis2", outputLines[4]);

        // Clean up
        File.Delete("output.txt");
    }

    [Fact]
    public async Task Test2()
    {
        // Arrange
        string inputString = ""; // Empty input string
        int levelOfIndentation = 0;
        var textSplitterAndIndenter = new TextSplitterAndIndenter();

        // Act
        await textSplitterAndIndenter.Process(inputString, levelOfIndentation);

        // Assert
        string[] outputLines = File.ReadAllLines("output.txt");
        Assert.Single(outputLines);

        // Clean up
        File.Delete("output.txt");
    }
}
