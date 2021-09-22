using Delegado_E.Regular.Interface;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Delegado_E.Regular.Model
{
    internal class NormalValidation : IValidator
    {
        private string _email;

        public NormalValidation(string email)
        {
            _email = email;
        }

        public bool Validator()
        {
            try
            {
                MailAddress m = new MailAddress(_email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}