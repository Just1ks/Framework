using Lab10.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Service
{
    public static class CameraCreator
    {
        //Тестовые данные
        public static string CameraModelTestData = "Canon 1300d";
        
        public static Camera WithCredentials()
        {
            return new Camera(CameraModelTestData);
        }

        public static Camera WithFullCamera()
        {
            return new Camera(CameraModelTestData = null, Camera.Type.Mirrorless, Camera.Frame.FullFrame);
        }
    }
}
