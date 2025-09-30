using ECommerce.Models;

namespace ECommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /*
         * Controller > UsuarioRepository
         * Cotroller > IUsuarioRepository(abstração) > UsuarioRepository
         */

        public static  List<Usuario> _db = new List<Usuario>();

        public List<Usuario> GetUsuarios()
        {
            return _db;
        }
        public List<Usuario> Get()
        {
            return _db;
        }

        public Usuario Get(int  Id)
        {
           return _db.Find(x => x.Id == Id)!;
        }

        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
        }                          

        public void Update(Usuario usuario)
        {
            _db.Remove(Get(usuario.Id));
            _db.Add(usuario);
        }
        public void Delete(int Id)
        {
            _db.Remove(Get(Id));
        }
    }
}
