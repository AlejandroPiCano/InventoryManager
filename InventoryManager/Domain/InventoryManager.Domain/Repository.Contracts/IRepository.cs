﻿namespace InventoryManager.Domain.Repository.Contracts
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Get inventory item by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        /// Get inventory item by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetAsync(int id);

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <returns></returns>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Create a inventory Item
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);

        /// Create a inventory Item
        /// </summary>
        /// <param name="entity"></param>
        Task CreateAsync(T entity);

        /// <summary>
        /// Update a inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        void Update(int id, T entity);

        /// <summary>
        /// Update a inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        Task UpdateAsync(int id, T entity);

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Delete By Name
        /// </summary>
        /// <param name="name"></param>
        void DeleteByName(string name);

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        Task DeleteAsync(int id);

        /// <summary>
        /// Get New
        /// </summary>
        /// <returns></returns>
        T GetNew();
    }
}