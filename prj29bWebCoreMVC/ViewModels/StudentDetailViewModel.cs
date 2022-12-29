using prj29bWebCoreMVC.Models;

namespace prj29bWebCoreMVC.ViewModels
{
    public class StudentDetailViewModel
    {
        public Student Student { get; set; }
        public Address Address { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
    }
}
