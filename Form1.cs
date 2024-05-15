using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Стани_Богат
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            question_one();
            ResetGame();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika1do5);
            simpleSound.PlayLooping();
        }
        //въпроси
        private void question_one()
        {
            viewAllAnswers();
            BackgroundColor1to5();
            MoneyList.Visible = true;
            QuestionToAsk.Text = "Oт какви елементи е съставена водната молекула?";
            AnswerA.Text = "сяра и силиций";
            AnswerB.Text = "водород и кислород";
            AnswerC.Text = "гадолиний и унунпентиум";
            AnswerD.Text = "хелий и желязо";
        }
        private void question_two()
        {
            viewAllAnswers();
            MoneyList.Visible = false;
            MoneyList2.Visible = true;
            QuestionToAsk.Text = "Как е правилно да се изпише правилно символът на химичния елемент Натрий?";
            AnswerA.Text = "na";
            AnswerB.Text = "nA";
            AnswerC.Text = "So";
            AnswerD.Text = "Na";
        }
        private void question_three()
        {
            viewAllAnswers();
            MoneyList2.Visible = false;
            MoneyList3.Visible = true;
            QuestionToAsk.Text = "Колко въглеродни атома се съдъдържат в една молекула пентан?";
            AnswerA.Text = "5";
            AnswerB.Text = "1";
            AnswerC.Text = "943";
            AnswerD.Text = "55";
        }
        private void question_four()
        {
            viewAllAnswers();
            MoneyList3.Visible = false;
            MoneyList4.Visible = true;
            QuestionToAsk.Text = "При каква температура в градуси ледът почва да се превръща във вода?";
            AnswerA.Text = "100";
            AnswerB.Text = "-93";
            AnswerC.Text = "0";
            AnswerD.Text = "66";
        }
        private void question_five()
        {
            viewAllAnswers();
            MoneyList4.Visible = false;
            MoneyList5.Visible = true;
            QuestionToAsk.Text = "Кой е 115-ият елемент поред в Менделеевата таблица?";
            AnswerA.Text = "Унунпентиум";
            AnswerB.Text = "Стронций";
            AnswerC.Text = "Хлор";
            AnswerD.Text = "Германий";
        }
        private void question_six()
        {
            viewAllAnswers();
            MoneyList5.Visible = false;
            MoneyList6.Visible = true;
            BackgroundColor6to7();
            QuestionToAsk.Text = "Какво е първото име на Целзий, шведски учен, предложил скала за измерване на температура, впоследствие наименувана на него?";
            AnswerA.Text = "Ханс";
            AnswerB.Text = "Кристиян";
            AnswerC.Text = "Андерс";
            AnswerD.Text = "Харолд";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika6);
            simpleSound.PlayLooping();

        }
        private void question_seven()
        {
            viewAllAnswers();
            MoneyList6.Visible = false;
            MoneyList7.Visible = true;
            QuestionToAsk.Text = "Съвременният екран на телефоните не работи, когато сме с ръкавици, защото човешкият пръст има:";
            AnswerA.Text = "Температура";
            AnswerB.Text = "Специфична плътност";
            AnswerC.Text = "Отпечатъци";
            AnswerD.Text = "Електропроводимост";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika7);
            simpleSound.PlayLooping();
        }
        private void question_eight()
        {
            viewAllAnswers();
            MoneyList7.Visible = false;
            MoneyList8.Visible = true;
            BackGroundColor8to10();
            QuestionToAsk.Text = "Каква 'вода' се ползва в работата на алхимиците?";
            AnswerA.Text = "Светена вода";
            AnswerB.Text = "Жива вода";
            AnswerC.Text = "Царска вода";
            AnswerD.Text = "Мъртва вода";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika8);
            simpleSound.PlayLooping();
        }
        private void question_nine()
        {
            viewAllAnswers();
            MoneyList8.Visible = false;
            MoneyList9.Visible = true;
            QuestionToAsk.Text = "Кой метал, наричан още Халкос, е бил свързан с Афродита и в алхимията е означаван със знака на Венера?";
            AnswerA.Text = "Сребро";
            AnswerB.Text = "Мед";
            AnswerC.Text = "Платина";
            AnswerD.Text = "Злато";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika9);
            simpleSound.PlayLooping();
        }
        private void question_ten()
        {
            viewAllAnswers();
            MoneyList9.Visible = false;
            MoneyList10.Visible = true;
            QuestionToAsk.Text = "Къде се намира 'вратата към Ада': кратер, от който излиза непрестанно природен газ, подпален и горящ вече 50 години?";
            AnswerA.Text = "Туркменистан";
            AnswerB.Text = "Азербайджан";
            AnswerC.Text = "Исландия";
            AnswerD.Text = "Венецуела";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika10);
            simpleSound.PlayLooping();
        }
        private void question_eleven()
        {
            viewAllAnswers();
            MoneyList10.Visible = false;
            MoneyList11.Visible = true;
            BackgroungColor11to14();
            QuestionToAsk.Text = "Какво число щеше да има на корицата на книгата '451 градуса по фаренхайт', ако мерните единици бяха в Келвини?";
            AnswerA.Text = "233";
            AnswerB.Text = "-40";
            AnswerC.Text = "506";
            AnswerD.Text = "0";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika11);
            simpleSound.PlayLooping();
        }
        private void question_twelve()
        {
            viewAllAnswers();
            MoneyList11.Visible = false;
            MoneyList12.Visible = true;
            QuestionToAsk.Text = "Кой от оксимороните е наименование на реално съществуващо вещество?";
            AnswerA.Text = "суха вода";
            AnswerB.Text = "дървено желязо";
            AnswerC.Text = "течен вятър";
            AnswerD.Text = "чуплив газ";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika12);
            simpleSound.PlayLooping();
        }
        private void question_thirteen()
        {
            viewAllAnswers();
            MoneyList12.Visible = false;
            MoneyList13.Visible = true;
            QuestionToAsk.Text = "7 химични елемента са открити след добив в мина край едно място, а 4 от тях са кръстени на него. Кое е това място?";
            AnswerA.Text = "планина в Чили";
            AnswerB.Text = "гара в Русия";
            AnswerC.Text = "река във Франция";
            AnswerD.Text = "село в Швеция";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika13);
            simpleSound.PlayLooping();
        }
        private void question_fourteen()
        {
            viewAllAnswers();
            MoneyList13.Visible = false;
            MoneyList14.Visible = true;
            QuestionToAsk.Text = "През 70-те години, пясъчни мишки са пробно 'назначени' от службите на летището в Тел Авив, защото могат да надушват:";
            AnswerA.Text = "терпени";
            AnswerB.Text = "озон";
            AnswerC.Text = "амониев нитрат";
            AnswerD.Text = "адреналин";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika14);
            simpleSound.PlayLooping();
        }
        private void question_fifteen()
        {
            viewAllAnswers();
            MoneyList14.Visible = false;
            MoneyList15.Visible = true;
            BackgroundColor15();
            QuestionToAsk.Text = "Преди да отворят кошера, пчеларите често пускат дим в него. Какво започват да правят пчелите, когато го усетят?";
            AnswerA.Text = "Жилят се една друга";
            AnswerB.Text = "Тъпчат се с мед";
            AnswerC.Text = "Изхвърлят търтеите";
            AnswerD.Text = "Роят се";
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika15);
            simpleSound.PlayLooping();
        }

        //Маркиране на отговор
        private void AnswerA_Click(object sender, EventArgs e)
        {
            MarkAnswer("A");
            AskAnswer();
        }
        private void AnswerB_Click(object sender, EventArgs e)
        {
            MarkAnswer("B");
            AskAnswer();
        }
        private void AnswerC_Click(object sender, EventArgs e)
        {
            MarkAnswer("C");
            AskAnswer();
        }
        private void AnswerD_Click(object sender, EventArgs e)
        {
            MarkAnswer("D");
            AskAnswer();
        }

        //потвърждаване на отговор
        private void yes_Click(object sender, EventArgs e)
        {
            IsThisFinalAnswer.Visible = false;
            yes.Visible = false;
            no.Visible = false;
            if (AnswerA.Text == "сяра и силиций")
            {
                TrueOrFalseAnswer(1);
            }
            else if (AnswerA.Text == "na")
            {
                TrueOrFalseAnswer(2);
            }
            else if (AnswerA.Text == "5")
            {
                TrueOrFalseAnswer(3);
            }
            else if (AnswerA.Text == "100")
            {
                TrueOrFalseAnswer(4);
            }
            else if (AnswerA.Text == "Унунпентиум")
            {
                TrueOrFalseAnswer(5);
            }
            else if (AnswerA.Text == "Ханс")
            {
                TrueOrFalseAnswer(6);
            }
            else if (AnswerA.Text == "Температура")
            {
                TrueOrFalseAnswer(7);
            }
            else if (AnswerA.Text == "Светена вода")
            {
                TrueOrFalseAnswer(8);
            }
            else if (AnswerA.Text == "Сребро")
            {
                TrueOrFalseAnswer(9);
            }
            else if (AnswerA.Text == "Туркменистан")
            {
                TrueOrFalseAnswer(10);
            }
            else if (AnswerA.Text == "233")
            {
                TrueOrFalseAnswer(11);
            }
            else if (AnswerA.Text == "суха вода")
            {
                TrueOrFalseAnswer(12);
            }
            else if (AnswerA.Text == "планина в Чили")
            {
                TrueOrFalseAnswer(13);
            }
            else if (AnswerA.Text == "терпени")
            {
                TrueOrFalseAnswer(14);
            }
            else if (AnswerA.Text == "Жилят се една друга")
            {
                TrueOrFalseAnswer(15);
            }
        }
        private void No_Click(object sender, EventArgs e)
        {
            ClickedYesOrNo();
            UseAudience.Enabled = true;
            UseFiftyFifty.Enabled = true;
            UsePhoneFriend.Enabled = true;
            giveUp.Enabled = true;
            AnswerA.BackColor = Color.Black;
            AnswerB.BackColor = Color.Black;
            AnswerC.BackColor = Color.Black;
            AnswerD.BackColor = Color.Black;
            if (AnswerA.Text == "Ханс")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika6);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "Температура")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika7);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "Светена вода")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika8);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "Сребро")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika9);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "Туркменистан")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika10);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "233")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika11);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "суха вода")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika12);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "планина в Чили")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika13);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "терпени")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika14);
                simpleSound.PlayLooping();
            }
            else if (AnswerA.Text == "Жилят се една друга")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Muzika15);
                simpleSound.PlayLooping();
            }
        }
        private void TrueOrFalseAnswer(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    if (AnswerB.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerB.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "50 лева";

                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "0 лева";
                        EndGame();
                        AnswerB.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 2:
                    if (AnswerD.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerB.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerD.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "100 лева";
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "0 лева";
                        EndGame();
                        AnswerD.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 3:
                    if (AnswerA.BackColor == Color.Orange && AnswerB.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerA.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "200 лева";
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "0 лева";
                        EndGame();
                        AnswerA.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 4:
                    if (AnswerC.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerB.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerC.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "300 лева";
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "0 лева";
                        EndGame();
                        AnswerC.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 5:
                    if (AnswerA.BackColor == Color.Orange && AnswerB.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerA.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "500 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.SafetyNets);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "0 лева";
                        EndGame();
                        AnswerA.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 6:
                    if (AnswerC.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerB.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerC.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "700 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win6);
                        simpleSound.Play();
                        TimeSpan ts = TimeSpan.FromMilliseconds(150);
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "500 лева";
                        EndGame();
                        AnswerC.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 7:
                    if (AnswerD.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerB.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerD.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "1000 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win7);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "500 лева";
                        EndGame();
                        AnswerD.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 8:
                    if (AnswerC.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerB.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerC.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "1500 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win8);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "500 лева";
                        EndGame();
                        AnswerC.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 9:
                    if (AnswerB.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerB.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "2000 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win9);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "500 лева";
                        EndGame();
                        AnswerB.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 10:
                    if (AnswerA.BackColor == Color.Orange && AnswerB.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        QuantityOfWonMoney.Text = "2500 лева";
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerA.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.SafetyNets);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "500 лева";
                        EndGame();
                        AnswerA.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 11:
                    if (AnswerC.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerB.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerC.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "5000 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win11);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "2500 лева";
                        EndGame();
                        AnswerC.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 12:
                    if (AnswerA.BackColor == Color.Orange && AnswerB.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerA.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "10000 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win12);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "2500 лева";
                        EndGame();
                        AnswerA.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 13:
                    if (AnswerD.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerB.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerD.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "15000 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win13);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "2500 лева";
                        EndGame();
                        AnswerD.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 14:
                    if (AnswerD.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerB.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        nextQuestion.Visible = true;
                        AnswerD.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "20000 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win14);
                        simpleSound.Play();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "2500 лева";
                        EndGame();
                        AnswerD.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
                case 15:
                    if (AnswerB.BackColor == Color.Orange && AnswerA.BackColor == Color.Black && AnswerC.BackColor == Color.Black && AnswerD.BackColor == Color.Black)
                    {
                        ClickedYesOrNo();
                        AnswerB.BackColor = Color.LimeGreen;
                        QuantityOfWonMoney.Text = "100000 лева";
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Win15);
                        simpleSound.Play();
                        EndGame();
                    }
                    else
                    {
                        QuantityOfWonMoney.Text = "2500 лева";
                        EndGame();
                        AnswerB.BackColor = Color.LimeGreen;
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Fail);
                        simpleSound.Play();
                    }
                    break;
            }
        }
        //жокери
        private void UseFiftyFifty_Click(object sender, EventArgs e)
        {
            UsedFiftyFifty.Visible = true;
            UseFiftyFifty.Visible = false;
            if (AnswerA.Text == "сяра и силиций")
            {
                FiftyFiftyCases(1);
            }
            else if (AnswerA.Text == "na")
            {
                FiftyFiftyCases(2);
            }
            else if (AnswerA.Text == "5")
            {
                FiftyFiftyCases(3);
            }
            else if (AnswerA.Text == "100")
            {
                FiftyFiftyCases(4);
            }
            else if (AnswerA.Text == "Унунпентиум")
            {
                FiftyFiftyCases(5);
            }
            else if (AnswerA.Text == "Ханс")
            {
                FiftyFiftyCases(6);
            }
            else if (AnswerA.Text == "Температура")
            {
                FiftyFiftyCases(7);
            }
            else if (AnswerA.Text == "Светена вода")
            {
                FiftyFiftyCases(8);
            }
            else if (AnswerA.Text == "Сребро")
            {
                FiftyFiftyCases(9);
            }
            else if (AnswerA.Text == "Туркменистан")
            {
                FiftyFiftyCases(10);
            }
            else if (AnswerA.Text == "233")
            {
                FiftyFiftyCases(11);
            }
            else if (AnswerA.Text == "суха вода")
            {
                FiftyFiftyCases(12);
            }
            else if (AnswerA.Text == "планина в Чили")
            {
                FiftyFiftyCases(13);
            }
            else if (AnswerA.Text == "терпени")
            {
                FiftyFiftyCases(14);
            }
            else if (AnswerA.Text == "Жилят се една друга")
            {
                FiftyFiftyCases(15);
            }
        }
        private void FiftyFiftyCases(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    Random rnd1 = new Random();
                    Button[] FiftyFiftyUse1 = new Button[3] { AnswerA, AnswerC, AnswerD };
                    List<Button> randomButtons1 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse1[rnd1.Next(0, FiftyFiftyUse1.Length)];
                        } while (randomButtons1.Contains(chosenButton));

                        randomButtons1.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons1)
                        button.Visible = false;
                    break;
                case 2:
                    Random rnd2 = new Random();
                    Button[] FiftyFiftyUse2 = new Button[3] { AnswerA, AnswerC, AnswerB };
                    List<Button> randomButtons2 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse2[rnd2.Next(0, FiftyFiftyUse2.Length)];
                        } while (randomButtons2.Contains(chosenButton));

                        randomButtons2.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons2)
                        button.Visible = false;
                    break;
                case 3:
                    Random rnd3 = new Random();
                    Button[] FiftyFiftyUse3 = new Button[3] { AnswerD, AnswerC, AnswerB };
                    List<Button> randomButtons3 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse3[rnd3.Next(0, FiftyFiftyUse3.Length)];
                        } while (randomButtons3.Contains(chosenButton));

                        randomButtons3.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons3)
                        button.Visible = false;
                    break;
                case 4:
                    Random rnd4 = new Random();
                    Button[] FiftyFiftyUse4 = new Button[3] { AnswerD, AnswerA, AnswerB };
                    List<Button> randomButtons4 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse4[rnd4.Next(0, FiftyFiftyUse4.Length)];
                        } while (randomButtons4.Contains(chosenButton));

                        randomButtons4.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons4)
                        button.Visible = false;
                    break;
                case 5:
                    Random rnd5 = new Random();
                    Button[] FiftyFiftyUse5 = new Button[3] { AnswerD, AnswerC, AnswerB };
                    List<Button> randomButtons5 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse5[rnd5.Next(0, FiftyFiftyUse5.Length)];
                        } while (randomButtons5.Contains(chosenButton));

                        randomButtons5.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons5)
                        button.Visible = false;
                    break;
                case 6:
                    Random rnd6 = new Random();
                    Button[] FiftyFiftyUse6 = new Button[3] { AnswerD, AnswerA, AnswerB };
                    List<Button> randomButtons6 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse6[rnd6.Next(0, FiftyFiftyUse6.Length)];
                        } while (randomButtons6.Contains(chosenButton));

                        randomButtons6.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons6)
                        button.Visible = false;
                    break;
                case 7:
                    Random rnd7 = new Random();
                    Button[] FiftyFiftyUse7 = new Button[3] { AnswerC, AnswerA, AnswerB };
                    List<Button> randomButtons7 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse7[rnd7.Next(0, FiftyFiftyUse7.Length)];
                        } while (randomButtons7.Contains(chosenButton));

                        randomButtons7.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons7)
                        button.Visible = false;
                    break;
                case 8:
                    Random rnd8 = new Random();
                    Button[] FiftyFiftyUse8 = new Button[3] { AnswerD, AnswerA, AnswerB };
                    List<Button> randomButtons8 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse8[rnd8.Next(0, FiftyFiftyUse8.Length)];
                        } while (randomButtons8.Contains(chosenButton));

                        randomButtons8.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons8)
                        button.Visible = false;
                    break;
                case 9:
                    Random rnd9 = new Random();
                    Button[] FiftyFiftyUse9 = new Button[3] { AnswerC, AnswerA, AnswerD };
                    List<Button> randomButtons9 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse9[rnd9.Next(0, FiftyFiftyUse9.Length)];
                        } while (randomButtons9.Contains(chosenButton));

                        randomButtons9.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons9)
                        button.Visible = false;
                    break;
                case 10:
                    Random rnd10 = new Random();
                    Button[] FiftyFiftyUse10 = new Button[3] { AnswerC, AnswerB, AnswerD };
                    List<Button> randomButtons10 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse10[rnd10.Next(0, FiftyFiftyUse10.Length)];
                        } while (randomButtons10.Contains(chosenButton));

                        randomButtons10.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons10)
                        button.Visible = false;
                    break;
                case 11:
                    Random rnd11 = new Random();
                    Button[] FiftyFiftyUse11 = new Button[3] { AnswerA, AnswerB, AnswerD };
                    List<Button> randomButtons11 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse11[rnd11.Next(0, FiftyFiftyUse11.Length)];
                        } while (randomButtons11.Contains(chosenButton));

                        randomButtons11.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons11)
                        button.Visible = false;
                    break;
                case 12:
                    Random rnd12 = new Random();
                    Button[] FiftyFiftyUse12 = new Button[3] { AnswerC, AnswerB, AnswerD };
                    List<Button> randomButtons12 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse12[rnd12.Next(0, FiftyFiftyUse12.Length)];
                        } while (randomButtons12.Contains(chosenButton));

                        randomButtons12.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons12)
                        button.Visible = false;
                    break;
                case 13:
                    Random rnd13 = new Random();
                    Button[] FiftyFiftyUse13 = new Button[3] { AnswerC, AnswerB, AnswerA };
                    List<Button> randomButtons13 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse13[rnd13.Next(0, FiftyFiftyUse13.Length)];
                        } while (randomButtons13.Contains(chosenButton));

                        randomButtons13.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons13)
                        button.Visible = false;
                    break;
                case 14:
                    Random rnd14 = new Random();
                    Button[] FiftyFiftyUse14 = new Button[3] { AnswerC, AnswerB, AnswerA };
                    List<Button> randomButtons14 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse14[rnd14.Next(0, FiftyFiftyUse14.Length)];
                        } while (randomButtons14.Contains(chosenButton));

                        randomButtons14.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons14)
                        button.Visible = false;
                    break;
                case 15:
                    Random rnd15 = new Random();
                    Button[] FiftyFiftyUse15 = new Button[3] { AnswerC, AnswerD, AnswerA };
                    List<Button> randomButtons15 = new List<Button>(4);

                    for (int i = 1; i <= 2; ++i)
                    {
                        Button chosenButton;
                        do
                        {
                            chosenButton = FiftyFiftyUse15[rnd15.Next(0, FiftyFiftyUse15.Length)];
                        } while (randomButtons15.Contains(chosenButton));

                        randomButtons15.Add(chosenButton);
                    }
                    foreach (Button button in randomButtons15)
                        button.Visible = false;
                    break;
            }
        }
        private void UsePhoneFriend_Click(object sender, EventArgs e)
        {
            UsedPhoneFriend.Visible = true;
            UsePhoneFriend.Visible = false;
            if (AnswerA.Text == "сяра и силиций")
            {
                PhoneCases(1);
            }
            else if (AnswerA.Text == "na")
            {
                PhoneCases(2);
            }
            else if (AnswerA.Text == "5")
            {
                PhoneCases(3);
            }
            else if (AnswerA.Text == "100")
            {
                PhoneCases(4);
            }
            else if (AnswerA.Text == "Унунпентиум")
            {
                PhoneCases(5);
            }
            else if (AnswerA.Text == "Ханс")
            {
                PhoneCases(6);
            }
            else if (AnswerA.Text == "Температура")
            {
                PhoneCases(7);
            }
            else if (AnswerA.Text == "Светена вода")
            {
                PhoneCases(8);
            }
            else if (AnswerA.Text == "Сребро")
            {
                PhoneCases(9);
            }
            else if (AnswerA.Text == "Туркменистан")
            {
                PhoneCases(10);
            }
            else if (AnswerA.Text == "233")
            {
                PhoneCases(11);
            }
            else if (AnswerA.Text == "суха вода")
            {
                PhoneCases(12);
            }
            else if (AnswerA.Text == "планина в Чили")
            {
                PhoneCases(13);
            }
            else if (AnswerA.Text == "терпени")
            {
                PhoneCases(14);
            }
            else if (AnswerA.Text == "Жилят се една друга")
            {
                PhoneCases(15);
            }
        }
        private void PhoneCases(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    Phone1.Visible = true;
                    break;
                case 2:
                    Phone2.Visible = true;
                    break;
                case 3:
                    Phone3.Visible = true;
                    break;
                case 4:
                    Phone4.Visible = true;
                    break;
                case 5:
                    Phone5.Visible = true;
                    break;
                case 6:
                    Phone6.Visible = true;
                    break;
                case 7:
                    Phone7.Visible = true;
                    break;
                case 8:
                    Phone8.Visible = true;
                    break;
                case 9:
                    Phone9.Visible = true;
                    break;
                case 10:
                    Phone10.Visible = true;
                    break;
                case 11:
                    Phone11.Visible = true;
                    break;
                case 12:
                    Phone12.Visible = true;
                    break;
                case 13:
                    Phone13.Visible = true;
                    break;
                case 14:
                    Phone14.Visible = true;
                    break;
                case 15:
                    Phone15.Visible = true;
                    break;
            }
        }
        private void UseAudience_Click(object sender, EventArgs e)
        {
            UsedAskAudience.Visible = true;
            UseAudience.Visible = false;
            if (AnswerA.Text == "сяра и силиций")
            {
                AudienceCases(1);
            }
            else if (AnswerA.Text == "na")
            {
                AudienceCases(2);
            }
            else if (AnswerA.Text == "5")
            {
                AudienceCases(3);
            }
            else if (AnswerA.Text == "100")
            {
                AudienceCases(4);
            }
            else if (AnswerA.Text == "Унунпентиум")
            {
                AudienceCases(5);
            }
            else if (AnswerA.Text == "Ханс")
            {
                AudienceCases(6);
            }
            else if (AnswerA.Text == "Температура")
            {
                AudienceCases(7);
            }
            else if (AnswerA.Text == "Светена вода")
            {
                AudienceCases(8);
            }
            else if (AnswerA.Text == "Сребро")
            {
                AudienceCases(9);
            }
            else if (AnswerA.Text == "Туркменистан")
            {
                AudienceCases(10);
            }
            else if (AnswerA.Text == "233")
            {
                AudienceCases(11);
            }
            else if (AnswerA.Text == "суха вода")
            {
                AudienceCases(12);
            }
            else if (AnswerA.Text == "планина в Чили")
            {
                AudienceCases(13);
            }
            else if (AnswerA.Text == "терпени")
            {
                AudienceCases(14);
            }
            else if (AnswerA.Text == "Жилят се една друга")
            {
                AudienceCases(15);
            }
        }
        private void AudienceCases(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    Audience1.Visible = true;
                    break;
                case 2:
                    Audience2.Visible = true;
                    break;
                case 3:
                    Audience3.Visible = true;
                    break;
                case 4:
                    Audience4.Visible = true;
                    break;
                case 5:
                    Audience5.Visible = true;
                    break;
                case 6:
                    Audience6.Visible = true;
                    break;
                case 7:
                    Audience7.Visible = true;
                    break;
                case 8:
                    Audience8.Visible = true;
                    break;
                case 9:
                    Audience9.Visible = true;
                    break;
                case 10:
                    Audience10.Visible = true;
                    break;
                case 11:
                    Audience11.Visible = true;
                    break;
                case 12:
                    Audience12.Visible = true;
                    break;
                case 13:
                    Audience13.Visible = true;
                    break;
                case 14:
                    Audience14.Visible = true;
                    break;
                case 15:
                    Audience15.Visible = true;
                    break;
            }
        }


        //бутони за отказване, продължаване нататък
        private void nextQuestion_Click(object sender, EventArgs e)
        {
            UseAudience.Enabled = true;
            UseFiftyFifty.Enabled = true;
            UsePhoneFriend.Enabled = true;
            giveUp.Enabled = true;
            nextQuestion.Visible = false;
            AnswerA.BackColor = Color.Black;
            AnswerB.BackColor = Color.Black;
            AnswerC.BackColor = Color.Black;
            AnswerD.BackColor = Color.Black;
            if (AnswerA.Text == "сяра и силиций")
            {
                question_two();
            }
            else if (AnswerA.Text == "na")
            {
                question_three();
            }
            else if (AnswerA.Text == "5")
            {
                question_four();
            }
            else if (AnswerA.Text == "100")
            {
                question_five();
            }
            else if (AnswerA.Text == "Унунпентиум")
            {
                question_six();
            }
            else if (AnswerA.Text == "Ханс")
            {
                question_seven();
            }
            else if (AnswerA.Text == "Температура")
            {
                question_eight();
            }
            else if (AnswerA.Text == "Светена вода")
            {
                question_nine();
            }
            else if (AnswerA.Text == "Сребро")
            {
                question_ten();
            }
            else if (AnswerA.Text == "Туркменистан")
            {
                question_eleven();
            }
            else if (AnswerA.Text == "233")
            {
                question_twelve();
            }
            else if (AnswerA.Text == "суха вода")
            {
                question_thirteen();
            }
            else if (AnswerA.Text == "планина в Чили")
            {
                question_fourteen();
            }
            else if (AnswerA.Text == "терпени")
            {
                question_fifteen();
            }
        }
        private void giveUp_Click(object sender, EventArgs e)
        {
            EndGame();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.GiveUp);
            simpleSound.Play();
        }


        //спомагателни методи
        private string MarkAnswer(string chosenAnswer)
        {
            if (chosenAnswer == "A")
            {
                AnswerA.BackColor = Color.Orange;
            }
            else if (chosenAnswer == "B")
            {
                AnswerB.BackColor = Color.Orange;
            }
            else if (chosenAnswer == "C")
            {
                AnswerC.BackColor = Color.Orange;
            }
            else if (chosenAnswer == "D")
            {
                AnswerD.BackColor = Color.Orange;
            }
            return chosenAnswer;
        }
        private void viewAllAnswers()
        {
            AnswerA.Visible = true;
            AnswerB.Visible = true;
            AnswerC.Visible = true;
            AnswerD.Visible = true;
            Phone1.Visible = false;
            Phone2.Visible = false;
            Phone3.Visible = false;
            Phone4.Visible = false;
            Phone5.Visible = false;
            Phone6.Visible = false;
            Phone7.Visible = false;
            Phone8.Visible = false;
            Phone9.Visible = false;
            Phone10.Visible = false;
            Phone11.Visible = false;
            Phone12.Visible = false;
            Phone13.Visible = false;
            Phone14.Visible = false;
            Phone15.Visible = false;
            Audience1.Visible = false;
            Audience2.Visible = false;
            Audience3.Visible = false;
            Audience4.Visible = false;
            Audience5.Visible = false;
            Audience6.Visible = false;
            Audience7.Visible = false;
            Audience8.Visible = false;
            Audience9.Visible = false;
            Audience10.Visible = false;
            Audience11.Visible = false;
            Audience12.Visible = false;
            Audience13.Visible = false;
            Audience14.Visible = false;
            Audience15.Visible = false;
        }
        private void AskAnswer()
        {
            IsThisFinalAnswer.Visible = true;
            yes.Visible = true;
            no.Visible = true;
            UsePhoneFriend.Enabled = false;
            UseFiftyFifty.Enabled = false;
            UseAudience.Enabled = false;
            giveUp.Enabled = false;
            if (AnswerA.Text == "Ханс" || AnswerA.Text == "233")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.FinalAnswer6_11);
                simpleSound.Play();
            }
            else if (AnswerA.Text == "Температура" || AnswerA.Text == "суха вода")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.FinalAnswer7_12);
                simpleSound.Play();
            }
            else if (AnswerA.Text == "Светена вода" || AnswerA.Text == "планина в Чили")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.FinalAnswer8_13);
                simpleSound.Play();
            }
            else if (AnswerA.Text == "Сребро" || AnswerA.Text == "терпени")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.FinalAnswer9_14);
                simpleSound.Play();
            }
            else if (AnswerA.Text == "Туркменистан" || AnswerA.Text == "Жилят се една друга")
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.FinalAnswer10_15);
                simpleSound.Play();
            }
        }
        private void ClickedYesOrNo()
        {
            IsThisFinalAnswer.Visible = false;
            yes.Visible = false;
            no.Visible = false;
        }
        private void BackgroundColor1to5()
        {
            PhoneFriend.BackColor = Color.Silver;
            FiftyFifty.BackColor = Color.Silver;
            AskAudience.BackColor = Color.Silver;
            BackColor = Color.Silver;
            UsedAskAudience.BackColor = Color.Silver;
            UsedFiftyFifty.BackColor = Color.Silver;
            UsedPhoneFriend.BackColor = Color.Silver;
            IsThisFinalAnswer.BackColor = Color.Silver;
            WonMoney.BackColor = Color.Silver;
        }
        private void BackgroundColor6to7()
        {
            PhoneFriend.BackColor = Color.FromArgb(51, 204, 204);
            FiftyFifty.BackColor = Color.FromArgb(51, 204, 204);
            AskAudience.BackColor = Color.FromArgb(51, 204, 204);
            BackColor = Color.FromArgb(51, 204, 204);
            UsedAskAudience.BackColor = Color.FromArgb(51, 204, 204);
            UsedFiftyFifty.BackColor = Color.FromArgb(51, 204, 204);
            UsedPhoneFriend.BackColor = Color.FromArgb(51, 204, 204);
            IsThisFinalAnswer.BackColor = Color.FromArgb(51, 204, 204);
            WonMoney.BackColor = Color.FromArgb(51, 204, 204);
        }
        private void BackGroundColor8to10()
        {
            PhoneFriend.BackColor = Color.FromArgb(0, 153, 255);
            FiftyFifty.BackColor = Color.FromArgb(0, 153, 255);
            AskAudience.BackColor = Color.FromArgb(0, 153, 255);
            BackColor = Color.FromArgb(0, 153, 255);
            UsedAskAudience.BackColor = Color.FromArgb(0, 153, 255);
            UsedFiftyFifty.BackColor = Color.FromArgb(0, 153, 255);
            UsedPhoneFriend.BackColor = Color.FromArgb(0, 153, 255);
            IsThisFinalAnswer.BackColor = Color.FromArgb(0, 153, 255);
            WonMoney.BackColor = Color.FromArgb(0, 153, 255);
        }
        private void BackgroungColor11to14()
        {
            PhoneFriend.BackColor = Color.FromArgb(0, 0, 77);
            FiftyFifty.BackColor = Color.FromArgb(0, 0, 77);
            AskAudience.BackColor = Color.FromArgb(0, 0, 77);
            BackColor = Color.FromArgb(0, 0, 77);
            UsedAskAudience.BackColor = Color.FromArgb(0, 0, 77);
            UsedFiftyFifty.BackColor = Color.FromArgb(0, 0, 77);
            UsedPhoneFriend.BackColor = Color.FromArgb(0, 0, 77);
            IsThisFinalAnswer.BackColor = Color.FromArgb(0, 0, 77);
            WonMoney.BackColor = Color.FromArgb(0, 0, 77);
            IsThisFinalAnswer.ForeColor = Color.White;
            WonMoney.ForeColor = Color.White;
        }
        private void BackgroundColor15()
        {
            PhoneFriend.BackColor = Color.FromArgb(10, 10, 10);
            FiftyFifty.BackColor = Color.FromArgb(10, 10, 10);
            AskAudience.BackColor = Color.FromArgb(10, 10, 10);
            BackColor = Color.FromArgb(10, 10, 10);
            UsedAskAudience.BackColor = Color.FromArgb(10, 10, 10);
            UsedFiftyFifty.BackColor = Color.FromArgb(10, 10, 10);
            UsedPhoneFriend.BackColor = Color.FromArgb(10, 10, 10);
            IsThisFinalAnswer.BackColor = Color.FromArgb(10, 10, 10);
            WonMoney.BackColor = Color.FromArgb(10, 10, 10);
            IsThisFinalAnswer.ForeColor = Color.White;
            WonMoney.ForeColor = Color.White;
        }

        //след приключване на играта
        private void EndGame()
        {
            newGame.Visible = true;
            WonMoney.Visible = true;
            QuantityOfWonMoney.Visible = true;
            giveUp.Visible = false;
            nextQuestion.Visible = false;
            UseFiftyFifty.Visible = false;
            UsePhoneFriend.Visible = false;
            UseAudience.Visible = false;
        }
        private void ResetGame()
        {
            MoneyList2.Visible = false;
            MoneyList3.Visible = false;
            MoneyList4.Visible = false;
            MoneyList5.Visible = false;
            MoneyList6.Visible = false;
            MoneyList7.Visible = false;
            MoneyList8.Visible = false;
            MoneyList9.Visible = false;
            MoneyList10.Visible = false;
            MoneyList11.Visible = false;
            MoneyList12.Visible = false;
            MoneyList13.Visible = false;
            MoneyList14.Visible = false;
            MoneyList15.Visible = false;
            newGame.Visible = false;
            WonMoney.Visible = false;
            QuantityOfWonMoney.Visible = false;
            QuantityOfWonMoney.Text = "0 лева";
            IsThisFinalAnswer.Visible = false;
            yes.Visible = false;
            no.Visible = false;
            giveUp.Visible = true;
            giveUp.Enabled = true;
            UsedFiftyFifty.Visible = false;
            UsedPhoneFriend.Visible = false;
            UsedAskAudience.Visible = false;
            UseAudience.Visible = true;
            UsePhoneFriend.Visible = true;
            UseFiftyFifty.Visible = true;
            UseAudience.Enabled = true;
            UsePhoneFriend.Enabled = true;
            UseFiftyFifty.Enabled = true;
            IsThisFinalAnswer.ForeColor = Color.Black;
            AnswerA.BackColor = Color.Black;
            AnswerB.BackColor = Color.Black;
            AnswerC.BackColor = Color.Black;
            AnswerD.BackColor = Color.Black;
        }

    }
}

