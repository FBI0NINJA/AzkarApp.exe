using System;
using System.Diagnostics;
using System.Windows;
using Microsoft.Win32;
using System.Reflection;

namespace AzkarApp
{
    public partial class MainWindow : Window
    {
        int count = 0;

        string[] duas =
       {
            "اللهم بك أصبحنا وبك أمسينا وبك نحيا وبك نموت وإليك النشور",
            "اللهم إني أسألك خير هذا اليوم وخير ما بعده",
            "اللهم اغفر لي ولوالدي وللمؤمنين يوم يقوم الحساب",
            "اللهم ارزقني رزقاً حلالاً طيباً مباركاً فيه",
            "اللهم اجعل هذا اليوم بداية خير وبركة"
        };
        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();
            int index = rnd.Next(duas.Length);

            MessageBox.Show(duas[index], "دعاء اليوم");
        }

        void AddToStartup()
        {
            string appName = "AzkarApp";
            string path = Assembly.GetExecutingAssembly().Location;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            key.SetValue(appName, path);
        }

        private void Tasbeeh_Click(object sender, RoutedEventArgs e)
        {
            count++;
            CounterText.Text = count.ToString();
        }


        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            CounterText.Text = "0";
        }


        //ضع روابط
        string facebookLink = "https://www.facebook.com/ninjafbi1";
        string githubLink = "https://github.com/FBI0NINJA";

        private void Facebook_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(facebookLink) { UseShellExecute = true });
        }

        private void Github_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(githubLink) { UseShellExecute = true });
        }
    }
}