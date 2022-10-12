namespace Kogane.Internal
{
    internal sealed class AudioPreprocessorSettings :
        PreprocessorSettingsBase<AudioPreprocessorSettings, AudioPreprocessorSetting>
    {
        private const string PATH = "ProjectSettings/Kogane/AudioPreprocessorSettings.json";

        public static AudioPreprocessorSettings GetInstance( bool force = false )
        {
            return GetInstance( PATH, force );
        }

        public void Save()
        {
            SaveToJson( PATH );
        }
    }
}