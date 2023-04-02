/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Gui Interface change</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxMmoPack))
{
    new ScriptObject(LiFxMmoPack)
    {
    };
}
package LiFxMmoPack
{
  function LiFxMmoPack::setup() {
    LiFx::registerCallback($LiFx::hooks::onInitialized, onInitialized, LiFxMmoPack);
  }

  function LiFxMmoPack::onInitialized() {
    //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LifxMainMenuMultiplayerWindow.gui"); //ogv video
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LifxloadingGui.gui"); //Background images
    //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LiFxselectWorld.gui");
    //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LiFxdeathWindow.gui");
    //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LifXcharacterWindow.gui");
    //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LiFxCreateWorldWindow.gui");
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LiFxskilMap.gui");
    //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LiFxmainMenuGui.gui");
    //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/gui/forms", "LiFxJoinWorldWindow.gui");
  }
  function LiFxMmoPack::path() {
    return $Con::File;
  }
};
activatePackage(LiFxMmoPack);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxMmoPack);