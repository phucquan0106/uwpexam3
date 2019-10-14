using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using uwpexam3.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpexam3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        private FileService fileService;

        public HomePage()
        {
            this.InitializeComponent();
            fileService = new FileService();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            string contenText = ContentText.Text;
            var dateTime = DateTime.Now;
            var year = dateTime.Year;
            var month = dateTime.Month;
            var day = dateTime.Day;
            var hour = dateTime.TimeOfDay.Hours;
            var min = dateTime.TimeOfDay.Minutes;
            string fileName = year + "-" + month + "-" + day + "-" + hour + "-" + min + ".txt";
            fileService.WriteIntoTxtFile(contenText,fileName);
            ContentSave.Text = "Noi dung file "+ fileName+ " vua submit: "+fileService.ReadFromTxtFile(fileName);
        }

        
        private void ButtonList_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
