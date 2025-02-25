namespace ECS.Benchmark;

using BenchmarkDotNet.Attributes;

[BenchmarkCategory("Component_Queries")]
public class ExecuteComponentQueryWithOneComponent : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();

        for (int i = 0; i < Entities / 2; i++)
        {
            TheiaAssemblageC2.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i }
            );
            TheiaAssemblageC3.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );

            ArchWorld.Create(new Component1() { Value = i }, new Component2() { Value = i });
            ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );

            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i });
            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i });

            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });

            var e2 = FrifloEntityStore.CreateEntity();
            e2.AddComponent(new Component1_F() { Value = i });
            e2.AddComponent(new Component2_F() { Value = i });
            e2.AddComponent(new Component3_F() { Value = i });
        }

        InitializeComponentQueries();
    }

    [Benchmark]
    public void Theia_C1()
    {
        TheiaWorld.ExecuteHermitQuery(
            TheiaComponentQueryC1,
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
            in ArchComponentQueryC1,
            (ref Component1 c1) =>
            {
                c1.Value += 1;
            }
        );
    }

    [Benchmark]
    public void Fennecs_C1()
    {
        FennecsComponentQueryC1
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
        FrifloComponentQueryC1!.ForEachEntity(
            (ref Component1_F c1, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
            }
        );
    }
}

[BenchmarkCategory("Component_Queries")]
public class ExecuteComponentQueryWithTwoComponents : Benchmark
{
    [IterationSetup]
    public void IterationSetup()
    {
        InitializeDependencies();

        for (int i = 0; i < Entities / 3; i++)
        {
            TheiaAssemblageC2.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i }
            );

            TheiaAssemblageC3.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );

            TheiaAssemblageC4.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i }
            );

            ArchWorld.Create(new Component1() { Value = i }, new Component2() { Value = i });
            ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );
            ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i }
            );

            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i });
            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i });
            FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i })
                .Add(new Component4() { Value = i });

            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });

            var e2 = FrifloEntityStore.CreateEntity();
            e2.AddComponent(new Component1_F() { Value = i });
            e2.AddComponent(new Component2_F() { Value = i });
            e2.AddComponent(new Component3_F() { Value = i });

            var e3 = FrifloEntityStore.CreateEntity();
            e3.AddComponent(new Component1_F() { Value = i });
            e3.AddComponent(new Component2_F() { Value = i });
            e3.AddComponent(new Component3_F() { Value = i });
            e3.AddComponent(new Component4_F() { Value = i });
        }

        InitializeComponentQueries();
    }

    [Benchmark]
    public void Theia_C2()
    {
        TheiaWorld.ExecuteHermitQuery(
            TheiaComponentQueryC2,
            (ref Component1 c1, ref Component1 c2) =>
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
            in ArchComponentQueryC2,
            (ref Component1 c1, ref Component1 c2) =>
            {
                c1.Value += 1;
                c2.Value += 1;
            }
        );
    }

    [Benchmark]
    public void Fennecs_C2()
    {
        FennecsComponentQueryC2
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
    public void Friflo_C3()
    {
        FrifloComponentQueryC2!.ForEachEntity(
            (ref Component1_F c1, ref Component2_F c2, Friflo.Engine.ECS.Entity entity) =>
            {
                c1.Value += 1;
                c2.Value += 1;
            }
        );
    }
}
