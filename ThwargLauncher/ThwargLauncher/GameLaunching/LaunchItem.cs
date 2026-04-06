using System;

namespace ThwargLauncher
{
    /// <summary>
    /// Info for one game launch
    /// </summary>
    public class LaunchItem
    {
        public string Alias;
        public string AccountName;
        public string Priority;
        public string Password;
        public string IpAndPort;
        public string ServerName;
        public string GameApiUrl;
        public string LoginServerUrl;
        public string DiscordUrl;
        public ServerModel.ServerEmuEnum EMU;
        public string CharacterSelected;
        public ServerModel.RodatEnum RodatSetting;
        public ServerModel.SecureEnum SecureSetting;
        public string CustomLaunchPath;
        public string CustomPreferencePath;
        public bool IsSimpleLaunch;
        /// <summary>Stable id for per-server dat cache and shadow client folder.</summary>
        public Guid ServerId;
        /// <summary>Optional override for DatCache location (advanced).</summary>
        public string DatCacheFolderOverride;
    }
}
