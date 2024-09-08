using PlayingWithJson;
using PlayingWithJson.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

JsonUtility JSonUtilityObj= new JsonUtility();

YouTuber youtubeObj= new YouTuber();

//Console.WriteLine(JSonUtilityObj.JsonData);
//Console.ReadLine();

youtubeObj = JsonSerializer.Deserialize<YouTuber>(JSonUtilityObj.JsonData);

Console.WriteLine("Name : " + youtubeObj.Name);
Console.WriteLine("Age : " + youtubeObj.Name);
Console.WriteLine("Active :" + youtubeObj.Active);
Console.WriteLine("Channel:" + youtubeObj.Channel);
Console.WriteLine("Members :" + youtubeObj.Members);

Console.Read();