﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace BusinessLogic.Interfaces
{
    public interface ImailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
