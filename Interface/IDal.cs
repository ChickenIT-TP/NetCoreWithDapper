using Interface.API;
using Model.API;
using Model.DB;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using System.Threading.Tasks;

namespace Interface
{
    public interface IDal<T>
    {
        IDbConnection GetOpenConnection();
        Task<IEnumerable<T>> GetAllAsync(ApiRequest<JsonElement> apiRequest);
        Task<T> FindAsync(int id);
        void InsertAsync(T entity);
        void DeleteAsync(int id);
        void UpdateAsync(T entityToUpdate);
    }
}
