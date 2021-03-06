﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace Nox7atra
{
    public static class ExtensionMethods
    {
        public static Texture2D GetTexture2D(this Texture texture)
        {
            Texture2D texture2D = new Texture2D(Screen.width, Screen.height);
            texture2D.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
            texture2D.Apply();
            return texture2D;
        }
        public static string GetLocationString(this ServerLocation location)
        {
            switch (location)
            {
                case ServerLocation.EastUS2:
                    return "eastus2";
                case ServerLocation.SoutheastAsia:
                    return "southeastasia";
                case ServerLocation.WestCentralUS:
                    return "westcentralus";
                case ServerLocation.WestEurope:
                    return "westeurope";
                default:
                case ServerLocation.WestUS:
                    return "westus";
            }
        }
        public static string GetEmotionString(this EmotionType emotion)
        {
            switch (emotion)
            {
                case EmotionType.Anger:
                    return "Злость";
                case EmotionType.Contempt:
                    return "Презрение";
                case EmotionType.Disgust:
                    return "Отвращение";
                case EmotionType.Fear:
                    return "Страх";
                default:
                case EmotionType.Happiness:
                    return "Счастье";
                case EmotionType.Neutral:
                    return "Безэмоционально";
                case EmotionType.Sadness:
                    return "Грусть";
                case EmotionType.Surprise:
                    return "Удивление";
            }
        }
    }
}