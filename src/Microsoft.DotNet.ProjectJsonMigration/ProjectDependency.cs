// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.ProjectJsonMigration
{
    internal class ProjectDependency
    {
        public string Name { get; }
        public string ProjectFilePath { get; }

        public ProjectDependency(string name, string projectFilePath)
        {
            Name = name;
            ProjectFilePath = System.IO.Path.GetFullPath(projectFilePath);
        }

        public override bool Equals(object obj)
        {
            var other = obj as ProjectDependency;

            return other != null && other.ProjectFilePath == ProjectFilePath;
        }

        public override int GetHashCode()
        {
            return ProjectFilePath.GetHashCode();
        }
    }
}
