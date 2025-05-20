using LogSheet_API.DTOs;

namespace LogSheet_API.Repository
{
    public interface ILogSheet
    {

        Task<List<LogSheetDto>> GetLogSheets();
        Task<LogSheetDto?> GetLogSheetById(LogSheetDtoByID dto);

        Task<LogSheetDto?> SaveAndUpdateLogSheet(SaveUpdateLogSheetDto dto);
    }
}
