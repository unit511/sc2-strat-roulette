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
        //solo strategies go here ("name", "description")
        string[] solostrats = new string[] {
        "Death by transport", "You are only allowed to make Alarak's war prisms",
        "Mech is for losers", "You are only allowed to make Nova's barracks units",
        "Covert ops", "Only spec ops ghosts and covert banshees are allowed",
        "Purification", "Only Fenix's disruptors are allowed",
        "The One Who Nukes", "Build as many ghost academies as you can afford and let the nukes rain",
        "Minefield", "Stop amon by covering everything with spider mines",
        "Laser party", "You are only allowed to make battlecruisers",
        "Science hurts", "Mass science vessel",
        "My army now", "Mass dark archon",
        "Annihilation commencing", "You are only allowed to build void rays",
        "Offesive base", "You are only allowed to use primal hives and wardens in addition to Dehaka",
        "Disco time", "Only oracles can be built",
        "Budget earthsplitter", "Only bile launchers can be made",
        "The knitting crew", "Only swarm queens can be used",
        "Old reliable", "You are only allowed to make brood queens",
        "Tickle beams", "Mass shieldguard",
        "Optics online", "Mass cyclone",
        "Power overwhelming", "Only units that have energy are allowed",
        "Top of the food chain", "Only tyrannozors can by built",
        "One woman army", "Only Nova and calldowns are allowed",
        "A problem explosives can solve", "You are only allowed to make widow mines"};
        ////party strategies go here ("name", "description")
        string[] partystrats
            = new string[] {
        "Coordinates received", "Mass wraith with support from Vorazun ally",
        "We are here in the shadows", "Both players must only make stalkers",
        "The golden armada", "Only protoss capital ships are allowed",
        "Forbidden machines", "Both players must only make colossi",
        "We move unseen", "One player plays Vorazun, only cloaked units are allowed",
        "Immortalisk", "Kerrigan masses ultralisk and abuses Artanis' passive",
        "Energy never dies", "Both players must mass archons",
        "Power overwhelming", "Only units that have energy are allowed",
        "Incoming reinforcements?", "Mass dark archon and energizer"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (in_party.Checked) //displays random party strategy
            {
                selector = 2 * rng.Next(partystrats.Length / 2);
                title.Text = partystrats[selector];
                content.Text = partystrats[selector + 1];
            }
            else //displays random one player strategy
            {
                selector = 2 * rng.Next(solostrats.Length / 2);
                title.Text = solostrats[selector];
                content.Text = solostrats[selector + 1];
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
