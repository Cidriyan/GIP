﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace GIP_Programmeren
{
    /// <summary>
    /// Interaction logic for LijstLeerlingen.xaml
    /// </summary>
    public partial class LijstLeerlingen : Window
    {
        public LijstLeerlingen()
        {
            InitializeComponent();
            OpvullenListBox();
        }

        public void OpvullenListBox()
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", "Denzel");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("SELECT * from leerling");
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Leerling objLeerling = new Leerling(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt16(dr[3]), Convert.ToBoolean(dr[4]), Convert.ToBoolean(dr[5]), Convert.ToBoolean(dr[6]), Convert.ToBoolean(dr[7]));
                lstLeerlingenLijst.Items.Add(objLeerling);
            }

            conn.Close();
        }

        private void OpvullenAanwezigheidsListBox(Leerling _objLeerling)
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", "Denzel");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("SELECT * from aanwezigheidslijst where Leerling_idLeerlingen = {0}",_objLeerling.strIdnummer);
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Aanwezigheid objAanwezigheid = new Aanwezigheid(dr[0].ToString(),dr[1].ToString(),dr[2].ToString(), dr[3].ToString());
                lstLeerlingAanwezigheid.Items.Add(objAanwezigheid);
            }

            conn.Close();
        }

        private void UpdateDBStatus(String _CkStatus,Leerling _objLeerling)
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", "Denzel");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("update aanwezigheidslijst set Status_idStatus = {0} where Leerling_idLeerlingen = {1}", _CkStatus, _objLeerling.strIdnummer);
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            lstLeerlingAanwezigheid.Items.Clear();
            Leerling objLeerling = (Leerling)lstLeerlingenLijst.SelectedItem;
            OpvullenAanwezigheidsListBox(objLeerling);
        }

        private void txtZoekNaam_KeyUp(object sender, KeyEventArgs e)
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", "Denzel");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("SELECT * from leerling where LeerlingVNaam like '{0}%' ", txtZoekNaam.Text);
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            lstLeerlingenLijst.Items.Clear();
            while (dr.Read())
            {
                
                Leerling objLeerling = new Leerling(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt16(dr[3]), Convert.ToBoolean(dr[4]), Convert.ToBoolean(dr[5]), Convert.ToBoolean(dr[6]), Convert.ToBoolean(dr[7]));
                lstLeerlingenLijst.Items.Add(objLeerling);
            }

            conn.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Leerling objLeerling = (Leerling)lstLeerlingenLijst.SelectedItem;
            if (objLeerling == null)
            {
                return;
            } else
            {
                UpdateDBStatus("1", objLeerling);
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Leerling objLeerling = (Leerling)lstLeerlingenLijst.SelectedItem;
            if (objLeerling == null)
            {
                return;
            }
            else
            {
                UpdateDBStatus("2", objLeerling);
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Leerling objLeerling = (Leerling)lstLeerlingenLijst.SelectedItem;
            if (objLeerling == null)
            {
                return;
            }
            else
            {
                UpdateDBStatus("3", objLeerling);
            }
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            Leerling objLeerling = (Leerling)lstLeerlingenLijst.SelectedItem;
            if (objLeerling == null)
            {
                return;
            }
            else
            {
                UpdateDBStatus("4", objLeerling);
            }
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            rbAanwezig.IsChecked = false;
            rbTeLaat.IsChecked = false;
            rbTeLaatReden.IsChecked = false;
            rbAfwezig.IsChecked = false;
            Aanwezigheid objAanwezigheid = (Aanwezigheid)lstLeerlingAanwezigheid.SelectedItem;
            if (objAanwezigheid == null)
            {
                return;
            }
            switch (objAanwezigheid.strStatusId)
            {
                case "1":
                    rbAanwezig.IsChecked = true;
                    break;

                case "2":
                    rbTeLaat.IsChecked = true;
                    break;

                case "3":
                    rbTeLaatReden.IsChecked = true;
                    break;

                case "4":
                    rbAfwezig.IsChecked = true;
                    break;
            }
        }
    }
}
