namespace SOLID._2___O___Open_Closed_Principle
{
    public class CriarConta
    {
        private readonly IUserRepository _userRepository;
        private readonly IServicoDeRegistro _servicoDeRegistro;

        public CriarConta(IUserRepository userRepository, IServicoDeRegistro servicoDeRegistro)
        {
            _userRepository = userRepository;
            _servicoDeRegistro = servicoDeRegistro;
        }

        public void RegistraUsuario(string nome, string perfil)
        {
            if (_servicoDeRegistro.BlacklistedUsernames.Contains(perfil))
                throw new Exception();

            _userRepository.Insert(nome());
        }
    }
}
