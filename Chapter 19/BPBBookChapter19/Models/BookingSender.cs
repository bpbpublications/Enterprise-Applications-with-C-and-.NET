using System.Text;
using System.Text.Json;

namespace BPBBookChapter19.Models
{
    public class BookingSender : IBookingSender
    {
        public BookingSender()
        {
        }

        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<string> SendAsync(BookingOrder bookingOrder)
        {
            var json = JsonSerializer.Serialize<BookingOrder>(bookingOrder);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8,
                "application/json");

            var response = await httpClient.PostAsync("https://externalservice.com",
                stringContent);

            return response.Content.ReadAsStringAsync().Result;

        }
    }
}

