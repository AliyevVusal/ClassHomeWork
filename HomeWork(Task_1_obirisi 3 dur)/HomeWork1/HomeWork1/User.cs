using System;
namespace HomeWork1
{
    class User
    {
        private string _userName;
        private string _Password;

        public User(string user, string password)
        {
            UserName = user;
            Password = password;
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                while (true)
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("Userinizi Duzgun Daxil edin: ");
                        value = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        _userName = value;
                        break;
                    }
                }
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                while (true)
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("Parolunuz Cox Qisadir");
                        value = Console.ReadLine();
                        
                    }
                    else
                    {
                        bool BoyukHerif = false;
                        bool KicikHerif = false;
                        bool Reqem = false;

                        for (int i = 0; i < value.Length; i++)
                        {
                            if (char.IsUpper(value[i]))
                            {
                                BoyukHerif = true;
                            }
                            if (char.IsDigit(value[i]))
                            {
                                Reqem = true;
                            }
                            if (char.IsLower(value[i]))
                            {
                                KicikHerif = true;
                            }

                        }
                        if (BoyukHerif && KicikHerif && Reqem)
                        {
                            _Password = value;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Parolu duzgun daxil edin! ");
                            value = Console.ReadLine();
                        }
                    }



                   

                }
            }


        }




    }
}

