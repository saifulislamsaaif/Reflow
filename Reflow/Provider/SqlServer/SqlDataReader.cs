﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Reflow.Provider.SqlServer
{
    public class SqlDataReader : ILinkReader
    {
        private IDataReader _reader = null;
        private IDataLink _link = null;

        public void Initialize(IDataLink link)
        {
            _link = link;
        }

        public string Command { get; set; }
        public bool Open()
        {
            SqlDataLink link = _link as SqlDataLink;
            IDbCommand cmd = link.Connection.CreateCommand();
            cmd.CommandText = this.Command;
            cmd.CommandType = CommandType.Text;
            _reader = cmd.ExecuteReader();
            return true;
        }


        public bool Open(string command)
        {
            this.Command = command;
            return this.Open();
        }

        public IDataReader Reader
        {
            get
            {
                return _reader;
            }
        }
    }
}
