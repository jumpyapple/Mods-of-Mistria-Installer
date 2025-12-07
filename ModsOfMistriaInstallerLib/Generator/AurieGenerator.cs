using System.Runtime.InteropServices;
using Garethp.ModsOfMistriaInstallerLib.Lang;
using Garethp.ModsOfMistriaInstallerLib.Models;
using Garethp.ModsOfMistriaInstallerLib.ModTypes;

namespace Garethp.ModsOfMistriaInstallerLib.Generator;

[InformationGenerator(1)]
public class AurieGenerator: IGenerator
{
    public GeneratedInformation Generate(IMod mod)
    {
        var information = new GeneratedInformation();
        
        foreach (var file in mod.GetFilesInFolder("aurie", ".dll"))
        {
            var fileName = Path.GetFileName(file);
            
            information.AurieMods.Add(new AurieMod
            {
                Mod = mod,
                FileName = fileName,
                Location = file
            });
        }

        return information;
    }

    public bool CanGenerate(IMod mod) => mod.HasFilesInFolder("aurie", ".dll");

    public Validation Validate(IMod mod)
    {
        var validation = new Validation();
        return validation;
    }
}