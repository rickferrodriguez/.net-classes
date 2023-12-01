using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Data structure to represent an appointment
public class Appointment
{
    [JsonProperty("Day")]
    public string DayOfWeek { get; set; }
    [JsonProperty("Hour")]
    public TimeSpan StartTime { get; set; }
    [JsonProperty("Duration")]
    public int Duration { get; set; } // Duration in minutes
}

public class Program
{
    public static async Task Main()
    {
        // URL of the JSON file on the web
        string jsonFileUrl = "https://luegopago.blob.core.windows.net/luegopago-uploads/Pruebas%20LuegoPago/data.json";

        // Download JSON from the web
        string jsonContent = await DownloadJsonFromUrl(jsonFileUrl);

        // Convert JSON to a list of appointments
        List<Appointment> appointments = JsonConvert.DeserializeObject<List<Appointment>>(jsonContent);

        // Example of calculating available spaces for a specific day (e.g., Monday)
        Console.WriteLine("Por favor ingrese el día que desea agendar una cita (Ej. Lunes)");
        var dayToCheck = Convert.ToString(Console.ReadLine());
        int availableSpaces = CalculateAvailableSpaces(appointments, dayToCheck);

        Console.WriteLine($"Available spaces for {dayToCheck}: {availableSpaces}");
    }

    // Method to download JSON from a URL
    public static async Task<string> DownloadJsonFromUrl(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("Failed to download the JSON file from the provided URL.");
            }
        }
    }

    // Method to calculate available spaces for a given day of the week
    public static int CalculateAvailableSpaces(List<Appointment> appointments, string dayToCheck)
    {
        // Business hours
        TimeSpan openingTime = TimeSpan.FromHours(9);
        TimeSpan closingTime = TimeSpan.FromHours(17);
        TimeSpan minAppointmentDuration = TimeSpan.FromMinutes(30);

        // Filter appointments for the day to check
        var appointmentsForDay = appointments.Where(appointment => appointment != null && appointment.DayOfWeek.ToLower() == dayToCheck.ToLower()).ToList();

        if (appointmentsForDay == null)
        {
            return 0;
        }
        else
        {
            // Calculate the total duration of appointments for that day
            int totalAppointmentDuration = appointmentsForDay.Sum(appointment => appointment.Duration);

            // Calculate available time
            TimeSpan availableTime = closingTime - openingTime;
            int remainingTime = (int)(availableTime.TotalMinutes - totalAppointmentDuration);

            // Calculate available spaces
            int availableSpaces = remainingTime / (int)minAppointmentDuration.TotalMinutes;

            return availableSpaces;
        }
    }
}