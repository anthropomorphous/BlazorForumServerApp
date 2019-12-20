using BlazorServerAppDB.Data.BlazorServerApp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class MessageTableService
    {
        //Connects to the database using the datacontext we created with the EF Core tools.
        private readonly BlazorserverappContext _context;
        public MessageTableService(BlazorserverappContext context)
        {
            _context = context;
        }
        public Task<List<MessageTable>>
            GetMessagesAsync(int CurrentId)
        {
            List<MessageTable> colMessageTable =
                new List<MessageTable>();
            // Get Messages 
            colMessageTable =
                (from messageTable in _context.MessageTable
                     // only get entries for the current logged in user
                 where messageTable.ThemeId == CurrentId
                 select messageTable).ToList();
            return Task.FromResult(colMessageTable);
        }

        public Task<List<MessageTable>>
           GetMessagesByItemAsync(int CurrentId)
        {
            List<MessageTable> colMessageTable =
                new List<MessageTable>();
            // Get Messages 
            colMessageTable =
                (from messageTable in _context.MessageTable
                 where messageTable.ItemId == CurrentId
                 select messageTable).ToList();
            return Task.FromResult(colMessageTable);
        }

        public Task<List<MessageTable>>
            GetMessageAsync(string strCurrentUser)
        {
            List<MessageTable> colMessageTables =
                new List<MessageTable>();
            Dictionary<ThemeTable, MessageTable> dictThemeTables =
               new Dictionary<ThemeTable, MessageTable>();
            // Get Message
            colMessageTables =
                (from messageTable in _context.MessageTable
                     // only get entries for the current logged in user
                 where messageTable.UserName == strCurrentUser
                 select messageTable).ToList();
            return Task.FromResult(colMessageTables);
        }

        public Task<MessageTable>
        CreateMessageAsync(MessageTable objMessageTable)
        {
            _context.MessageTable.Add(objMessageTable);
            _context.SaveChanges();
            return Task.FromResult(objMessageTable);
        }

        public Task<bool>
            UpdateMessageAsync(MessageTable objMessageTable)
        {
            var ExistingMessageTable =
                _context.MessageTable
                .Where(x => x.Text == objMessageTable.Text)
                .FirstOrDefault();
            if (ExistingMessageTable != null)
            {
                ExistingMessageTable.Date =
                    objMessageTable.Date;
                ExistingMessageTable.ThemeId =
                    objMessageTable.ThemeId;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteMessageAsync(MessageTable objMessageTable)
        {
            var ExistingMessageTable =
                _context.MessageTable
                .Where(x => x.Id == objMessageTable.Id)
                .FirstOrDefault();
            if (ExistingMessageTable != null)
            {
                _context.MessageTable.Remove(ExistingMessageTable);
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