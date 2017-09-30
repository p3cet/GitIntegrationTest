using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletonTest.Models
{
    public sealed class Message
    {
        public static Message Instance
        {
            get
            {
                if (instance == null)
                    instance = new Message();
                return instance;
            }
        }

        public string MessageText
        {
            get => messageText;
            set => messageText = value;
        }

        private static Message instance;
        private string messageText="Message text is not set";
        private Message() { }


    }
}