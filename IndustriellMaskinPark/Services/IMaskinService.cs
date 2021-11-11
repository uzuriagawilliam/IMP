using IndustriellMaskinPark.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IndustriellMaskinPark.Services
{
    public interface IMaskinService
    {
        public Task<Maskin> AddMaskin(Maskin maskin);
        public Task DeleteMaskin(int id);
        public Task<IEnumerable<Maskin>> GetAllMaskins();
        public Task<Maskin> GetMaskinsDetails(int maskinId);
        public Task UpdateMaskins(Maskin maskin);
    }
} 
