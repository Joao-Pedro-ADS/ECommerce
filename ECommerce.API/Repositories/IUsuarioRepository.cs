using ECommerce.Models;

namespace ECommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        /*
         * CRUD - Create, Read, Update, Delete
        */ 
        List<Usuario> GetUsuarios();

        Usuario Get(int Id);

        void Add(Usuario usuario);

        void Update(Usuario usuario);

        void Delete(int Id);
    }
}
