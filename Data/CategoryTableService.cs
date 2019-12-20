using BlazorServerAppDB.Data.BlazorServerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorServerApp.Data
{
    public class CategoryTableService
    {
        private readonly BlazorserverappContext _context;
        public CategoryTableService(BlazorserverappContext context)
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

        private ThemeTable _theme;

        public ThemeTable Theme
        {
            get
            {
                return _theme;
            }

            set
            {
                _theme = value;
                NotifyDataChanged();
            }
        }

        private string _themename;
        public string Name
        {
            get
            {
                return _themename;
            }
            set
            {
                _themename = value;
                NotifyDataChanged();
            }
        }

        public event Action OnClick;
        private void NotifyDataChanged() => OnClick?.Invoke();


        public Task<List<CategoryTable>>
            GetCategoryAsync(string strCurrentUser)
        {
            List<CategoryTable> colCategoryTables =
                new List<CategoryTable>();
            colCategoryTables =
                (from categoryTable in _context.CategoryTable
                 where categoryTable.UserName == strCurrentUser
                 select categoryTable).ToList();
            return Task.FromResult(colCategoryTables);
        }

        public Task<CategoryTable>
        CreateCategoryAsync(CategoryTable objCategoryTable)
        {
            _context.CategoryTable.Add(objCategoryTable);
            _context.SaveChanges();
            return Task.FromResult(objCategoryTable);
        }

    }
}