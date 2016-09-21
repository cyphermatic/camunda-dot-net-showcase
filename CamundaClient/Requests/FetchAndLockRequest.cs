﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamundaClient.Dto;

namespace CamundaClient.Requests
{
    class FetchAndLockRequest
    {
        public string WorkerId { get; set; }
        public int MaxTasks { get; set; }
        public List<FetchAndLockTopic> Topics { get; set; } = new List<FetchAndLockTopic>();
    }
}
