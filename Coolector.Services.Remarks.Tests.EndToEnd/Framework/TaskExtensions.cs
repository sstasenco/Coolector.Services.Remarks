﻿using System.Threading.Tasks;

namespace Coolector.Services.Remarks.Tests.EndToEnd.Framework
{
    public static class TaskExtensions
    {
        public static T WaitForResult<T>(this Task<T> task) => task.GetAwaiter().GetResult();
        public static void WaitForResult(this Task task) => task.GetAwaiter().GetResult();
    }
}