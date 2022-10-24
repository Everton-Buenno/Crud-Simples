using Crud_Simples.Data;
using Crud_Simples.Models;
using Crud_Simples.Repositories.Abstracao;

namespace Crud_Simples.Repositories.Implementacoes
{
    public class UserService : IUserService

    {

        private readonly DataContext context;


        public UserService(DataContext context)
        {
            this.context = context;
        }



        public bool Add(Usuario model)
        {
            try
            {
                context.Usuarios.Add(model);
                context.SaveChanges();
                return true;
            }catch(Exception Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.ListById(id);
                if(data == null)
                    return false;
                context.Usuarios.Remove(data);
                return true;
            }catch(Exception Exception)
            {
                return false;
            }
        }

        public Usuario ListById(int id)
        {
            return context.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ListUser()
        {
            return context.Usuarios.ToList();
        }

        public bool Update(Usuario model)
        {
            try
            {
                context.Usuarios.Update(model);
                context.SaveChanges();
                return true;
            }
            catch(Exception Exception)
            {
                return false;
            }
        }
    }
}
