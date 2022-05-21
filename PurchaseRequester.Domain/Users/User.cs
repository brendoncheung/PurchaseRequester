using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequester.Domain.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }

    public enum Roles
    {
        HUMANRESOURCE,
        ENGINEERING,
        PURCHASING,
        PRODUCTION,
        QUALITY,
        OPERATION,
    }
}
