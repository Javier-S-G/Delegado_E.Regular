using Delegado_E.Regular.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Delegado_E.Regular.Model
{
    internal class UsingRegex : IValidator
    {
        private string _email;

        public UsingRegex(string email)
        {
            _email = email;
        }

        public bool Validator()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(_email);

            return match.Success;
        }
    }
}