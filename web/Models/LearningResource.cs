﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetLearnerWeb.Models
{
    public class LearningResource : InternetResource
    {
        public List<LearningResourceItemList> LearningResourceItemLists
        {
            get; set;
        }
    }
}
