using Football.Business;
using Football.Data.Models;
using System.Xml.Linq;

namespace WinFormsFootball
{
    public partial class Form1 : Form
    {

        private NationalityBusiness nationalityBusiness = new NationalityBusiness();
        private couchBusiness couchBusiness = new couchBusiness();
        private LeagueBusiness leagueBusiness = new LeagueBusiness();
        private PlayerBusiness playerBusiness = new PlayerBusiness();
        private PlayerTeamBusiness playerTeamBusiness = new PlayerTeamBusiness();
        private teamBusiness teamBusiness = new teamBusiness();

        private int editID = 0;
        public int flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void hideobj()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label7.Hide();
            button4.Hide();
            button2.Hide();
            button3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            dataGridView1.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hideobj();
        }
        private void UpdateGridnat()
        {

            dataGridView1.DataSource = nationalityBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UpdateGridleag()
        {
            dataGridView1.DataSource = leagueBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateGridteam()
        {

            dataGridView1.DataSource = teamBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateGridplayer()
        {

            dataGridView1.DataSource = playerBusiness.GetAll();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateGridplayert()
        {


            dataGridView1.DataSource = playerTeamBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateGridcoach()
        {
            dataGridView1.DataSource = couchBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        public void nationShow()
        {
            UpdateGridnat();
            ClearTextBoxes();
        }
        public void LeagueShow()
        {
            UpdateGridleag();
            ClearTextBoxes();
        }
        public void PlayerShow()
        {
            UpdateGridplayer();
            ClearTextBoxes();
        }
        public void PlayerteamShow()
        {
            UpdateGridplayert();
            ClearTextBoxes();
        }
        public void CoachShow()
        {
            UpdateGridcoach();
            ClearTextBoxes();
        }
        public void TeamShow()
        {
            UpdateGridteam();
            ClearTextBoxes();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Text = "ID";
            label1.Visible = true;
            label2.Text = "Name";
            label2.Visible = true;
            label3.Text = "BestPlayer";
            label3.Visible = true;
            label4.Hide();
            label5.Hide();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            button4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            flag = 1;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries");
            comboBox1.Items.Add("Add new entry");
            comboBox1.Items.Add("Update entry");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Delete entry by ID");
            comboBox1.Items.Add("exit");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Text = "ID";
            label1.Visible = true;
            label2.Text = "Name";
            label2.Visible = true;
            label3.Text = "TeamID";
            label3.Visible = true;
            label4.Text = "NationalityID";
            label4.Visible = true;
            label5.Hide();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Hide();
            button4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            flag = 2;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries");
            comboBox1.Items.Add("Add new entry");
            comboBox1.Items.Add("Update entry");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Delete entry by ID");
            comboBox1.Items.Add("exit");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Text = "ID";
            label1.Visible = true;
            label2.Text = "PlayersID";
            label2.Visible = true;
            label3.Text = "TeamID";
            label3.Visible = true;
            label4.Text = "Salary";
            label4.Visible = true;
            label5.Text = "Months active";
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            flag = 3;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries");
            comboBox1.Items.Add("Add new entry");
            comboBox1.Items.Add("Update entry");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Delete entry by ID");
            comboBox1.Items.Add("exit");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Text = "ID";
            label1.Visible = true;
            label2.Text = "Name";
            label2.Visible = true;
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            button4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            flag = 4;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries");
            comboBox1.Items.Add("Add new entry");
            comboBox1.Items.Add("Update entry");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Delete entry by ID");
            comboBox1.Items.Add("exit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Text = "ID";
            label1.Visible = true;
            label2.Text = "Name";
            label2.Visible = true;
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            flag = 5;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries");
            comboBox1.Items.Add("Add new entry");
            comboBox1.Items.Add("Update entry");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Delete entry by ID");
            comboBox1.Items.Add("exit");


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Text = "ID";
            label1.Visible = true;
            label2.Text = "Name";
            label2.Visible = true;
            label3.Text = "LeagueID";
            label3.Visible = true;
            label4.Text = "CoachesID";
            label4.Visible = true;
            label5.Text = "Trophies";
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            flag = 6;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries");
            comboBox1.Items.Add("Add new entry");
            comboBox1.Items.Add("Update entry");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Delete entry by ID");
            comboBox1.Items.Add("exit");
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                nationShow();
            }
            if (flag == 2)
            {
                PlayerShow();
            }
            if (flag == 3)
            {
                PlayerteamShow();
            }
            if (flag == 4)
            {
                LeagueShow();
            }
            if (flag == 5)
            {
                CoachShow();
            }
            if (flag == 6)
            {
                TeamShow();
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                int bestpl = int.Parse(textBox1.Text);


                Nationality nationality = new Nationality();
                nationality.Id = ID;
                nationality.Name = name;
                nationality.BestPlayer = bestpl;

                nationalityBusiness.Add(nationality);
                UpdateGridnat();
                //   ClearTextBoxes();
            }
            if (flag == 5)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;


                Coach coach = new Coach();
                coach.Id = ID;
                coach.Name = name;

                couchBusiness.Add(coach);
                UpdateGridcoach();
                //   ClearTextBoxes();
            }
            if (flag == 2)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                int team_id = int.Parse(textBox3.Text);
                int nationality_id = int.Parse(textBox4.Text);


                Player player = new Player();
                player.Id = ID;
                player.Name = name;
                player.TeamId = team_id;
                player.NationalityId = nationality_id;

                playerBusiness.Add(player);
                UpdateGridplayer();
                //   ClearTextBoxes();
            }
            if (flag == 3)
            {
                int ID = int.Parse(textBox1.Text);
                int players_id = int.Parse(textBox2.Text);
                int team_id = int.Parse(textBox3.Text);
                int salary = int.Parse(textBox4.Text);
                int months_active = int.Parse(textBox5.Text);


                PlayerTeam playerteam = new PlayerTeam();
                playerteam.Id = ID;
                playerteam.PlayersId = players_id;
                playerteam.TeamId = team_id;
                playerteam.Salary = salary;
                playerteam.MonthsActive = months_active;

                playerTeamBusiness.Add(playerteam);
                UpdateGridplayert();
                //   ClearTextBoxes();
            }
            if (flag == 4)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;


                League league = new League();
                league.Id = ID;
                league.Name = name;

                leagueBusiness.Add(league);
                UpdateGridleag();
                //   ClearTextBoxes();
            }
            if (flag == 6)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                int league_id = int.Parse(textBox3.Text);
                int coaches_id = int.Parse(textBox4.Text);
                int trophies = int.Parse(textBox5.Text);

                Team team = new Team();
                team.Id = ID;
                team.Name = name;
                team.LeagueId = league_id;
                team.CoachesId = coaches_id;
                team.Trophies = trophies;

                teamBusiness.Add(team);
                UpdateGridteam();
                //   ClearTextBoxes();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                int bestpl = int.Parse(textBox3.Text);


                Nationality nationality = new Nationality();
                nationality.Id = ID;
                nationality.Name = name;
                nationality.BestPlayer = bestpl;

                nationalityBusiness.Update(nationality);
                UpdateGridnat();
            }
            if (flag == 5)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;


                Coach coach = new Coach();
                coach.Id = ID;
                coach.Name = name;

                couchBusiness.Update(coach);
                UpdateGridcoach();
                //   ClearTextBoxes();
            }
            if (flag == 2)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                int team_id = int.Parse(textBox3.Text);
                int nationality_id = int.Parse(textBox4.Text);


                Player player = new Player();
                player.Id = ID;
                player.Name = name;
                player.TeamId = team_id;
                player.NationalityId = nationality_id;

                playerBusiness.Update(player);
                UpdateGridplayer();
                //   ClearTextBoxes();
            }
            if (flag == 3)
            {
                int ID = int.Parse(textBox1.Text);
                int players_id = int.Parse(textBox2.Text);
                int team_id = int.Parse(textBox3.Text);
                int salary = int.Parse(textBox4.Text);
                int months_active = int.Parse(textBox5.Text);


                PlayerTeam playerteam = new PlayerTeam();
                playerteam.Id = ID;
                playerteam.PlayersId = players_id;
                playerteam.TeamId = team_id;
                playerteam.Salary = salary;
                playerteam.MonthsActive = months_active;

                playerTeamBusiness.Update(playerteam);
                UpdateGridplayert();
                //   ClearTextBoxes();
            }
            if (flag == 4)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;


                League league = new League();
                league.Id = ID;
                league.Name = name;

                leagueBusiness.Update(league);
                UpdateGridleag();
                //   ClearTextBoxes();
            }
            if (flag == 6)
            {
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                int league_id = int.Parse(textBox3.Text);
                int coaches_id = int.Parse(textBox4.Text);
                int trophies = int.Parse(textBox5.Text);

                Team team = new Team();
                team.Id = ID;
                team.Name = name;
                team.LeagueId = league_id;
                team.CoachesId = coaches_id;
                team.Trophies = trophies;

                teamBusiness.Update(team);
                UpdateGridteam();
                //   ClearTextBoxes();
            }

            // ResetSelect(); 

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                int ID = int.Parse(textBox1.Text);


                Nationality nationality = new Nationality();
                nationality.Id = ID;

                nationalityBusiness.Delete(ID);
                UpdateGridnat();
            }
            if (flag == 5)
            {
                int ID = int.Parse(textBox1.Text);
 


                Coach coach = new Coach();
                coach.Id = ID;
                

                couchBusiness.Delete(ID);
                UpdateGridcoach();
                //   ClearTextBoxes();
            }
            if (flag == 2)
            {
                int ID = int.Parse(textBox1.Text);
               


                Player player = new Player();
                player.Id = ID;
                

                playerBusiness.Delete(ID);
                UpdateGridplayer();
                //   ClearTextBoxes();
            }
            if (flag == 3)
            {
                int ID = int.Parse(textBox1.Text);


                PlayerTeam playerTeam = new PlayerTeam();
                playerTeam.Id = ID;

                playerTeamBusiness.Delete(ID);
                UpdateGridplayert();
            }

            if (flag == 4)
            {
                int ID = int.Parse(textBox1.Text);


                League league = new League();
                league.Id = ID;

                leagueBusiness.Delete(ID);
                UpdateGridleag();
                //   ClearTextBoxes();
            }
            if (flag == 6)
            {
                int ID = int.Parse(textBox1.Text);

                Team team = new Team();
                team.Id = ID;
         
                teamBusiness.Delete(ID);
                UpdateGridteam();
                //   ClearTextBoxes();
            }

            // ResetSelect(); 

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                int ID = int.Parse(textBox1.Text);


                Nationality nationality = new Nationality();
                //nationality.Id = ID;
                

                nationality = nationalityBusiness.Get(ID);
                textBox2.Text = nationality.Name;
                textBox3.Text = nationality.BestPlayer+"";

                UpdateGridnat();
            }

        }
    }
}

