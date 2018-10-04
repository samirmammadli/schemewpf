using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Tools.Forms
{
    class CodeInputForm : IRequestForm
    {
        public string Email { get; set; }
        public int Code { get; set; }

        public CodeInputForm()
        {
            Email = "";
            Code = 0;
        }
    }
}
