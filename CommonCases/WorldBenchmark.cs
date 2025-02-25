namespace ECS.Benchmark;

using BenchmarkDotNet.Attributes;

[BenchmarkCategory("World")]
[IterationCount(16), InvocationCount(1, 1)]
public class WorldBenchmark
{
    [Benchmark]
    public void TheiaECS_WorldCreation()
    {
        TheiaECS.Source.Core.World world = new();
    }

    [Benchmark]
    public void Arch_WorldCreation()
    {
        Arch.Core.World world = Arch.Core.World.Create();
    }

    [Benchmark]
    public void Fennecs_WorldCreation()
    {
        fennecs.World world = new();
    }

    [Benchmark]
    public void Friflo_WorldCreation()
    {
        Friflo.Engine.ECS.EntityStore World = new Friflo.Engine.ECS.EntityStore();
    }
}
