namespace ECS.Benchmark;

using BenchmarkDotNet.Attributes;

#region Create Command

[BenchmarkCategory("Create_Command")]
public class EntityCreateCommandWithOneComponentBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
    }

    [Benchmark]
    public void Theia_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            TheiaAssemblageC1.DeferredCreate(TheiaWorld, new Component1() { Value = i });
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ArchCommandBuffer.Create(ArchComponentTypesC1);
        }
        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloCommandBuffer.CreateEntity();
            FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Create_Command")]
public class EntityCreateCommandWithTwoComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
    }

    [Benchmark]
    public void Theia_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            TheiaAssemblageC2.DeferredCreate(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i }
            );
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ArchCommandBuffer.Create(ArchComponentTypesC2);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloCommandBuffer.CreateEntity();
            FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Create_Command")]
public class EntityCreateCommandWithThreeComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
    }

    [Benchmark]
    public void Theia_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            TheiaAssemblageC3.DeferredCreate(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ArchCommandBuffer.Create(ArchComponentTypesC3);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloCommandBuffer.CreateEntity();
            FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component3_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Create_Command")]
public class EntityCreateCommandWithFourComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
    }

    [Benchmark]
    public void Theia_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            TheiaAssemblageC4.DeferredCreate(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i }
            );
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ArchCommandBuffer.Create(ArchComponentTypesC4);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloCommandBuffer.CreateEntity();
            FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component3_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component4_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Create_Command")]
public class EntityCreateCommandWithFiveComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
    }

    [Benchmark]
    public void Theia_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            TheiaAssemblageC5.DeferredCreate(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i },
                new Component5() { Value = i }
            );
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ArchCommandBuffer.Create(ArchComponentTypesC4);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloCommandBuffer.CreateEntity();
            FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component3_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component4_F() { Value = i });
            FrifloCommandBuffer.AddComponent(e, new Component5_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

#endregion

#region Destroy Command
[BenchmarkCategory("Destroy_Command")]
public class EntityWithOneComponentDestroyCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
        InitializeWithOneComponent();
    }

    [Benchmark]
    public void Theia_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredDestroy(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Destroy(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.DeleteEntity(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destroy_Command")]
public class EntityWithTwoComponentsDestroyCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
        InitializeWithTwoComponents();
    }

    [Benchmark]
    public void Theia_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredDestroy(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Destroy(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.DeleteEntity(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destroy_Command")]
public class EntityWithThreeComponentsDestroyCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
        InitializeWithThreeComponents();
    }

    [Benchmark]
    public void Theia_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredDestroy(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Destroy(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.DeleteEntity(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destroy_Command")]
public class EntityWithFourComponentsDestroyCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
        InitializeWithFourComponents();
    }

    [Benchmark]
    public void Theia_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredDestroy(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Destroy(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.DeleteEntity(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destroy_Command")]
public class EntityWithFiveComponentsDestroyCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeArchComponentTypes();
        InitializeWithFiveComponents();
    }

    [Benchmark]
    public void Theia_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredDestroy(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Destroy(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.DeleteEntity(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

#endregion

#region Add Command
[BenchmarkCategory("Add_Command")]
public class EntityWithOneComponentAddCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithOneComponent();
    }

    [Benchmark]
    public void Theia_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredAdd(in e, new Component2() { Value = i });
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Add(in e, new Component2() { Value = i });
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.AddComponent(e.Id, new Component2_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Add_Command")]
public class EntityWithTwoComponentsAddCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithTwoComponents();
    }

    [Benchmark]
    public void Theia_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredAdd(in e, new Component3() { Value = i });
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Add(in e, new Component3() { Value = i });
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.AddComponent(e.Id, new Component3_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Add_Command")]
public class EntityWithThreeComponentsAddCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithThreeComponents();
    }

    [Benchmark]
    public void Theia_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredAdd(in e, new Component4() { Value = i });
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Add(in e, new Component4() { Value = i });
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.AddComponent(e.Id, new Component4_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Add_Command")]
public class EntityWithFourComponentsAddCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithFourComponents();
    }

    [Benchmark]
    public void Theia_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredAdd(in e, new Component5() { Value = i });
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Add(in e, new Component5() { Value = i });
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.AddComponent(e.Id, new Component5_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Add_Command")]
public class EntityWithFiveComponentsAddCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithFiveComponents();
    }

    [Benchmark]
    public void Theia_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredAdd(in e, new Component6() { Value = i });
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Add(in e, new Component6() { Value = i });
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.AddComponent(e.Id, new Component6_F() { Value = i });
        }

        FrifloCommandBuffer.Playback();
    }
}

#endregion

#region Remove Command

[BenchmarkCategory("Remove_Command")]
public class EntityWithTwoComponentsRemoveCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithTwoComponents();
    }

    [Benchmark]
    public void Theia_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredRemove<Component2>(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Remove<Component2>(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.RemoveComponent<Component2_F>(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Remove_Command")]
public class EntityWithThreeComponentsRemoveCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithThreeComponents();
    }

    [Benchmark]
    public void Theia_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredRemove<Component3>(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Remove<Component3>(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.RemoveComponent<Component3_F>(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Remove_Command")]
public class EntityWithFourComponentsRemoveCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithFourComponents();
    }

    [Benchmark]
    public void Theia_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredRemove<Component4>(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Remove<Component4>(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.RemoveComponent<Component4_F>(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Remove_Command")]
public class EntityWithFiveComponentsRemoveCommandBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();
        InitializeWithFiveComponents();
    }

    [Benchmark]
    public void Theia_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref TheiaWorld.Get(i);
            TheiaWorld.DeferredRemove<Component5>(in e);
        }

        TheiaWorld.CommitDeferreds();
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref ArchEntities[i];
            ArchCommandBuffer.Remove<Component5>(in e);
        }

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref var e = ref FrifloEntities[i];
            FrifloCommandBuffer.RemoveComponent<Component5_F>(e.Id);
        }

        FrifloCommandBuffer.Playback();
    }
}

#endregion
