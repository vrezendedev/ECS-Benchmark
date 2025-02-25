namespace ECS.Benchmark;

using BenchmarkDotNet.Attributes;

[BenchmarkCategory("Assemblage_Queries")]
public class ExecuteQueryOnEntitiesWithOneComponent : Benchmark
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
        TheiaWorld.ExecuteQueryAsProspective(
            TheiaQueryC1,
            (ref Component1 c1) =>
            {
                c1.Value += 1;
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
            }
        );
    }

    [Benchmark]
    public void Fennecs_C1()
    {
        FennecsQueryC1
            .Stream<Component1>()
            .For(
                (ref Component1 c1) =>
                {
                    c1.Value += 1;
                }
            );
    }

    [Benchmark]
    public void Friflo_C1()
    {
        FrifloQueryC1!.ForEachEntity(
            (ref Component1_F c1, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
            }
        );
    }
}

[BenchmarkCategory("Assemblage_Queries")]
public class ExecuteQueryOnEntitiesWithTwoComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsProspective(
            TheiaQueryC2,
            (ref Component1 c1, ref Component2 c2) =>
            {
                c1.Value += 1;
                c2.Value += 1;
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
            }
        );
    }

    [Benchmark]
    public void Fennecs_C2()
    {
        FennecsQueryC2
            .Stream<Component1, Component2>()
            .For(
                (ref Component1 c1, ref Component2 c2) =>
                {
                    c1.Value += 1;
                    c2.Value += 1;
                }
            );
    }

    [Benchmark]
    public void Friflo_C2()
    {
        FrifloQueryC2!.ForEachEntity(
            (ref Component1_F c1, ref Component2_F c2, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
                c2.Value += 1;
            }
        );
    }
}

[BenchmarkCategory("Assemblage_Queries")]
public class ExecuteQueryOnEntitiesWithThreeComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsProspective(
            TheiaQueryC3,
            (ref Component1 c1, ref Component2 c2, ref Component3 c3) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
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
            }
        );
    }

    [Benchmark]
    public void Fennecs_C3()
    {
        FennecsQueryC3
            .Stream<Component1, Component2, Component3>()
            .For(
                (ref Component1 c1, ref Component2 c2, ref Component3 c3) =>
                {
                    c1.Value += 1;
                    c2.Value += 1;
                    c3.Value += 1;
                }
            );
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
            }
        );
    }
}

[BenchmarkCategory("Assemblage_Queries")]
public class ExecuteQueryOnEntitiesWithFourComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsProspective(
            TheiaQueryC4,
            (ref Component1 c1, ref Component2 c2, ref Component3 c3, ref Component4 c4) =>
            {
                c1.Value += 1;
                c2.Value += 1;
                c3.Value += 1;
                c4.Value += 1;
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
            }
        );
    }

    [Benchmark]
    public void Fennecs_C4()
    {
        FennecsQueryC4
            .Stream<Component1, Component2, Component3, Component4>()
            .For(
                (ref Component1 c1, ref Component2 c2, ref Component3 c3, ref Component4 c4) =>
                {
                    c1.Value += 1;
                    c2.Value += 1;
                    c3.Value += 1;
                    c4.Value += 1;
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
            }
        );
    }
}

[BenchmarkCategory("Assemblage_Queries")]
public class ExecuteQueryOnEntitiesWithFiveComponents : Benchmark
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
        TheiaWorld.ExecuteQueryAsProspective(
            TheiaQueryC5,
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
            }
        );
    }

    [Benchmark]
    public void Fennecs_C5()
    {
        FennecsQueryC5
            .Stream<Component1, Component2, Component3, Component4, Component5>()
            .For(
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
            }
        );
    }
}
