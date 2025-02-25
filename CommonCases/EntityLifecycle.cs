namespace ECS.Benchmark;

using BenchmarkDotNet.Attributes;

#region Create Entity

[BenchmarkCategory("Create_Entity")]
public class EntityCreateWithOneComponentBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup() => InitializeDependencies();

    [Benchmark]
    public void Theia_C1()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC1.Create(TheiaWorld, new Component1() { Value = i });
    }

    [Benchmark]
    public void Arch_C1()
    {
        for (int i = 0; i < Entities; i++)
            ArchWorld.Create(new Component1() { Value = i });
    }

    [Benchmark]
    public void Fennecs_C1()
    {
        for (int i = 0; i < Entities; i++)
            FennecsWorld.Spawn().Add(new Component1() { Value = i });
    }

    [Benchmark]
    public void Friflo_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Create_Entity")]
public class EntityCreateWithTwoComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup() => InitializeDependencies();

    [Benchmark]
    public void Theia_C2()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC2.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i }
            );
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
            ArchWorld.Create(new Component1() { Value = i }, new Component2() { Value = i });
    }

    [Benchmark]
    public void Fennecs_C2()
    {
        for (int i = 0; i < Entities; i++)
            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i });
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Create_Entity")]
public class EntityCreateWithThreeComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup() => InitializeDependencies();

    [Benchmark]
    public void Theia_C3()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC3.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
            ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );
    }

    [Benchmark]
    public void Fennecs_C3()
    {
        for (int i = 0; i < Entities; i++)
            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i });
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
            e.AddComponent(new Component3_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Create_Entity")]
public class EntityCreateWithFourComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup() => InitializeDependencies();

    [Benchmark]
    public void Theia_C4()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC4.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i }
            );
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
            ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i }
            );
    }

    [Benchmark]
    public void Fennecs_C4()
    {
        for (int i = 0; i < Entities; i++)
            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i })
                .Add(new Component4() { Value = i });
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
            e.AddComponent(new Component3_F() { Value = i });
            e.AddComponent(new Component4_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Create_Entity")]
public class EntityCreateWithFiveComponentsBenchmark : Benchmark
{
    [IterationSetup]
    public void IterationSetup() => InitializeDependencies();

    [Benchmark]
    public void Theia_C5()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC5.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i },
                new Component5() { Value = i }
            );
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
            ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i },
                new Component5() { Value = i }
            );
    }

    [Benchmark]
    public void Fennecs_C5()
    {
        for (int i = 0; i < Entities; i++)
            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i })
                .Add(new Component4() { Value = i })
                .Add(new Component5() { Value = i });
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
            e.AddComponent(new Component3_F() { Value = i });
            e.AddComponent(new Component4_F() { Value = i });
            e.AddComponent(new Component5_F() { Value = i });
        }
    }
}

#endregion

#region Destroy Entity
[BenchmarkCategory("Destroy_Entity")]
public class EntityDestroyWithOneComponentBenchmark : Benchmark
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
            ref TheiaECS.Source.Core.Entity e = ref TheiaWorld.Get(i);
            TheiaWorld.Destroy(in e);
        }
    }

    [Benchmark]
    public void Arch_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            ArchWorld.Destroy(e);
        }
    }

    [Benchmark]
    public void Fennecs_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            FennecsWorld.Despawn(e);
        }
    }

    [Benchmark]
    public void Friflo_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.DeleteEntity();
        }
    }
}

[BenchmarkCategory("Destroy_Entity")]
public class EntityDestroyWithTwoComponentsBenchmark : Benchmark
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
            ref TheiaECS.Source.Core.Entity e = ref TheiaWorld.Get(i);
            TheiaWorld.Destroy(in e);
        }
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            ArchWorld.Destroy(e);
        }
    }

    [Benchmark]
    public void Fennecs_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            FennecsWorld.Despawn(e);
        }
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.DeleteEntity();
        }
    }
}

[BenchmarkCategory("Destroy_Entity")]
public class EntityDestroyWithThreeComponentsBenchmark : Benchmark
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
            ref TheiaECS.Source.Core.Entity e = ref TheiaWorld.Get(i);
            TheiaWorld.Destroy(in e);
        }
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            ArchWorld.Destroy(e);
        }
    }

    [Benchmark]
    public void Fennecs_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            FennecsWorld.Despawn(e);
        }
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.DeleteEntity();
        }
    }
}

[BenchmarkCategory("Destroy_Entity")]
public class EntityDestroyWithFourComponentsBenchmark : Benchmark
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
            ref TheiaECS.Source.Core.Entity e = ref TheiaWorld.Get(i);
            TheiaWorld.Destroy(in e);
        }
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            ArchWorld.Destroy(e);
        }
    }

    [Benchmark]
    public void Fennecs_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            FennecsWorld.Despawn(e);
        }
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.DeleteEntity();
        }
    }
}

[BenchmarkCategory("Destroy_Entity")]
public class EntityDestroyWithFiveComponentsBenchmark : Benchmark
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
            ref TheiaECS.Source.Core.Entity e = ref TheiaWorld.Get(i);
            TheiaWorld.Destroy(in e);
        }
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            ArchWorld.Destroy(e);
        }
    }

    [Benchmark]
    public void Fennecs_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            FennecsWorld.Despawn(e);
        }
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.DeleteEntity();
        }
    }
}
#endregion
