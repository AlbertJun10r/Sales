using Sales.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Repository
{
    public interface IUsuarioRepository
    {
        void Save(Usuario usuario);
        void Update(Usuario usuario);
        void Remove(Usuario usuario);
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(int id);
    }
}
