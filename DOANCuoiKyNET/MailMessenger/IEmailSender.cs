﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.MailMessenger
{
    public interface IEmailSender
    {
        void SendEmail(Message messenger);
    }
}
