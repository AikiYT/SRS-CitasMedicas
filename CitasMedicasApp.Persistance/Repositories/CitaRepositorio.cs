﻿

using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Configuration;

namespace CitasMedicasApp.Persistance.Repositories
{
    public class CitaRepositorio : BaseRepository<Cita>, ICitaRepositorio
    {
        public CitaRepositorio(CitaContext context) : base(context)
        {


        }

        public Task<OperationRessult> Add(Cita entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cita> GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Cita>> ICitaRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }            // me falta llenar esto
}