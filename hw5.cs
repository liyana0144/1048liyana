using System;

namespace ConsoleApp3_hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input image data adress: ");
            string ImageData = Console.ReadLine();
            double[,] imageDataArray = ReadImageDataFromFile(ImageData);

            Console.WriteLine("Input convolution kernel address: ");
            string convolutionk = Console.ReadLine();
            double[,] convolutionArray = ReadImageDataFromFile(convolutionk);

            Console.WriteLine("Output address: ");
            string output = Console.ReadLine();

            int collum = imageDataArray.GetLength(0) + convolutionArray.GetLength(0) - 1;
            int row = imageDataArray.GetLength(1) + convolutionArray.GetLength(1) - 1;

            double[,] ExpandedDataArray = WriteExpandedDataArray(imageDataArray, collum, row, imageDataArray.GetLength(0), convolutionArray.GetLength(1), imageDataArray.GetLength(0), convolutionArray.GetLength(1));
            double[,] outputImage = convolution(ExpandedDataArray, convolutionArray, imageDataArray.GetLength(0), imageDataArray.GetLength(1));
            WriteImageDataToFile(output, outputImage);
        }
        static double[,] WriteExpandedDataArray(double[,] imageDataArray, int expandedcollumn, int explandedrow, int dataArraycollumn, int dataArrayrow, int convolutioncollum, int convolutionrow)
        {
            double[,] ExpandedDataArray = new double[expandedcollumn, explandedrow];
            for (int i = 0; i < expandedcollumn; i++)
            {
                for (int j = 0; j < explandedrow; j++)
                {
                    ExpandedDataArray[i, j] = imageDataArray[(i + (dataArraycollumn - 1)) % dataArraycollumn, (j + (dataArrayrow - 1)) % dataArrayrow];

                }
            }
            return ExpandedDataArray;
        }
        static double[,] convolution(double[,] expandedDataArray, double[,] convolutionArray, int dataArraycollumn, int dataArrayrow)
        {
            double[,] outputImageArray = new double[dataArraycollumn, dataArrayrow];
            for (int i = 0; i < dataArraycollumn; i++)
            {
                for (int j = 0; j < dataArrayrow; j++)
                {
                    for (int k = 0; k < convolutionArray.GetLength(0); k++)
                    {
                        for (int l = 0; l < convolutionArray.GetLength(1); l++)
                        {
                            outputImageArray[i, j] += expandedDataArray[i + k, j + l] * convolutionArray[k, l];
                        }
                    }

                }
            }
            return outputImageArray;
        }
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath, double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i, imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }
            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }

    }
}
