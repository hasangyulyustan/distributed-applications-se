﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace MC.WcfServices
{
    public class UserAuthentication : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            try
            {
                if (userName == "test" && password == "test123")
                {
                    Console.WriteLine("Authentic User");
                }
            }
            catch (Exception ex)
            {
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
    }
}