using LogSheet_API.DTOs;
using LogSheet_API.Models;

namespace LogSheet_API.Repository
{
    public interface IClient
    {
        Task<List<ClientDto>> GetClients();
        Task<ClientDto> GetClientById(ClientDtoByID id);
        Task<ClientDto> SaveAndUpdateClient(SaveUpdateClientDto saveUpdateClientDto);
        Task<bool> deleteClient(int id);
    }
}
