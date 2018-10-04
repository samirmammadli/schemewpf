using RestSharp;
using SchemeWpf.Navigation;
using SchemeWpf.Tools.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Tools
{
    interface IResponseHandler
    {
        void Handle(INavigationService navigation, IRestResponse response, IRequestForm form);
    }
}
