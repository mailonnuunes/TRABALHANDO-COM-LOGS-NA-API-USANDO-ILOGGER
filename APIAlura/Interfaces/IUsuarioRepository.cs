
using APIAlura.Entity;

namespace APIAlura.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ObterComPedidos(int id);
    }
}
