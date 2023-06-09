using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain.Models
{
    public static class MessageHandler
    {
        public static readonly string userSubmitOk = ".ثبت نام شما با موفقیت انجام شد";
        public static readonly string userSubmitError = ".ثبت نام شما با مشکل مواجه شد";
        public static readonly string orderBasketFormOk = ".ثبت نام شما با موفقیت انجام شد";
        public static readonly string orderBasketFormError = "پرداخت با مشکل مواجه شد";

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
            else if (formName == "OrderBasketFormError")
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

            return message;
        }
    }
}
