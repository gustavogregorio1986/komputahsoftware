using komputahsoftware.Data.Context;
using komputahsoftware.Data.DTO;
using komputahsoftware.Data.Repository.Interface;
using komputahsoftware.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komputahsoftware.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _db;

        public UsuarioRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Usuario?> BuscarPorCredenciaisAsync(string usuario, string senha)
        {
            return await _db.Usuarios
                .FirstOrDefaultAsync(u => u.NomeUsuario == usuario && u.Senha == senha);
        }
    }
}
