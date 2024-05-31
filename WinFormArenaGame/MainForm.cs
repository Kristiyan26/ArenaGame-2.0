using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            if (args.Attacker.Name==label2.Text)
                tbAttacker = tbHeroOne;
            else
                tbAttacker = tbHeroTwo;

            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;
            
            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbHeroTwo.Text = "";
            tbHeroOne.Text = "";
            lbWinner.Visible = false;

            Hero HeroOne = CreateHero(groupBox1, groupBox2);
            Hero HeroTwo = CreateHero(groupBox3, groupBox4);

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = HeroOne,
                HeroB = HeroTwo,
                NotificationsCallBack = gameNotification
            };

            label1.Text = HeroTwo.Name;
            label2.Text = HeroOne.Name;

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }
        private Hero CreateHero(GroupBox groupBoxForHero, GroupBox groupBoxForWeapon)
        {
            IWeapon weapon = CreateWeapon(groupBoxForWeapon);
            Hero hero = null;
            foreach (Control control in groupBoxForHero.Controls)
            {
                RadioButton radioButton = control as RadioButton;
                if (radioButton.Checked)
                {
                    if (radioButton.Text == "Assassin")
                    {
                        hero = new Assassin("Assassin",15,23,weapon);
                    }
                    else if (radioButton.Text == "Dwarf")
                    {
                        hero = new Dwarf("Dwarf",18,19,weapon);
                    }
                    else if (radioButton.Text == "Gladiator")
                    {
                        hero = new Gladiator("Gladiator",23,20,weapon);
                    }
                    else if (radioButton.Text == "Knight")
                    {
                        hero = new Knight("Knight",25,15,weapon);
                    }

                }

            }
            return hero;
        }
        private IWeapon CreateWeapon(GroupBox groupBox)
        {
            IWeapon weapon = null;
            foreach (Control control in groupBox.Controls)
            {
                RadioButton radioButton = control as RadioButton;
                if (radioButton.Checked)
                {
                    if (radioButton.Text == "Spear")
                    {
                        weapon = new Spear("Spear");
                    }
                    else if (radioButton.Text == "Dagger")
                    {
                        weapon = new Dagger("Dagger");
                    }
                    else if (radioButton.Text == "Crossbow")
                    {
                        weapon = new Crossbow("Crossbow");
                    }
                    else if (radioButton.Text == "Sword")
                    {
                        weapon = new Sword("Sword");
                    }
                    else if (radioButton.Text == "Axe")
                    {
                        weapon = new Axe("Axe");
                    }

                }

            }
            return weapon;
        }





    }
}