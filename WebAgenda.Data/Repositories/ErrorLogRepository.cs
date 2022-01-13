using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WebAgenda.Data.Context;
using WebAgenda.Data.Interfaces;
using WebAgenda.Domain.Entities;

namespace WebAgenda.Data.Repositories
{
    class ErrorLogRepository : IErrorLogRepository
    {
        private readonly ApplicationContext _contexto;

        public ErrorLogRepository(ApplicationContext contexto)
        {
            _contexto = contexto;
        }


        public void SaveException(string details, Exception exception)
        {
            try
            {
                ErrorLog erro = new ErrorLog(DateTime.Now, details, exception.Message, exception.StackTrace);
                _contexto.ErrorLogs.Add(erro);
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                // Salvar o log de erros caso o banco de dados não esteja conectando
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string folderErrorLog = folder + @"\WebAgenda\LogErros";
                string moment = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                string momentFileName = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = folderErrorLog + @"\" + momentFileName + "_LogErros";

                if (!Directory.Exists(folder + @"\WebAgenda\"))
                {
                    Directory.CreateDirectory(folder + @"\WebAgenda\");
            }

            if (!Directory.Exists(folder + @"\WebAgenda\LogErros"))
            {
                Directory.CreateDirectory(folder + @"\WebAgenda\LogErros");
            }

            using StreamWriter sw = new StreamWriter(File.Create(fileName));
            sw.WriteLine(moment + " - Erro ao tentar salvar o LOGERROS no banco de dados");
            sw.WriteLine(moment + " - Erro \"Exception.Message\": " + ex.Message);
            sw.WriteLine(moment + " - Erro \"Exception.StackTrace\": " + ex.StackTrace);
            sw.WriteLine(moment + " - Último erro ao tentar salvar \"Detalhes\": " + detalhes);
            sw.WriteLine(moment + " - Último erro ao tentar salvar \"Exception.Message\": " + exception.Message);
            sw.WriteLine(moment + " - Último erro ao tentar salvar \"Exception.StackTrace\": " + exception.StackTrace);
            sw.Close();
        }
    }
}
 }
