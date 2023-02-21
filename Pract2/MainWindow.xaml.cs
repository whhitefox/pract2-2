using System;
using System.Collections.Generic;
using System.Windows;

namespace Pract2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zametka> zametki;
        List<Zametka> curerentZametki;  

        public MainWindow()
        {
            InitializeComponent();
            zametki = Serializer.Load<List<Zametka>>("zametki.json");
            if (zametki == null)
            {
                zametki = new List<Zametka>();
            }
            DatePicker.Text = DateTime.Now.ToShortDateString();
            UpdateZametkiList();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(DatePicker.Text);
            string name = NameBox.Text;
            string description = DescriptionBox.Text;

            Zametka zametka = new Zametka(name, description, date);
            zametki.Add(zametka);
            Serializer.Save(zametki, "zametki.json");

            UpdateZametkiList();
        }

        private void UpdateZametkiList()
        {
            DateTime date = Convert.ToDateTime(DatePicker.Text);
            curerentZametki = zametki.FindAll((zametka) => zametka.date == date);
            List<string> names = new List<string>();
            foreach (Zametka zametka in curerentZametki)
            {
                names.Add(zametka.name);
            }
            ZametkiList.ItemsSource = names;
        }

        private void ZametkiList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ZametkiList.SelectedIndex != -1)
            {
                Zametka zametka = curerentZametki[ZametkiList.SelectedIndex];
                NameBox.Text = zametka.name;
                DescriptionBox.Text = zametka.description;
            }
            else
            {
                NameBox.Text = "";
                DescriptionBox.Text = "";
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            UpdateZametkiList();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ZametkiList.SelectedIndex != -1)
            {
                string name = NameBox.Text;
                string description = DescriptionBox.Text;
                Zametka zametka = curerentZametki[ZametkiList.SelectedIndex];

                zametka.name = name;
                zametka.description = description;

                Serializer.Save(zametki, "zametki.json");

                UpdateZametkiList();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ZametkiList.SelectedIndex != -1)
            {
                Zametka zametka = curerentZametki[ZametkiList.SelectedIndex];

                zametki.Remove(zametka);

                Serializer.Save(zametki, "zametki.json");

                UpdateZametkiList();
            }
        }
    }
}
