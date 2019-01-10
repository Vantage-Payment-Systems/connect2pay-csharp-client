﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Connect2PayLibrary
{
    class URLRecord
    {
        public String Url { get; set; }
        public String Method { get; set; }

        public URLRecord(RequestType action, String objectId)
        {
            if (action == RequestType.CREATE_PAYMENT)
            {
                Url = "transaction/prepare";
                Method = "POST";
            } else if (action == RequestType.GET_PAYMENT_STATUS)
            {
                Url = "transaction/" + objectId + "/status";
                Method = "GET";
            } else if (action == RequestType.GET_TRANSACTION_INFORMATION)
            {
                Url = "transaction/" + objectId + "/info";
                Method = "GET";
            }
            else if (action == RequestType.ACCOUNT_INFO)
            {
                Url = "account";
                Method = "GET";
            }
        }

        public void SetInURL(String name, String value)
        {
            String paramToReplace = ":" + name;
            this.Url = this.Url.Replace(paramToReplace, value);
        }
    }
}
