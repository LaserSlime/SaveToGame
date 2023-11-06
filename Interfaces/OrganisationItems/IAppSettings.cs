using System.ComponentModel;
using SharedData.Enums;

namespace Interfaces.OrganisationItems
{
    public interface IAppSettings : INotifyPropertyChanged
    {
        string Language { get; set; }

        BackupType BackupType { get; set; }

        string PopupMessage { get; set; }

        string Theme { get; set; }

        bool AlternativeSigning { get; set; }

        bool Notifications { get; set; }

        int Version { get; set; }

        bool StringEncryption { get; set; }

        string ModName { get; set; }

        string ModVersion { get; set; }
    }
}