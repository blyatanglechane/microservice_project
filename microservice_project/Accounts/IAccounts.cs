using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microservice_project.Accounts
{
    interface IAccounts
    {
        void CustomerInformation();
        bool SubmitYourApplication();
        bool LogOutOfYourAccount();
    }
}
