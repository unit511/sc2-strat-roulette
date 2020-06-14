using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sc2_strat_roulette
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int selector = 0;
        int prev_selector = -1;
        int limiter = 0;
        List<Strategy> singleplayer = new List<Strategy>();
        List<Strategy> party = new List<Strategy>();
        public Form1()
        {
            InitializeComponent();
            DataLoader();
        }
        private void DataLoader()
        {
            //strategies for a single player go here, paste the following and modify the values:
            //singleplayer.Add(new Strategy("title here", "description here"));
            singleplayer.Add(new Strategy("Death by transport", "You are only allowed to make Alarak's war prisms"));
            singleplayer.Add(new Strategy("Mech is for losers", "You are only allowed to make Nova's barracks units"));
            singleplayer.Add(new Strategy("Covert ops", "Only spec ops ghosts and covert banshees are allowed"));
            singleplayer.Add(new Strategy("Purification", "Only Fenix's disruptors are allowed"));
            singleplayer.Add(new Strategy("The One Who Nukes", "Build as many ghost academies as you can afford and let the nukes rain"));
            singleplayer.Add(new Strategy("Minefield", "Stop amon by covering everything with spider mines"));
            singleplayer.Add(new Strategy("Laser party", "You are only allowed to make battlecruisers"));
            singleplayer.Add(new Strategy("Science hurts", "Mass science vessel"));
            singleplayer.Add(new Strategy("My army now", "Mass dark archon"));
            singleplayer.Add(new Strategy("Annihilation commencing", "You are only allowed to build void rays"));
            singleplayer.Add(new Strategy("Offesive base", "You are only allowed to use primal hives and wardens in addition to Dehaka"));
            singleplayer.Add(new Strategy("Disco time", "Only oracles can be built"));
            singleplayer.Add(new Strategy("Budget earthsplitter", "Only bile launchers can be made"));
            singleplayer.Add(new Strategy("The knitting crew", "Only swarm queens can be used"));
            singleplayer.Add(new Strategy("Protectors of the brood", "You are only allowed to make brood queens"));
            singleplayer.Add(new Strategy("Tickle beams", "Mass shieldguard"));
            singleplayer.Add(new Strategy("Optics online", "Mass cyclone"));
            singleplayer.Add(new Strategy("Power overwhelming", "Only units that have energy are allowed"));
            singleplayer.Add(new Strategy("Top of the food chain", "Only tyrannozors can by built"));
            singleplayer.Add(new Strategy("One woman army", "Only Nova and calldowns are allowed"));
            singleplayer.Add(new Strategy("A problem explosives can solve", "You are only allowed to make widow mines"));
            //strategies for a 2 player party go here, paste the following and modify the values:
            //party.Add(new Strategy("title here", "description here"));
            party.Add(new Strategy("Coordinates received", "Mass wraith with support from Vorazun ally"));
            party.Add(new Strategy("We are here in the shadows", "Both players must only make stalkers"));
            party.Add(new Strategy("The Golden Armada", "Only protoss capital ships are allowed"));
            party.Add(new Strategy("Skyscrapers of Destruction", "Both players must only make colossi (and wrathwalkers)"));
            party.Add(new Strategy("We move unseen", "One player plays Vorazun, only cloaked units are allowed"));
            party.Add(new Strategy("Immortalisk", "Kerrigan masses ultralisk and abuses Artanis' passive"));
            party.Add(new Strategy("Energy never dies", "Both players must mass (dark) archons"));
            party.Add(new Strategy("Power overwhelming", "Only units that have energy are allowed"));
            party.Add(new Strategy("Incoming reinforcements?", "Mass dark archon and energizer"));
            party.Add(new Strategy("Tickle beams", "Only shieldguards, energizers and conservators are allowed"));
            party.Add(new Strategy("The knitting crew", "Olny Kerrigan's and Zagara's queens are allowed"));
            party.Add(new Strategy("Blades of the Nerazim", "Both player must mass Dark Templar and Void templar"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (in_party.Checked) //displays random party strategy
            {
                limiter = 0;
                do
                {
                    selector = rng.Next(party.Count);
                    limiter++;
                } while (selector == prev_selector && limiter < 10);
                prev_selector = selector;
                title.Text = party[selector].title;
                content.Text = party[selector].description;
            }
            else //displays random one player strategy
            {
                limiter = 0;
                do
                {
                    selector = rng.Next(singleplayer.Count);
                    limiter++;
                } while (selector == prev_selector && limiter < 10);
                prev_selector = selector;
                title.Text = singleplayer[selector].title;
                content.Text = singleplayer[selector].description;
            }
        }

        private void in_party_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void content_Click(object sender, EventArgs e)
        {

        }
    }
}
