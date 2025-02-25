namespace ECS.Benchmark;

using BenchmarkDotNet.Attributes;

#region Create New Entity with same Component Set

[BenchmarkCategory("Creational_Queries")]
public class ExecuteCreationalQueryOnEntitiesWithOneComponent : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC1,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1) =>
            {
                c1.Value += 1;
                TheiaAssemblageC1.DeferredCreate(TheiaWorld, new Component1() { Value = e.ID });
            }
        );
    }

    [Benchmark]
    public void Arch_C1()
    {
        ArchWorld.Query(
            in ArchQueryC1,
            (ref Component1 c1) =>
            {
                c1.Value += 1;
                ArchCommandBuffer.Create(ArchComponentTypesC1);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C1()
    {
        FrifloQueryC1!.ForEachEntity(
            (ref Component1_F c1, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
                int e = FrifloCommandBuffer.CreateEntity();
                FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = entity.Id });
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Creational_Queries")]
public class ExecuteCreationalQueryOnEntitiesWithTwoComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC2,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                c2.Value += 1;

                TheiaAssemblageC2.DeferredCreate(
                    TheiaWorld,
                    new Component1() { Value = e.ID },
                    new Component2() { Value = e.ID }
                );
            }
        );
    }

    [Benchmark]
    public void Arch_C2()
    {
        ArchWorld.Query(
            in ArchQueryC2,
            (ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                c2.Value += 1;

                ArchCommandBuffer.Create(ArchComponentTypesC2);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        FrifloQueryC2!.ForEachEntity(
            (ref Component1_F c1, ref Component2_F c2, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
                c2.Value += 1;

                int e = FrifloCommandBuffer.CreateEntity();
                FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = entity.Id });
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Creational_Queries")]
public class ExecuteCreationalQueryOnEntitiesWithThreeComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC3,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;

                TheiaAssemblageC3.DeferredCreate(
                    TheiaWorld,
                    new Component1() { Value = e.ID },
                    new Component2() { Value = e.ID },
                    new Component3() { Value = e.ID }
                );
            }
        );
    }

    [Benchmark]
    public void Arch_C3()
    {
        ArchWorld.Query(
            in ArchQueryC3,
            (ref Component1 c1, ref Component2 c2, ref Component3 c3) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                ArchCommandBuffer.Create(ArchComponentTypesC3);
            }
        );
        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        FrifloQueryC3!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;

                int e = FrifloCommandBuffer.CreateEntity();
                FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component3_F() { Value = entity.Id });
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Creational_Queries")]
public class ExecuteCreationalQueryOnEntitiesWithFourComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC4,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;

                TheiaAssemblageC4.DeferredCreate(
                    TheiaWorld,
                    new Component1() { Value = e.ID },
                    new Component2() { Value = e.ID },
                    new Component3() { Value = e.ID },
                    new Component4() { Value = e.ID }
                );
            }
        );
    }

    [Benchmark]
    public void Arch_C4()
    {
        ArchWorld.Query(
            in ArchQueryC4,
            (ref Component1 c1, ref Component2 c2, ref Component3 c3, ref Component4 c4) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                ArchCommandBuffer.Create(ArchComponentTypesC4);
            }
        );
    }

    [Benchmark]
    public void Friflo_C4()
    {
        FrifloQueryC4!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;

                int e = FrifloCommandBuffer.CreateEntity();
                FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component3_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component4_F() { Value = entity.Id });
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Creational_Queries")]
public class ExecuteCreationalQueryOnEntitiesWithFiveComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC5,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                c5.Value += 1;

                TheiaAssemblageC5.DeferredCreate(
                    TheiaWorld,
                    new Component1() { Value = e.ID },
                    new Component2() { Value = e.ID },
                    new Component3() { Value = e.ID },
                    new Component4() { Value = e.ID },
                    new Component5() { Value = e.ID }
                );
            }
        );
    }

    [Benchmark]
    public void Arch_C5()
    {
        ArchWorld.Query(
            in ArchQueryC5,
            (
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                c5.Value += 1;

                ArchCommandBuffer.Create(ArchComponentTypesC5);
            }
        );
    }

    [Benchmark]
    public void Friflo_C5()
    {
        FrifloQueryC5!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                ref Component5_F c5,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                c5.Value += 1;

                int e = FrifloCommandBuffer.CreateEntity();
                FrifloCommandBuffer.AddComponent(e, new Component1_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component2_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component3_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component4_F() { Value = entity.Id });
                FrifloCommandBuffer.AddComponent(e, new Component5_F() { Value = entity.Id });
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

#endregion

#region Destroy Entity

[BenchmarkCategory("Destructional_Queries")]
public class ExecuteDestructionalQueryOnEntitiesWithOneComponent : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC1,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1) =>
            {
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C1()
    {
        ArchWorld.Query(
            in ArchQueryC1,
            (Arch.Core.Entity e, ref Component1 c1) =>
            {
                ArchCommandBuffer.Destroy(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C1()
    {
        FrifloQueryC1!.ForEachEntity(
            (ref Component1_F c1, Friflo.Engine.ECS.Entity entity) =>
            {
                FrifloCommandBuffer.DeleteEntity(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destructional_Queries")]
public class ExecuteDestructionalQueryOnEntitiesWithTwoComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC2,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C2()
    {
        ArchWorld.Query(
            in ArchQueryC2,
            (Arch.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                ArchCommandBuffer.Destroy(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        FrifloQueryC2!.ForEachEntity(
            (ref Component1_F c1, ref Component2_F c2, Friflo.Engine.ECS.Entity entity) =>
            {
                FrifloCommandBuffer.DeleteEntity(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destructional_Queries")]
public class ExecuteDestructionalQueryOnEntitiesWithThreeComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC3,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3
            ) =>
            {
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C3()
    {
        ArchWorld.Query(
            in ArchQueryC3,
            (Arch.Core.Entity e, ref Component1 c1, ref Component2 c2, ref Component3 c3) =>
            {
                ArchCommandBuffer.Destroy(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        FrifloQueryC3!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                FrifloCommandBuffer.DeleteEntity(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destructional_Queries")]
public class ExecuteDestructionalQueryOnEntitiesWithFourComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC4,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C4()
    {
        ArchWorld.Query(
            in ArchQueryC4,
            (
                Arch.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                ArchCommandBuffer.Destroy(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C4()
    {
        FrifloQueryC4!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                FrifloCommandBuffer.DeleteEntity(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Destructional_Queries")]
public class ExecuteDestructionalQueryOnEntitiesWithFiveComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC5,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C5()
    {
        ArchWorld.Query(
            in ArchQueryC5,
            (
                Arch.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                ArchCommandBuffer.Destroy(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C5()
    {
        FrifloQueryC5!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                ref Component5_F c5,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                FrifloCommandBuffer.DeleteEntity(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

#endregion


#region Add New Component on Entity

[BenchmarkCategory("Addition_Queries")]
public class ExecuteAdditionQueryOnEntitiesWithOneComponent : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC1,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1) =>
            {
                c1.Value += 1;
                TheiaWorld.DeferredAdd(in e, new Component2() { Value = e.ID });
            }
        );
    }

    [Benchmark]
    public void Theia_C1_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC1,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1) =>
            {
                c1.Value += 1;
                TheiaAssemblageC2.Create(TheiaWorld, c1, new Component2() { Value = e.ID });
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C1()
    {
        ArchWorld.Query(
            in ArchQueryC1,
            (Arch.Core.Entity e, ref Component1 c1) =>
            {
                c1.Value += 1;
                ArchCommandBuffer.Add(in e, new Component2() { Value = e.Id });
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C1()
    {
        FrifloQueryC1!.ForEachEntity(
            (ref Component1_F c1, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
                FrifloCommandBuffer.AddComponent(
                    entity.Id,
                    new Component2_F() { Value = entity.Id }
                );
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Addition_Queries")]
public class ExecuteAdditionQueryOnEntitiesWithTwoComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC2,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                TheiaWorld.DeferredAdd(in e, new Component3() { Value = e.ID });
            }
        );
    }

    [Benchmark]
    public void Theia_C2_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC2,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                TheiaAssemblageC3.Create(TheiaWorld, c1, c2, new Component3() { Value = e.ID });
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C2()
    {
        ArchWorld.Query(
            in ArchQueryC2,
            (Arch.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                ArchCommandBuffer.Add(in e, new Component3() { Value = e.Id });
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        FrifloQueryC2!.ForEachEntity(
            (ref Component1_F c1, ref Component2_F c2, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                FrifloCommandBuffer.AddComponent(
                    entity.Id,
                    new Component3_F() { Value = entity.Id }
                );
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Addition_Queries")]
public class ExecuteAdditionQueryOnEntitiesWithThreeComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC3,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                TheiaWorld.DeferredAdd(in e, new Component4() { Value = e.ID });
            }
        );
    }

    [Benchmark]
    public void Theia_C3_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC3,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                TheiaAssemblageC4.Create(TheiaWorld, c1, c2, c3, new Component4() { Value = e.ID });
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C3()
    {
        ArchWorld.Query(
            in ArchQueryC3,
            (Arch.Core.Entity e, ref Component1 c1, ref Component2 c2, ref Component3 c3) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                ArchCommandBuffer.Add(in e, new Component4() { Value = e.Id });
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        FrifloQueryC3!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                FrifloCommandBuffer.AddComponent(
                    entity.Id,
                    new Component4_F() { Value = entity.Id }
                );
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Addition_Queries")]
public class ExecuteAdditionQueryOnEntitiesWithFourComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC4,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                TheiaWorld.DeferredAdd(in e, new Component5() { Value = e.ID });
            }
        );
    }

    [Benchmark]
    public void Theia_C4_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC4,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                TheiaAssemblageC5.Create(
                    TheiaWorld,
                    c1,
                    c2,
                    c3,
                    c4,
                    new Component5() { Value = e.ID }
                );
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C4()
    {
        ArchWorld.Query(
            in ArchQueryC4,
            (
                Arch.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                ArchCommandBuffer.Add(in e, new Component5() { Value = e.Id });
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C4()
    {
        FrifloQueryC4!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                FrifloCommandBuffer.AddComponent(
                    entity.Id,
                    new Component5_F() { Value = entity.Id }
                );
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Addition_Queries")]
public class ExecuteAdditionQueryOnEntitiesWithFiveComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC5,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                c5.Value += 1;
                TheiaWorld.DeferredAdd(in e, new Component6() { Value = e.ID });
            }
        );
    }

    [Benchmark]
    public void Theia_C5_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC5,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                c5.Value += 1;

                TheiaAssemblageC6.Create(
                    TheiaWorld,
                    c1,
                    c2,
                    c3,
                    c4,
                    c5,
                    new Component6() { Value = e.ID }
                );
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C5()
    {
        ArchWorld.Query(
            in ArchQueryC5,
            (
                Arch.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                c5.Value += 1;
                ArchCommandBuffer.Add(in e, new Component6() { Value = e.Id });
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C5()
    {
        FrifloQueryC5!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                ref Component5_F c5,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                c5.Value += 1;
                FrifloCommandBuffer.AddComponent(
                    entity.Id,
                    new Component6_F() { Value = entity.Id }
                );
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

#endregion

#region Remove Component on Entity

[BenchmarkCategory("Removal_Queries")]
public class ExecuteRemovalQueryOnEntitiesWithTwoComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC2,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                TheiaWorld.DeferredRemove<Component2>(in e);
            }
        );
    }

    [Benchmark]
    public void Theia_C2_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC2,
            (ref TheiaECS.Source.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                TheiaAssemblageC1.Create(TheiaWorld, c1);
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C2()
    {
        ArchWorld.Query(
            in ArchQueryC2,
            (Arch.Core.Entity e, ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                ArchCommandBuffer.Remove<Component2>(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C2()
    {
        FrifloQueryC2!.ForEachEntity(
            (ref Component1_F c1, ref Component2_F c2, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
                FrifloCommandBuffer.RemoveComponent<Component2_F>(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Removal_Queries")]
public class ExecuteRemovalQueryOnEntitiesWithThreeComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC3,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                TheiaWorld.DeferredRemove<Component3>(in e);
            }
        );
    }

    [Benchmark]
    public void Theia_C3_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC3,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                TheiaAssemblageC2.Create(TheiaWorld, c1, c2);
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C3()
    {
        ArchWorld.Query(
            in ArchQueryC3,
            (Arch.Core.Entity e, ref Component1 c1, ref Component2 c2, ref Component3 c3) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                ArchCommandBuffer.Remove<Component3>(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C3()
    {
        FrifloQueryC3!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                FrifloCommandBuffer.RemoveComponent<Component3_F>(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Removal_Queries")]
public class ExecuteRemovalQueryOnEntitiesWithFourComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC4,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                TheiaWorld.DeferredRemove<Component4>(in e);
            }
        );
    }

    [Benchmark]
    public void Theia_C4_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC4,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                TheiaAssemblageC3.Create(TheiaWorld, c1, c2, c3);
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C4()
    {
        ArchWorld.Query(
            in ArchQueryC4,
            (
                Arch.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                ArchCommandBuffer.Remove<Component4>(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C4()
    {
        FrifloQueryC4!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                FrifloCommandBuffer.RemoveComponent<Component4_F>(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

[BenchmarkCategory("Removal_Queries")]
public class ExecuteRemovalQueryOnEntitiesWithFiveComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC5,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                TheiaWorld.DeferredRemove<Component5>(in e);
            }
        );
    }

    [Benchmark]
    public void Theia_C5_Optional()
    {
        TheiaWorld.ExecuteQueryAsCreational(
            TheiaQueryC5,
            (
                ref TheiaECS.Source.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;

                TheiaAssemblageC4.Create(TheiaWorld, c1, c2, c3, c4);
                TheiaWorld.DeferredDestroy(in e);
            }
        );
    }

    [Benchmark]
    public void Arch_C5()
    {
        ArchWorld.Query(
            in ArchQueryC5,
            (
                Arch.Core.Entity e,
                ref Component1 c1,
                ref Component2 c2,
                ref Component3 c3,
                ref Component4 c4,
                ref Component5 c5
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                ArchCommandBuffer.Remove<Component5>(in e);
            }
        );

        ArchCommandBuffer.Playback(ArchWorld, false);
    }

    [Benchmark]
    public void Friflo_C5()
    {
        FrifloQueryC5!.ForEachEntity(
            (
                ref Component1_F c1,
                ref Component2_F c2,
                ref Component3_F c3,
                ref Component4_F c4,
                ref Component5_F c5,
                Friflo.Engine.ECS.Entity entity
            ) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
                FrifloCommandBuffer.RemoveComponent<Component5_F>(entity.Id);
            }
        );

        FrifloCommandBuffer.Playback();
    }
}

#endregion
