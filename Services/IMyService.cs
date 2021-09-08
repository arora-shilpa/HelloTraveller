using System.Threading.Tasks;
using HelloTraveller.Models;

namespace HelloTraveller.Services
{
    public interface IMyService
    {
        Task<Result[]> GetAllData();
        Task<Topics[]> GetTopics();
        Task<MyModelClass> SearchPhotos(string search);
    }
}