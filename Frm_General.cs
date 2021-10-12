using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using TelegramBotWinForms.Models;

namespace TelegramBotWinForms
{
    public partial class Frm_General : Form
    {
        private static string botKey = "";
        private static TelegramBotClient botClient;


        public Frm_General()
        {
            InitializeComponent();
        }


        private void Frm_General_Load(object sender, EventArgs e)
        {
            //Проверяем наличие АПИ ключа
            if (string.IsNullOrEmpty(Properties.Settings.Default["BotApiKey"].ToString()))
                MessageBox.Show("Необходимо указать API Key bot");
            else
            {
                InitBot();
            }
        }


        /// <summary>
        /// Прослушиваем входящие сообщения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BotClient_OnMessage(object sender, MessageEventArgs e)
        {
            string text = e.Message.Text;
            //Если текстовое сообщение
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                //Добавляем сообщение в таблицу
                dataGridView_MessageList.Invoke((MethodInvoker)delegate
                {
                    dataGridView_MessageList.Rows.Add(e.Message.Date,
                        "In",
                        e.Message.Chat.Id.ToString(),
                        e.Message.Chat.FirstName,
                        e.Message.Chat.LastName,
                        e.Message.Chat.Username,
                        e.Message.Text);

                });



                string outText = $"Contact name: {e.Message.Chat.FirstName} \n <b>Message:</b> {e.Message.Text}";
                //Отправляем ответ
                await botClient.SendTextMessageAsync(e.Message.Chat.Id, outText, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                //Добавляем сообщение ответа в таблицу
                dataGridView_MessageList.Invoke((MethodInvoker)delegate
                {
                    dataGridView_MessageList.Rows.Add(e.Message.Date,
                        "Out",
                        e.Message.Chat.Id.ToString(),
                        lbl_BotName.Text,
                        "",
                        "",
                        outText);
                });

                //Сохраняем сообщения в БД в истории
                using(AppDbContext db = new AppDbContext())
                {
                    //Входящее сообщение 
                    History history = new History
                    {
                        DateMsg = e.Message.Date.ToString(),
                        TypeMsg = "In",
                        FirstName = e.Message.Chat.FirstName,
                        ChatId = e.Message.Chat.Id.ToString(),
                        LastName = e.Message.Chat.LastName,
                        UserName = e.Message.Chat.Username,
                        TextMsg = e.Message.Text
                    };
                    db.Histories.Add(history);

                    //Исходящее сообщение
                    History history2 = new History
                    {
                        DateMsg = e.Message.Date.ToString(),
                        TypeMsg = "Out",
                        FirstName = lbl_BotName.Text,
                        ChatId = e.Message.Chat.Id.ToString(),
                        LastName = "",
                        UserName = "",
                        TextMsg = outText
                    };
                    db.Histories.Add(history2);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Сохранение / изменение настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            //Api Key
            if (!string.IsNullOrEmpty(tb_ApiKey.Text))
                Properties.Settings.Default["BotApiKey"] = tb_ApiKey.Text;

            //Сохранение настроек
            Properties.Settings.Default.Save();

            //Инициализация бота и программы с новыми настройками
            InitBot();
            MessageBox.Show("Настройки сохранены");
        }


        /// <summary>
        /// Завершение работы с ботом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_General_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть программу?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                botClient.StopReceiving();
            }
        }

        /// <summary>
        /// Инициализация бота
        /// </summary>
        private void InitBot()
        {
            if (botClient != null)
                botClient.StopReceiving();

            //Получаем Апи ключ клиента
            botKey = Properties.Settings.Default["BotApiKey"].ToString();
            tb_ApiKey.Text = botKey;

            //Инициализация бота
            try
            {
                botClient = new TelegramBotClient(botKey);
                botClient.StartReceiving();
                var me = botClient.GetMeAsync().GetAwaiter().GetResult();
                lbl_BotName.Text = me.FirstName;
                botClient.OnMessage += BotClient_OnMessage;

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при инициализации бота. Необходимо проверить настройки или подключение к интернету");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
