///Lake Storey (programming) and Sahil Patel (Design) Wed. Jan. 25th, 2017
///to provide entertainment to the user
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boxHead
{
    public partial class Form1 : Form
    {
        //create graphics object
        Graphics g;

         
        //create brushes and fonts
        Brush blueBrush = new SolidBrush(Color.Black);
        Font arial30 = new Font("Arial", 30);
        Font arial12 = new Font("Arial", 12, FontStyle.Bold);

        #region powerups
        //declare randoms
        Random powerUpGen = new Random();
        Random powerUpLocationGen = new Random();

        //declare starting locations and values
        int powerUpx = -30;
        int powerUpy = -30;
        int powerUpHeight = 20;
        int powerUpWidth = 20;
        int powerUpSpawner = 0;
        bool powerUpSpawned = false;
        int powerUpCollected = 0;

        #endregion

        int characterNum = 1;

        int gameStart = 0;

        #region coins
        //random generator
        Random coinGen = new Random();
        Random coinPosGen = new Random();

        //values for coins
        int coin1X = -100;
        int coin1Y = -100;
        int coin2X = -100;
        int coin2Y = -100;
        int coin3X = -100;
        int coin3Y = -100;
        int coin4X = -100;
        int coin4Y = -100;
        int coin5X = -100;
        int coin5Y = -100;
        int coin6X = -100;
        int coin6Y = -100;
        int coin7X = -100;
        int coin7Y = -100;
        int coin8X = -100;
        int coin8Y = -100;
        int coin9X = -100;
        int coin9Y = -100;
        int coin10X = -100;
        int coin10Y = -100;
        int coinWidth = 20;
        int coinHeight = 20;
        int coinNum;
        #endregion

        #region zombies
        //stats for zombie 1
        int zom1X = 0;
        int zom1Y = 150;
        int zom1Spd = 1;
        int zom1Height = 20;
        int zom1Width = 20;

        //stats for zombie 2
        int zom2X = 400;
        int zom2Y = 150;
        int zom2Spd = 1;
        int zom2Height = 20;
        int zom2Width = 20;
        #endregion

        #region hero
        //stats for hero
        int heroX =200;
        int heroY =150;
        int heroSpd = 2;
        int heroheight = 20;
        int herowidth = 20;
        int heroLives = 3;
        int collectedCoins = 0;

        //controls
        bool leftArrowDown;
        bool downArrowDown;
        bool rightArrowDown;
        bool upArrowDown;
        #endregion

        public Form1()
        {
            InitializeComponent();
            //set the graphics object and make all objects invisible
            g = this.CreateGraphics();
            character1Box.Visible = false;
            character2Box.Visible = false;
            character3Box.Visible = false;
            startGameLabel.Visible = false;

        }

        private void newGameLabel_Click(object sender, EventArgs e)
        {
            //dispose of unecessary onjects
            titleScreenPicture.Dispose();
            newGameLabel.Dispose();
            chooseCharacterLabel.Dispose();
            howToPlayLabel.Dispose();
            character1Box.Dispose();
            character2Box.Dispose();
            character3Box.Dispose();
            backLabel.Dispose();
            Refresh();

            g.DrawString("The game is set in a fictional world where Zombies have taken control of \r\n" +
                "\r\n" +
                "                      the world and eradicated most of the human race. \r\n" +
                "\r\n" +
                "                         Your purpose is to try and eliminate Zombies \r\n" +
                "\r\n" +
                "                                   while collecting power ups in  \r\n" +
                "\r\n" +
                "                                            order to survive ", arial12, blueBrush, 20, 50);
            startGameLabel.Visible = true;
        }

        private void startGameLabel_Click(object sender, EventArgs e)
        {
            //dispose of unecessary objects and make start game
            gameStart = 1;
            startGameLabel.Dispose();

            #region coin value decision
            //decide num of coins
            coinNum = coinGen.Next(5, 11);

            //decide coin values
            coin1X = coinPosGen.Next(0, this.Width - coinWidth-30);
            coin1Y = coinPosGen.Next(0, this.Height -140);
            coin2X = coinPosGen.Next(0, this.Width - coinWidth-30);
            coin2Y = coinPosGen.Next(0, this.Height -140);
            coin3X = coinPosGen.Next(0, this.Width - coinWidth-30);
            coin3Y = coinPosGen.Next(0, this.Height -140);
            coin4X = coinPosGen.Next(0, this.Width - coinWidth-30);
            coin4Y = coinPosGen.Next(0, this.Height -140);
            coin5X = coinPosGen.Next(0, this.Width - coinWidth-30);
            coin5Y = coinPosGen.Next(0, this.Height - 140);
            if (coinNum >= 6)
            {
                coin6X = coinPosGen.Next(0, this.Width - 30);
                coin6Y = coinPosGen.Next(0, this.Height - 140);
            }
            if (coinNum >= 7)
            {
                coin7X = coinPosGen.Next(0, this.Width - 30);
                coin7Y = coinPosGen.Next(0, this.Height - 140);
            }
            if (coinNum >= 8)
            {
                coin8X = coinPosGen.Next(0, this.Width - 30);
                coin8Y = coinPosGen.Next(0, this.Height - 140);
            }
            if (coinNum >= 9)
            {
                coin9X = coinPosGen.Next(0, this.Width - 30);
                coin9Y = coinPosGen.Next(0, this.Height - 140);
            }
            if (coinNum >= 10)
            {
                coin10X = coinPosGen.Next(0, this.Width - 30);
                coin10Y = coinPosGen.Next(0, this.Height - 140);
            }

            #endregion

            //refresh and start gametimer
            Refresh();
            gameTimer.Start();

        }

        private void chooseCharacterLabel_Click(object sender, EventArgs e)
        {
            //make labels dissapear
            titleScreenPicture.Visible = false;
            newGameLabel.Visible = false;
            chooseCharacterLabel.Visible = false;
            howToPlayLabel.Visible = false;

            // makes characters visible
            character1Box.Visible = true;
            character2Box.Visible = true;
            character3Box.Visible = true;
        }

        private void howToPlayLabel_Click(object sender, EventArgs e)
        {
            //make labels dissapear
            titleScreenPicture.Visible = false;
            newGameLabel.Visible = false;
            chooseCharacterLabel.Visible = false;
            howToPlayLabel.Visible = false;
            character1Box.Visible = false;
            character2Box.Visible = false;
            character3Box.Visible = false;

            Refresh();

            //draw instructions
            g.DrawString("How To Play", arial30, blueBrush, 180, 0);
            g.DrawString("Use WASD To Move", arial12, blueBrush, 220, 40);
            g.DrawImage(Properties.Resources.Hero1, 240, 70);
            g.DrawString("Survive against the blue zombies by using W A S D to escape.", arial12, blueBrush, 57, 80);
            g.DrawString("Activate and use the power up(s) by colliding with them.", arial12, blueBrush, 90, 120);
            g.DrawString("Collect the gold coins by colliding with them.", arial12, blueBrush, 140, 160);

            backLabel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            //make labels appear
            titleScreenPicture.Visible = true;
            newGameLabel.Visible = true;
            chooseCharacterLabel.Visible = true;
            howToPlayLabel.Visible = true;
            backLabel.Visible = false;
        }

        private void character1Box_Click(object sender, EventArgs e)
        {
            //make labels appear
            titleScreenPicture.Visible = true;
            newGameLabel.Visible = true;
            chooseCharacterLabel.Visible = true;
            howToPlayLabel.Visible = true;
            //make labels dissapear
            character1Box.Visible = false;
            character2Box.Visible = false;
            character3Box.Visible = false;

            characterNum = 1;
        }

        private void character2Box_Click(object sender, EventArgs e)
        {
            //make labels appear
            titleScreenPicture.Visible = true;
            newGameLabel.Visible = true;
            chooseCharacterLabel.Visible = true;
            howToPlayLabel.Visible = true;

            //make labels dissapear
            character1Box.Visible = false;
            character2Box.Visible = false;
            character3Box.Visible = false;

            characterNum = 2;
        }

        private void character3Box_Click(object sender, EventArgs e)
        {
            //make labels appear
            titleScreenPicture.Visible = true;
            newGameLabel.Visible = true;
            chooseCharacterLabel.Visible = true;
            howToPlayLabel.Visible = true;

            //make labels dissapear
            character1Box.Visible = false;
            character2Box.Visible = false;
            character3Box.Visible = false;

            characterNum = 3;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //set up controls
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.S:
                    downArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.W:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //set up controls
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.S:
                    downArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
                case Keys.W:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
        }
           
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region sounds
            //sets up sounds to be used in game
            SoundPlayer coinSound = new SoundPlayer(Properties.Resources.smb_coin);
            SoundPlayer deathSound = new SoundPlayer(Properties.Resources.pacman_death);
            SoundPlayer stageClearSound = new SoundPlayer(Properties.Resources.smb_stage_clear__1_);
            SoundPlayer powerUpGet = new SoundPlayer(Properties.Resources.smb_powerup);
            SoundPlayer powerUpSpawns = new SoundPlayer(Properties.Resources.smb_powerup_appears);
            #endregion

            #region spawn powerups
            //detects if powerup is spawned, if not then it spawns one
            if (powerUpSpawned == false && powerUpCollected < 5)
            {
                powerUpSpawner = powerUpGen.Next(0, 301);
            }

            if (powerUpSpawner == 20)
            {
                powerUpSpawns.Play();
                powerUpx = powerUpLocationGen.Next(0, this.Width - powerUpWidth);
                powerUpy = powerUpLocationGen.Next(0, this.Height - powerUpHeight);
                powerUpSpawner = 0;
                powerUpSpawned = true;
            }

            #endregion

            #region control character based on key presses
            //check movement for hero1
            if (heroX > 0 && leftArrowDown == true)
            {
                heroX = heroX - heroSpd;
            }

            if (heroY < this.Height - heroheight - 40 && downArrowDown == true)
            {
                heroY = heroY + heroSpd;
            }

            if (heroX < this.Width - herowidth - 16 && rightArrowDown == true)
            {
                heroX = heroX + heroSpd;
            }

            if (heroY > 0 && upArrowDown == true)
            {
                heroY = heroY - heroSpd;
            }
            #endregion

            #region control zom1
            //control zom1
            if (heroX > zom1X)
            {
                zom1X = zom1X + zom1Spd;
            }

            if (heroY < zom1Y)
            {
                zom1Y = zom1Y - zom1Spd;
            }

            if (heroX < zom1X)
            {
                zom1X = zom1X - zom1Spd;
            }

            if (heroY > zom1Y)
            {
                zom1Y = zom1Y + zom1Spd;
            }
            #endregion

            #region control zom2
            //control zom2
            if (heroX > zom2X)
            {
                zom2X = zom2X + zom2Spd;
            }

            if (heroY < zom2Y)
            {
                zom2Y = zom2Y - zom2Spd;
            }

            if (heroX < zom2X)
            {
                zom2X = zom2X - zom2Spd;
            }

            if (heroY > zom2Y)
            {
                zom2Y = zom2Y + zom2Spd;
            }
            #endregion

            #region collision detection
            //declare hitboxes
            Rectangle zombie1 = new Rectangle(zom1X, zom1Y, zom1Height, zom1Width);
            Rectangle zombie2 = new Rectangle(zom2X, zom2Y, zom2Height, zom2Width);
            Rectangle heroRec = new Rectangle(heroX, heroY, heroheight, herowidth);

            #region coin hitboxes
            //declare coin hitboxes
            Rectangle coin1 = new Rectangle(coin1X, coin1Y, coinHeight, coinWidth);
            Rectangle coin2 = new Rectangle(coin2X, coin2Y, coinHeight, coinWidth);
            Rectangle coin3 = new Rectangle(coin3X, coin3Y, coinHeight, coinWidth);
            Rectangle coin4 = new Rectangle(coin4X, coin4Y, coinHeight, coinWidth);
            Rectangle coin5 = new Rectangle(coin5X, coin5Y, coinHeight, coinWidth);
            Rectangle coin6 = new Rectangle(coin6X, coin6Y, coinHeight, coinWidth);
            Rectangle coin7 = new Rectangle(coin7X, coin7Y, coinHeight, coinWidth);
            Rectangle coin8 = new Rectangle(coin8X, coin8Y, coinHeight, coinWidth);
            Rectangle coin9 = new Rectangle(coin9X, coin9Y, coinHeight, coinWidth);
            Rectangle coin10 = new Rectangle(coin10X, coin10Y, coinHeight, coinWidth);
            #endregion

            #region powerup hitboxes
            //declares hitboxes
            Rectangle power1 = new Rectangle(powerUpx, powerUpy, powerUpHeight, powerUpWidth);

            #endregion

            ////check for collision detection
            if (heroRec.IntersectsWith(zombie1))
            {
                deathSound.Play();
                heroLives--;
                heroX = 0;
                heroY = 0;
            }
            if (heroRec.IntersectsWith(zombie2))
            {
                deathSound.Play();
                heroLives--;
                heroX = 0;
                heroY = 0;
            }
            if (zombie1.IntersectsWith(zombie2))
            {
                zom2X--;
                zom2Y--;
            }
            if (heroLives == 0)
            {
                gameTimer.Stop();
            }
            if (collectedCoins == coinNum)
            {
                gameTimer.Stop();
                stageClearSound.Play();
            }

            #region coins collision detection
            //check for coin collision
            if (heroRec.IntersectsWith(coin1))
            {
                coinSound.Play();
                collectedCoins++;
                coin1X = -25;
                coin1Y = -25;
            }
            if (heroRec.IntersectsWith(coin2))
            {
                coinSound.Play();
                collectedCoins++;
                coin2X = -25;
                coin2Y = -25;
            }
            if (heroRec.IntersectsWith(coin3))
            {
                coinSound.Play();
                collectedCoins++;
                coin3X = -25;
                coin3Y = -25;
            }
            if (heroRec.IntersectsWith(coin4))
            {
                coinSound.Play();
                collectedCoins++;
                coin4X = -25;
                coin4Y = -25;
            }
            if (heroRec.IntersectsWith(coin5))
            {
                coinSound.Play();
                collectedCoins++;
                coin5X = -25;
                coin5Y = -25;
            }
            if (coinNum == 6 || coinNum > 6)
            {
                if (heroRec.IntersectsWith(coin6))
                {
                    coinSound.Play();
                    collectedCoins++;
                    coin6X = -25;
                    coin6Y = -25;
                }
            }
            if (coinNum == 7 || coinNum > 7)
            {
                if (heroRec.IntersectsWith(coin7))
                {
                    coinSound.Play();
                    collectedCoins++;
                    coin7X = -25;
                    coin7Y = -25;
                }
            }
            if (coinNum == 8 || coinNum > 8)
            {
                if (heroRec.IntersectsWith(coin8))
                {
                    coinSound.Play();
                    collectedCoins++;
                    coin8X = -25;
                    coin8Y = -25;
                }
            }
            if (coinNum == 9 || coinNum > 9)
            {
                if (heroRec.IntersectsWith(coin9))
                {
                    coinSound.Play();
                    collectedCoins++;
                    coin9X = -25;
                    coin9Y = -25;
                }
            }
            if (coinNum == 10 || coinNum > 10)
            {
                if (heroRec.IntersectsWith(coin10))
                {
                    coinSound.Play();
                    collectedCoins++;
                    coin10X = -25;
                    coin10Y = -25;
                }
            }
            #endregion

            #region powerUp collision detection
            //detects if coin has collided with hero
            if (heroRec.IntersectsWith(power1))
            {
                powerUpGet.Play();
                powerUpx = -30;
                powerUpy = -30;
                heroSpd++;
                powerUpCollected++;
                powerUpSpawned = false;
            }

            #endregion

            #endregion

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameStart > 0) {
                //draws character
                if (characterNum == 1)
                {
                    e.Graphics.DrawImage(Properties.Resources.Hero1, heroX, heroY, 20, 20);
                }
                if (characterNum == 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.Hero2, heroX, heroY, 20, 20);
                }
                if (characterNum == 3)
                {
                    e.Graphics.DrawImage(Properties.Resources.Hero3, heroX, heroY, 20, 20);
                }

                //draws enemies and powerups
                e.Graphics.DrawImage(Properties.Resources.BasicEnemy, zom1X, zom1Y, 20, 20);
                e.Graphics.DrawImage(Properties.Resources.BasicEnemy, zom2X, zom2Y, 20, 20);
                e.Graphics.DrawImage(Properties.Resources.Powerup, powerUpx, powerUpy, 20, 20);

                #region coins
                //draw coins
                e.Graphics.DrawImage(Properties.Resources.Coin, coin1X, coin1Y, coinWidth, coinHeight);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin2X, coin2Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin3X, coin3Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin4X, coin4Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin5X, coin5Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin6X, coin6Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin7X, coin7Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin8X, coin8Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin9X, coin9Y, coinWidth, coinWidth);
                e.Graphics.DrawImage(Properties.Resources.Coin, coin10X, coin10Y, coinWidth, coinWidth);

                #endregion

                //checks for game over, if game over draws score
                if (heroLives == 0)
                {
                    e.Graphics.DrawString("Game Over", arial30, blueBrush, 200, 150);
                    e.Graphics.DrawString("Your Score is: " + collectedCoins, arial12, blueBrush, 210, 250);
                }
                if (collectedCoins == coinNum)
                {
                    e.Graphics.DrawString("You Win", arial30, blueBrush, 200, 150);
                    e.Graphics.DrawString("Your Score is: " + collectedCoins, arial12, blueBrush, 210, 250);
                }

                // draws score and lives
                e.Graphics.DrawString("You Score: " + collectedCoins, arial12, blueBrush, 10, 10);
                e.Graphics.DrawString("Lives: " + heroLives, arial12, blueBrush, this.Width - 100, 10);
            }
        }
    }

}
