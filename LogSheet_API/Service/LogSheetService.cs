using AutoMapper;
using LogSheet_API.Common;
using LogSheet_API.Data;
using LogSheet_API.DTOs;
using LogSheet_API.Models;
using LogSheet_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace LogSheet_API.Service
{
    public class LogSheetService : ILogSheet
    {
        private readonly LogSheetDbContext _context;
        private readonly IMapper _mapper;

        public LogSheetService(LogSheetDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<LogSheetDto>> GetLogSheets()
        {
            var logs = await _context.LogSheets.ToListAsync(); 
            return _mapper.Map<List<LogSheetDto>>(logs);
        }

        public async Task<LogSheetDto?> GetLogSheetById(LogSheetDtoByID dto)
        {
            var log = await _context.LogSheets.FindAsync(dto.Id);
            if (log == null) return null;
            return _mapper.Map<LogSheetDto>(log);
        }

        public async Task<LogSheetDto?> SaveAndUpdateLogSheet(SaveUpdateLogSheetDto dto)
        {
            try
            {
                LogSheet log;

                if (dto.Id == 0)
                {
                    log = new LogSheet
                    {
                        SolutionId = dto.SolutionId,
                        ClientId = dto.ClientId,
                        TaskId = dto.TaskId,
                        WorkStatus = dto.WorkStatus,
                        LogDescription = dto.LogDescription,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now
                    };

                    _context.LogSheets.Add(log);
                }
                else
                {
                    log = await _context.LogSheets.FindAsync(dto.Id);
                    if (log == null) return null;

                    log.SolutionId = dto.SolutionId;
                    log.ClientId = dto.ClientId;
                    log.TaskId = dto.TaskId;
                    log.WorkStatus = dto.WorkStatus;
                    log.LogDescription = dto.LogDescription;
                   

                    _context.LogSheets.Update(log);
                }

                await _context.SaveChangesAsync();
                return _mapper.Map<LogSheetDto>(log);
            }
            catch (Exception ex)
            {
                Log.WriteLog("LogSheet", "SaveAndUpdateLogSheet", "SaveOrUpdate", ex.Message);
                throw new ApplicationException("Error saving or updating log sheet", ex);
            }
        }
    }

}
