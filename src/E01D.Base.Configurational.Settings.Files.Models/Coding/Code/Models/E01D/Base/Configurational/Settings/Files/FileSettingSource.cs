using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings.Files
{
    public class FileSettingSource: FileSettingSource_I
    {
        /// <summary>
        /// The absolute path to the file.
        /// </summary>
        public AbsoluteFilePath AbsolutePath { get; set; }

        /// <summary>
        /// Determines if loading the file is optional.
        /// </summary>
        public bool LoadingIsOptional { get; set; }


        /// <summary>
        /// Determines whether the source will be loaded if the underlying file changes.
        /// </summary>
        public bool ReloadOnChange { get; set; }

        /// <summary>
        /// The relative path to the file.
        /// </summary>
        public RelativeFilePath RelativeFilePath { get; set; }

        /// <summary>
        /// Number of milliseconds that reload will wait before calling Load.  This helps
        /// avoid triggering reload before a file is completely written. Default is 250.
        /// </summary>
        public int ReloadDelay { get; set; } = 250;


        
    }
}
