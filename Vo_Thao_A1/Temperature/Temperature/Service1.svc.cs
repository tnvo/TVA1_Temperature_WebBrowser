﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Temperature
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int c2f(int c) //convert Celsius temperature into Farentheit
        {
            int result = (c * 9 / 5) + 32;
            return result;
        }

        public int f2c(int f) //convert F to C
        {
            int result = (f - 32) * 5/9;
            return result;

        }

    }
}
