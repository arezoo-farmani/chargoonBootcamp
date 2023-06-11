
namespace Domain.Handler
{
    public static class MessageHandler
    {
        public static readonly string userSubmitOk = ".ثبت نام شما با موفقیت انجام شد";
        public static readonly string userSubmitError = ".ثبت نام شما با مشکل مواجه شد";
        public static readonly string orderBasketFormError = ".پرداخت با مشکل مواجه شد";
        public static readonly string orderBasketFormOk = ".پرداخت با موفقیت مواجه شد";
        public static readonly string foodMenuSubmitOk = "عمللیات ثبت با موفقیت انجام شد";
        public static readonly string foodMenuSubmitError = "عمللیات ثبت با مشکل مواجه شد";
        public static readonly string foodEditFormSubmitOk = "عمللیات ویرایش با موفقیت انجام شد";
        public static readonly string foodEditFormSubmitError = "عمللیات ویرایش با مشکل مواجه شد";
        public static string GetMessage(string formName, string action, bool success)
        {
            string message = string.Empty;

            if (formName == "UserRegistrationForm")
            {
                if (action == "Registration" && success)
                {
                    message = userSubmitOk;
                }
                else if (action == "Registration" && !success)
                {
                    message = userSubmitError;
                }
            }
            else if (formName == "ResturantRegistrationForm")
            {
                if (action == "Registration" && success)
                {
                    message = userSubmitOk;
                }
                else if (action == "Registration" && !success)
                {
                    message = userSubmitError;
                }
            }
            else if (formName == "OrderBasketForm")
            {
                if (action == "Registration" && success)
                {
                    message = orderBasketFormOk;
                }
                else if (action == "Registration" && !success)
                {
                    message = orderBasketFormError;
                }
            }
            else if (formName == "FoodMenu")
            {
                if (action == "Registration" && success)
                {
                    message = foodMenuSubmitOk;
                }
                else if (action == "Registration" && !success)
                {
                    message = foodMenuSubmitError;
                }
            }
            else if (formName == "FoodEditForm")
            {
                if (action == "Registration" && success)
                {
                    message = foodEditFormSubmitOk;
                }
                else if (action == "Registration" && !success)
                {
                    message = foodEditFormSubmitError;
                }
            }
            return message;
        }
    }
}
