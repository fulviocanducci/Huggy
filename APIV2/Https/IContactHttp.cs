using Huggy.Models;
using Huggy.Models.Contacts;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Huggy.Https
{
   public interface IContactHttp
   {
      Task<IReturnOf<List<Contact>>> ListAsync(int? page = null);
      Task<IReturnOf<List<Contact>>> ListAsync(string mobile, int? page = null);
      Task<IReturnOf<Contact>> GetAsync(int id);
      Task<IReturnOf<Contact>> GetAsync(string id);
      Task<IReturnOf<Contact>> AddAsync(ContactCreate model);
      Task<IReturnOf<string>> UpdateAsync(ContactUpdate model, int id);
      Task<IReturnOf<string>> UpdateAsync(ContactUpdate model, string id);
      Task<IReturnOf<string>> DeleteAsync(int id);
      Task<IReturnOf<string>> DeleteAsync(string id);
   }
}