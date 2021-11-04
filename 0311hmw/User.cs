using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;
namespace _0311hmw
{
   public class User
    {
        Check check = new Check();
        private string _password;
        
       public string Password
        {
            get
            {
                return _password;
            }
            set
            { 
                
                if (check.HasDigit(value) ==true && check.HasLower(value)==true && check.HasUpper(value)==true)
                {
                     _password = value; 
                }
                else
                {
                    throw new PasswordIncorrectException("Yazdiginiz parol qebul edile bilmez!!!");
                }
            }
        }
        private string _username;
       public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if(value.Length>5 && value.Length<26)
                { _username = value; }
                else
                {
                    throw new InvalidUserNameException("Yazdiginiz istifadeci adi verilmis araliqda deyil!!!");
                }
            }
        }
        public User(string username)
        {
            Username = username;
        }
        public virtual void ShowInfo ()
        {
            Console.WriteLine($"Username; {Username}, Password; {Password}");
        }
      
    }
}   
