// See https://aka.ms/new-console-template for more information
string filepath = "C:\\OOP\\Lab03\\Exercise05";
string Verbatim_filepath = @"C:\OOP\Lab03\Exercise05";

System.Console.WriteLine(@"Example #1. directory name separation '\'");
System.Console.WriteLine($"filepath = {filepath}");
System.Console.WriteLine($"Verbatim_filepath = {Verbatim_filepath}");

// 
var multi_line_text = "this\nis\nmulti\nline\ntext.";

var verbatim_multi_line_text = @"this
is
multi
line
text.";

System.Console.WriteLine("--------------------------------------");
System.Console.WriteLine(@"Example #2. multi line text without \n escape sequence");
System.Console.WriteLine($"multi_line_text = {multi_line_text}");
System.Console.WriteLine($"verbatim_multi_line_text = {verbatim_multi_line_text}");

var quote_in_text = "My name is \"Sara\".";
var quote_in_verbatim_text = @"My name is ""Sara"".";

System.Console.WriteLine("--------------------------------------");
System.Console.WriteLine(@"Example #3. double quote in text");
System.Console.WriteLine($"quote_in_verbatim_text = {quote_in_verbatim_text}");
System.Console.WriteLine($"quote_in_text = {quote_in_text}");

