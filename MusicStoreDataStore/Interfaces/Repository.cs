/*---------------------------------------------------------------------------------------------------------------
 * File Name   : Repository.cs
 * Purpose     : Model Class for Repository
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
using Microsoft.EntityFrameworkCore;
using MusicStoreDataStore.Context;
using MusicStoreDataStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreDataStore.Interfaces
{
    public class Repository<T> : IRepository<T> where T : BaseEntity   
    {
        private readonly MusicDbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(MusicDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        //public void InitContext(MusicDbContext context)
        //{
        //    this.context = context;
        //    this.entities = context.Set<T>();
        //}
        public IEnumerable<T> GetAll()
        {
            var data = entities.AsEnumerable();
            return data;
        }

        public T Get(long id)
        {
            return entities.Single(s => s.Id == id);
        }

        public void Attach(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.entities.Attach(entity);
        }

        public void InsertMany(List<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.AddRange(entity);
            context.SaveChanges();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void UpdateMany(List<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.UpdateRange(entity);
            context.SaveChanges();
        }

        public void DeleteMany(List<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.RemoveRange(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual IQueryable<T> FilteredGetAll()
        {
            return entities.AsQueryable();
        }

 
        public virtual SqlParameter[] ExecuteSPCommands(string sqlQuery, SqlParameter[] parameters)
        {
            try
            {

                _ = this.context.Database.ExecuteSqlRaw(sqlQuery, parameters);
                return parameters.Where(x => x.Direction == System.Data.ParameterDirection.Output).ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IQueryable<T> ReadFromStoredProcedure(string sqlQuery, SqlParameter[] parameters)
        {
            try
            {
                return entities.FromSqlRaw(sqlQuery, parameters);
            }
            catch (Exception ex)
            {

                throw;
            }
        }   
    }
}
