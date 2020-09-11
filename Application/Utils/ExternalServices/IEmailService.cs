using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Utils.ExternalServices
{
    public interface IEmailService
    {
        string Send(string destino, string titulo, string body);
    }
}
