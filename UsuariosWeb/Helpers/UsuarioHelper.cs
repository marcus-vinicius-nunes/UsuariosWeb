using Blazored.LocalStorage;
using UsuariosWeb.Dtos;

namespace UsuariosWeb.Helpers
{
    /// <summary>
    /// Classe para execucao de operações do sistema com o usuário
    /// </summary>
    public class UsuarioHelper
    {
        private readonly ILocalStorageService _storageService;

        public UsuarioHelper(ILocalStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task SignIn(UsuarioDto dto)
        {
            await _storageService.SetItemAsync("user-auth", dto);
        }
    }
}
