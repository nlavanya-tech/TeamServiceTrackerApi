﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeamServiceTrackerApi.DataLayer
{
  public class MongoDbSetting
    {
        //creating mongodb connection properties
        public string ConnectionString { get; set; }
        public string Database { get; set; }

    }
}
