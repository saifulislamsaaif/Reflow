﻿using Reflow.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Reflow.Provider.Access
{
    public class AccessDataWriter : ILinkWriter
    {
        public void Write(IDataReader source, string table, TaskExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void Initialize(IDataLink link)
        {
            throw new NotImplementedException();
        }
    }
}
