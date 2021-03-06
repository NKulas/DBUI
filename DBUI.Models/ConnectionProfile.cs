﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Models
{
    public class ConnectionProfile
    {
        private StructureObject server;
        private StructureObject database;
        private StructureObject schema;
        private StructureObject table;

        public StructureObject Server
        {
            get
            {
                return server;
            }
            set
            {
                server = ValidateType(StructureObjectType.Server, value);
            }
        }

        public StructureObject Database
        {
            get
            {
                return database;
            }
            set
            {
                database = ValidateType(StructureObjectType.Database, value);
            }
        }

        public StructureObject Schema
        {
            get
            {
                return schema;
            }
            set
            {
                schema = ValidateType(StructureObjectType.Schema, value);
            }
        }

        public StructureObject Table
        {
            get
            {
                return table;
            }
            set
            {
                table = ValidateType(StructureObjectType.Table, value);
            }
        }

        public AuthenticationType AuthenticationType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private StructureObject ValidateType(StructureObjectType requestedType, StructureObject structureObject)
        {
            if (structureObject == null) return null;

            if (structureObject.ObjectType == requestedType)
            {
                return structureObject;
            }
            else
            {
                return null;
            }
        }

        public string GetConnectionString(StructureObjectType endpoint = StructureObjectType.Database)
        {
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();

            if (Server != null)
            {
                connectionBuilder.DataSource = Server.InternalName;
            }

            if (AuthenticationType == AuthenticationType.Windows)
            {
                connectionBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionBuilder.IntegratedSecurity = false;
                connectionBuilder.UserID = Username;
                connectionBuilder.Password = Password;
            }

            if (Database != null)
            {
                connectionBuilder.InitialCatalog = Database.InternalName;
            }

            return connectionBuilder.ConnectionString;
        }

        public bool ValidateComplete()
        {
            bool isComplete = true;

            if (Server == null || Server.InternalName == string.Empty)
            {
                isComplete = false;
            }

            if (Database == null || Database.InternalName == string.Empty)
            {
                isComplete = false;
            }

            if (Schema == null || Schema.InternalName == string.Empty)
            {
                isComplete = false;
            }

            if (Table == null || Table.InternalName == string.Empty)
            {
                isComplete = false;
            }

            if (AuthenticationType == AuthenticationType.Server)
            {
                if (string.IsNullOrWhiteSpace(Username))
                {
                    isComplete = false;
                }

                if (string.IsNullOrWhiteSpace(Password))
                {
                    isComplete = false;
                }
            }

            return isComplete;
        }
    }
}