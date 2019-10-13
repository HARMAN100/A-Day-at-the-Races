using Day_At_The_Races;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Races
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


            Var.dogsArray[0] = new Greyhound() { MyPictureBox = pictureBox1, Name = "Day Break", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox1.Left, Randomizer = Var.Randomizer, oddsFor = Var.Randomizer.Next(1, 3), oddsAgainst = Var.Randomizer.Next(2, 8) };
            Var.dogsArray[1] = new Greyhound() { MyPictureBox = pictureBox2, Name = "Lightning's Revenge", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox2.Left, Randomizer = Var.Randomizer, oddsFor = Var.Randomizer.Next(1, 3), oddsAgainst = Var.Randomizer.Next(2,14) };
            Var.dogsArray[2] = new Greyhound() { MyPictureBox = pictureBox3, Name = "Mytosis", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox3.Left, Randomizer = Var.Randomizer, oddsFor = Var.Randomizer.Next(1, 3), oddsAgainst = Var.Randomizer.Next(2, 12) };
            Var.dogsArray[3] = new Greyhound() { MyPictureBox = pictureBox4, Name = "Sleeping Sycamore", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox4.Left, Randomizer = Var.Randomizer, oddsFor = Var.Randomizer.Next(1, 3), oddsAgainst = Var.Randomizer.Next(2, 10) };

            Var.guyArray[0] = new Guy() { MyBet = null, Name = "Zack", Cash = 50, MyLabel = Var.lblZack, MyRadioButton = rdbtnZack, MyLabel2 = lblZackBet };
            Var.guyArray[1] = new Guy() { MyBet = null, Name = "Nick", Cash = 75, MyLabel = Var.lblNick, MyRadioButton = rdbtnNick, MyLabel2 = lblNickBet };
            Var.guyArray[2] = new Guy() { MyBet = null, Name = "Taylor", Cash = 45, MyLabel = Var.lblTaylor, MyRadioButton = rdbtnTaylor, MyLabel2 = lblTaylorBet };

            Var.guyArray[0].UpdateLabels();
            Var.guyArray[1].UpdateLabels();
            Var.guyArray[2].UpdateLabels();

           
            if (Var.dogsArray[0].oddsFor.ToString() == Var.dogsArray[0].oddsAgainst.ToString())
                Var.lblDBOdds.Text = "Even";
            else
                Var.lblDBOdds.Text = Var.dogsArray[0].oddsAgainst.ToString() + " : " + Var.dogsArray[0].oddsFor.ToString();
            if (Var.dogsArray[1].oddsFor.ToString() ==  Var.dogsArray[1].oddsAgainst.ToString())
                Var.LROdds.Text = "Even";
            else
                Var.LROdds.Text = Var.dogsArray[1].oddsAgainst.ToString() + " : " + Var.dogsArray[1].oddsFor.ToString();
            if (Var.dogsArray[2].oddsFor.ToString() == Var.dogsArray[2].oddsAgainst.ToString())
                Var.MOdds.Text = "Even";
            else
                Var.MOdds.Text = Var.dogsArray[2].oddsAgainst.ToString() + " : " + Var.dogsArray[2].oddsFor.ToString();
            if (Var.dogsArray[3].oddsFor.ToString() == Var.dogsArray[3].oddsAgainst.ToString())
                Var.SSOdds.Text = "Even";
            else
                Var.SSOdds.Text = Var.dogsArray[3].oddsAgainst.ToString() + " : " + Var.dogsArray[3].oddsFor.ToString();


        }

        private void btnRace_Click_1(object sender, EventArgs e)
        {

            Var.dogsArray[0].TakeStartingPosition();
            Var.dogsArray[1].TakeStartingPosition();
            Var.dogsArray[2].TakeStartingPosition();
            Var.dogsArray[3].TakeStartingPosition();
            Var.zackBet = 0;
            Var.nickBet = 0;
            Var.taylorBet = 0;
            btnRace.Enabled = false;
            Var.timer1.Start();
          
        }

        private PictureBox racetrackPictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;

        private void InitializeComponent()
        {
            Var.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnZack = new System.Windows.Forms.RadioButton();
            this.rdbtnNick = new System.Windows.Forms.RadioButton();
            this.rdbtnTaylor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZackBet = new System.Windows.Forms.Label();
            this.lblNickBet = new System.Windows.Forms.Label();
            this.lblTaylorBet = new System.Windows.Forms.Label();
            this.lblBetter = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            Var.timer1 = new System.Windows.Forms.Timer(Var.components);
            Var.label9 = new System.Windows.Forms.Label();
            Var.label10 = new System.Windows.Forms.Label();
            Var.label11 = new System.Windows.Forms.Label();
            Var.label12 = new System.Windows.Forms.Label();
            Var.lblZack = new System.Windows.Forms.Label();
            Var.lblNick = new System.Windows.Forms.Label();
            Var.lblTaylor = new System.Windows.Forms.Label();
            Var.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            Var.comboBox1 = new System.Windows.Forms.ComboBox();
            Var.lblOdds = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            Var.lblDBOdds = new System.Windows.Forms.Label();
            Var.LROdds = new System.Windows.Forms.Label();
            Var.MOdds = new System.Windows.Forms.Label();
            Var.SSOdds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(Var.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Betting Parlor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimum bet:  5 dollars";
            // 
            // rdbtnZack
            // 
            this.rdbtnZack.AutoSize = true;
            this.rdbtnZack.Checked = true;
            this.rdbtnZack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnZack.Location = new System.Drawing.Point(33, 302);
            this.rdbtnZack.Name = "rdbtnZack";
            this.rdbtnZack.Size = new System.Drawing.Size(14, 13);
            this.rdbtnZack.TabIndex = 7;
            this.rdbtnZack.TabStop = true;
            this.rdbtnZack.UseVisualStyleBackColor = true;
            this.rdbtnZack.CheckedChanged += new System.EventHandler(this.rdbtnZack_CheckedChanged);
            // 
            // rdbtnNick
            // 
            this.rdbtnNick.AutoSize = true;
            this.rdbtnNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNick.Location = new System.Drawing.Point(33, 326);
            this.rdbtnNick.Name = "rdbtnNick";
            this.rdbtnNick.Size = new System.Drawing.Size(14, 13);
            this.rdbtnNick.TabIndex = 8;
            this.rdbtnNick.UseVisualStyleBackColor = true;
            this.rdbtnNick.CheckedChanged += new System.EventHandler(this.rdbtnNick_CheckedChanged);
            // 
            // rdbtnTaylor
            // 
            this.rdbtnTaylor.AutoSize = true;
            this.rdbtnTaylor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTaylor.Location = new System.Drawing.Point(33, 349);
            this.rdbtnTaylor.Name = "rdbtnTaylor";
            this.rdbtnTaylor.Size = new System.Drawing.Size(14, 13);
            this.rdbtnTaylor.TabIndex = 9;
            this.rdbtnTaylor.UseVisualStyleBackColor = true;
            this.rdbtnTaylor.CheckedChanged += new System.EventHandler(this.rdbtnTaylor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // lblZackBet
            // 
            this.lblZackBet.AutoSize = true;
            this.lblZackBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZackBet.Location = new System.Drawing.Point(266, 304);
            this.lblZackBet.Name = "lblZackBet";
            this.lblZackBet.Size = new System.Drawing.Size(154, 16);
            this.lblZackBet.TabIndex = 11;
            this.lblZackBet.Text = "Zack hasn\'t placed a bet";
            this.lblZackBet.Click += new System.EventHandler(this.lblZackBet_Click);
            // 
            // lblNickBet
            // 
            this.lblNickBet.AutoSize = true;
            this.lblNickBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickBet.Location = new System.Drawing.Point(266, 328);
            this.lblNickBet.Name = "lblNickBet";
            this.lblNickBet.Size = new System.Drawing.Size(151, 16);
            this.lblNickBet.TabIndex = 12;
            this.lblNickBet.Text = "Nick hasn\'t placed a bet";
            // 
            // lblTaylorBet
            // 
            this.lblTaylorBet.AutoSize = true;
            this.lblTaylorBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaylorBet.Location = new System.Drawing.Point(266, 350);
            this.lblTaylorBet.Name = "lblTaylorBet";
            this.lblTaylorBet.Size = new System.Drawing.Size(163, 16);
            this.lblTaylorBet.TabIndex = 13;
            this.lblTaylorBet.Text = "Taylor hasn\'t placed a bet";
            // 
            // lblBetter
            // 
            this.lblBetter.AutoSize = true;
            this.lblBetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetter.Location = new System.Drawing.Point(50, 394);
            this.lblBetter.Name = "lblBetter";
            this.lblBetter.Size = new System.Drawing.Size(44, 20);
            this.lblBetter.TabIndex = 14;
            this.lblBetter.Text = "Zack";
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(107, 391);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 15;
            this.btnBet.Text = "Bets";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "dollars on ";
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(591, 377);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(116, 44);
            this.btnRace.TabIndex = 18;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click_1);
            // 
            // timer1
            // 
            Var.timer1.Interval = 35;
            Var.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            Var.label9.AutoSize = true;
            Var.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.label9.Location = new System.Drawing.Point(680, 34);
            Var.label9.Name = "label9";
            Var.label9.Size = new System.Drawing.Size(72, 16);
            Var.label9.TabIndex = 19;
            Var.label9.Text = "Day Break";
            Var.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            Var.label10.AutoSize = true;
            Var.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.label10.Location = new System.Drawing.Point(680, 75);
            Var.label10.Name = "label10";
            Var.label10.Size = new System.Drawing.Size(139, 18);
            Var.label10.TabIndex = 20;
            Var.label10.Text = "Lightning\'s Revenge";
            // 
            // label11
            // 
            Var.label11.AutoSize = true;
            Var.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.label11.Location = new System.Drawing.Point(680, 128);
            Var.label11.Name = "label11";
            Var.label11.Size = new System.Drawing.Size(60, 18);
            Var.label11.TabIndex = 21;
            Var.label11.Text = "Mytosis";
            // 
            // label12
            // 
            Var.label12.AutoSize = true;
            Var.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.label12.Location = new System.Drawing.Point(683, 179);
            Var.label12.Name = "label12";
            Var.label12.Size = new System.Drawing.Size(136, 18);
            Var.label12.TabIndex = 22;
            Var.label12.Text = "Sleeping Sycamore";
            Var.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblZack
            // 
            Var.lblZack.AutoSize = true;
            Var.lblZack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.lblZack.Location = new System.Drawing.Point(51, 300);
            Var.lblZack.Name = "lblZack";
            Var.lblZack.Size = new System.Drawing.Size(0, 16);
            Var.lblZack.TabIndex = 23;
            // 
            // lblNick
            // 
            Var.lblNick.AutoSize = true;
            Var.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.lblNick.Location = new System.Drawing.Point(51, 324);
            Var.lblNick.Name = "lblNick";
            Var.lblNick.Size = new System.Drawing.Size(0, 16);
            Var.lblNick.TabIndex = 24;
            Var.lblNick.Click += new System.EventHandler(this.lblNick_Click);
            // 
            // lblTaylor
            // 
            Var.lblTaylor.AutoSize = true;
            Var.lblTaylor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.lblTaylor.Location = new System.Drawing.Point(51, 347);
            Var.lblTaylor.Name = "lblTaylor";
            Var.lblTaylor.Size = new System.Drawing.Size(0, 16);
            Var.lblTaylor.TabIndex = 25;
            // 
            // numericUpDown2
            // 
            Var.numericUpDown2.Location = new System.Drawing.Point(197, 392);
            Var.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            Var.numericUpDown2.Name = "numericUpDown2";
            Var.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            Var.numericUpDown2.TabIndex = 26;
            Var.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            Var.comboBox1.FormattingEnabled = true;
            Var.comboBox1.Items.AddRange(new object[] {
            "Day Break",
            "Lightning\'s Revenge",
            "Mytosis",
            "Sleeping Sycamore"});
            Var.comboBox1.Location = new System.Drawing.Point(400, 390);
            Var.comboBox1.Name = "comboBox1";
            Var.comboBox1.Size = new System.Drawing.Size(121, 21);
            Var.comboBox1.TabIndex = 27;
            Var.comboBox1.Text = "Day Break";
            // 
            // lblOdds
            // 
            Var.lblOdds.AutoSize = true;
            Var.lblOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.lblOdds.Location = new System.Drawing.Point(795, 3);
            Var.lblOdds.Name = "lblOdds";
            Var.lblOdds.Size = new System.Drawing.Size(190, 20);
            Var.lblOdds.TabIndex = 28;
            Var.lblOdds.Text = "Odds for Current Race";
            Var.lblOdds.Click += new System.EventHandler(this.lblOdds_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(72, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 28);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(72, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 28);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(72, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 28);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(72, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.BackgroundImage = global::Day_At_The_Races.Properties.Resources.racetrack__1_;
            this.racetrackPictureBox.Location = new System.Drawing.Point(57, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(602, 205);
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // lblDBOdds
            // 
            Var.lblDBOdds.AutoSize = true;
            Var.lblDBOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.lblDBOdds.Location = new System.Drawing.Point(852, 34);
            Var.lblDBOdds.Name = "lblDBOdds";
            Var.lblDBOdds.Size = new System.Drawing.Size(51, 16);
            Var.lblDBOdds.TabIndex = 29;
            Var.lblDBOdds.Text = "label4";
            Var.lblDBOdds.Click += new System.EventHandler(this.dbOddsAgainst_Click);
            // 
            // LROdds
            // 
            Var.LROdds.AutoSize = true;
            Var.LROdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.LROdds.Location = new System.Drawing.Point(852, 79);
            Var.LROdds.Name = "LROdds";
            Var.LROdds.Size = new System.Drawing.Size(41, 13);
            Var.LROdds.TabIndex = 30;
            Var.LROdds.Text = "label5";
            // 
            // MOdds
            // 
            Var.MOdds.AutoSize = true;
            Var.MOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.MOdds.Location = new System.Drawing.Point(852, 132);
            Var.MOdds.Name = "MOdds";
            Var.MOdds.Size = new System.Drawing.Size(41, 13);
            Var.MOdds.TabIndex = 31;
            Var.MOdds.Text = "label6";
            // 
            // SSOdds
            // 
            Var.SSOdds.AutoSize = true;
            Var.SSOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Var.SSOdds.Location = new System.Drawing.Point(852, 183);
            Var.SSOdds.Name = "SSOdds";
            Var.SSOdds.Size = new System.Drawing.Size(41, 13);
            Var.SSOdds.TabIndex = 32;
            Var.SSOdds.Text = "label7";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1023, 458);
            this.Controls.Add(Var.SSOdds);
            this.Controls.Add(Var.MOdds);
            this.Controls.Add(Var.LROdds);
            this.Controls.Add(Var.lblDBOdds);
            this.Controls.Add(Var.lblOdds);
            this.Controls.Add(Var.comboBox1);
            this.Controls.Add(Var.numericUpDown2);
            this.Controls.Add(Var.lblTaylor);
            this.Controls.Add(Var.lblNick);
            this.Controls.Add(Var.lblZack);
            this.Controls.Add(Var.label12);
            this.Controls.Add(Var.label11);
            this.Controls.Add(Var.label10);
            this.Controls.Add(Var.label9);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblBetter);
            this.Controls.Add(this.lblTaylorBet);
            this.Controls.Add(this.lblNickBet);
            this.Controls.Add(this.lblZackBet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbtnTaylor);
            this.Controls.Add(this.rdbtnNick);
            this.Controls.Add(this.rdbtnZack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(Var.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private RadioButton rdbtnZack;
        private RadioButton rdbtnNick;
        private RadioButton rdbtnTaylor;
        private Label label3;
        private Label lblZackBet;
        private Label lblNickBet;
        private Label lblTaylorBet;
        private Label lblBetter;
        private Button btnBet;
        private Label label8;
        private Button btnRace;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //dogsArray[0].Run();
            //dogsArray[1].Run();
            //dogsArray[2].Run();
            //dogsArray[3].Run();
            //  while (dogsArray[0].Run() == false && dogsArray[1].Run() == false && dogsArray[2].Run() == false && dogsArray[3].Run() == false)
            // {
            for (int i = 0; i < Var.dogsArray.Length; i++)
            {

                Var.dogsArray[i].Run();
                if (Var.dogsArray[i].Run() == true)
                {
                    // dogsArray[i].Run() = true;
                    Var.timer1.Stop();
                    Var.timer1.Enabled = false;
                    MessageBox.Show(Var.dogsArray[i].Name + " has won the race");
                    Var.winningDog = Var.dogsArray[i].Name;
                    i = Var.dogsArray.Length;
                    btnRace.Enabled = true;
                    Var.guyArray[0].Collect(Var.winningDog);
                    Var.guyArray[1].Collect(Var.winningDog);
                    Var.guyArray[2].Collect(Var.winningDog);


                    // guyArray[0].ClearBet();
                    // guyArray[1].ClearBet();
                    // guyArray[2].ClearBet();
                }

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblNick_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnZack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnZack.Enabled)
                lblBetter.Text = "Zack";
        }

        private void rdbtnNick_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNick.Enabled)
                lblBetter.Text = "Nick";
        }

        private void rdbtnTaylor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnTaylor.Enabled)
                lblBetter.Text = "Taylor";
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (Var.comboBox1.Text.ToString() == "Day Break")
                Var.Test = Var.dogsArray[0].oddsAgainst / Var.dogsArray[0].oddsFor;
            if (Var.comboBox1.Text.ToString() == "Lightning's Revenge")
                Var.Test = Var.dogsArray[1].oddsAgainst / Var.dogsArray[1].oddsFor;
            if (Var.comboBox1.Text.ToString() == "Mytosis")
                Var.Test = Var.dogsArray[2].oddsAgainst / Var.dogsArray[2].oddsFor;
            if (Var.comboBox1.Text.ToString() == "Sleeping Sycamore")
                Var.Test = Var.dogsArray[3].oddsAgainst / Var.dogsArray[3].oddsFor;

            if (lblBetter.Text == "Zack")
            {
                if (Var.zackBet == 0)
                {

                    Var.Bet = Var.guyArray[0].PlaceBet(Convert.ToInt16(Var.numericUpDown2.Value), Var.comboBox1.Text.ToString(), Var.Test);
                    if (Var.Bet == true)
                    {
                        Var.zackBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Zack has already placed a bet.");
                }
                             
            }
            if (lblBetter.Text == "Nick")
            {
                 if (Var.nickBet == 0)
                 {
                    Var.Bet = Var.guyArray[1].PlaceBet(Convert.ToInt16(Var.numericUpDown2.Value), Var.comboBox1.Text.ToString(), Var.Test);
                     if (Var.Bet == true)
                     {
                        Var.nickBet = 1;
                     }
                 }
                 else
                 {
                     MessageBox.Show("Nick has already placed a bet.");
                 }
               
            }
            if (lblBetter.Text == "Taylor")
            {
                if (Var.taylorBet == 0)
                {
                    Var.Bet = Var.guyArray[2].PlaceBet(Convert.ToInt16(Var.numericUpDown2.Value), Var.comboBox1.Text.ToString(), Var.Test);
                    if (Var.Bet == true)
                    {
                        Var.taylorBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Taylor has already placed a bet.");
                }             

            }
        }

        private void lblZackBet_Click(object sender, EventArgs e)
        {

        }

        private void lblOdds_Click(object sender, EventArgs e)
        {

        }

        private void dbOddsAgainst_Click(object sender, EventArgs e)
        {

        }

    }
}

      
    

