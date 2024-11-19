namespace Microsoft.ComponentDetection.Detectors.NuGet;

using static global::NuGet.Frameworks.FrameworkConstants.CommonFrameworks;

/// <summary>
/// Framework packages for net6.0.
/// </summary>
internal partial class FrameworkPackages
{
    internal static class NETCoreApp60
    {
        internal static FrameworkPackages Instance { get; } = new(Net60, FrameworkNames.NetCoreApp, NETCoreApp50.Instance)
        {
            { "System.Collections.Immutable", "6.0.0" },
            { "System.Diagnostics.DiagnosticSource", "6.0.0" },
            { "System.Formats.Asn1", "6.0.0" },
            { "System.Net.Http.Json", "6.0.0" },
            { "System.Reflection.Metadata", "6.0.0" },
            { "System.Runtime.CompilerServices.Unsafe", "6.0.0" },
            { "System.Security.AccessControl", "6.0.0" },
            { "System.Text.Encoding.CodePages", "6.0.0" },
            { "System.Text.Encodings.Web", "6.0.0" },
            { "System.Text.Json", "6.0.0" },
            { "System.Threading.Channels", "6.0.0" },
            { "System.Threading.Tasks.Dataflow", "6.0.0" },
        };

        internal static FrameworkPackages AspNetCore { get; } = new(Net60, FrameworkNames.AspNetCoreApp, NETCoreApp50.AspNetCore)
        {
            { "Microsoft.AspNetCore", "6.0.0" },
            { "Microsoft.AspNetCore.Antiforgery", "6.0.0" },
            { "Microsoft.AspNetCore.Authentication", "6.0.0" },
            { "Microsoft.AspNetCore.Authentication.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Authentication.Cookies", "6.0.0" },
            { "Microsoft.AspNetCore.Authentication.Core", "6.0.0" },
            { "Microsoft.AspNetCore.Authentication.OAuth", "6.0.0" },
            { "Microsoft.AspNetCore.Authorization", "6.0.0" },
            { "Microsoft.AspNetCore.Authorization.Policy", "6.0.0" },
            { "Microsoft.AspNetCore.Components", "6.0.0" },
            { "Microsoft.AspNetCore.Components.Authorization", "6.0.0" },
            { "Microsoft.AspNetCore.Components.Forms", "6.0.0" },
            { "Microsoft.AspNetCore.Components.Server", "6.0.0" },
            { "Microsoft.AspNetCore.Components.Web", "6.0.0" },
            { "Microsoft.AspNetCore.Connections.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.CookiePolicy", "6.0.0" },
            { "Microsoft.AspNetCore.Cors", "6.0.0" },
            { "Microsoft.AspNetCore.Cryptography.Internal", "6.0.0" },
            { "Microsoft.AspNetCore.Cryptography.KeyDerivation", "6.0.0" },
            { "Microsoft.AspNetCore.DataProtection", "6.0.0" },
            { "Microsoft.AspNetCore.DataProtection.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.DataProtection.Extensions", "6.0.0" },
            { "Microsoft.AspNetCore.Diagnostics", "6.0.0" },
            { "Microsoft.AspNetCore.Diagnostics.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Diagnostics.HealthChecks", "6.0.0" },
            { "Microsoft.AspNetCore.HostFiltering", "6.0.0" },
            { "Microsoft.AspNetCore.Hosting", "6.0.0" },
            { "Microsoft.AspNetCore.Hosting.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Hosting.Server.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Html.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Http", "6.0.0" },
            { "Microsoft.AspNetCore.Http.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Http.Connections", "6.0.0" },
            { "Microsoft.AspNetCore.Http.Connections.Common", "6.0.0" },
            { "Microsoft.AspNetCore.Http.Extensions", "6.0.0" },
            { "Microsoft.AspNetCore.Http.Features", "6.0.0" },
            { "Microsoft.AspNetCore.Http.Results", "6.0.0" },
            { "Microsoft.AspNetCore.HttpLogging", "6.0.0" },
            { "Microsoft.AspNetCore.HttpOverrides", "6.0.0" },
            { "Microsoft.AspNetCore.HttpsPolicy", "6.0.0" },
            { "Microsoft.AspNetCore.Identity", "6.0.0" },
            { "Microsoft.AspNetCore.Localization", "6.0.0" },
            { "Microsoft.AspNetCore.Localization.Routing", "6.0.0" },
            { "Microsoft.AspNetCore.Metadata", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.ApiExplorer", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.Core", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.Cors", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.DataAnnotations", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.Formatters.Json", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.Formatters.Xml", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.Localization", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.Razor", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.RazorPages", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.TagHelpers", "6.0.0" },
            { "Microsoft.AspNetCore.Mvc.ViewFeatures", "6.0.0" },
            { "Microsoft.AspNetCore.Razor", "6.0.0" },
            { "Microsoft.AspNetCore.Razor.Runtime", "6.0.0" },
            { "Microsoft.AspNetCore.ResponseCaching", "6.0.0" },
            { "Microsoft.AspNetCore.ResponseCaching.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.ResponseCompression", "6.0.0" },
            { "Microsoft.AspNetCore.Rewrite", "6.0.0" },
            { "Microsoft.AspNetCore.Routing", "6.0.0" },
            { "Microsoft.AspNetCore.Routing.Abstractions", "6.0.0" },
            { "Microsoft.AspNetCore.Server.HttpSys", "6.0.0" },
            { "Microsoft.AspNetCore.Server.IIS", "6.0.0" },
            { "Microsoft.AspNetCore.Server.IISIntegration", "6.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel", "6.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel.Core", "6.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel.Transport.Quic", "6.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets", "6.0.0" },
            { "Microsoft.AspNetCore.Session", "6.0.0" },
            { "Microsoft.AspNetCore.SignalR", "6.0.0" },
            { "Microsoft.AspNetCore.SignalR.Common", "6.0.0" },
            { "Microsoft.AspNetCore.SignalR.Core", "6.0.0" },
            { "Microsoft.AspNetCore.SignalR.Protocols.Json", "6.0.0" },
            { "Microsoft.AspNetCore.StaticFiles", "6.0.0" },
            { "Microsoft.AspNetCore.WebSockets", "6.0.0" },
            { "Microsoft.AspNetCore.WebUtilities", "6.0.0" },
            { "Microsoft.Extensions.Caching.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.Caching.Memory", "6.0.0" },
            { "Microsoft.Extensions.Configuration", "6.0.0" },
            { "Microsoft.Extensions.Configuration.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.Configuration.Binder", "6.0.0" },
            { "Microsoft.Extensions.Configuration.CommandLine", "6.0.0" },
            { "Microsoft.Extensions.Configuration.EnvironmentVariables", "6.0.0" },
            { "Microsoft.Extensions.Configuration.FileExtensions", "6.0.0" },
            { "Microsoft.Extensions.Configuration.Ini", "6.0.0" },
            { "Microsoft.Extensions.Configuration.Json", "6.0.0" },
            { "Microsoft.Extensions.Configuration.KeyPerFile", "6.0.0" },
            { "Microsoft.Extensions.Configuration.UserSecrets", "6.0.0" },
            { "Microsoft.Extensions.Configuration.Xml", "6.0.0" },
            { "Microsoft.Extensions.DependencyInjection", "6.0.0" },
            { "Microsoft.Extensions.DependencyInjection.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.Diagnostics.HealthChecks", "6.0.0" },
            { "Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.Features", "6.0.0" },
            { "Microsoft.Extensions.FileProviders.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.FileProviders.Composite", "6.0.0" },
            { "Microsoft.Extensions.FileProviders.Embedded", "6.0.0" },
            { "Microsoft.Extensions.FileProviders.Physical", "6.0.0" },
            { "Microsoft.Extensions.FileSystemGlobbing", "6.0.0" },
            { "Microsoft.Extensions.Hosting", "6.0.0" },
            { "Microsoft.Extensions.Hosting.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.Http", "6.0.0" },
            { "Microsoft.Extensions.Identity.Core", "6.0.0" },
            { "Microsoft.Extensions.Identity.Stores", "6.0.0" },
            { "Microsoft.Extensions.Localization", "6.0.0" },
            { "Microsoft.Extensions.Localization.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.Logging", "6.0.0" },
            { "Microsoft.Extensions.Logging.Abstractions", "6.0.0" },
            { "Microsoft.Extensions.Logging.Configuration", "6.0.0" },
            { "Microsoft.Extensions.Logging.Console", "6.0.0" },
            { "Microsoft.Extensions.Logging.Debug", "6.0.0" },
            { "Microsoft.Extensions.Logging.EventLog", "6.0.0" },
            { "Microsoft.Extensions.Logging.EventSource", "6.0.0" },
            { "Microsoft.Extensions.Logging.TraceSource", "6.0.0" },
            { "Microsoft.Extensions.ObjectPool", "6.0.0" },
            { "Microsoft.Extensions.Options", "6.0.0" },
            { "Microsoft.Extensions.Options.ConfigurationExtensions", "6.0.0" },
            { "Microsoft.Extensions.Options.DataAnnotations", "6.0.0" },
            { "Microsoft.Extensions.Primitives", "6.0.0" },
            { "Microsoft.Extensions.WebEncoders", "6.0.0" },
            { "Microsoft.JSInterop", "6.0.0" },
            { "Microsoft.Net.Http.Headers", "6.0.0" },
            { "System.Diagnostics.EventLog", "6.0.0" },
            { "System.IO.Pipelines", "6.0.0" },
            { "System.Security.Cryptography.Pkcs", "6.0.0" },
            { "System.Security.Cryptography.Xml", "6.0.0" },
        };

        internal static FrameworkPackages WindowsDesktop { get; } = new(Net60, FrameworkNames.WindowsDesktopApp, NETCoreApp50.WindowsDesktop)
        {
            { "Microsoft.Win32.Registry.AccessControl", "6.0.0" },
            { "Microsoft.Win32.SystemEvents", "6.0.0" },
            { "System.CodeDom", "6.0.0" },
            { "System.Configuration.ConfigurationManager", "6.0.0" },
            { "System.Diagnostics.EventLog", "6.0.0" },
            { "System.Diagnostics.PerformanceCounter", "6.0.0" },
            { "System.Drawing.Common", "6.0.0" },
            { "System.IO.Packaging", "6.0.0" },
            { "System.Resources.Extensions", "6.0.0" },
            { "System.Security.Cryptography.Pkcs", "6.0.0" },
            { "System.Security.Cryptography.ProtectedData", "6.0.0" },
            { "System.Security.Cryptography.Xml", "6.0.0" },
            { "System.Security.Permissions", "6.0.0" },
            { "System.Threading.AccessControl", "6.0.0" },
            { "System.Windows.Extensions", "6.0.0" },
        };

        internal static void Register() => FrameworkPackages.Register(Instance, AspNetCore, WindowsDesktop);
    }
}