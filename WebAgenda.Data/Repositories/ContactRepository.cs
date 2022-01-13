using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAgenda.Domain.Entities;
using WebAgenda.Data.Interfaces;
using WebAgenda.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.RegularExpressions;

namespace WebAgenda.Data.Repositories
{
    class ContactRepository : IContactRepository
    {
        private readonly ApplicationContext _context;
        private readonly IErrorLogRepository _errorLogRepository;
        public ContactRepository(ApplicationContext context, IErrorLogRepository errorLogRepository)
        {
            _context = context;
            _errorLogRepository = errorLogRepository;
        }

        public async Task Create(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao cadastrar contato", ex);
                throw ex;
            }
        }

        public async Task EditByContact(Contact contact)
        {
            try
            {
                _context.Contacts.Update(contact);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao atualizar contato", ex);
                throw ex;
            }
        }

        public async Task<List<Contact>> GetAll()
        {
            try
            {
                return await _context.Contacts.ToListAsync();
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao retornar todos os contatos", ex);
                throw ex;
            }
        }

        public async Task<Contact> GetByID(int ID)
        {
            try
            {
                return await _context.Contacts.Where(x => x.ID == ID).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao retornar contato por Id", ex);
                throw ex;
            }
        }

        public bool ValidMail(string mail)
        {
            try
            {
                var domain = mail.Split('@')[1];
                if (domain.Contains(".com") && domain.Length > 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao validar email do contato", ex);
                throw ex;
            }

        }


        public static string KeepOnlyNumbers(string formattedNumber)
        {
            if (formattedNumber != null)
            {
                formattedNumber = Regex.Replace(formattedNumber, "[^0-9]", string.Empty);
            }

            return formattedNumber ?? string.Empty;
        }

        public bool ValidPhone(string phone)
        {
            try
            {
                string formatted = KeepOnlyNumbers(phone);

                return formatted.Length == 10 || formatted.Length == 11;
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao validar telefone do contato", ex);
                throw ex;
            }
        
        }

        public async Task DeleteByID(int ID)
        {
            try
            {
                var contact = await GetByID(ID);
                _context.Remove(contact);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao deletar contato", ex);
                throw ex;
            }
        }

        public bool validDate(DateTime dateTime)
        {
            try
            {
                DateTime dateMin = DateTime.Parse("01/01/1600");
                if (dateTime.Date >= DateTime.Now || dateTime.Date < dateMin.Date)
                {
                    return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                _errorLogRepository.SaveException("Erro ao validar data", ex);
                throw ex;
            }
        }
    }
}
