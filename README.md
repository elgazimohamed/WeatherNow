# WeatherNow

## Overview
WeatherNow is a web application that allows users to check the current weather for any city around the globe. Leveraging the OpenWeatherMap API, this application provides real-time weather data, including temperature, humidity, wind speed, and weather conditions. Built with ASP.NET Core MVC and Bootstrap 5, it aims to deliver a responsive and user-friendly experience.

## Features
- **Real-Time Weather Data**: Get current weather information for any city using OpenWeatherMap API.
- **Responsive Design**: Built with Bootstrap 5 for optimal viewing on all devices.
- **User-Friendly Interface**: Simple and intuitive interface for quick access to weather information.
- **Error Handling**: Informative error messages when invalid input is provided.

## Prerequisites
Before you begin, ensure you have met the following requirements:
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine.
- A valid OpenWeatherMap API key. You can obtain one by signing up on [OpenWeatherMap](https://openweathermap.org/).

## Getting Started

To clone and run this application, follow these steps:

1. **Clone the Repository**
   
   ```bash
   git clone https://github.com/yourusername/WeatherNow.git

3. **Navigate to the Project Directory**
   ```bash
   cd WeatherNow

5. **Modify the API Key**
Open the appsettings.json file in your project and locate the WeatherApi section. You will need to replace the placeholder API key with your actual OpenWeatherMap API key
   ```bash
   "WeatherApi": {
    "ApiKey": "your_api_key_here", 
    "BaseUrl": "https://api.openweathermap.org/data/2.5/weather"
  }

4. **Restore Dependencies**
   ```bash
   dotnet restore

5. **Run the Application**
   ```bash
   dotnet run

6. **Access the Application**
   ```bash
   Open your web browser and navigate to http://localhost:5000 (or the URL shown in the terminal) to see the application in action. 

   
