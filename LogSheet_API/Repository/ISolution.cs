using LogSheet_API.DTOs;
using LogSheet_API.Models;

namespace LogSheet_API.Repository
{
    public interface ISolution
    {
        Task<List<SolutionDto>> getSolutions();
        Task<SolutionDto> GetSolutionById(SolutionDtoByID id);
        Task<SolutionDto> SaveAndUpdateSolution(SaveUpdateSolutionDto saveUpdateSolutionDto);
        Task<bool> deleteSolution(int id);
    }
}
