namespace ECS.Benchmark;

using Arch.Core.Extensions;
using BenchmarkDotNet.Attributes;

#region Add Component


[BenchmarkCategory("Add_Component")]
public class AddComponentOnEntityWithOneComponentBenchmark : Benchmark
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
            TheiaWorld.Add(in e, new Component2() { Value = i });
        }
    }

    [Benchmark]
    public void Arch_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Add(new Component2() { Value = i });
        }
    }

    [Benchmark]
    public void Fennecs_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Add(new Component2() { Value = i });
        }
    }

    [Benchmark]
    public void Friflo_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.AddComponent(new Component2_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Add_Component")]
public class AddComponentOnEntityWithTwoComponentsBenchmark : Benchmark
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
            TheiaWorld.Add(in e, new Component3() { Value = i });
        }
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Add(new Component3() { Value = i });
        }
    }

    [Benchmark]
    public void Fennecs_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Add(new Component3() { Value = i });
        }
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.AddComponent(new Component3_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Add_Component")]
public class AddComponentOnEntityWithThreeComponentsBenchmark : Benchmark
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
            TheiaWorld.Add(in e, new Component4() { Value = i });
        }
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Add(new Component4() { Value = i });
        }
    }

    [Benchmark]
    public void Fennecs_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Add(new Component4() { Value = i });
        }
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.AddComponent(new Component4_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Add_Component")]
public class AddComponentOnEntityWithFourComponentsBenchmark : Benchmark
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
            TheiaWorld.Add(in e, new Component5() { Value = i });
        }
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Add(new Component5() { Value = i });
        }
    }

    [Benchmark]
    public void Fennecs_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Add(new Component5() { Value = i });
        }
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.AddComponent(new Component5_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Add_Component")]
public class AddComponentOnEntityWithFiveComponentsBenchmark : Benchmark
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
            TheiaWorld.Add(in e, new Component6() { Value = i });
        }
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Add(new Component6() { Value = i });
        }
    }

    [Benchmark]
    public void Fennecs_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Add(new Component6() { Value = i });
        }
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.AddComponent(new Component6_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Add_Component")]
public class AddTwoComponentsOnEntityWithOneComponentBenchmark : Benchmark
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
            TheiaWorld.Add(in e, new Component2() { Value = i });
            TheiaWorld.Add(in e, new Component3() { Value = i });
        }
    }

    [Benchmark]
    public void Arch_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Add(new Component2() { Value = i });
            e.Add(new Component3() { Value = i });
        }
    }

    [Benchmark]
    public void Fennecs_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Add(new Component2() { Value = i });
            e.Add(new Component3() { Value = i });
        }
    }

    [Benchmark]
    public void Friflo_C1()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.AddComponent(new Component2_F() { Value = i });
            e.AddComponent(new Component3_F() { Value = i });
        }
    }
}

[BenchmarkCategory("Add_Component")]
public class AddTwoComponentsOnEntityWithFiveComponentsBenchmark : Benchmark
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
            TheiaWorld.Add(in e, new Component6() { Value = i });
            TheiaWorld.Add(in e, new Component7() { Value = i });
        }
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Add(new Component6() { Value = i });
            e.Add(new Component7() { Value = i });
        }
    }

    [Benchmark]
    public void Fennecs_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Add(new Component6() { Value = i });
            e.Add(new Component7() { Value = i });
        }
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.AddComponent(new Component6_F() { Value = i });
            e.AddComponent(new Component7_F() { Value = i });
        }
    }
}

#endregion

#region Remove Component

[BenchmarkCategory("Remove_Component")]
public class RemoveComponentOnEntityWithTwoComponentsBenchmark : Benchmark
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
            TheiaWorld.Remove<Component2>(in e);
        }
    }

    [Benchmark]
    public void Arch_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Remove<Component2>();
        }
    }

    [Benchmark]
    public void Fennecs_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Remove<Component2>();
        }
    }

    [Benchmark]
    public void Friflo_C2()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.RemoveComponent<Component2_F>();
        }
    }
}

[BenchmarkCategory("Remove_Component")]
public class RemoveComponentOnEntityWithThreeComponentsBenchmark : Benchmark
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
            TheiaWorld.Remove<Component3>(in e);
        }
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Remove<Component3>();
        }
    }

    [Benchmark]
    public void Fennecs_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Remove<Component3>();
        }
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.RemoveComponent<Component3_F>();
        }
    }
}

[BenchmarkCategory("Remove_Component")]
public class RemoveComponentOnEntityWithFourComponentsBenchmark : Benchmark
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
            TheiaWorld.Remove<Component4>(in e);
        }
    }

    [Benchmark]
    public void Arch_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Remove<Component4>();
        }
    }

    [Benchmark]
    public void Fennecs_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Remove<Component4>();
        }
    }

    [Benchmark]
    public void Friflo_C4()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.RemoveComponent<Component4_F>();
        }
    }
}

[BenchmarkCategory("Remove_Component")]
public class RemoveComponentOnEntityWithFiveComponentsBenchmark : Benchmark
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
            TheiaWorld.Remove<Component5>(in e);
        }
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Remove<Component5>();
        }
    }

    [Benchmark]
    public void Fennecs_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Remove<Component5>();
        }
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.RemoveComponent<Component5_F>();
        }
    }
}

[BenchmarkCategory("Remove_Component")]
public class RemoveTwoComponentsOnEntityWithThreeComponentsBenchmark : Benchmark
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
            TheiaWorld.Remove<Component2>(in e);
            TheiaWorld.Remove<Component3>(in e);
        }
    }

    [Benchmark]
    public void Arch_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Remove<Component2>();
            e.Remove<Component3>();
        }
    }

    [Benchmark]
    public void Fennecs_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Remove<Component2>();
            e.Remove<Component3>();
        }
    }

    [Benchmark]
    public void Friflo_C3()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.RemoveComponent<Component2_F>();
            e.RemoveComponent<Component3_F>();
        }
    }
}

[BenchmarkCategory("Remove_Component")]
public class RemoveTwoComponentsOnEntityWithFiveComponentsBenchmark : Benchmark
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
            TheiaWorld.Remove<Component4>(in e);
            TheiaWorld.Remove<Component5>(in e);
        }
    }

    [Benchmark]
    public void Arch_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref Arch.Core.Entity e = ref ArchEntities[i];
            e.Remove<Component4>();
            e.Remove<Component5>();
        }
    }

    [Benchmark]
    public void Fennecs_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            ref fennecs.Entity e = ref FennecsEntities[i];
            e.Remove<Component4>();
            e.Remove<Component5>();
        }
    }

    [Benchmark]
    public void Friflo_C5()
    {
        for (int i = 0; i < Entities; i++)
        {
            Friflo.Engine.ECS.Entity e = FrifloEntities[i];
            e.RemoveComponent<Component4_F>();
            e.RemoveComponent<Component5_F>();
        }
    }
}

#endregion
