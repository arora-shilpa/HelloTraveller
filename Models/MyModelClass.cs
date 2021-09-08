using System;
using System.Text.Json.Serialization;

namespace HelloTraveller.Models
{
    public class MyModelClass
    {
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public Result[] Results { get; set; }
    }

    public class Result
    {
        public string Id { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public string Description { get; set; }
        public string AltDescription { get; set; }
        public Urls Urls { get; set; }
        public long Likes { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TwitterUsername { get; set; }
        public Uri PortfolioUrl { get; set; }
        [JsonPropertyName("profile_image")] public ProfileImage ProfileImage { get; set; }

        [JsonPropertyName("instagram_username")]
        public string InstagramUsername { get; set; }
    }

    public class ProfileImage
    {
        public Uri Small { get; set; }
        public Uri Medium { get; set; }
        public Uri Large { get; set; }
    }

    public class Urls
    {
        public Uri Raw { get; set; }
        public Uri Full { get; set; }
        public Uri Regular { get; set; }
        public Uri Small { get; set; }
        public Uri Thumb { get; set; }
    }
}