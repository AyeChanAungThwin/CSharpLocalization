using System;
using System.Windows;
using WpfLocalicationProject.Properties;

namespace WpfLocalicationProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            //loadLanguage(Properties.Language.Myanmar);
            InitializeComponent();
        }

        private void loadLanguage(Language language)
        {
            // Remove MergedDictionaries
            Application.Current.Resources.MergedDictionaries.Clear();

            // Add your application-wide resources if needed
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri($"pack://application:,,,/WpfLocalicationProject;component/Resources/Strings.{language.ToString()}.xaml") });
        }

        private void MenuEnglish_Click(object sender, RoutedEventArgs e)
        {
            loadLanguage(Properties.Language.English);
        }
        
        private void MenuMyanmar_Click(object sender, RoutedEventArgs e)
        {
            loadLanguage(Properties.Language.Myanmar);
        }
        
        private void MenuKorean_Click(object sender, RoutedEventArgs e)
        {
            loadLanguage(Properties.Language.Korean);
        }
    }
}