//Create by Satvik Rajnarayanan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Weather;
using System.Drawing;
namespace ConsoleApp1
{
    //Create by Satvik Rajnarayanan
    internal class Program
    {
        //Create by Satvik Rajnarayanan
        static void Main(string[] args)
        {
            //Get the Weather (Current Time)
            Weather weather = Api.GetWeatherByCity("City Name");
            Console.WriteLine($"Temperature: {weather.Temperature}, " +
            $"Humidity: {weather.Humidity}, Looks like Day? {weather.IsDay}," +
            $" Latitude: {weather.Latitude}, Longitude: {weather.Longitude}, " +
            $"State: {weather.State}, Country: {weather.Country}," +
            $" Weather: {weather.Weather_Current}, Cloud Cover {weather.Cloud_Cover}," +
            $" Time Zone: {weather.TimeZone}, Wind Speed {weather.Wind_Speed}," +
            $" Wind Degree {weather.Wind_Degree}, Wind Direction: {weather.Wind_Direction}, " +
            $"Pressure: {weather.Pressure}, Icon Url: {weather.Weather_Icon_url}");
            weather.Save_Weather_Icon_As_Jpg("C:\\weather");
            Console.WriteLine("Press Enter to continue...");
            Console.Read();

            //Get Current Season
            Console.WriteLine(Api.Get_Curent_Season_Northern_Hemisphere_As_String());
            Console.WriteLine(Api.Get_Curent_Season_Southern_Hemisphere_As_String());

            //Get images of different seasons and save it
            Image image = Api.GetSummerImage(2);
            Image winter = Api.GetWinterImage(3);
            Image autumn = Api.GetAutumnImage(5);
            Image spring = Api.GetSpringImage(4);
            image.Save("C:\\test\\Summer.png");
            winter.Save("C:\\test\\Winter.png");
            autumn.Save("C:\\test\\autumn.png");
            spring.Save("C:\\test\\Spring.png");
            Console.WriteLine("Files Saved..");
            Console.Read();

            //Get Current Season Image and Save it.
            Image image_north = Api.Get_Curent_Season_Image_Northern_Hemisphere(4);
            Image image_south = Api.Get_Curent_Season_Image_Southern_Hemisphere(2);
            image_north.Save("C:\\North.png");
            image_south.Save("C:\\South.png");
            Console.WriteLine("Files Saved");
            Console.Read();
        }
    }
}
