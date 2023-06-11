
using Domain.Enumration;
using System.Collections.Generic;

namespace Domain.Handler
{
    public static class MessageHandler
    {
        private static Dictionary<MessageType, string> _myDictionary = new Dictionary<MessageType, string>{
            {MessageType.FoodEditFormSubmitError, "عمللیات ویرایش با مشکل مواجه شد"},
            {MessageType.FoodEditFormSubmitOk, "عمللیات ویرایش با موفقیت انجام شد" },
            {MessageType.UserSubmitOk, "ثبت نام شما با موفقیت انجام شد" },
            {MessageType.UserSubmitError, "ثبت نام شما با مشکل مواجه شد" },
            {MessageType.OrderBasketFormError, "پرداخت با مشکل مواجه شد" },
            {MessageType.OrderBasketFormOk, "پرداخت با موفقیت مواجه شد"},
            {MessageType.FoodMenuSubmitError, "عمللیات ثبت با مشکل انجام شد" },
            {MessageType.FoodMenuSubmitOk, "عمللیات ثیت با موفقیت انجام شد" },
            {MessageType.RestaurantSubmitOk, "ثبت رستوران با موفقیت انجام شد" },
            {MessageType.RestaurantSubmitError, "ثبت رستوران با مشکل مواجه شد" },
        };

        public static string GetMessage(MessageType messageType)
        {
            if (!_myDictionary.ContainsKey(messageType)) return messageType.ToString();
            else return _myDictionary[messageType];
        }

    }
}
