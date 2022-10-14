using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using InventoryManager.Infrastructure.Entities;
using System.Net;

namespace InventoryManager.Infrastructure
{
    public class InventoryManagerInMemoryRepository : IRepository<InventoryItem>
    {
        private List<DefaultInventoryItem> items;

        public InventoryManagerInMemoryRepository()
        {
            this.items = new();
        }

        public void Create(InventoryItem entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            this.items.Add(entity as DefaultInventoryItem);
        }

        public Task CreateAsync(InventoryItem entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            return new Task(() => this.items.Add(entity as DefaultInventoryItem));
        }

        public void Delete(int id)
        {
            this.items.Remove(items.Find(i => i.Id == id));
        }

        public Task DeleteAsync(int id)
        {
            return new Task(() => this.items.Remove(items.Find(i => i.Id == id)));
        }

        public InventoryItem Get(int id)
        {
            return items.Find(i => i.Id == id);
        }

        public List<InventoryItem> GetAll()
        {
            return this.items.Select(t => t as InventoryItem).ToList();
        }

        public Task<List<InventoryItem>> GetAllAsync()
        {
            return new Task<List<InventoryItem>>(() => this.items.Select(t => t as InventoryItem).ToList());
        }

        public Task<InventoryItem> GetAsync(int id)
        {
            return new Task<InventoryItem>(() => items.Find(i => i.Id == id));
        }

        public InventoryItem GetNew()
        {
            return new DefaultInventoryItem();
        }

        public void Update(int id, InventoryItem entity)
        {
            var index = items.IndexOf(items.Find(i => i.Id == id));

            this.items[index] = entity as DefaultInventoryItem;
        }

        public Task UpdateAsync(int id, InventoryItem entity)
        {
            return new Task(() =>
            {
                var index = items.IndexOf(items.Find(i => i.Id == id));

                this.items[index] = entity as DefaultInventoryItem;
            });
        }

        void IRepository<InventoryItem>.DeleteByName(string name)
        {
            this.items.Remove(items.Find(i => i.Name == name));
        }
    }
}