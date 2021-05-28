using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppLab4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentPage : ContentPage
    {
        public StudentPage()
        {
            InitializeComponent();
        }
        private void SaveStudent(object sender, EventArgs e)
        {
            var student = (Student)BindingContext;
            if (!String.IsNullOrEmpty(student.studentName))
            {
                App.Database.SaveItem(student);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteStudent(object sender, EventArgs e)
        {
            var student = (Student)BindingContext;
            App.Database.DeleteItem(student.id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
