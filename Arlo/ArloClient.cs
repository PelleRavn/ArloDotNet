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

        public async Task<Result<List<Media>>> ArmDeviceAsync(Device device)
        {
            var notifyRequest = new NotifyRequest(device, "USER_ID_web", Mode.Arm);
            //        {
            //            "from":    "3AB3-210-6687469_web",
            //"to":    "48E46573A0B8B",
            //"action":    "set",
            //"resource":    "modes",
            //"transId":    "web!3975ac7b.ebb3a8!1504266382584",
            //"publishResponse":    true,
            //"properties": {
            //                "active":    "mode1"
            //}
            //        }
            var result = await _requestHandler.PostAsync<List<Media>>("hmsweb/users/library", notifyRequest);

            return result;
        }

        public async Task<Result<List<Media>>> DisarmDeviceAsync(Device device)
        {
            var notifyRequest = new NotifyRequest(device, "USER_ID_web", Mode.Disarm);
            //        {
            //            "from":    "3AB3-210-6687469_web",
            //"to":    "48E46573A0B8B",
            //"action":    "set",
            //"resource":    "modes",
            //"transId":    "web!3975ac7b.ebb3a8!1504266382584",
            //"publishResponse":    true,
            //"properties": {
            //                "active":    "mode0"
            //}
            //        }
            var result = await _requestHandler.PostAsync<List<Media>>("hmsweb/users/library", notifyRequest);

            return result;
        }

        public async Task<Result<List<Media>>> GetLibraryAsync(DateTime dateFrom, DateTime dateTo)
        {
            var mediaRequest = new MediaLibraryRequest(dateFrom, dateTo);
            var result = await _requestHandler.PostAsync<List<Media>>("hmsweb/users/library", mediaRequest);

            return result;
        }

        public async Task<Result<List<object>>> GetLibraryMetadataAsync()
        {
            var result = await _requestHandler.GetAsync<List<object>>("hmsweb/users/library/metadata/v2");

            return result;
        }

        public async Task<Result<List<object>>> GetProfileAsync()
        {
            var result = await _requestHandler.GetAsync<List<object>>("hmsweb/users/profile");

            return result;
        }

        public async Task<Result<object>> GetSessionAsync()
        {
            var result = await _requestHandler.GetAsync<object>("hmsweb/users/session");

            return result;
        }

        public async Task<Result<List<object>>> GetFriendsAsync()
        {
            var result = await _requestHandler.GetAsync<List<object>>("hmsweb/users/friends");

            return result;
        }

        public async Task<Result<List<object>>> GetUserLocationsAsync()
        {
            var result = await _requestHandler.GetAsync<List<object>>("hmsweb/users/locations");

            return result;
        }

        public async Task<Result<List<object>>> GetServiceLevelAsync()
        {
            var result = await _requestHandler.GetAsync<List<object>>("hmsweb/users/serviceLevel/v2");

            return result;
        }

        public async Task<Result<List<object>>> GetPaymentOffersAsync()
        {
            var result = await _requestHandler.GetAsync<List<object>>("hmsweb/users/payment/offers");

            return result;
        }
    }
}
