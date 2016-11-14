﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication
{

    /// <summary>
    /// Dependency Injection Implementation.
    /// </summary>
    public class BusinessService
    {
        private IDataAccessComponent _dataAccessComponent;
        private IWebServiceProxy _webServiceProxy;
        private ILoggingComponent _loggingComponent;

        public BusinessService(IDataAccessComponent dataAccessComponent,
                                IWebServiceProxy webServiceProxy,
                                ILoggingComponent loggingComponent)
        {
            _loggingComponent = loggingComponent;
            _webServiceProxy = webServiceProxy;
            _dataAccessComponent = dataAccessComponent;
        }
    }
}