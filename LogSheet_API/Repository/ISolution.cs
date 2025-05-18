using LogSheet_API.DTOs;
using LogSheet_API.Models;

namespace LogSheet_API.Repository
{
    public interface ISolution
    {
        Task<List<Solution>> getSolutions();
        Task<Solution> getSolutionById(SolutionDtoByID id);
        Task<bool> saveandupdatesolution(SolutionDto solution);
        Task<bool> deleteSolution(int id);
    }
}
