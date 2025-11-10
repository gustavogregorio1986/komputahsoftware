using komputahsoftware.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komputahsoftware.Service.Service.Interface
{
    public interface IAuthService
    {
        Task<string> AutenticarAsync(LoginDTO login);
    }
}
