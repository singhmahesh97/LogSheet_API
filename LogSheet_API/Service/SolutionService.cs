using AutoMapper;
using LogSheet_API.Common;
using LogSheet_API.Data;
using LogSheet_API.DTOs;
using LogSheet_API.Models;
using LogSheet_API.Repository;
using LogSheet_API.VMMOdels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Transactions;

namespace LogSheet_API.Service
{
    public class SolutionService : ISolution
    {
        private readonly LogSheetDbContext _context;
        private readonly IMapper _mapper;

        public SolutionService(LogSheetDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<bool> deleteSolution(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SolutionDto> GetSolutionById(SolutionDtoByID dto)
        {
            try
            {
                var solution = await _context.Solutions
                    .FirstOrDefaultAsync(s => s.Id == dto.Id);

                if (solution == null)
                    return null; // or throw an exception, or return a custom response

                var result = _mapper.Map<SolutionDto>(solution);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteLog("Solution", "GetSolutionById", "getSolutionById method", ex.Message);
                throw new ApplicationException("Error retrieving solution by ID", ex);
            }
        }


        public async Task<List<SolutionDto>> getSolutions()
        {
            
            try
            {
                var solutions = await _context.Solutions.ToListAsync();
                var solutionList = _mapper.Map<List<SolutionDto>>(solutions);
                return solutionList;
            }
            catch (Exception ex)
            {
                // Optionally log the error
                //string fromModule, string fromMethod,string errorSource,string errMesssage
                Log.WriteLog("Solution", "getSolutions", "getSolutions method",ex.Message);
                throw new ApplicationException("Error retrieving solutions", ex);

            }

        }
        public async Task<SolutionDto?> SaveAndUpdateSolution(SaveUpdateSolutionDto dto)
        {
            try
            {
                Solution solution;

                if (dto.Id == 0) // New record (Insert)
                {
                    solution = new Solution
                    {
                        Name = dto.Name,
                        Description = dto.Description,
                        Active = dto.Active,
                        CreatedBy = 1, // Replace with actual user ID
                        CreatedDate = DateTime.Now,
                        ModifiedBy=1,
                        ModifiedDate=DateTime.Now
                    };

                    _context.Solutions.Add(solution);
                }
                else // Existing record (Update)
                {
                    solution = await _context.Solutions.FindAsync(dto.Id);
                    if (solution == null)
                        return null;

                    solution.Name = dto.Name;
                    solution.Description = dto.Description;
                    solution.Active = dto.Active;
                    solution.ModifiedBy = 1; // Replace with actual user ID
                    solution.ModifiedDate = DateTime.Now;

                    _context.Solutions.Update(solution);
                }

                await _context.SaveChangesAsync();
               
                // Map entity to DTO before returning
                var solutionDto = _mapper.Map<SolutionDto>(solution);
                return solutionDto;
            }
            catch (Exception ex)
            {
                Log.WriteLog("Solution", "SaveAndUpdateSolution", "SaveOrUpdate method", ex.Message);
                throw new ApplicationException("Error saving or updating solution", ex);
            }
        }


    }
}
