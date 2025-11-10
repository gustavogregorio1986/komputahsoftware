using komputahsoftware.Data.DTO;
using komputahsoftware.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komputahsoftware.Data.Repository.Interface
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> BuscarPorCredenciaisAsync(string usuario, string senha);
    }
}
