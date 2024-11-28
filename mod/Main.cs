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
        Registry.register(Registries.ITEM, key, new ExampleItem(new Item.Settings().registryKey(key)));
    }
}

[Identifier("example_item")]
public class ExampleItem : Item
{
    public ExampleItem(Settings settings) : base(settings) { }
}