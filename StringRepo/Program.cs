// See https://aka.ms/new-console-template for more information
using StringRepo.GroupAnagram;
using StringRepo.ValidAnagram;


ValidAnagram validAnagram = new ValidAnagram();
bool val =validAnagram.CheckValidAnagram("anagram", "nagaram");
Console.WriteLine(val);