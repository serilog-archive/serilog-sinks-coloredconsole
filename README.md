# The colored console sink for Serilog  

[![Build status](https://ci.appveyor.com/api/projects/status/dbtyq05dgvac8jbv/branch/master?svg=true)](https://ci.appveyor.com/project/serilog/serilog-sinks-coloredconsole/branch/master) [![NuGet Version](http://img.shields.io/nuget/v/Serilog.Sinks.ColoredConsole.svg?style=flat)](https://www.nuget.org/packages/Serilog.Sinks.ColoredConsole/)

Writes to the system console, using colour to emphasise levels and to highlight structured data within log messages. Makes the ordinary console sink look ordinary! (_See also: [Literate Console](https://github.com/serilog/serilog-sinks-literate)_)

```csharp
var log = new LoggerConfiguration()
    .WriteTo.ColoredConsole()
    .CreateLogger();
```
Or in XML [app-settings format](https://github.com/serilog/serilog/wiki/AppSettings):

```xml
<add key="serilog:write-to:ColoredConsole" />
```

* [Documentation](https://github.com/serilog/serilog/wiki)

Copyright &copy; 2016 Serilog Contributors - Provided under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html).
