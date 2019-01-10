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
            }
        }

        public void SetInURL(String name, String value)
        {
            String paramToReplace = ":" + name;
            this.Url = this.Url.Replace(paramToReplace, value);
        }
    }
}