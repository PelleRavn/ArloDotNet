using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Arlo.Handler;
using Arlo.Models;
using Arlo.Models.Requests;

namespace Arlo
{
    public class ArloClient
    {
        private RequestHandler _requestHandler;

        public ArloClient(string authenticationToken)
        {
            if (string.IsNullOrEmpty(authenticationToken) == true)
            {
                throw new ArgumentException("Invalid authentication token passed to constructor");
            }

            _requestHandler = new RequestHandler();
            _requestHandler.Authorization = authenticationToken;
        }

        public ArloClient(Result<LoginData> loginResult) : this(loginResult?.Data?.Token)
        {

        }

        public ArloClient(LoginData loginData) : this(loginData?.Token)
        {

        }

        public static async Task<Result<LoginData>> AuthenticateAsync(string email, string password)
        {
            var loginRequest = new LoginRequest(email, password);
            var requestHandler = new RequestHandler();
            var result = await requestHandler.PostAsync<LoginData>("hmsweb/login/v2", loginRequest);

            return result;
        }

        public async Task<Result<List<Device>>> GetDevicesAsync()
        {
            var result = await _requestHandler.GetAsync<List<Device>>("hmsweb/users/devices");

            return result;
        }

        public async Task<Result<List<Media>>> GetLibraryAsync(DateTime dateFrom, DateTime dateTo)
        {
            var mediaRequest = new MediaLibraryRequest(dateFrom, dateTo);
            var result = await _requestHandler.PostAsync<List<Media>>("hmsweb/users/library", mediaRequest);

            return result;
        }
    }
}
