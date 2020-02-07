﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.WebJobs.Script.Workers.ProcessManagement
{
    public class WorkerStats
    {
        public IDictionary<string, ProcessStats> Stats { get; set; }
    }
}