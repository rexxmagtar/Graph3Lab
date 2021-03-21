using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Graph3
{
    static class BitmapExtensions
    {
        public enum MorphologyType
        {
            Dilation,
            Erosion
        }

        public static Bitmap DilateAndErodeFilter(
            this Bitmap sourceBitmap,
            int matrixSize,
            MorphologyType morphType,
            bool applyBlue = true,
            bool applyGreen = true,
            bool applyRed = true)
        {
            BitmapData sourceData =
                sourceBitmap.LockBits(new Rectangle(0, 0,
                        sourceBitmap.Width, sourceBitmap.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb);


            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];


            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                pixelBuffer.Length);


            sourceBitmap.UnlockBits(sourceData);


            int filterOffset = (matrixSize - 1) / 2;
       


            byte morphResetValue = 0;


            if (morphType == MorphologyType.Erosion)
            {
                morphResetValue = 255;
            }


            for (int offsetY = filterOffset;
                offsetY <
                sourceBitmap.Height - filterOffset;
                offsetY++)
            {
                for (int offsetX = filterOffset;
                    offsetX <
                    sourceBitmap.Width - filterOffset;
                    offsetX++)
                {

                    int calcOffset = 0;


                    int byteOffset = 0;


                    byte blue = 0;
                    byte green = 0;
                    byte red = 0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;


                    blue = morphResetValue;
                    green = morphResetValue;
                    red = morphResetValue;


                    if (morphType == MorphologyType.Dilation)
                    {
                        for (int filterY = -filterOffset;
                            filterY <= filterOffset;
                            filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset;
                                filterX++)
                            {
                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * sourceData.Stride);


                                if (pixelBuffer[calcOffset] > blue)
                                {
                                    blue = pixelBuffer[calcOffset];
                                }


                                if (pixelBuffer[calcOffset + 1] > green)
                                {
                                    green = pixelBuffer[calcOffset + 1];
                                }


                                if (pixelBuffer[calcOffset + 2] > red)
                                {
                                    red = pixelBuffer[calcOffset + 2];
                                }
                            }
                        }
                    }
                    else if (morphType == MorphologyType.Erosion)
                    {
                        for (int filterY = -filterOffset;
                            filterY <= filterOffset;
                            filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset;
                                filterX++)
                            {
                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * sourceData.Stride);


                                if (pixelBuffer[calcOffset] < blue)
                                {
                                    blue = pixelBuffer[calcOffset];
                                }


                                if (pixelBuffer[calcOffset + 1] < green)
                                {
                                    green = pixelBuffer[calcOffset + 1];
                                }


                                if (pixelBuffer[calcOffset + 2] < red)
                                {
                                    red = pixelBuffer[calcOffset + 2];
                                }
                            }
                        }
                    }


                    if (applyBlue == false)
                    {
                        blue = pixelBuffer[byteOffset];
                    }


                    if (applyGreen == false)
                    {
                        green = pixelBuffer[byteOffset + 1];
                    }


                    if (applyRed == false)
                    {
                        red = pixelBuffer[byteOffset + 2];
                    }


                    resultBuffer[byteOffset] = blue;
                    resultBuffer[byteOffset + 1] = green;
                    resultBuffer[byteOffset + 2] = red;
                    resultBuffer[byteOffset + 3] = 255;
                }
            }


            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                sourceBitmap.Height);


            BitmapData resultData =
                resultBitmap.LockBits(new Rectangle(0, 0,
                        resultBitmap.Width, resultBitmap.Height),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format32bppArgb);


            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                resultBuffer.Length);


            resultBitmap.UnlockBits(resultData);


            return resultBitmap;
        }

        public static Bitmap OpenMorphologyFilter(
            this Bitmap sourceBitmap,
            int matrixSize,
            bool applyBlue = true,
            bool applyGreen = true,
            bool applyRed = true)
        {
            Bitmap resultBitmap =
                sourceBitmap.DilateAndErodeFilter(
                    matrixSize, MorphologyType.Erosion,
                    applyBlue, applyGreen, applyRed);


            resultBitmap =
                resultBitmap.DilateAndErodeFilter(
                    matrixSize,
                    MorphologyType.Dilation,
                    applyBlue, applyGreen, applyRed);


            return resultBitmap;
        }


        public static Bitmap CloseMorphologyFilter(
            this Bitmap sourceBitmap,
            int matrixSize,
            bool applyBlue = true,
            bool applyGreen = true,
            bool applyRed = true)
        {
            Bitmap resultBitmap =
                sourceBitmap.DilateAndErodeFilter(
                    matrixSize, MorphologyType.Dilation,
                    applyBlue, applyGreen, applyRed);


            resultBitmap =
                resultBitmap.DilateAndErodeFilter(
                    matrixSize,
                    MorphologyType.Erosion,
                    applyBlue, applyGreen, applyRed);


            return resultBitmap;
        }

        public static Bitmap LinearContrast(this Bitmap sourceBitmap, int minBrightness, int maxBrightness)
        {
            BitmapData sourceData =
                sourceBitmap.LockBits(new Rectangle(0, 0,
                        sourceBitmap.Width, sourceBitmap.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb);


            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];


            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                pixelBuffer.Length);


            sourceBitmap.UnlockBits(sourceData);


            int currentMaxBR = 0;
            int currentMinBR = 255;

            for (int offsetY = 0;
                offsetY <
                sourceBitmap.Height;
                offsetY++)
            {
                for (int offsetX = 0;
                    offsetX <
                    sourceBitmap.Width;
                    offsetX++)
                {

                    int byteOffset = offsetY *
                                     sourceData.Stride +
                                     offsetX * 4;


                    int brightness = (int)Math.Min(255, GetBrightness(sourceBitmap.GetPixel(offsetX, offsetY)));


                    currentMaxBR = Math.Max(currentMaxBR, brightness);

                    currentMinBR = Math.Min(currentMinBR, brightness);
                }

            }

            for (int offsetY = 0;
                offsetY <
                sourceBitmap.Height;
                offsetY++)
            {
                for (int offsetX = 0;
                    offsetX <
                    sourceBitmap.Width;
                    offsetX++)
                {
                    int byteOffset = offsetY *
                                     sourceData.Stride +
                                     offsetX * 4;

                    int brightness = (int)Math.Min(255, GetBrightness(sourceBitmap.GetPixel(offsetX, offsetY)));

                    int newBrightness = LinearContrast(minBrightness, maxBrightness, currentMinBR, currentMaxBR, brightness);

                    float diff = 1.0f * newBrightness / brightness;

                    resultBuffer[byteOffset] = (byte)Math.Min(255, pixelBuffer[byteOffset] * diff);
                    resultBuffer[byteOffset + 1] = (byte)Math.Min(255, pixelBuffer[byteOffset + 1] * diff);
                    resultBuffer[byteOffset + 2] = (byte)Math.Min(255, pixelBuffer[byteOffset + 2] * diff);

                    resultBuffer[byteOffset + 3] = 255;
                }

            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                sourceBitmap.Height);


            BitmapData resultData =
                resultBitmap.LockBits(new Rectangle(0, 0,
                        resultBitmap.Width, resultBitmap.Height),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format32bppArgb);


            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                resultBuffer.Length);


            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static int LinearContrast(int yMin, int yMax, int xMin, int xMax, int x)
        {
            return (int)(((1.0f * (x - xMin) / (xMax - xMin)) * (yMax - yMin)) + yMin);
        }

        public static float GetBrightness(Color color)
        {
            return (0.2126f * color.R + 0.7152f * color.G + 0.0722f * color.B);
        }
    }
}