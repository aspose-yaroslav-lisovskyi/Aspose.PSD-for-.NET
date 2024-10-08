﻿using Aspose.PSD.FileFormats.Psd;
using Aspose.PSD.FileFormats.Psd.Layers;
using System;
using System.IO;

namespace Aspose.PSD.Examples.Aspose.Opening
{
    class LoadingImageFromStreamAsALayer
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Opening();

            //ExStart:LoadingImageFromStream

            string outputFilePath = dataDir + "PsdResult.psd";

            var filesList = new string[]
            {
                "PsdExample.psd",
                "BmpExample.bmp",
                "GifExample.gif",
                "Jpeg2000Example.jpf",
                "JpegExample.jpg",
                "PngExample.png",
                "TiffExample.tif",
            };
            using (var image = new PsdImage(200, 200))
            {
                foreach (var fileName in filesList)
                {
                    string filePath = dataDir + fileName;
                    using (var stream = new FileStream(filePath, FileMode.Open))
                    {
                        Layer layer = null;
                        try
                        {
                            layer = new Layer(stream);
                            image.AddLayer(layer);
                        }
                        catch (Exception e)
                        {
                            if (layer != null)
                            {
                                layer.Dispose();
                            }
                            throw e;
                        }
                    }
                }
                image.Save(outputFilePath);
            }
            //ExEnd:LoadingImageFromStream

        }
    }
}