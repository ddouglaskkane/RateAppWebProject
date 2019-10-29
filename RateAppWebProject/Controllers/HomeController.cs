using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RateAppWebProject.Models;

namespace RateAppWebProject.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Ratings> ratingList = new List<Ratings>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://tcapprateapi.azurewebsites.net/api/Commands"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ratingList = JsonConvert.DeserializeObject<List<Ratings>>(apiResponse);
                }
            }
            return View(ratingList);
        }

        public ViewResult GetRating() => View();

        [HttpGet]
        public async Task<IActionResult> GetRating(int Id)
        {
            Ratings rating = new Ratings();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://tcapprateapi.azurewebsites.net/api/Commands/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    rating = JsonConvert.DeserializeObject<Ratings>(apiResponse);
                }
            }
            return View(rating);
        }
    }
}