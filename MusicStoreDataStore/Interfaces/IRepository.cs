/*---------------------------------------------------------------------------------------------------------------
 * File Name   : IRepository.cs
 * Purpose     : Interface Class for Repository
 * Date Created: 16 April 2018
 * Created By  : 10xDS Team
 * 
 * History
 * ==============================================================================================================
 * Number   Date Modified   Modification Information      Modified By
 * ==============================================================================================================
 *       
 * 
 * ==============================================================================================================
 *
 */
using Microsoft.Data.SqlClient;
using MusicStoreDataStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreDataStore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IQueryable<T> FilteredGetAll(); 
        SqlParameter[] ExecuteSPCommands(string sqlQuery, SqlParameter[] parameters);
        T Get(long id);
        void Insert(T entity);
        void InsertMany(List<T> entity);
        void Update(T entity);
        void UpdateMany(List<T> entity);
        void Delete(T entity);
        void DeleteMany(List<T> entity);
        void Remove(T entity); 
        void SaveChanges();
        IQueryable<T> ReadFromStoredProcedure(string sqlQuery, SqlParameter[] parameters);
        void Attach(T entity);
    }
}
