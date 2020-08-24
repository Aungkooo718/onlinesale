using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalePrj.Helper
{
    public class ApplicationClaimType
    {
        // Policy Claims
        public const string Administrator = "http://yourdomain.com/claims/administrator";
        // User Claims
        public const string DisplayedName = "http://yourdomain.com/claims/displayedname";
        public const string UserCreateDate = "http://yourdomain.com/claims/usercreatedate";
    }
}
