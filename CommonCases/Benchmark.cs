#pragma warning disable CS8618

namespace ECS.Benchmark;

using BenchmarkDotNet.Attributes;

[IterationCount(16), InvocationCount(1, 1)]
public class Benchmark
{
    [Params(
        1,
        5,
        10,
        25,
        50,
        100,
        200,
        400,
        800,
        1_600,
        3_200,
        6_400,
        16_000,
        32_000,
        64_000,
        100_000
    )]
    public int Entities;

    public TheiaECS.Source.Core.World TheiaWorld;
    public Arch.Core.World ArchWorld;
    public fennecs.World FennecsWorld;
    public Friflo.Engine.ECS.EntityStore FrifloEntityStore;

    public Arch.Core.Entity[] ArchEntities;
    public fennecs.Entity[] FennecsEntities;
    public Friflo.Engine.ECS.Entity[] FrifloEntities;

    public TheiaECS.Source.Core.Assemblage<Component1> TheiaAssemblageC1;
    public TheiaECS.Source.Core.Assemblage<Component1, Component2> TheiaAssemblageC2;
    public TheiaECS.Source.Core.Assemblage<Component1, Component2, Component3> TheiaAssemblageC3;
    public TheiaECS.Source.Core.Assemblage<
        Component1,
        Component2,
        Component3,
        Component4
    > TheiaAssemblageC4;
    public TheiaECS.Source.Core.Assemblage<
        Component1,
        Component2,
        Component3,
        Component4,
        Component5
    > TheiaAssemblageC5;
    public TheiaECS.Source.Core.Assemblage<
        Component1,
        Component2,
        Component3,
        Component4,
        Component5,
        Component6
    > TheiaAssemblageC6;

    public Arch.Buffer.CommandBuffer ArchCommandBuffer;
    public Arch.Core.Utils.ComponentType[] ArchComponentTypesC1;
    public Arch.Core.Utils.ComponentType[] ArchComponentTypesC2;
    public Arch.Core.Utils.ComponentType[] ArchComponentTypesC3;
    public Arch.Core.Utils.ComponentType[] ArchComponentTypesC4;
    public Arch.Core.Utils.ComponentType[] ArchComponentTypesC5;

    public Friflo.Engine.ECS.CommandBuffer FrifloCommandBuffer;

    public TheiaECS.Source.Core.Query TheiaQueryC1;
    public TheiaECS.Source.Core.Query TheiaQueryC2;
    public TheiaECS.Source.Core.Query TheiaQueryC3;
    public TheiaECS.Source.Core.Query TheiaQueryC4;
    public TheiaECS.Source.Core.Query TheiaQueryC5;

    public TheiaECS.Source.Core.Query TheiaComponentQueryC1;
    public TheiaECS.Source.Core.Query TheiaComponentQueryC2;

    public Arch.Core.QueryDescription ArchQueryC1;
    public Arch.Core.QueryDescription ArchQueryC2;
    public Arch.Core.QueryDescription ArchQueryC3;
    public Arch.Core.QueryDescription ArchQueryC4;
    public Arch.Core.QueryDescription ArchQueryC5;
    public Arch.Core.QueryDescription ArchComponentQueryC1;
    public Arch.Core.QueryDescription ArchComponentQueryC2;

    public fennecs.Query FennecsQueryC1;
    public fennecs.Query FennecsQueryC2;
    public fennecs.Query FennecsQueryC3;
    public fennecs.Query FennecsQueryC4;
    public fennecs.Query FennecsQueryC5;
    public fennecs.Query FennecsComponentQueryC1;
    public fennecs.Query FennecsComponentQueryC2;

    public Friflo.Engine.ECS.ArchetypeQuery<Component1_F> FrifloQueryC1;
    public Friflo.Engine.ECS.ArchetypeQuery<Component1_F, Component2_F> FrifloQueryC2;
    public Friflo.Engine.ECS.ArchetypeQuery<Component1_F, Component2_F, Component3_F> FrifloQueryC3;
    public Friflo.Engine.ECS.ArchetypeQuery<
        Component1_F,
        Component2_F,
        Component3_F,
        Component4_F
    > FrifloQueryC4;
    public Friflo.Engine.ECS.ArchetypeQuery<
        Component1_F,
        Component2_F,
        Component3_F,
        Component4_F,
        Component5_F
    > FrifloQueryC5;
    public Friflo.Engine.ECS.ArchetypeQuery<Component1_F> FrifloComponentQueryC1;
    public Friflo.Engine.ECS.ArchetypeQuery<Component1_F, Component2_F> FrifloComponentQueryC2;

    protected void InitializeDependencies()
    {
        TheiaWorld = new();
        ArchWorld = Arch.Core.World.Create();
        FennecsWorld = new();
        FrifloEntityStore = new();

        ArchEntities = new Arch.Core.Entity[Entities];
        FennecsEntities = new fennecs.Entity[Entities];
        FrifloEntities = new Friflo.Engine.ECS.Entity[Entities];

        TheiaAssemblageC1 = new(TheiaWorld);
        TheiaAssemblageC2 = new(TheiaWorld);
        TheiaAssemblageC3 = new(TheiaWorld);
        TheiaAssemblageC4 = new(TheiaWorld);
        TheiaAssemblageC5 = new(TheiaWorld);
        TheiaAssemblageC6 = new(TheiaWorld);

        ArchCommandBuffer = new(Entities);
        FrifloCommandBuffer = FrifloEntityStore.GetCommandBuffer();

        TheiaQueryC1 = TheiaWorld.CreateQuery(TheiaAssemblageC1)!;
        TheiaQueryC2 = TheiaWorld.CreateQuery(TheiaAssemblageC2)!;
        TheiaQueryC3 = TheiaWorld.CreateQuery(TheiaAssemblageC3)!;
        TheiaQueryC4 = TheiaWorld.CreateQuery(TheiaAssemblageC4)!;
        TheiaQueryC5 = TheiaWorld.CreateQuery(TheiaAssemblageC5)!;

        ArchQueryC1 = new Arch.Core.QueryDescription().WithExclusive<Component1>();
        ArchQueryC2 = new Arch.Core.QueryDescription().WithExclusive<Component1, Component2>();
        ArchQueryC3 = new Arch.Core.QueryDescription().WithExclusive<
            Component1,
            Component2,
            Component3
        >();
        ArchQueryC4 = new Arch.Core.QueryDescription().WithExclusive<
            Component1,
            Component2,
            Component3,
            Component4
        >();
        ArchQueryC5 = new Arch.Core.QueryDescription().WithExclusive<
            Component1,
            Component2,
            Component3,
            Component4,
            Component5
        >();

        FennecsQueryC1 = FennecsWorld.Query().Has<Component1>().Compile();
        FennecsQueryC2 = FennecsWorld.Query().Has<Component1>().Has<Component2>().Compile();
        FennecsQueryC3 = FennecsWorld
            .Query()
            .Has<Component1>()
            .Has<Component2>()
            .Has<Component3>()
            .Compile();
        FennecsQueryC4 = FennecsWorld
            .Query()
            .Has<Component1>()
            .Has<Component2>()
            .Has<Component3>()
            .Has<Component4>()
            .Compile();
        FennecsQueryC5 = FennecsWorld
            .Query()
            .Has<Component1>()
            .Has<Component2>()
            .Has<Component3>()
            .Has<Component4>()
            .Has<Component5>()
            .Compile();

        FrifloQueryC1 = FrifloEntityStore
            .Query<Component1_F>()
            .AllComponents(Friflo.Engine.ECS.ComponentTypes.Get<Component1_F>());

        FrifloQueryC2 = FrifloEntityStore
            .Query<Component1_F, Component2_F>()
            .AllComponents(
                new Friflo.Engine.ECS.ComponentTypes()
                {
                    Friflo.Engine.ECS.ComponentTypes.Get<Component1_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component2_F>(),
                }
            );

        FrifloQueryC3 = FrifloEntityStore
            .Query<Component1_F, Component2_F, Component3_F>()
            .AllComponents(
                new Friflo.Engine.ECS.ComponentTypes()
                {
                    Friflo.Engine.ECS.ComponentTypes.Get<Component1_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component2_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component3_F>(),
                }
            );

        FrifloQueryC4 = FrifloEntityStore
            .Query<Component1_F, Component2_F, Component3_F, Component4_F>()
            .AllComponents(
                new Friflo.Engine.ECS.ComponentTypes()
                {
                    Friflo.Engine.ECS.ComponentTypes.Get<Component1_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component2_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component3_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component4_F>(),
                }
            );

        FrifloQueryC5 = FrifloEntityStore
            .Query<Component1_F, Component2_F, Component3_F, Component4_F, Component5_F>()
            .AllComponents(
                new Friflo.Engine.ECS.ComponentTypes()
                {
                    Friflo.Engine.ECS.ComponentTypes.Get<Component1_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component2_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component3_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component4_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component5_F>(),
                }
            );
    }

    protected void InitializeComponentQueries()
    {
        TheiaComponentQueryC1 = TheiaWorld.CreateQuery<Component1>()!;

        ArchComponentQueryC1 = new Arch.Core.QueryDescription().WithAll<Component1>();

        FennecsComponentQueryC1 = FennecsWorld.Query().Has<Component1>().Compile();

        FrifloComponentQueryC1 = FrifloEntityStore
            .Query<Component1_F>()
            .AllComponents(Friflo.Engine.ECS.ComponentTypes.Get<Component1_F>());

        TheiaComponentQueryC2 = TheiaWorld.CreateQuery<Component1, Component2>()!;

        ArchComponentQueryC2 = new Arch.Core.QueryDescription().WithAll<Component1, Component2>();

        FennecsComponentQueryC2 = FennecsWorld
            .Query()
            .Has<Component1>()
            .Has<Component2>()
            .Compile();

        FrifloComponentQueryC2 = FrifloEntityStore
            .Query<Component1_F, Component2_F>()
            .AllComponents(
                new Friflo.Engine.ECS.ComponentTypes()
                {
                    Friflo.Engine.ECS.ComponentTypes.Get<Component1_F>(),
                    Friflo.Engine.ECS.ComponentTypes.Get<Component2_F>(),
                }
            );
    }

    protected void InitializeArchComponentTypes()
    {
        var c1 = Arch.Core.Utils.ComponentRegistry.Add<Component1>();
        var c2 = Arch.Core.Utils.ComponentRegistry.Add<Component2>();
        var c3 = Arch.Core.Utils.ComponentRegistry.Add<Component3>();
        var c4 = Arch.Core.Utils.ComponentRegistry.Add<Component4>();
        var c5 = Arch.Core.Utils.ComponentRegistry.Add<Component5>();
        ArchComponentTypesC1 = [c1];
        ArchComponentTypesC2 = [c1, c2];
        ArchComponentTypesC3 = [c1, c2, c3];
        ArchComponentTypesC4 = [c1, c2, c3, c4];
        ArchComponentTypesC5 = [c1, c2, c3, c4, c5];
    }

    protected void InitializeWithOneComponent()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC1.Create(TheiaWorld, new Component1() { Value = i });

        for (int i = 0; i < Entities; i++)
            ArchEntities[i] = ArchWorld.Create(new Component1() { Value = i });

        for (int i = 0; i < Entities; i++)
            FennecsEntities[i] = FennecsWorld.Spawn().Add(new Component1() { Value = i });

        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            FrifloEntities[i] = e;
        }
    }

    protected void InitializeWithTwoComponents()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC2.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i }
            );

        for (int i = 0; i < Entities; i++)
            ArchEntities[i] = ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i }
            );

        for (int i = 0; i < Entities; i++)
            FennecsEntities[i] = FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i });

        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
            FrifloEntities[i] = e;
        }
    }

    protected void InitializeWithThreeComponents()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC3.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );

        for (int i = 0; i < Entities; i++)
            ArchEntities[i] = ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i }
            );

        for (int i = 0; i < Entities; i++)
            FennecsEntities[i] = FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i });

        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
            e.AddComponent(new Component3_F() { Value = i });
            FrifloEntities[i] = e;
        }
    }

    protected void InitializeWithFourComponents()
    {
        for (int i = 0; i < Entities; i++)
            TheiaAssemblageC4.Create(
                TheiaWorld,
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i }
            );

        for (int i = 0; i < Entities; i++)
            ArchEntities[i] = ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i }
            );

        for (int i = 0; i < Entities; i++)
            FennecsEntities[i] = FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i })
                .Add(new Component4() { Value = i });

        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
            e.AddComponent(new Component3_F() { Value = i });
            e.AddComponent(new Component4_F() { Value = i });
            FrifloEntities[i] = e;
        }
    }

    protected void InitializeWithFiveComponents()
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

        for (int i = 0; i < Entities; i++)
            ArchEntities[i] = ArchWorld.Create(
                new Component1() { Value = i },
                new Component2() { Value = i },
                new Component3() { Value = i },
                new Component4() { Value = i },
                new Component5() { Value = i }
            );

        for (int i = 0; i < Entities; i++)
            FennecsEntities[i] = FennecsWorld
                .Spawn()
                .Add(new Component1() { Value = i })
                .Add(new Component2() { Value = i })
                .Add(new Component3() { Value = i })
                .Add(new Component4() { Value = i })
                .Add(new Component5() { Value = i });

        for (int i = 0; i < Entities; i++)
        {
            var e = FrifloEntityStore.CreateEntity();
            e.AddComponent(new Component1_F() { Value = i });
            e.AddComponent(new Component2_F() { Value = i });
            e.AddComponent(new Component3_F() { Value = i });
            e.AddComponent(new Component4_F() { Value = i });
            e.AddComponent(new Component5_F() { Value = i });
            FrifloEntities[i] = e;
        }
    }
}
