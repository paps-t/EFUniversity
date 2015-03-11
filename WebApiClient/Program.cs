using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.ReadKey();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50086/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/Student");
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<Student> students = await response.Content.ReadAsAsync<IEnumerable<Student>>();
                    Student firstStudent = students.First();
                    Console.WriteLine("Student info! Name: {0} Surname: {1} Age: {2}", firstStudent.FirstName, firstStudent.LastName, firstStudent.Age);
                }
            }
        }
    }
}