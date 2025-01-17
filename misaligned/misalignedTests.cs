using System;
using MisalignedSpace;
using Xunit;

public class MisalignedTests {
    [Fact]
    public void Test_PrintColorMap_Output() {
        string expectedOutput = 
            "0 | White | Blue\n" +
            "1 | White | Orange\n" +
            "2 | White | Green\n" +
            "3 | White | Brown\n" +
            "4 | White | Slate\n" +
            "5 | Red | Blue\n" +
            "6 | Red | Orange\n" +
            "7 | Red | Green\n" +
            "8 | Red | Brown\n" +
            "9 | Red | Slate\n" +
            "10 | Black | Blue\n" +
            "11 | Black | Orange\n" +
            "12 | Black | Green\n" +
            "13 | Black | Brown\n" +
            "14 | Black | Slate\n" +
            "15 | Yellow | Blue\n" +
            "16 | Yellow | Orange\n" +
            "17 | Yellow | Green\n" +
            "18 | Yellow | Brown\n" +
            "19 | Yellow | Slate\n" +
            "20 | Violet | Blue\n" +
            "21 | Violet | Orange\n" +
            "22 | Violet | Green\n" +
            "23 | Violet | Brown\n" +
            "24 | Violet | Slate\n";
        
        string actualOutput = Misaligned.PrintColorMap();
        Assert.Equal(expectedOutput, actualOutput); // This will fail due to misalignment in output.
    }
}
