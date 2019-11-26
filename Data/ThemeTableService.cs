using BlazorServerAppDB.Data.BlazorServerApp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorServerApp.Data
{
    public class ThemeTableService
    {
        private readonly BlazorserverappContext _context;
        public ThemeTableService(BlazorserverappContext context)
        {
            _context = context;
        }
        public Task<List<ThemeTable>>
            GetThemeAsync(string strCurrentUser)
        {
            List<ThemeTable> colThemeTables =
                new List<ThemeTable>();
            // Get Theme  
            colThemeTables =
                (from themeTable in _context.ThemeTable
                     // only get entries for the current logged in user
                 where themeTable.UserName == strCurrentUser
                 select themeTable).ToList();
            return Task.FromResult(colThemeTables);
        }

        public Task<List<ThemeTable>>
            GetThemesAsync(int CurrentTheme)
        {
            List<ThemeTable> colThemeTable =
                new List<ThemeTable>();
            // Get Themes  
            colThemeTable =
                (from ThemeTable in _context.ThemeTable
                 select ThemeTable).ToList();
            return Task.FromResult(colThemeTable);
        }

        public Task<ThemeTable>
        CreateThemeAsync(ThemeTable objThemeTable)
        {
            _context.ThemeTable.Add(objThemeTable);
            _context.SaveChanges();
            return Task.FromResult(objThemeTable);
        }

        public Task<bool>
            UpdateThemeAsync(ThemeTable objThemeTable)
        {
            var ExistingThemeTable =
                _context.ThemeTable
                .Where(x => x.Id == objThemeTable.Id)
                .FirstOrDefault();
            if (ExistingThemeTable != null)
            {
                ExistingThemeTable.Date =
                    objThemeTable.Date;
                ExistingThemeTable.ThemeName =
                    objThemeTable.ThemeName;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteThemeAsync(ThemeTable objThemeTable)
        {
            var ExistingThemeTable =
                _context.ThemeTable
                .Where(x => x.Id == objThemeTable.Id)
                .FirstOrDefault();
            if (ExistingThemeTable != null)
            {
                _context.ThemeTable.Remove(ExistingThemeTable);
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