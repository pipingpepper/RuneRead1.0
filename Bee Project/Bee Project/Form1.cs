using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee_Project_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InittializeMyButton()
        {
            Button readButton = new Button();
            readButton.DialogResult = DialogResult.OK;
            Controls.Add(readButton);

            Button runePic = new Button();
            runePic.DialogResult = DialogResult.OK;
            Controls.Add(runePic);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            string[] Runes = { "Fehu", "Uruz", "Thurisaz", "Ansuz", "Raidho", "Kenaz", "Gebo", "Wunjo", "Hagalaz", "Nauthiz", "Isa", "Jera", "Eihwaz", "Perthro", "Algiz", "Sowilo", "Tiwaz", "Berkana", "Ehwaz", "Mannaz", "Laguz", "Ingwaz", "Othala", "Dagaz" };

            List<string> Runelist = new List<string>();
            List<Image> imgs = new List<Image>();
            List<string> Names = new List<string>();

            Runelist.AddRange(Runes);
            string debug = "";
            Random rand = new Random();

            var index = rand.Next(Runelist.Count);
            debug += Runelist[index] + "\n";
            Names.Add(Runelist[index]);
            imgs.Add(Image.FromFile(@"..\..\..\..\Runes\" + Runelist[index] + ".png"));


            runePic.BackgroundImage = imgs[0];
            runePic.BackgroundImageLayout = ImageLayout.Stretch;


            if (Names[0] == "Fehu")
            {
                label1.Text = "The first of the Elder Futhark, Fehu indicates prosperity and material wealth, either won or earned income.\nIt can represent good luck, abundance and financial success in the near future.\n It can also relate to social success.\n Not everyone chooses to read a rune as reversed (“merkstave”) if it comes up that way,\n but if doing so resonates with you- its reversed meaning may indicate the loss of personal possessions or income,\n a dip in self-esteem or some other kind of material struggles.\n KEYWORDS: Abundance, luck, hope, prosperity, wealth, fortune";

            }
            else if (Names[0] == "Uruz")
            {
                label1.Text = "The second, Uruz, is representative of the wild bull.\n This is a stone of strength, endurance, hard work, perseverance, motivation, and determination.\n It can indicate a time of great energy, speed and health.\n It also shows increasing power and masculinity.\n Reversed, it may indicate a loss of health, endurance, a blockage, dominance of others over you or misdirected force.\nKEYWORDS: Strength, endurance, health, courage, vigour, vitality, force, perseverance";
            }
            else if (Names[0] == "Thurisaz")
            {
                label1.Text = "This represents Thor’s hammer or a giant.\n As such, it indicates a powerful direction of energy and force, for either destruction or defence, so may also indicate conflict. This could be cathartic, cleansing and purgative.\n Reversed, it could mean defencelessness, compulsion, spite or betrayal.\nKEYWORDS: Defence, challenge, danger, protection, attack, strength";
            }
            else if (Names[0] == "Ansuz")
            {
                label1.Text = "Ansuz is the rune of communication.\n It’s representative of the ancestral God Odin’s wisdom and so indicates a divine message or insight arriving.\n It can also mean good advice, wisdom, truth, inspiration and enthusiasm.\n Reversed it could point to a miscommunication, deceit, misunderstandings and manipulation.\nKEYWORDS: Revelation, signs, visions, insight, message, knowledge, communication";
            }
            else if (Names[0] == "Raidho")
            {
                label1.Text = "Raidho is indicative of a journey and represents a wheel.\n This could be both physical travel, as in a holiday or house move,\n or a spiritual voyage in the expansion of your horizons.\n It can also indicate things being put into perspective, evolution and the cycle of life.\n Reversed it means rigidity, injustice, irrationality and disruption.\nKEYWORDS: Progress, movement, evolution, perspective, journey, travel";
            }
            else if (Names[0] == "Kenaz")
            {
                label1.Text = "Kenaz is the flame or torch.\n As such, it represents the beacon of truth and finding your true north guided by your own shining light.\n It can indicate that that which was previously unknown may come to light,\n secrets may be spilled, and you are on the right path of finding your true calling in life.\n It also means knowledge, creativity, inspiration, vitality, regeneration and energy.\n Reversed it can indicate that you lack vision, are stuck in a creative rut, false hope, and instability.\nKEYWORDS: Enlightenment, knowledge, comprehension, insight, illumination, calling, purpose, idea";
            }
            else if (Names[0] == "Gebo")
            {
                label1.Text = "Gebo is the rune of gifts.\n It’s a positive symbol that indicates you are in the possession of many gifts and talents or that someone will bestow upon you bountiful blessings.\n It also relates to generosity, balance, and positive relationships.\n It has no inverted meaning.\nKEYWORDS: Generosity, partnership, gifts, talents, charity, service, assistance, luck, fortune";
            }
            else if (Names[0] == "Wunjo")
            {
                label1.Text = "Wunjo is representative of the clan’s flag and victory.\n It represents triumph and joy, security, safety, celebration and belonging.\n It can also indicate harmony, prosperity and spiritual rewards.\n Reversed it can point to sorrow, alienation and loss.\nKEYWORDS: Pleasure, joy, feast, celebration, comfort, belonging, community, success, festivities";
            }
            else if (Names[0] == "Hagalaz")
            {
                label1.Text = "Hagalaz represents hail.\n This natural form of disaster which strikes out of the blue and has the power to destroy much needed crops, is similarly indicative of sudden and cataclismic change.\n Similar to The Tower card in the tarot, Hagalaz represents an unavoidable change that is out of our hands,\n but how destructive it ends up being is dependant on whether we are capable of weathering its storm with grace.\n As they say, some storms come to clear our path. The lesson of Hagalaz is to learn from our hardships and grow through our mistakes.\n It has no inverted meaning.\nKEYWORDS: Destruction, natural wrath, uncontrolled forces, testing, change, external input";
            }
            else if (Names[0] == "Nauthiz")
            {
                label1.Text = "Nauthiz is indicative of our needs.\n What do you need to feel emotionally stable and fulfilled?\n Are you taking enough time for yourself to balance work, play and rest?\n Assessing what are our needs and where we may currently be lacking can help us take better care of our future selves, we can’t pour form an empty cup after all.\n It can also indicate delays, restriction, and endurance. This is a time to practice patience.\n Nauthiz reversed can point to depression, exhaustion, and distress.\nKEYWORDS: Need, restriction, disagreements, resistance, survival, necessity, lacking";
            }
            else if (Names[0] == "Isa")
            {
                label1.Text = "Isa represents ice. It’s symbolic of the Hangman card in the Tarot.\n It highlights the need to pause, wait, although there may be a feeling of being stuck in ice, sometimes a break is what’s needed to put things into perspective.\n Waiting until we have gathered all the information, all sides of the story, properly done our research, or simply allowed the Universe to unfold.\n It can also indicate frustration or psychological blocks. Isa has no inverted meaning.\nKEYWORDS: Suspension, delay, stillness, frustration, blocks, pause, waiting";
            }
            else if (Names[0] == "Jera")
            {
                label1.Text = "Jera is representative of the harvest. It indicates that we can now reap what we’ve sown and enjoy our plentiful abundance.\n If you don’t feel like you have many blessings, it can show that either a breakthrough is on the way, or it’s time to take stock and express gratitude for what you do have.\n It also represents the life cycle and cyclic nature of Mother Earth. It cannot be reversed.\nKEYWORDS: Year, conclusion, harvest, life cycle, endings and beginnings, abundance, learnings, growth";
            }
            else if (Names[0] == "Eihwaz")
            {
                label1.Text = "In Norse mythology, the ash tree (sometimes said to be translated from the old word for yew- needle ash), Yggradisil, is representative of The Tree Of Life.\n As such, it relates to the cycle of life, similar to the Death Tarot card (signifying the dying of an old way of being or period of life).\n It can also represent reliability, dependability, trustworthiness, enlightenment, and a sense of purpose, symbolising the connection between all the worlds.\n Reversed, it can mean confusion and isolation.\nKEYWORDS: Connection, inspiration, endurance, sacred knowledge, protection, life cycle’s, divinity";
            }
            else if (Names[0] == "Perthro")
            {
                label1.Text = "This is the gambler’s rune and as such represents the cup of dice, or fortune.\n It indicates that influences in life may be down to chance, and so can go either well or not.\n The lesson here is to learn to take the hand you’ve been dealt and make lemonade out of lemons.\n In Tarot, this is would be similar to the Wheel of Fortune card.\n It can also represent hidden meanings, secrets, and change. \nReversed it can indicate stagnation and loss of faith.\nKEYWORDS: Fate, mysteries, occult, feminine fertility, chance, fortune, mysticism, unknown";
            }
            else if (Names[0] == "Algiz")
            {
                label1.Text = "Algiz is the elk, and so represents defence and protection.\n If you get this one, it means that you have the internal power to manifest your dreams and that your spirit guides are protecting you along your path.\n It is said to act as a shield to guard you against evil. It can also represent an awakening and strong intuition. \nReversed it means there could be a hidden danger.\nKEYWORDS: Protection, guardian, awakening, courage, defence, instincts";
            }
            else if (Names[0] == "Sowilo")
            {
                label1.Text = "Sowilo is the happy symbol of the sun.\n It represents a time of joy, abundance, luck, and good fortune.\n It’s a cause for celebration and can indicate a success of your goals, optimal health and an elemental power. \nIt has no inverted meaning. In Tarot, its card is, likewise, The Sun.\nKEYWORDS: Success, vitality, inspiration, justice, success, joy, happiness, abundance";
            }
            else if (Names[0] == "Tiwaz")
            {
                label1.Text = "Tiwaz is representative of the warrior’s arrowhead of the God Tyr.\n It shows that you are capable of spearheading your way through all your troubles and possess great leadership skills, authority and rationality. \nIt can indicate victory and knowing of your true strengths with a willingness to self-sacrifice. \nReversed it can indicate blocked creative energies, over-analysis, imbalance, and lack of passion.\nKEYWORDS: Leadership, rationality, victory, honour, bravery, courage, strength, perseverance, endurance";
            }
            else if (Names[0] == "Berkana")
            {
                label1.Text = "Berkana is the rune of birth.\n It represents the Birch Goddess and so indicates fertility and creation, not just of an actual birth (its traditional meaning), but also of projects, partnerships and rebirth.\n It indicates mental and physical growth, and a regenerative power and liberation of spirit. \nReversed it can point to family troubles, anxiety, or rigid control.\nKEYWORDS: Fertility, growth, renewal, new beginnings, birth, creation, new projects, creativity";
            }
            else if (Names[0] == "Ehwaz")
            {
                label1.Text = "Ehwaz is the horse. This represents man’s trusty aid, our only form of transport in times past. \nIt indicates a moving forward and change for the better with gradual but steady progress. \nIt can also show teamwork, trust and loyalty. \nReversed it can show restlessness, craving of change, mistrust or disharmony. It can be seen as The Lovers Tarot card.\nKEYWORDS: Progress, movement, harmony, trust, loyalty, friendship, assistance, duality, animal instincts";
            }
            else if (Names[0] == "Mannaz")
            {
                label1.Text = "Mannaz is representative of humankind and humanity. \nIt encompasses yourself and identity, and relationship towards others. \nIt is social order and cooperation, our sense of morals and values. \nReversed it can indicate self-delusion, manipulation and isolation.\nKEYWORDS: Humanity, collective, mortality, community, relationships, morals, values";
            }
            else if (Names[0] == "Laguz")
            {
                label1.Text = "Laguz represents the element of water and so is tied to our emotions, dreams and intuition. \nIt indicates a healing power of renewal, heightened imagination and psychic abilities. \nIt can also relate to mysteries, secrets, the unknown and the underworld. \nReversed it can point to fear, misjudgement, lack of creativity and avoidance.\nKEYWORDS: Water, intuition, imagination, healing, dreams, mysteries, insight, instinct, knowing";
            }
            else if (Names[0] == "Ingwaz")
            {
                label1.Text = "Ingwaz is the rune of fertility, representing the Earth God Ing. \nIt points to male fertility, common virtues, common sense, wellbeing, strength, family, rest, and loose ends being tied up. \nIt has no reversed meaning.\nKEYWORDS: Fertility, virility, inner growth, virtue, peace, harmony";
            }
            else if (Names[0] == "Othala")
            {
                label1.Text = "Othala is the rune of inheritance. \nIt tells of our lasting legacy, spiritual heritage, values becoming aligned to what is truly important, communal prosperity and fundamental values.\n Reversed it can indicate bad luck and prejudice.\nKEYWORDS: Legacy, inheritance, spiritual growth, abundance, values, contribution";
            }
            else if (Names[0] == "Dagaz")
            {
                label1.Text = "Dagaz represents dawn. It shows the coming of age and the ending of a cycle. \nNew beginnings are approaching and new breakthroughs, awareness and awakenings are possible. \nIt represents the transformative power of change and that it is a good time to embark upon a fresh enterprise. \nA final, positive symbol of hope, certainty and security, it has no reversed meaning. \nThis would be the completion of the cycle with the World card in the Tarot.\nKEYWORDS: Day, awakening, consciousness, clarity, hope, balance, growth, new cycles";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 

}
            
        
