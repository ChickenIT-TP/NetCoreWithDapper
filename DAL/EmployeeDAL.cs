using Common;
using Dapper;
using Model;
using Model.API;
using Model.DB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL : SqlServerRepository<Employee>
    {
        public EmployeeDAL(string connectionString) : base(connectionString) { }

        public override async Task<Employee> FindAsync(int id)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM Employee WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id, System.Data.DbType.Int32);
                return await conn.QueryFirstOrDefaultAsync<Employee>(sql, parameters);
            }
        }

        public override async Task<IEnumerable<Employee>> GetAllAsync(ApiRequest<JsonElement> req)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM Employee";
                return await conn.QueryAsync<Employee>(sql);
            }
        }

        public override void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        

        public override void InsertAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public override void UpdateAsync(Employee entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
