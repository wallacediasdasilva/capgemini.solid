namespace SOLID._5___D___Dependency_Inversion_Principle
{
    public class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void ConnectToDatabase()
        {
        }

        public void PegarUsuario(int id)
        {
        }
    }
    public class Servico
    {
        private readonly UsuarioRepository _usuarioRepository;

        public MyService()
        {
            _usuarioRepository = new UsuarioRepository("myConnectionString");
        }
    }
}
