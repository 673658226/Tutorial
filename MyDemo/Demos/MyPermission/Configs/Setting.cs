﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPermission.Configs
{
    public static class Setting
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Permission"].ConnectionString;

    }
}
