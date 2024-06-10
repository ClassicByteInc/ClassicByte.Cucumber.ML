using System;
using System.Net;
using ClassicByte_Cucumber_ML_AI;
using ClassicByte_Cucumber_ML_Test;

namespace ClassicByte.Cucumber.ML.AI
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    var input = new PictureLearnModel.ModelInput();
                    Console.Write("输入你的照片的位置:");
                    var imgpath = Console.ReadLine();

                    var web = new WebClient();
                    var data = web.DownloadData(imgpath);
                    input.ImageSource = data;

                    var result = PictureLearnModel.Predict(input);
                    switch (result.PredictedLabel)
                    {
                        case "初音未来":
                            Console.WriteLine("这是初音未来吧");
                            break;
                        case "洛天依":
                            Console.WriteLine("这是洛天依吧");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}");
                }
            }
        }
    }
}
