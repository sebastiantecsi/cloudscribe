﻿using System.Collections.Generic;
using System.Threading.Tasks;

//TODO: comments and documentation

namespace cloudscribe.Email
{
    public interface IEmailSender
    {
        string Name { get; }

        Task<bool> IsConfigured(string configLookupKey = null);

       
        Task<EmailSendResult> SendEmailAsync(
            string toEmailCsv,
            string fromEmail,
            string subject,
            string plainTextMessage,
            string htmlMessage,
            string replyToEmail = null,
            Importance importance = Importance.Normal,
            bool isTransactional = true,
            string fromName = null,
            string replyToName = null,
            string toAliasCsv = null,
            string ccEmailCsv = null,
            string ccAliasCsv = null,
            string bccEmailCsv = null,
            string bccAliasCsv = null,
            List<EmailAttachment> attachments = null,
            string charsetBodyHtml = null,
            string charsetBodyText = null,
            string configLookupKey = null
            );

    }
}
