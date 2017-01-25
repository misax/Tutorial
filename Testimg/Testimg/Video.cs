using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Testing
{
    public class Video
    {
      public int ID { get; set; }
      public string VideoName { get; set; }
      public Han Hans { get; set; }
      public  string Title { get; set; }
      public string Description { get; set; }
      public override string ToString() => $"{Title} {this?.Hans?.Type}";

        public void Hex(Han video)
        {
            (Hans as IDisposable)?.Dispose();
            this.Hans = video;
        }

        public static JArray GetArray(IEnumerable<Video> jsonVideos)
        {
            var jsonArray = new JArray();
            if(jsonArray == null)
                   return new JArray(jsonVideos);

            else
            {
                if (jsonVideos != null)
                {
                    foreach (var json in jsonVideos)
                    {
                          jsonArray.Add(new JObject
                        {
                             ["VideoName"] =  json.VideoName,
                             ["Title"] = json.Title,
                             ["Description"] = json.Description,
                             ["Hans"] = new JObject
                             {
                                 ["VideoName"] = json?.Hans?.Type
                             }
                         });
                    }
                  
                }
            }
            return jsonArray;
        }

        public static void GetArray(Video jsonVideos)
        {
            Console.WriteLine(jsonVideos.VideoName);
        }
    }
}