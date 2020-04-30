// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Tools.Properties
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Tools.Properties.Resources", typeof(Resources).Assembly);

        /// <summary>
        ///     Build failed.
        /// </summary>
        public static string BuildFailed
            => GetString("BuildFailed");

        /// <summary>
        ///     The configuration to use.
        /// </summary>
        public static string ConfigurationDescription
            => GetString("ConfigurationDescription");

        /// <summary>
        ///     The connection string to the database.
        /// </summary>
        public static string ConnectionDescription
            => GetString("ConnectionDescription");

        /// <summary>
        ///     The DbContext to use.
        /// </summary>
        public static string ContextDescription
            => GetString("ContextDescription");

        /// <summary>
        ///     The name of the DbContext.
        /// </summary>
        public static string ContextNameDescription
            => GetString("ContextNameDescription");

        /// <summary>
        ///     Use attributes to configure the model (where possible). If omitted, only the fluent API is used.
        /// </summary>
        public static string DataAnnotationsDescription
            => GetString("DataAnnotationsDescription");

        /// <summary>
        ///     Commands to manage the database.
        /// </summary>
        public static string DatabaseDescription
            => GetString("DatabaseDescription");

        /// <summary>
        ///     Drops the database.
        /// </summary>
        public static string DatabaseDropDescription
            => GetString("DatabaseDropDescription");

        /// <summary>
        ///     Show which database would be dropped, but don't drop it.
        /// </summary>
        public static string DatabaseDropDryRunDescription
            => GetString("DatabaseDropDryRunDescription");

        /// <summary>
        ///     Don't confirm.
        /// </summary>
        public static string DatabaseDropForceDescription
            => GetString("DatabaseDropForceDescription");

        /// <summary>
        ///     Updates the database to a specified migration.
        /// </summary>
        public static string DatabaseUpdateDescription
            => GetString("DatabaseUpdateDescription");

        /// <summary>
        ///     Commands to manage DbContext types.
        /// </summary>
        public static string DbContextDescription
            => GetString("DbContextDescription");

        /// <summary>
        ///     Gets information about a DbContext type.
        /// </summary>
        public static string DbContextInfoDescription
            => GetString("DbContextInfoDescription");

        /// <summary>
        ///     Lists available DbContext types.
        /// </summary>
        public static string DbContextListDescription
            => GetString("DbContextListDescription");

        /// <summary>
        ///     Scaffolds a DbContext and entity types for a database.
        /// </summary>
        public static string DbContextScaffoldDescription
            => GetString("DbContextScaffoldDescription");

        /// <summary>
        ///     Overwrite existing files.
        /// </summary>
        public static string DbContextScaffoldForceDescription
            => GetString("DbContextScaffoldForceDescription");

        /// <summary>
        ///     Entity Framework Core .NET Command-line Tools
        /// </summary>
        public static string DotnetEfFullName
            => GetString("DotnetEfFullName");

        /// <summary>
        ///     Entity Framework Core Command-line Tools
        /// </summary>
        public static string EFFullName
            => GetString("EFFullName");

        /// <summary>
        ///     The target framework.
        /// </summary>
        public static string FrameworkDescription
            => GetString("FrameworkDescription");

        /// <summary>
        ///     Unable to retrieve project metadata. Ensure it's an MSBuild-based .NET Core project. If you're using custom BaseIntermediateOutputPath or MSBuildProjectExtensionsPath values, Use the --msbuildprojectextensionspath option.
        /// </summary>
        public static string GetMetadataFailed
            => GetString("GetMetadataFailed");

        /// <summary>
        ///     Generate a script that can be used on a database at any migration.
        /// </summary>
        public static string IdempotentDescription
            => GetString("IdempotentDescription");

        /// <summary>
        ///     Show JSON output.
        /// </summary>
        public static string JsonDescription
            => GetString("JsonDescription");

        /// <summary>
        ///     The target migration. If '0', all migrations will be reverted. Defaults to the last migration.
        /// </summary>
        public static string MigrationDescription
            => GetString("MigrationDescription");

        /// <summary>
        ///     The starting migration. Defaults to '0' (the initial database).
        /// </summary>
        public static string MigrationFromDescription
            => GetString("MigrationFromDescription");

        /// <summary>
        ///     The name of the migration.
        /// </summary>
        public static string MigrationNameDescription
            => GetString("MigrationNameDescription");

        /// <summary>
        ///     Adds a new migration.
        /// </summary>
        public static string MigrationsAddDescription
            => GetString("MigrationsAddDescription");

        /// <summary>
        ///     Commands to manage migrations.
        /// </summary>
        public static string MigrationsDescription
            => GetString("MigrationsDescription");

        /// <summary>
        ///     Lists available migrations.
        /// </summary>
        public static string MigrationsListDescription
            => GetString("MigrationsListDescription");

        /// <summary>
        ///     The directory (and sub-namespace) to use. Paths are relative to the project directory. Defaults to "Migrations".
        /// </summary>
        public static string MigrationsOutputDirDescription
            => GetString("MigrationsOutputDirDescription");

        /// <summary>
        ///     Removes the last migration.
        /// </summary>
        public static string MigrationsRemoveDescription
            => GetString("MigrationsRemoveDescription");

        /// <summary>
        ///     Revert the migration if it has been applied to the database.
        /// </summary>
        public static string MigrationsRemoveForceDescription
            => GetString("MigrationsRemoveForceDescription");

        /// <summary>
        ///     Generates a SQL script from migrations.
        /// </summary>
        public static string MigrationsScriptDescription
            => GetString("MigrationsScriptDescription");

        /// <summary>
        ///     The ending migration. Defaults to the last migration.
        /// </summary>
        public static string MigrationToDescription
            => GetString("MigrationToDescription");

        /// <summary>
        ///     More than one project was found in the current working directory. Use the --project option.
        /// </summary>
        public static string MultipleProjects
            => GetString("MultipleProjects");

        /// <summary>
        ///     More than one project was found in directory '{projectDir}'. Specify one using its file name.
        /// </summary>
        public static string MultipleProjectsInDirectory([CanBeNull] object projectDir)
            => string.Format(
                GetString("MultipleProjectsInDirectory", nameof(projectDir)),
                projectDir);

        /// <summary>
        ///     More than one project was found in the current working directory. Use the --startup-project option.
        /// </summary>
        public static string MultipleStartupProjects
            => GetString("MultipleStartupProjects");

        /// <summary>
        ///     Startup project '{startupProject}' targets framework '.NETCoreApp' version '{targetFrameworkVersion}'. This version of the Entity Framework Core .NET Command-line Tools only supports version 2.0 or higher. For information on using older versions of the tools, see https://go.microsoft.com/fwlink/?linkid=871254
        /// </summary>
        public static string NETCoreApp1StartupProject([CanBeNull] object startupProject, [CanBeNull] object targetFrameworkVersion)
            => string.Format(
                GetString("NETCoreApp1StartupProject", nameof(startupProject), nameof(targetFrameworkVersion)),
                startupProject, targetFrameworkVersion);

        /// <summary>
        ///     Startup project '{startupProject}' targets framework '.NETStandard'. There is no runtime associated with this framework, and projects targeting it cannot be executed directly. To use the Entity Framework Core .NET Command-line Tools with this project, add an executable project targeting .NET Core or .NET Framework that references this project, and set it as the startup project using --startup-project; or, update this project to cross-target .NET Core or .NET Framework. For more information on using the EF Core Tools with .NET Standard projects, see https://go.microsoft.com/fwlink/?linkid=2034781
        /// </summary>
        public static string NETStandardStartupProject([CanBeNull] object startupProject)
            => string.Format(
                GetString("NETStandardStartupProject", nameof(startupProject)),
                startupProject);

        /// <summary>
        ///     Don't colorize output.
        /// </summary>
        public static string NoColorDescription
            => GetString("NoColorDescription");

        /// <summary>
        ///     No project was found. Change the current working directory or use the --project option.
        /// </summary>
        public static string NoProject
            => GetString("NoProject");

        /// <summary>
        ///     No project was found in directory '{projectDir}'.
        /// </summary>
        public static string NoProjectInDirectory([CanBeNull] object projectDir)
            => string.Format(
                GetString("NoProjectInDirectory", nameof(projectDir)),
                projectDir);

        /// <summary>
        ///     The file to write the result to.
        /// </summary>
        public static string OutputDescription
            => GetString("OutputDescription");

        /// <summary>
        ///     The directory to put files in. Paths are relative to the project directory.
        /// </summary>
        public static string OutputDirDescription
            => GetString("OutputDirDescription");

        /// <summary>
        ///     Prefix output with level.
        /// </summary>
        public static string PrefixDescription
            => GetString("PrefixDescription");

        /// <summary>
        ///     The project to use.
        /// </summary>
        public static string ProjectDescription
            => GetString("ProjectDescription");

        /// <summary>
        ///     The MSBuild project extensions path. Defaults to "obj".
        /// </summary>
        public static string ProjectExtensionsDescription
            => GetString("ProjectExtensionsDescription");

        /// <summary>
        ///     The provider to use. (E.g. Microsoft.EntityFrameworkCore.SqlServer)
        /// </summary>
        public static string ProviderDescription
            => GetString("ProviderDescription");

        /// <summary>
        ///     The runtime to use.
        /// </summary>
        public static string RuntimeDescription
            => GetString("RuntimeDescription");

        /// <summary>
        ///     The schemas of tables to generate entity types for.
        /// </summary>
        public static string SchemasDescription
            => GetString("SchemasDescription");

        /// <summary>
        ///     The startup project to use.
        /// </summary>
        public static string StartupProjectDescription
            => GetString("StartupProjectDescription");

        /// <summary>
        ///     The tables to generate entity types for.
        /// </summary>
        public static string TablesDescription
            => GetString("TablesDescription");

        /// <summary>
        ///     Startup project '{startupProject}' targets framework '{targetFramework}'. The Entity Framework Core .NET Command-line Tools don't support this framework.
        /// </summary>
        public static string UnsupportedFramework([CanBeNull] object startupProject, [CanBeNull] object targetFramework)
            => string.Format(
                GetString("UnsupportedFramework", nameof(startupProject), nameof(targetFramework)),
                startupProject, targetFramework);

        /// <summary>
        ///     Use table and column names directly from the database.
        /// </summary>
        public static string UseDatabaseNamesDescription
            => GetString("UseDatabaseNamesDescription");

        /// <summary>
        ///     Using project '{project}'.
        /// </summary>
        public static string UsingProject([CanBeNull] object project)
            => string.Format(
                GetString("UsingProject", nameof(project)),
                project);

        /// <summary>
        ///     Using startup project '{startupProject}'.
        /// </summary>
        public static string UsingStartupProject([CanBeNull] object startupProject)
            => string.Format(
                GetString("UsingStartupProject", nameof(startupProject)),
                startupProject);

        /// <summary>
        ///     Show verbose output.
        /// </summary>
        public static string VerboseDescription
            => GetString("VerboseDescription");

        /// <summary>
        ///     Writing '{file}'...
        /// </summary>
        public static string WritingFile([CanBeNull] object file)
            => string.Format(
                GetString("WritingFile", nameof(file)),
                file);

        /// <summary>
        ///     Don't build the project. Only use this when the build is up-to-date.
        /// </summary>
        public static string NoBuildDescription
            => GetString("NoBuildDescription");

        /// <summary>
        ///     The directory to put DbContext file in. Paths are relative to the project directory.
        /// </summary>
        public static string ContextDirDescription
            => GetString("ContextDirDescription");

        /// <summary>
        ///     The working directory of the tool invoking this command.
        /// </summary>
        public static string WorkingDirDescription
            => GetString("WorkingDirDescription");

        /// <summary>
        ///     Build started...
        /// </summary>
        public static string BuildStarted
            => GetString("BuildStarted");

        /// <summary>
        ///     Build succeeded.
        /// </summary>
        public static string BuildSucceeded
            => GetString("BuildSucceeded");

        /// <summary>
        ///     The last argument '{argumentName}' accepts multiple values. No more argument can be added.
        /// </summary>
        public static string LastArgumentHasMultipleValues([CanBeNull] object argumentName)
            => string.Format(
                GetString("LastArgumentHasMultipleValues", nameof(argumentName)),
                argumentName);

        /// <summary>
        ///     Unexpected value '{optionValue}' for option '{optionName}'.
        /// </summary>
        public static string UnexpectedOptionValue([CanBeNull] object optionValue, [CanBeNull] object optionName)
            => string.Format(
                GetString("UnexpectedOptionValue", nameof(optionValue), nameof(optionName)),
                optionValue, optionName);

        /// <summary>
        ///     Unrecognized {argumentName} '{argumentValue}'.
        /// </summary>
        public static string UnexpectedArgument([CanBeNull] object argumentName, [CanBeNull] object argumentValue)
            => string.Format(
                GetString("UnexpectedArgument", nameof(argumentName), nameof(argumentValue)),
                argumentName, argumentValue);

        /// <summary>
        ///     Response file '{fileName}' doesn't exist.
        /// </summary>
        public static string ResponseFileMissing([CanBeNull] object fileName)
            => string.Format(
                GetString("ResponseFileMissing", nameof(fileName)),
                fileName);

        /// <summary>
        ///     Invalid template pattern '{template}'.
        /// </summary>
        public static string InvalidTemplatePattern([CanBeNull] object template)
            => string.Format(
                GetString("InvalidTemplatePattern", nameof(template)),
                template);

        /// <summary>
        ///     The connection string to the database. Defaults to the one specified in AddDbContext or OnConfiguring.
        /// </summary>
        public static string DbContextConnectionDescription
            => GetString("DbContextConnectionDescription");

        /// <summary>
        ///     Specify to override the namespace for the generated entity types.
        /// </summary>
        public static string NamespaceDescription
            => GetString("NamespaceDescription");

        /// <summary>
        ///     Specify to override the namespace for the DbContext class.
        /// </summary>
        public static string ContextNamespaceDescription
            => GetString("ContextNamespaceDescription");

        /// <summary>
        ///     Specify to override the namespace for the migration.
        /// </summary>
        public static string MigrationsNamespaceDescription
            => GetString("MigrationsNamespaceDescription");

        /// <summary>
        ///     Suppress generation of the DbContext.OnConfiguring() method.
        /// </summary>
        public static string SuppressOnConfiguringDescription
            => GetString("SuppressOnConfiguringDescription");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

