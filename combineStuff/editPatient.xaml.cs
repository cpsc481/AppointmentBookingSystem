﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace loginPage
{
    /// <summary>
    /// Interaction logic for editPatient.xaml
    /// </summary>
    public partial class editPatient : Window
    {
        public editPatient()
        {
            InitializeComponent();
        }

        private void editCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editSelectButton_Click(object sender, RoutedEventArgs e)
        {
            searchPatient searchPat = new searchPatient(this);
            searchPat.Show();

        }

        private void editSaveButton_Click(object sender, RoutedEventArgs e)
        {
            Patient p = new Patient(this.editFirst.Text, this.editLast.Text,
                this.editMale.IsSelected ? "M":"F", this.editAddress.Text, int.Parse(this.editArea.Text),
                int.Parse(this.editPhone.Text), this.editCountry.Text, this.editProvince.Text,
                this.editCity.Text, int.Parse(this.editMonthBox.Text), int.Parse(this.editDayBox.Text),
                int.Parse(this.editYearBox.Text), int.Parse(this.editNo.Text), this.editNotes.Text);

            var mb = MessageBox.Show(p.ToString());
            this.Close();
        }

        public void ShowPatient(Patient p)
        {
             
            this.editFirst.Text = p.firstName;
            this.editLast.Text = p.lastName;
            if (p.sex=="M") this.editMale.IsSelected=true;
            else if (p.sex=="F") this.editFemale.IsSelected=true;
            this.editAddress.Text = p.address;
            this.editArea.Text = p.areaCode.ToString("G");
            this.editPhone.Text = p.phoneNumber.ToString("G");
            this.editCountry.Text = p.country;
            this.editProvince.Text = p.province;
            this.editCity.Text = p.city;
            this.editMonthBox.Text = p.dobMM.ToString("G");
            this.editDayBox.Text = p.dobDD.ToString("G");
            this.editYearBox.Text = p.dobYYYY.ToString("G");
            this.editNo.Text = p.healthcare.ToString("G");
            this.editNotes.Text = p.notes;
              
        }


    }
}
