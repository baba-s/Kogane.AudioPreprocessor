using UnityEditor;

namespace Kogane.Internal
{
    [FilePath( "ProjectSettings/Kogane/AudioPreprocessorSettings.asset", FilePathAttribute.Location.ProjectFolder )]
    internal sealed class AudioPreprocessorSettings :
        PreprocessorSettingsBase<AudioPreprocessorSettings, AudioPreprocessorSetting>
    {
    }
}