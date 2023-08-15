// See https://aka.ms/new-console-template for more information

// Console.Write("Enter a String : ");
//  string sentence = Console.ReadLine();


string sentence = "Rea!ders ar*e request;ted to% &send t$heir queries@.";  //sentence to reverse word
string[] specialSymbols = { "!", "@", "#", "$", "%", "^", "&", "*" , "/", "(" , ")" , "," , ".", ";"};  // add all the special symbols that yow want to ignore in reverse 
List<int> symbolIndex = new List<int>(); 
List<string> symbolValues = new List<string>();



for(int i = 0 ; i < sentence.Length ; i++)  //check and add all the symbols syntax and value
{
    string e = sentence[i].ToString();
    foreach(var x in specialSymbols){
     if(e.Equals(x))
    {
        symbolIndex.Add(i);
        symbolValues.Add(x);
    }
    }

}
  foreach (var c in specialSymbols) //remove special symbols from sentence
    {
        sentence = sentence.Replace(c,"");
    }

List<string> words = sentence.Split(" ").ToList(); // split sentence in to word list

string final = "";

foreach(var x in words) // Reverse words from list
{   
     char[] charArray = x.ToCharArray();
     Array.Reverse(charArray);
     string reverseString = new string(charArray);
     final = final + reverseString + " ";
}
   
for(int i = 0 ; i < symbolIndex.Count; i++) // add special symbols bac at there position 
{
    final = final.Insert(symbolIndex[i],symbolValues[i]);
}

Console.WriteLine(final);

// foreach(var x in symbolIndex)
// {
//     Console.WriteLine(x);
// }
// foreach(var x in symbolValues)
// {
//     Console.WriteLine(x);
// }