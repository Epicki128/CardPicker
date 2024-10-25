using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardPicker
{
    public partial class Picker : Form
    {
        private string[] cards;
        private string[] karty;
        private int[] pickedCards = new int[5];

        Random random = new Random();
        public Picker()
        {
            InitializeComponent();

            cards = new string[] {
                "2_Clubs.jpg", "2_Diamonds.jpg", "2_Hearts.jpg", "2_Spades.jpg",
    "3_Clubs.jpg", "3_Diamonds.jpg", "3_Hearts.jpg", "3_Spades.jpg",
    "4_Clubs.jpg", "4_Diamonds.jpg", "4_Hearts.jpg", "4_Spades.jpg",
    "5_Clubs.jpg", "5_Diamonds.jpg", "5_Hearts.jpg", "5_Spades.jpg",
    "6_Clubs.jpg", "6_Diamonds.jpg", "6_Hearts.jpg", "6_Spades.jpg",
    "7_Clubs.jpg", "7_Diamonds.jpg", "7_Hearts.jpg", "7_Spades.jpg",
    "8_Clubs.jpg", "8_Diamonds.jpg", "8_Hearts.jpg", "8_Spades.jpg",
    "9_Clubs.jpg", "9_Diamonds.jpg", "9_Hearts.jpg", "9_Spades.jpg",
    "10_Clubs.jpg", "10_Diamonds.jpg", "10_Hearts.jpg", "10_Spades.jpg",
    "Jack_Clubs.jpg", "Jack_Diamonds.jpg", "Jack_Hearts.jpg", "Jack_Spades.jpg",
    "Queen_Clubs.jpg", "Queen_Diamonds.jpg", "Queen_Hearts.jpg", "Queen_Spades.jpg",
    "King_Clubs.jpg", "King_Diamonds.jpg", "King_Hearts.jpg", "King_Spades.jpg",
    "Ace_Clubs.jpg", "Ace_Diamonds.jpg", "Ace_Hearts.jpg", "Ace_Spades.jpg",
    "Joker_Black.jpg", "Joker_Red.jpg" };

            karty = new string[] {
    "2 Trefl", "2 Karo", "2 Kier", "2 Pik",
    "3 Trefl", "3 Karo", "3 Kier", "3 Pik",
    "4 Trefl", "4 Karo", "4 Kier", "4 Pik",
    "5 Trefl", "5 Karo", "5 Kier", "5 Pik",
    "6 Trefl", "6 Karo", "6 Kier", "6 Pik",
    "7 Trefl", "7 Karo", "7 Kier", "7 Pik",
    "8 Trefl", "8 Karo", "8 Kier", "8 Pik",
    "9 Trefl", "9 Karo", "9 Kier", "9 Pik",
    "10 Trefl", "10 Karo", "10 Kier", "10 Pik",
    "Walet Trefl", "Walet Karo", "Walet Kier", "Walet Pik",
    "Dama Trefl", "Dama Karo", "Dama Kier", "Dama Pik",
    "Król Trefl", "Król Karo", "Król Kier", "Król Pik",
    "As Trefl", "As Karo", "As Kier", "As Pik",
    "Joker Czarny", "Joker Czerwony"
};

            load_Images();
        }

        private void load_Images()
        {
            for (int i = 0, x = 0; i < 5; i++)
            {
                do
                {
                    x = random.Next(0, (cards.Length));
                } while (pickedCards.Contains(x));
                pickedCards[i] = x;
            }


            string basePath = Path.Combine(Application.StartupPath, "images");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = Image.FromFile(Path.Combine(basePath, cards[pickedCards[0]]));
            pictureBox2.Image = Image.FromFile(Path.Combine(basePath, cards[pickedCards[1]]));
            pictureBox3.Image = Image.FromFile(Path.Combine(basePath, cards[pickedCards[2]]));
            pictureBox4.Image = Image.FromFile(Path.Combine(basePath, cards[pickedCards[3]]));
            pictureBox5.Image = Image.FromFile(Path.Combine(basePath, cards[pickedCards[4]]));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            label2.Text = karty[pickedCards[2]];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = karty[pickedCards[3]];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            label2.Text = karty[pickedCards[0]];
        }

        private void Picker_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = karty[pickedCards[1]];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = karty[pickedCards[4]];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_Images();
        }
    }
}
