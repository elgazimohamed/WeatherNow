# WeatherNow

## Overview
WeatherNow is a web application that allows users to check the current weather for any city around the globe. Leveraging the OpenWeatherMap API, this application provides real-time weather data, including temperature, humidity, wind speed, and weather conditions. Built with ASP.NET Core MVC and Bootstrap 5, it aims to deliver a responsive and user-friendly experience.

<img width="959" alt="image" src="https://github.com/user-attachments/assets/b3c308af-2e65-40e6-9110-9a72a7231fb0">

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

4. **Modify the API Key**
Open the appsettings.json file in your project and locate the WeatherApi section. You will need to replace the placeholder API key with your actual OpenWeatherMap API key
   ```bash
   "WeatherApi": {
    "ApiKey": "your_api_key_here", 
    "BaseUrl": "https://api.openweathermap.org/data/2.5/weather"
   }

5. **Restore Dependencies**
   
   ```bash
   dotnet restore

6. **Run the Application**
   
   ```bash
   dotnet run

7. **Access the Application**

   Open your web browser and navigate to
   ```bash
    http://localhost:5000
(or the URL shown in the terminal) to see the application in action. 

   
