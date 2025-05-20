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
    public class ClientService : IClient
    {
        private readonly LogSheetDbContext _context;
        private readonly IMapper _mapper;

        public ClientService(LogSheetDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ClientDto>> GetClients()
        {
            var clients = await _context.Clients.ToListAsync();
            return _mapper.Map<List<ClientDto>>(clients);
        }

        public async Task<ClientDto?> GetClientById(ClientDtoByID dto)
        {
            var client = await _context.Clients.FindAsync(dto.Id);
            if (client == null) return null;
            return _mapper.Map<ClientDto>(client);
        }

        public async Task<ClientDto?> SaveAndUpdateClient(SaveUpdateClientDto dto)
        {
            try
            {
                Client client;

                if (dto.Id == 0) // Insert
                {
                    client = new Client
                    {
                        Name = dto.Name,
                        Description = dto.Description,
                        Active = dto.Active,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy=1,
                        ModifiedDate= DateTime.Now,

                    };

                    _context.Clients.Add(client);
                }
                else // Update
                {
                    client = await _context.Clients.FindAsync(dto.Id);
                    if (client == null) return null;

                    client.Name = dto.Name;
                    client.Description = dto.Description;
                    client.Active = dto.Active;
                    client.ModifiedBy = 1;
                    client.ModifiedDate = DateTime.Now;

                    _context.Clients.Update(client);
                }

                await _context.SaveChangesAsync();
                return _mapper.Map<ClientDto>(client);
            }
            catch (Exception ex)
            {
                Log.WriteLog("Client", "SaveAndUpdateClient", "SaveOrUpdate method", ex.Message);
                throw new ApplicationException("Error saving or updating client", ex);
            }
        }

        public Task<bool> deleteClient(int id)
        {
            throw new NotImplementedException();
        }
    }

}
