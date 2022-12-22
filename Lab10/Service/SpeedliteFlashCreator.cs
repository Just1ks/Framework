using Lab10.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Service
{
    public class SpeedliteFlashCreator
    {
        public static string SpeedliteFlashTestData = "Speedlite 470EX-AI";

        public static SpeedliteFlash WithCredentials()
        {
            return new SpeedliteFlash(SpeedliteFlashTestData);
        }
    }
}
