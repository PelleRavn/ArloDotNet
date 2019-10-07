using System.Collections.Generic;
using System.Threading.Tasks;
using Arlo.Handler;
using Arlo.Models;
using Arlo.Models.Requests;

namespace Arlo
{
    public class ArloClient
    {
        public static string Email { get; set; }
        public static string Password { get; set; }

        private RequestHandler _requestHandler;

        public ArloClient()
        {
            _requestHandler = new RequestHandler();
        }

        public async Task Authenticate()
        {
            var loginRequest = new LoginRequest(Email, Password);
            var result = await _requestHandler.PostAsync<LoginData>("hmsweb/login/v2", loginRequest);
            if (result != null && result.Success == true)
            {
                _requestHandler.Authorization = result.Data.Token;
            }
        }

        public async Task<List<Device>> GetDevicesAsync()
        {
            var result = await _requestHandler.GetAsync<List<Device>>("hmsweb/users/devices");
            if (result != null && result.Success == true)
            {
                return result.Data;
            }

            return null;
        }

        public async Task<List<Media>> GetLibraryAsync()
        {
            var result = await _requestHandler.PostAsync<List<Media>>("hmsweb/users/library");
            if (result != null && result.Success == true)
            {
                return result.Data;
            }

            return null;
        }
    }
}
