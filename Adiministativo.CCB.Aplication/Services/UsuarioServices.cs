using Adiministativo.CCB.Aplication.IServices;
using Adiministativo.CCB.Aplication.Model;
using Administrativo.CCB.Dominio.Entity;
using Administrativo.CCB.Dominio.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adiministativo.CCB.Aplication.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IEncryptionService _encryptionService;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IJwtTokenService _jwtTokenService;

        public UsuarioServices(IEncryptionService encryptionService, IUsuarioRepository usuarioRepository, IJwtTokenService jwtTokenService)
        {
            _encryptionService = encryptionService;
            _usuarioRepository = usuarioRepository;
            _jwtTokenService = jwtTokenService;

        }
        public async Task<Usuario> AuthenticateUserAsync(LoginModel model)
        {
            try
            {
                var user = await _usuarioRepository.GetUserByUsernameAsync(model.Username);
                if (user == null)
                    throw new Exception("Usuário não encontrado.");

                string encryptedPassword = _encryptionService.Encrypt(user.PasswordHash);

                bool usuariovailar = model.Username == user.Username;
                bool senharValidar = model.PasswordHash == encryptedPassword;
                if (!senharValidar || !usuariovailar)
                    throw new Exception("Senhar ou Usuário invalido");

                bool valido = _jwtTokenService.ValidateToken(user.Token);
                if (!valido)
                    throw new Exception("Token do Usuário não e valido ou cadastro no e valido.");

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Realizar a Autenticação.", ex);
            }
        }

        public async Task<Usuario> RegisterUserAsync(RegistreModel model)
        {
            try
            {
                var existeUsuario = await _usuarioRepository.GetUserByUsernameAsync(model.Username);
                if (existeUsuario != null)
                    throw new Exception("Usuario já possuir um cadastro.");

                string encryptedPassword = _encryptionService.Encrypt(model.PasswordHash);

                var novoUsuario = new Usuario
                {
                    Id = Guid.NewGuid(),
                    Username = model.Username,
                    PasswordHash = encryptedPassword,
                    EmailAddress = model.EmailAddress,
                    Token = _jwtTokenService.GenerateToken(model.Username,model.Role), // Método para gerar token
                    DateOfJoining = DateTime.UtcNow,
                    Role = model.Role,
                    Date = DateTime.UtcNow
                };

                // Adicionar o novo usuário ao repositório
                await _usuarioRepository.AddUserAsync(novoUsuario);

                return novoUsuario;
            }
            catch (Exception ex) 
            {
                throw new Exception("Erro ao Cadastra o Usuario.", ex);
            }
        }
    }
}
