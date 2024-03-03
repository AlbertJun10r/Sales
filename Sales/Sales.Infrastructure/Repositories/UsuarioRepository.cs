using Sales.Domain.Entitites;
using Sales.Domain.Repository;
using Sales.Infrastructure.Context;
using Sales.Infrastructure.Core;
using Sales.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sales.Infraestructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
{
    private readonly SalesContext context;

    public UsuarioRepository(SalesContext context) : base(context)
    {
        this.context = context;
    }

    public override List<Usuario> GetEntities()
    {
        return base.GetEntities().Where(usu => !usu.Eliminado).ToList();
    }

    public override void Save(Usuario entity)
    {
        base.Save(entity);
        this.context.SaveChanges();
    }

    public override void Update(Usuario entity)
    {
        Usuario usuario = this.GetEntity(entity.idUsuario);

        usuario.idUsuario = entity.idUsuario;
        usuario.FechaMod = entity.FechaMod;
        usuario.IdUsuarioMod = entity.IdUsuarioMod;
        usuario.Telefono = entity.Telefono;
        usuario.nombre = entity.nombre;
        usuario.correo = entity.correo;
        usuario.clave = entity.clave;
        usuario.idRol = entity.idRol;
        usuario.urlFoto = entity.urlFoto;
        usuario.nombreFoto = entity.nombreFoto;

        this.context.Usuario.Update(usuario);
        this.context.SaveChanges();

    }


    public override void Remove(Usuario entity)
    {
        Usuario usuario = this.GetEntity(entity.idUsuario);

        usuario.idUsuario = entity.idUsuario;
        usuario.Eliminado = entity.Eliminado = true;
        usuario.IdUsuarioElimino = entity.IdUsuarioElimino;
        usuario.FechaElimino = entity.FechaElimino;

        this.context.Usuario.Update(usuario);
        this.context.SaveChanges();
    }

    public List<UsuarioModel> GetUsuarios()
    {
        var usuarios = this.context.Usuario
                         .Where(usu => !usu.Eliminado)
                         .OrderByDescending(usu => usu.fechaRegistro)
                         .Select(usu => new UsuarioModel
                         {
                             fechaRegistro = usu.fechaRegistro,
                             idRol = usu.idRol,
                             nombreCompleto = usu.nombre,
                             correo = usu.correo,
                             idUsuario = usu.idUsuario,
                         })
                            .ToList();

        return usuarios;
    }

    public UsuarioModel GetUsuario(int idUsuario)
    {
        var usuarios = this.GetUsuarios();
        return usuarios.Find(s => s.idUsuario == idUsuario);
    }

        List<Usuario> IUsuarioRepository.GetUsuarios()
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioRepository.GetUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}