// See https://aka.ms/new-console-template for more information
using StringRepo.GroupAnagram;
using StringRepo.StringCompression443;
using StringRepo.ValidAnagram;


StringData stringData= new StringData();
char[] data = new char[]
{ 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
int s = stringData.Compress(data);
Console.WriteLine(s);