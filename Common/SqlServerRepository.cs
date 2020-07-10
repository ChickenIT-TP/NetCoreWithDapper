using Interface;
using Model.API;
using Model.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Common.CommConst;

namespace Common
{
    public abstract class SqlServerRepository<T> : IDal<T> where T : class
    {
        private string _connectionString;
        private EDbConnectionTypes _dbType;

        public SqlServerRepository(string connectionString)
        {
            _dbType = EDbConnectionTypes.SQL_SERVER;
            _connectionString = connectionString;
        }
        public IDbConnection GetOpenConnection()
        {
            return DbConnectionFactory.GetDbConnection(_dbType, _connectionString);
        }


        public abstract void DeleteAsync(int id);

        public abstract Task<T> FindAsync(int id);

        public abstract Task<IEnumerable<T>> GetAllAsync(ApiRequest<JsonElement> apiRequest);

        public abstract void InsertAsync(T entity);

        public abstract void UpdateAsync(T entityToUpdate);
    }
}
