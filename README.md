# TheiaECS - Benchmark of Archetype-based ECSs (C#)

This benchmark evaluates various frameworks that are based on **archetypes**, which define a unique combination of component types for an entity. Archetypes serve as unique identifiers for entities that share the same component types within a world.

### 🔳 Frameworks Benchmarked

- **[Theia ECS](https://github.com/vrezendedev/TheiaECS)**
- **[Arch](https://github.com/genaray/Arch)**  
- **[Friflo](https://github.com/friflo/Friflo.Engine.ECS)**  
- **[Fennecs](https://github.com/outfox/fennecs/)**  

---

## 📌 Key Considerations:
- **Core Libraries Only**: The benchmarks focus on core libraries, excluding "extended" libraries that may enhance performance.
- **Bulk Operations**: Bulked operations were **not** considered in these tests, ensuring that the results reflect only the core operations.

---

## 🎯 Results

You can access the benchmark results in the spreadsheet linked below:

[Benchmark Results](https://docs.google.com/spreadsheets/d/e/2PACX-1vTACAEZOs7owk1YY9H7tZm9kcsstpa4pdvcBOfpsnEm0YyAaHAniUKyXpAb6oAU8594vxGA5zyks3Cq/pubhtml)

If you prefer, you can check the markdown (.MD) files in the [Results](./Results/) folder. These were executed on 02/28/2025.

---

## 📩 Feedback

If you notice any discrepancies or inconsistencies in the implementations, **feel free to reach out to me**.

--- 

## 🔖 Benchmark Categories

The following are the benchmark categories:

- **World**
- **Create_Entity**
- **Destroy_Entity**
- **Add_Component**
- **Remove_Component**
- **Create_Command**
- **Destroy_Command**
- **Add_Command**
- **Remove_Command**
- **Assemblage_Queries**
- **Component_Queries**
- **Creational_Queries**
- **Destructional_Queries**
- **Addition_Queries**
- **Removal_Queries**

---

## 💻 CLI Examples

To run benchmarks filtering categories, use the following command:

    dotnet run -c release --allCategories Assemblage_Queries

To include multiple categories in a single run, use:

    dotnet run -c release --allCategories Assemblage_Queries Component_Queries