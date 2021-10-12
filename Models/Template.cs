using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotWinForms.Models
{
   public class Template
    {
        public int Id { get; set; }
        /// <summary>
        /// Входящее сообщение
        /// </summary>
        public string InMessage { get; set; }
        //Ответ
        public string OutMessage { get; set; }
    }
}
