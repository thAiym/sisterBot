using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace sisterBot.keyboards
{
    public static class Agreement
    {
        

       



        public static InlineKeyboardMarkup agreementButton = new InlineKeyboardMarkup(
                        new[]
                        {
                            // first row
                            new[]
                            {
                                // first button in row
                                InlineKeyboardButton.WithCallbackData(text: "Кнопка 3", callbackData: "post3"),
                                // second button in row
                                InlineKeyboardButton.WithCallbackData(text: "Кнопка 4", callbackData: "post4"),
                            },

                        });
    }
}
