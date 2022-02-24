using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CourseProfileUI.ViewModels
{
    public class CourseProfileViewModel
    {
        public ObservableCollection<HomeWork> homeWorks { get; set; }

        public CourseProfileViewModel()
        {
            homeWorks = new ObservableCollection<HomeWork>()
            {
                new HomeWork { FileName = "English_speakingmeeting.docx" },
                new HomeWork { FileName = "German_writingnotes.docx" },
                new HomeWork { FileName = "German_writingnotes.docx" }
            };
        }
    }

}
