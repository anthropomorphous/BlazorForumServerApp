using BlazorServerAppDB.Data.BlazorServerApp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorServerApp.Data
{
    public class AllThemesTableService
    {
        //Connects to the database using the datacontext we created with the EF Core tools.
        private readonly BlazorserverappContext _context;
        public AllThemesTableService(BlazorserverappContext context)
        {
            _context = context;
        }
        public Task<List<AllThemesTable>>
            GetThemeAsync(int CurrentTheme)
        {
            List<AllThemesTable> colAllThemesTable =
                new List<AllThemesTable>();
            // Get Themes  
            colAllThemesTable =
                (from allThemesTable in _context.AllThemesTable
                     // only get entries for the current logged in user
                 where allThemesTable.ThemeId == CurrentTheme
                 select allThemesTable).ToList();
            return Task.FromResult(colAllThemesTable);
        }



        public Task<AllThemesTable>
        CreateThemeAsync(AllThemesTable objAllThemesTable)
        {
            _context.AllThemesTable.Add(objAllThemesTable);
            _context.SaveChanges();
            return Task.FromResult(objAllThemesTable);
        }

        public Task<bool>
            UpdateThemeAsync(AllThemesTable objAllThemesTable)
        {
            var ExistingAllThemesTable =
                _context.AllThemesTable
                .Where(x => x.Id == objAllThemesTable.Id)
                .FirstOrDefault();
            if (ExistingAllThemesTable != null)
            {
                ExistingAllThemesTable.Date =
                    objAllThemesTable.Date;
                ExistingAllThemesTable.ThemeId =
                    objAllThemesTable.ThemeId;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteThemeAsync(AllThemesTable objAllThemesTable)
        {
            var ExistingAllThemesTable =
                _context.AllThemesTable
                .Where(x => x.Id == objAllThemesTable.Id)
                .FirstOrDefault();
            if (ExistingAllThemesTable != null)
            {
                _context.AllThemesTable.Remove(ExistingAllThemesTable);
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