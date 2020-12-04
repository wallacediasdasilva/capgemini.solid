namespace SOLID._5___D___Dependency_Inversion_Principle
{
    public interface IUsuarioRepository
    {
        void PegarUsuario(int id);
    }

    public class UsuarioRrepository : IUsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRrepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private void connectToDatabase()
        {
            //Go away and make a connection to the database. 
        }

        public void PegarUsuario(int id)
        {
            connectToDatabase();
            //Use the database connection and then return people. 
        }
    }
    public class Servico
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public Servico(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void PegarUsuario(int id)
        {
            _usuarioRepository.PegarUsuario(id);
        }
    }
}
