using Huggy.Models;
using Huggy.Models.Contacts;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Huggy.Https
{
   public interface IContactHttp
   {
      Task<IReturnOf<List<Contact>>> GetListAsync(int? page = null);
      Task<IReturnOf<Contact>> GetAsync(int id);
      Task<IReturnOf<Contact>> PostAsync(ContactCreate model);
      Task<IReturnOf<string>> PutAsync(ContactUpdate model, int id);
      Task<IReturnOf<string>> DeleteAsync(int id);
   }
}