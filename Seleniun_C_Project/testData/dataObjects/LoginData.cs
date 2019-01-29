using Seleniun_C_Project.testData.dataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.testData.dataObjects
{
    class LoginData
    {
        public static String invalidCredentialsErrorText = "Sorry, we can’t find an account with that email. You can register for a new account or get help here.";

        public static User myUser = new User
        {
            email = "truscaionutalex@gmail.com",
            password = "dummyPassword123",
            firstName = "Ionut",
            lastName = "Trusca"
        };

        public static User invalidUser = new User
        {
            email = "truscaionutalex2@gmail.com",
            password = "dummyPassword123",
            firstName = "Ionut",
            lastName = "Trusca"
        };

    }
}
