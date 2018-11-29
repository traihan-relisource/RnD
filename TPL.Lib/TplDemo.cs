﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPL.Lib
{
    public class TplDemo
    {
        public static string DownloadSite(string address)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(address);
            return $"Download complete of site {address}. Total length is {content.Length} ";
        }

        public static async Task<string> DownloadSiteAsync(string address)
        {
            WebClient client = new WebClient();
            string content = await client.DownloadStringTaskAsync(address);
            return $"Download complete of site {address}. Total length is {content.Length} ";
        }
    }
}
