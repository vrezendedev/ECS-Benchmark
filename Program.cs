using System.Reflection;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Perfolizer.Metrology;

DirectoryInfo di = new DirectoryInfo(DefaultConfig.Instance.ArtifactsPath);

if (di.Exists)
    foreach (FileInfo file in di.GetFiles())
        file.Delete();

var exporter = new CsvExporter(
    CsvSeparator.CurrentCulture,
    new SummaryStyle(
        cultureInfo: System.Globalization.CultureInfo.CurrentCulture,
        printUnitsInHeader: true,
        printUnitsInContent: false,
        timeUnit: Perfolizer.Horology.TimeUnit.Microsecond,
        sizeUnit: SizeUnit.KB
    )
);

var config = ManualConfig
    .Create(DefaultConfig.Instance)
    .KeepBenchmarkFiles(false)
    .StopOnFirstError(true)
    .HideColumns([Column.Error, Column.Median, Column.StdDev])
    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.Declared))
    .WithSummaryStyle(
        SummaryStyle
            .Default.WithTimeUnit(Perfolizer.Horology.TimeUnit.Microsecond)
            .WithSizeUnit(SizeUnit.KB)
    )
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddDiagnoser(MemoryDiagnoser.Default)
    .AddExporter(exporter);

BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args, config);
