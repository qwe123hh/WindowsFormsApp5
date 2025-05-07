

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportsAchievementsApp
{
    public partial class Form1 : Form
    {
        DBConnection db = new DBConnection();

        public Form1()
        {
            InitializeComponent();
            LoadAthletes();
        }

        private void LoadAthletes()
        {
            comboBoxAthletes.Items.Clear();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AthleteID, LastName + ' ' + FirstName FROM Athletes", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxAthletes.Items.Add(new ComboBoxItem(reader.GetInt32(0), reader.GetString(1)));
                }
            }
        }

        private void buttonAddAthlete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Athletes (LastName, FirstName, BirthDate, Sport) VALUES (@ln, @fn, @bd, @sp)", conn);
                cmd.Parameters.AddWithValue("@ln", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@fn", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@bd", dateTimePickerBirth.Value);
                cmd.Parameters.AddWithValue("@sp", textBoxSport.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Спортсмен добавлен");
            LoadAthletes();
        }

        private void buttonAddAchievement_Click(object sender, EventArgs e)
        {
            if (comboBoxAthletes.SelectedItem is ComboBoxItem selectedItem)
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Achievements (AthleteID, EventName, Result, AchievementDate) VALUES (@aid, @ev, @res, @dt)", conn);
                    cmd.Parameters.AddWithValue("@aid", selectedItem.Id);
                    cmd.Parameters.AddWithValue("@ev", textBoxEvent.Text);
                    cmd.Parameters.AddWithValue("@res", textBoxResult.Text);
                    cmd.Parameters.AddWithValue("@dt", dateTimePickerAchieve.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Достижение добавлено");
            }
        }

        private void buttonShowAchievements_Click(object sender, EventArgs e)
        {
            listBoxAchievements.Items.Clear();
            if (comboBoxAthletes.SelectedItem is ComboBoxItem selectedItem)
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT EventName, Result, AchievementDate FROM Achievements WHERE AthleteID = @aid", conn);
                    cmd.Parameters.AddWithValue("@aid", selectedItem.Id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listBoxAchievements.Items.Add($"{reader["EventName"]} — {reader["Result"]} ({Convert.ToDateTime(reader["AchievementDate"]).ToShortDateString()})");
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}