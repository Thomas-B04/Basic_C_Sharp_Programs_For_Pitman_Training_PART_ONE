// Imports the `System.Text` namespace so `StringBuilder` can be used in this file.
using System.Text;

// Creates the first string value that will be used in the concatenation example.
string firstWord = "Learning";

// Creates the second string value that will be used in the concatenation example.
string secondWord = "C#";

// Creates the third string value that will be used in the concatenation example.
string thirdWord = "is fun!";

// Combines the three string values into one sentence, adding spaces between each word.
string combinedSentence = firstWord + " " + secondWord + " " + thirdWord;

// Displays the concatenated string on the console so the user can see the result.
Console.WriteLine("Concatenated string: " + combinedSentence);

// Converts the concatenated string into uppercase letters and stores the result.
string upperCaseSentence = combinedSentence.ToUpper();

// Displays the uppercase version of the string on the console.
Console.WriteLine("Uppercase string: " + upperCaseSentence);

// Creates a new `StringBuilder` object to build a paragraph efficiently.
StringBuilder paragraphBuilder = new StringBuilder();

// Adds the first sentence to the paragraph.
paragraphBuilder.Append("String handling is an important part of C# programming. ");

// Adds the second sentence to the paragraph.
paragraphBuilder.Append("You can join text together by concatenating multiple strings. ");

// Adds the third sentence to the paragraph.
paragraphBuilder.Append("You can also change text to uppercase when needed. ");

// Adds the fourth sentence to the paragraph.
paragraphBuilder.Append("StringBuilder is useful when creating larger pieces of text one sentence at a time.");

// Converts the completed `StringBuilder` content into a normal string.
string paragraph = paragraphBuilder.ToString();

// Displays the finished paragraph on the console.
Console.WriteLine("Paragraph built with StringBuilder: " + paragraph);
