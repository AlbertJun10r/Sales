using Sales.Domain.Entitites;
using Sales.Domain.Repository;
using Sales.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infrastructure.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        public List<UsuarioModel> GetUsuarios();
        public UsuarioModel GetUsuario(int id);
    }
}
