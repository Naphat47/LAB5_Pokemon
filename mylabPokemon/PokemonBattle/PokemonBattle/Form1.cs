using PokemonBattle.pokemons;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Ivysaur());
            pokemons.Add(new Venusaur());
            pokemons.Add(new Charmander());
            pokemons.Add(new Charmeleon());

            this.monster = new Caterpie();
            this.pictureBox2.Image = this.monster.getImage();
            this.tbNameEnemy.Text = monster.getName();
            this.tbHPEnemy.Text = monster.getHP().ToString(); //ToString (KeyWord)
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Can't fight");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Can't fight");
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int atk = Math.Abs(this.monster.getDefense() - this.selectedPokemon.getAttack());
            this.monster.takeDamage(atk);
            this.tbHPEnemy.Text = monster.getHP().ToString();
            if (monster.getHP() <= 0)
            {
                MessageBox.Show("WINNER CHICKEN DINNER");
                Application.Exit();
            }
            //this display data
        }



        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int atk = Math.Abs(this.selectedPokemon.getDefense() - this.monster.getAttack());
            this.selectedPokemon.takeDamage(atk);
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Please Change Pokemon");
            }
            
            //this display data
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Can't fight");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Can't fight");
                this.Close();
                return;
            }
        }
    }
}