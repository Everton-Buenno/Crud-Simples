using Crud_Simples.Models;

namespace Crud_Simples.Repositories.Abstracao
{
    public interface IUserService
    {


        bool Add(Usuario model);

        bool Update(Usuario model);
        bool Delete(int id);

        Usuario ListById(int id);

        IEnumerable<Usuario> ListUser();
    }
}
