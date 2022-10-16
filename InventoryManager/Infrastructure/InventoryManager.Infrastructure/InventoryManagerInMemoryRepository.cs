using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;

namespace InventoryManager.Infrastructure
{
    /// <summary>
    /// The InventoryManagerInMemoryRepository class.
    /// </summary>
    public class InventoryManagerInMemoryRepository : IRepository<InventoryItem>
    {
        /// <summary>
        /// The items
        /// </summary>
        private List<InventoryItem> items;

        /// <summary>
        /// The InventoryManagerInMemoryRepository constructor
        /// </summary>
        public InventoryManagerInMemoryRepository()
        {
            this.items = new();
        }

        /// <summary>
        /// The Create method.
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Create(InventoryItem entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            this.items.Add(entity as InventoryItem);
        }

        /// <summary>
        /// The CreateAsync method.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>The Task</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task CreateAsync(InventoryItem entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            return new Task(() => this.items.Add(entity as InventoryItem));
        }

        /// <summary>
        /// The Delete method.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            this.items.Remove(items.Find(i => i.Id == id));
        }

        /// <summary>
        /// The DeleteAsync method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The Task</returns>
        public Task DeleteAsync(int id)
        {
            return new Task(() => this.items.Remove(items.Find(i => i.Id == id)));
        }

        /// <summary>
        /// The Get method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The InventoryItem</returns>
        public InventoryItem Get(int id)
        {
            return items.Find(i => i.Id == id);
        }

        /// <summary>
        /// The GetAll method.
        /// </summary>
        /// <returns>The List of InventoryItem</returns>
        public List<InventoryItem> GetAll()
        {
            return this.items.Select(t => t as InventoryItem).ToList();
        }

        /// <summary>
        /// The GetAllAsync method.
        /// </summary>
        /// <returns>The Task<List<InventoryItem>></returns>
        public Task<List<InventoryItem>> GetAllAsync()
        {
            return new Task<List<InventoryItem>>(() => this.items.Select(t => t as InventoryItem).ToList());
        }

        /// <summary>
        /// The GetAsync method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task<InventoryItem> </returns>
        public Task<InventoryItem> GetAsync(int id)
        {
            return new Task<InventoryItem>(() => items.Find(i => i.Id == id));
        }

        /// <summary>
        /// The Update Method.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        public void Update(int id, InventoryItem entity)
        {
            var index = items.IndexOf(items.Find(i => i.Id == id));

            this.items[index] = entity as InventoryItem;
        }

        /// <summary>
        /// The UpdateAsync method.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns>The Task.</returns>
        public Task UpdateAsync(int id, InventoryItem entity)
        {
            return new Task(() =>
            {
                var index = items.IndexOf(items.Find(i => i.Id == id));

                this.items[index] = entity as InventoryItem;
            });
        }

        /// <summary>
        /// The DeleteByName method.
        /// </summary>
        /// <param name="name"></param>
        void IRepository<InventoryItem>.DeleteByName(string name)
        {
            this.items.Remove(items.Find(i => i.Name == name));
        }
    }
}