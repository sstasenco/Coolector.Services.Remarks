﻿using System;
using Coolector.Common.Queries;

namespace Coolector.Services.Remarks.Queries
{
    public class GetRemarkPhoto : IQuery
    {
        public Guid Id { get; set; }
        public string Size { get; set; }
    }
}