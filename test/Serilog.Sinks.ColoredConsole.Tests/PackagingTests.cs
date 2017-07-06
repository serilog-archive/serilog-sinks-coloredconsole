using System.Reflection;
using Xunit;

namespace Serilog.Sinks.ColoredConsole.Tests
{
    public class PackagingTests
    {
        [Fact]
        public void AssemblyVersionIsSet()
        {
            var assembly = typeof(ColoredConsoleLoggerConfigurationExtensions).GetTypeInfo().Assembly;
            Assert.Equal("3", assembly.GetName().Version.ToString(1));
        }
    }
}
