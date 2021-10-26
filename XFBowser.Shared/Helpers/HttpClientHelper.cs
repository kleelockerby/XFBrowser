using System;
using System.Collections.Generic;
using System.Text;

namespace XFBrowser.Shared
{
    public static class HttpClientHelper
    {
        public static string GetSelectedApplicationStringId(string selectedApplicationName)
        {
            string selectedApplicationId = string.Empty;
            switch (selectedApplicationName)
            {
                case "GolfStreamDemo_v36":
                    selectedApplicationId = "56ae220f-4bc8-4a96-9fa5-e622381b027a";
                    break;
                case "OneStream_GolfStream":
                    selectedApplicationId = "c4174af1-6c5d-456f-b3b1-da1583482774";
                    break;
                case "EZCorp":
                    selectedApplicationId = "ac7a2dc8-aa0c-438a-a3c8-fdba48f350d0";
                    break;
                case "MarketPlace":
                    selectedApplicationId = "290f545a-44fc-4e01-b0aa-ea2d322825a9";
                    break;
                case "MarketPlace_SS":
                    selectedApplicationId = "290f545a-44fc-4e01-b0aa-ea2d322825a7";
                    break;
                case "OneStream_KL":
                    selectedApplicationId = "cde8be57-5274-4812-9b3e-9034292ffc69";
                    break;
                case "SalesPlan":
                    selectedApplicationId = "0ae54d5a-0976-43bd-be98-6ceb58b691f8";
                    break;
                case "OneStream_Planning":
                    selectedApplicationId = "290f545a-44fc-4e01-b0aa-ea2d322825a9";
                    break;
                case "Walmart POC Dev":
                    selectedApplicationId = "f81d6861-f291-452a-af21-97c9ece02248";
                    break;
            }
            return selectedApplicationId;
        }
    }
}
