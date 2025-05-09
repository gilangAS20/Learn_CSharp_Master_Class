// See https://aka.ms/new-console-template for more information

using StringSplit_StringJoin;


string input = "this,is,some,string";
string originalSeparator = "-";
string targetSeparator = "+";
Console.WriteLine(StringsTransformator.TransformSeparator(input, originalSeparator, targetSeparator));