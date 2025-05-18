using LogSheet_API.Models;

namespace LogSheet_API.Repository
{
    public interface ISolution
    {
        Task<List<Solution>> getSolutions();
        Task<Solution> getSolutionById(int id);
        Task<bool> saveandupdatesolution(Solution solution);
        Task<bool> deleteSolution(int id);
    }
}
