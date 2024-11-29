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
    }
}

[Identifier("example_item")]
public class ExampleItem : Item
{
    public ExampleItem(Settings settings) : base(settings) { }
}