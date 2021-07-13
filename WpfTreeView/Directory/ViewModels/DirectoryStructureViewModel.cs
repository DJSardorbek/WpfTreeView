using System.Collections.ObjectModel;
using System.Linq;

namespace WpfTreeView
{
    

    /// <summary>
    /// The view model for the application main Directory view
    /// </summary>
    public class DirectoryStructureViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// A list of all directories on the machine
        /// </summary>

        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }
        
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public DirectoryStructureViewModel()
        {
            // Get the logical drive
            var children = DirectoryStructure.GetLogicalDrives();
            //Creata view models from the data
            this.Items = new ObservableCollection<DirectoryItemViewModel>(
                             children.Select(drive => new DirectoryItemViewModel(drive.FullPath, DirectoryItemType.Drive)));
        }

        #endregion
    }
}
