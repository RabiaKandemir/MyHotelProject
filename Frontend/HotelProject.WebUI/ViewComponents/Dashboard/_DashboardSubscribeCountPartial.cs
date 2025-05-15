using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/kndmrabiaa"),
                Headers =
    {
        { "x-rapidapi-key", "385248deafmsh9fb2bb2cff18322p1d8b59jsn4d0621633628" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync(); ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDtos.Followers;
                ViewBag.v2 = resultInstagramFollowersDtos.Following;

                var request2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://twitter32.p.rapidapi.com/profile?username=kndmrabia"),
                    Headers =
    {
        { "x-rapidapi-key", "385248deafmsh9fb2bb2cff18322p1d8b59jsn4d0621633628" },
        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
    },
                };
                using (var response2 = await client.SendAsync(request2))
                {
                    response2.EnsureSuccessStatusCode();
                    var body2 = await response2.Content.ReadAsStringAsync();
                    ResultTwittterFollowersDto resultTwittterFollowersDto = JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2);
                    ViewBag.v3 = resultTwittterFollowersDto.data.stats.followers;
                    ViewBag.v4 = resultTwittterFollowersDto.data.stats.following;
                }

                var request3 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Frabia-kandemir%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                    Headers =
    {
        { "x-rapidapi-key", "385248deafmsh9fb2bb2cff18322p1d8b59jsn4d0621633628" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
                };
                using (var response3 = await client.SendAsync(request3))
                {
                    response3.EnsureSuccessStatusCode();
                    var body3 = await response3.Content.ReadAsStringAsync();
                    ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
                    ViewBag.v5 = resultLinkedinFollowersDto.data.follower_count;
                }
                return View();
            }
        }
    }
}
