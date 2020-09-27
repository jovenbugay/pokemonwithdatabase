using MySql.Data.MySqlClient;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string connectionString = "datasource=localhost;port=3306;username=root;password=;database=test;";
        User currUser = null;

        public MainWindow()
        {
            InitializeComponent();
            listUsers();


        }
         
        class User
        {
            public int Id { get; set; }
            public string pokemon_name { get; set; }
            public int pokemon_lvl { get; set; }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (listView.SelectedIndex > -1)
            {
                currUser = (User)listView.SelectedItem;
                btnEdit.IsEnabled = true;
                btnDelete.IsEnabled = true;
                txtid.Text = currUser.Id.ToString();
                txtpokemonname.Text = currUser.pokemon_name;
                txtpokemonlevel.Text = currUser.pokemon_lvl.ToString();
            }
            else {
                currUser = null;
                btnEdit.IsEnabled = false;
                btnDelete.IsEnabled = false;
                txtid.Text = "";
                txtpokemonname.Text = "";
                txtpokemonlevel.Text = "";
            }

        }
        private void listUsers()
        {
            listView.Items.Clear();

            string query = "SELECT * FROM tbl_pokemon";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Success, now list 

                // If there are available rows
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User _tmpUser = new User { Id = reader.GetInt32(0), pokemon_name = reader.GetString(1), pokemon_lvl = reader.GetInt32(2) };
                        listView.Items.Add(_tmpUser);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO tbl_pokemon(`pokemon_name`, `pokemon_lvl`) VALUES (@POKEMON_NAME, @POKEMON_LVL)";
         

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.AddWithValue("@POKEMON_NAME", txtpokemonname.Text);
            commandDatabase.Parameters.AddWithValue("@POKEMON_LVL", txtpokemonlevel.Text);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listUsers();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Delete the item with ID 1
            string query = "DELETE FROM `tbl_pokemon` WHERE id = @ID";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.AddWithValue("@ID", Convert.ToInt32(txtid.Text));
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully deleted

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listUsers();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            // Update the properties of the row with ID 1
            string query = "UPDATE `tbl_pokemon` SET `pokemon_name`=@POKEMON_NAME,`pokemon_lvl`=@POKEMON_LVL WHERE id = @ID";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.Parameters.AddWithValue("@ID", Convert.ToInt32(txtid.Text));
            commandDatabase.Parameters.AddWithValue("@POKEMON_NAME", txtpokemonname.Text);
            commandDatabase.Parameters.AddWithValue("@POKEMON_LVL", Convert.ToInt32(txtpokemonlevel.Text));
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully updated

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listUsers();
            }
        }
    }
}
