using ClassicByte_Cucumber_ML_Test;

namespace ClassicByte.Cucumber.ML.Test
{
    internal class Program
    {
        static void Main()
        {
            var input = new PictureLearnModel.ModelInput();
            Console.WriteLine();
            input.ImageSource = File.ReadAllBytes();
        }
    }
}
