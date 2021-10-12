using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotWinForms.Models
{
   public class History
    {
        public int Id { get; set; }
        public string DateMsg { get; set; }
        public string TypeMsg { get; set; }
        public string ChatId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string TextMsg { get; set; }
    }
}
