﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HelloSGBotService.Model.LUIS;

namespace HelloSGBotService.Service
{
    [Serializable]
    public class LUISService : IAIService
    {
        private IHTTPService _httpService;

        public LUISService() {
            this._httpService = new HTTPService();
            this._httpService.ServiceURL = ConfigurationManager.AppSettings["LUISServiceURL"].ToString();
        }

        public async Task<T> GetIntent<T>(string input)
        {
            return await this._httpService.Get<T>(input);
        }
    }
}