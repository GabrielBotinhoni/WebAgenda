using System;
using System.Collections.Generic;
using System.Text;

namespace WebAgenda.Data.Interfaces
{
    public interface IErrorLogRepository
    {
        void SaveException(string detalhes, Exception exception);
    }
}
