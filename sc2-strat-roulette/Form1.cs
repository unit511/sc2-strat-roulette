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
        //strategy names go here
        string[] titles = new string[] {"Death by transport",  "Mech is for losers", "Covert ops", "Purification", "The One Who Nukes", "Minefield", "Laser party", "Science hurts", "My army now", "Annihilation commencing", "Offesive base", "Disco time", "Budget earthsplitter", "The knitting crew", "Old reliable", "Tickle beams", "Optics online"};
        //strategy descriptions go here
        string[] desc = new string[] {
        "You are only allowed to make Alarak's war prisms",
        "You are only allowed to make Nova's barracks units",
        "Only spec ops ghosts and covert banshees are allowed",
        "Only Fenix's disruptors are allowed",
        "Build as many ghost academies as you can afford and let the nukes rain",
        "Stop amon by covering everything with spider mines",
        "You are only allowed to make battlecruisers",
        "Mass science vessel",
        "Mass dark archon",
        "You are only allowed to build void rays",
        "You are only allowed to use primal hives and wardens in addition to Dehaka",
        "Only oracles can be built",
        "Only bile launchers can be made",
        "Only swarm queens can be used",
        "You are only allowed to make brood queens",
        "Mass shieldguard",
        "Mass cyclone"};
        //strategy names for party go here
        string[] party_titles = new string[] {"Coordinates received", "We are here in the shadows", "The golden armada", "Forbidden machines", "We move unseen", "Immortalisk", "Energy never dies"};
        ////strategy descriptions for party go here
        string[] party_desc = new string[] {
        "Mass wraith with support from Vorazun ally",
        "Both players must only make stalkers",
        "Only protoss capital ships are allowed",
        "Both players must only make colossi",
        "One player plays Vorazun, only cloaked units are allowed",
        "Kerrigan masses ultralisk and abuses Artanis' passive",
        "Both players must mass archons"};
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
                selector = rng.Next(party_titles.Length);
                title.Text = party_titles[selector];
                content.Text = party_desc[selector];
            }
            else //displays random one player strategy
            {
                selector = rng.Next(titles.Length);
                title.Text = titles[selector];
                content.Text = desc[selector];
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
