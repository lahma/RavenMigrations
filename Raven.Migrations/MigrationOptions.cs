﻿using System.Collections.Generic;
using System.Reflection;

namespace Raven.Migrations
{
    public class MigrationOptions
    {
        public MigrationOptions()
        {
            Direction = Directions.Up;
            Assemblies = new List<Assembly>();
            Profiles = new List<string>();
            MigrationResolver = new DefaultMigrationResolver();
            Assemblies = new List<Assembly>();
            ToVersion = 0;
        }

        public Directions Direction { get; set; }
        public IList<Assembly> Assemblies { get; set; }
        public IList<string> Profiles { get; set; }
        public IMigrationResolver MigrationResolver { get; set; }
        public int ToVersion { get; set; }
    }
}