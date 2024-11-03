using Interfaces.OrganisationItems;
using SettingsManager;
using SharedData.Enums;

namespace SaveToGameWpf.Logic.OrganisationItems
{
    public class AppSettings : SettingsModel, IAppSettings
    {
        public virtual string Language { get; set; } = "EN";

        public virtual BackupType BackupType { get; set; } = BackupType.Folder;

        public virtual string PopupMessage { get; set; } = "Modified by SaveToGame";

        public virtual string Theme { get; set; } = "Light";

        public virtual bool AlternativeSigning { get; set; }

        public virtual bool Notifications { get; set; } = true;

        public virtual int Version { get; set; } = GlobalVariables.LatestSettingsVersion;

        public virtual string ModId { get; set; } = "";

        public virtual int ModVersion { get; set; } = 1;

        public virtual bool OverwriteLegacy { get; set; } = true;
    }
}
