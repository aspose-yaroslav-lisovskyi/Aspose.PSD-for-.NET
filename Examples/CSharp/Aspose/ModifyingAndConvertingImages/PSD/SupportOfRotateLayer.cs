﻿using Aspose.PSD.FileFormats.Png;
using Aspose.PSD.FileFormats.Psd;
using Aspose.PSD.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.PSD.Examples.Aspose.ModifyingAndConvertingImages.PSD
{
    class SupportOfRotateLayer
    {
        public static void Run() {

            //ExStart:SupportOfRotateLayer
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            var sourceFile = dataDir + "1.psd";
            var pngPath = dataDir + "RotateFlipTest2617.png";
            var psdPath = dataDir + "RotateFlipTest2617.psd";
            var flipType = RotateFlipType.Rotate270FlipXY;
            using (var im = (PsdImage)(Image.Load(sourceFile)))
            {
                im.RotateFlip(flipType);
                im.Save(pngPath, new PngOptions()
                {
                    ColorType = PngColorType.TruecolorWithAlpha
                });
                im.Save(psdPath);
            }

            //ExEnd:SupportOfRotateLayer

        }
    }
}