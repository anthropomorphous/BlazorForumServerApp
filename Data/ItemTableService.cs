using BlazorServerAppDB.Data.BlazorServerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorServerApp.Data
{
    public class ItemTableService
    {
        private readonly BlazorserverappContext _context;
        public ItemTableService(BlazorserverappContext context)
        {
            _context = context;
        }

        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                NotifyDataChanged();
            }
        }

        private ItemTable _item;

        public ItemTable Item
        {
            get
            {
                return _item;
            }

            set
            {
                _item = value;
                NotifyDataChanged();
            }
        }

        private string _categoryname;
        public string Category
        {
            get
            {
                return _categoryname;
            }
            set
            {
                _categoryname = value;
                NotifyDataChanged();
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyDataChanged();
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyDataChanged();
            }
        }

        public event Action OnClick;
        private void NotifyDataChanged() => OnClick?.Invoke();


        public Task<List<ItemTable>>
            GetItemAsync(string strCurrentUser)
        {
            List<ItemTable> colItemTables =
                new List<ItemTable>();
            colItemTables =
                (from itemTable in _context.ItemTable
                 where itemTable.UserName == strCurrentUser
                 select itemTable).ToList();
            return Task.FromResult(colItemTables);
        }

        public Task<List<ItemTable>>
            GetItemByCategoryAsync(string CategoryName)
        {
            List<ItemTable> colItemTables =
                new List<ItemTable>();  
            colItemTables =
                (from itemTable in _context.ItemTable
                 where itemTable.Category == CategoryName
                 select itemTable).ToList();
            return Task.FromResult(colItemTables);
        }


        public Task<List<ItemTable>>
            GetItemsAsync()
        {
            List<ItemTable> colItemTable =
                new List<ItemTable>();
            colItemTable =
                (from ItemTable in _context.ItemTable
                 select ItemTable).ToList();
            return Task.FromResult(colItemTable);
        }

        public Task<ItemTable>
        CreateItemAsync(ItemTable objItemTable)
        {
            _context.ItemTable.Add(objItemTable);
            _context.SaveChanges();
            return Task.FromResult(objItemTable);
        }

        public Task<bool>
            UpdateItemAsync(ItemTable objItemTable)
        {
            var ExistingItemTable =
                _context.ItemTable
                .Where(x => x.Id == objItemTable.Id)
                .FirstOrDefault();
            if (ExistingItemTable != null)
            {
                ExistingItemTable.Date =
                    objItemTable.Date;
                ExistingItemTable.ItemName =
                    objItemTable.ItemName;
                ExistingItemTable.ImageUrl =
                    objItemTable.ImageUrl;
                ExistingItemTable.Description =
                    objItemTable.Description;
                ExistingItemTable.Category =
                    objItemTable.Category;
                ExistingItemTable.CategoryId =
                    objItemTable.CategoryId;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteItemAsync(ItemTable objItemTable)
        {
            var ExistingItemTable =
                _context.ItemTable
                .Where(x => x.Id == objItemTable.Id)
                .FirstOrDefault();
            if (ExistingItemTable != null)
            {
                _context.ItemTable.Remove(ExistingItemTable);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}