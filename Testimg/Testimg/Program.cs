using System;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Security.Principal;
using Newtonsoft.Json;
using Testing;
using static System.Console;
using static System.String;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Testimg
{
    class Tetx : TextReader
    {
        private readonly TextReader read = null;
        public TextReader Type => read;

        public Tetx(TextReader read)
        {
            this.read = read;
            base.ReadAsync(new char[1000], 100, 10);
        }

        public static void X()
        {
           var  type = typeof (IApplicationTrustManager).Assembly.CodeBase;
             Matrix matrix = new Matrix();
            var offSet = matrix.OffsetX;
            var offSetY = matrix.OffsetY;
           
            if (!string.IsNullOrEmpty(type as String))
            {
                 matrix.Rotate(offSetY,MatrixOrder.Append);
            matrix.RotateAt(offSet,PointF.Empty);
            matrix.Scale(offSet,offSetY);
            }

        }
        public static void AddComponent()
        {
            Component compon = new Component();
            IContainer con = compon.Container;
            if (con == null)
            {
                con = new Container();
                con.Add(compon);
                if (compon != null)
                {
                    con.Remove(compon); 
                }  
               
            }         
        }

        public void TextRead(TextReader text,out string line)
        {

            using (text = new StreamReader(File.Create("text.txt")))
            {
              var stream =  File.Open("", FileMode.Open);
                line = text.ReadLine();
                while (line != null)
                {
                    stream.ReadByte();
                }
                stream.Close();
                text.Close();
            }
        }

        public static void CreateFiles(FileInfo[] file,string path)
        {
            var byt = 0;
            try
            {
                if (!file.IsReadOnly)
                {
                      int buffer = 512;
                      var fileCreate =  File.Create(path, buffer, FileOptions.None);
               if(!string.IsNullOrEmpty(path))
               {
                  byt = fileCreate.ReadByte();
                   for (int i = 0; i < file.Length; i++)
                   {
                       file[i] = new FileInfo(path);
                   }
               }  
                    Console.WriteLine(file.GetValue(0));
            }
              
            }
            catch
            {
                
                throw;
            }
        
        }
    }

    public class Program
    {
       private static void Main(string[] args)
       {
            Tetx.X();
            Tetx t = new Tetx(null);
            Tetx.AddComponent();
            Tetx.CreateFiles(new FileInfo[10], @"C:\Users\admin\text");
            
            string result = default(string);
           try
           {
             if(IsNullOrWhiteSpace(result))
               {
                   string format = $"{454} + {1} = {454 + 1} + {nameof(result)}";
                   result = format;
                   Console.WriteLine(result);
               }

           }
           catch (Exception e) when( e != null)
           {
               e = e.InnerException;
           }
            var video = new Video
           {
                Description = "my test of | Video class",
                VideoName = "Horror.Title",
                Title = "headline"
           };
      
           Video.GetArray(new Video{VideoName = "test"});
            var context = new MeContext();

           // Video videos = context.Videos.Single();
           //WriteLine(videos.VideoName);
           // WriteLine(videos.Description);
           // WriteLine(videos.ID);
            WriteLine(video.VideoName);
            WriteLine(video.Title);
            WriteLine(video.Description);
            // context.Database.Delete();
            //context.Videos.Add(video);
            //context.SaveChanges();

        }
    }
}
