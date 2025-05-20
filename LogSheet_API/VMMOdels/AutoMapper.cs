using AutoMapper;
using LogSheet_API.DTOs;
using LogSheet_API.Models;

namespace LogSheet_API.VMMOdels
{
    public class AutoMapper :Profile
    {
        public AutoMapper()
        {
            CreateMap<Solution, SolutionDto>().ReverseMap();

            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<SaveUpdateClientDto, Client>();

            CreateMap<LogSheet, LogSheetDto>().ReverseMap();
            CreateMap<SaveUpdateLogSheetDto, LogSheet>();
        }
    }
    
}
