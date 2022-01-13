using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAgenda.Domain.Entities;

namespace WebAgenda.Data.Interfaces
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAll();
        Task<Contact> GetByID(int ID);
        bool ValidPhone(string phone);
        bool ValidMail(string mail);

        bool validDate(DateTime dateTime);
        Task Create(Contact contact);
        Task EditByContact(Contact contact);
        Task DeleteByID(int ID);
    }
}
