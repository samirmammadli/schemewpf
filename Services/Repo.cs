using RestSharp;
using RestSharp.Deserializers;
using SchemeWpf.Tools;
using SchemeWpf.Tools.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Services
{
    class Repo
    {
        public RestClient Client { get; set; }
        public AccessTokenResult Token { get; set; }

        public Repo()
        {
            Client = new RestClient("https://mammadli.info/");
        }

        public async Task<IRestResponse> Login(string email, string password)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "api/account/login";
            request.AddJsonBody(new { Email = email, Password = password });

            return await Client.ExecuteTaskAsync(request);
        }

        public async Task<IRestResponse> Register(dynamic data)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "api/account/registration";
            request.AddJsonBody(data);

            return await Client.ExecuteTaskAsync(request);
        }

        public async Task<AccessTokenResult> RegConfirm(CodeInputForm form)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "api/account/registration/confirm";
            request.AddJsonBody(form);
            var response = await Client.ExecuteTaskAsync(request);

            if (response.IsSuccessful)
            {
                var ser = new JsonDeserializer();
                Token = ser.Deserialize<AccessTokenResult>(response);
                return Token;
            }
            throw new ArgumentException("Something went wrong: " + response.Content);
        }

        public async Task ResendCode(string email)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "api/account/registration/resend_code";
            request.AddJsonBody(new { Email = email });
            var response = await Client.ExecuteTaskAsync(request);

            if (response.IsSuccessful)
                return;

            throw new ArgumentException("Something went wrong: " + response.Content);
        }

        public async Task ForgotPassword(string email)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "api/account/password/forgot";
            request.AddJsonBody(new { Email = email });
            var response = await Client.ExecuteTaskAsync(request);

            if (response.IsSuccessful)
                return;

            throw new ArgumentException("Something went wrong: " + response.Content);
        }

        public async Task ResetPassword(ChangePasswordForm form)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "api/account/password/reset";
            request.AddJsonBody(form);
            var response = await Client.ExecuteTaskAsync(request);

            if (response.IsSuccessful)
                return;

            throw new ArgumentException("Something went wrong: " + response.Content);
        }
    }
}
