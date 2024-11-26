using Pilynth.Fabric;

namespace ExampleMod;

[Identifier("pilynth_example")]
[Version("1.0.0")]
public class ExampleMod : FabricMod
{
    public void onInitialize()
    {
        Logger log = LoggerFactory.GetLogger("pilynth_example");
        log.Info("hello pilynth world!");

        RegistryKey key = RegistryKey.of(RegistryKey.ofRegistry(Identifier.of("item")), Identifier.of("pilynth_example", "example_item"));
        Registry.Register(Registries.ITEM, key, new ExampleItem(new Item.Settings().registryKey(key)));

        // RegistryKey key2 = RegistryKey.of(RegistryKey.ofRegistry(Identifier.of("item")), Identifier.of("pilynth_example", "example_2"));
        // Registry.Register(Registries.ITEM, key2, new ExampleItem(new Item.Settings().registryKey(key2)));
    }
}