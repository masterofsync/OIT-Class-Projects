using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    public partial class Form1 : Form
    {
        string[] teams;
        int []played;
        int []wins;
        int []loss;
        int []draw;
        int []goalagainst;
        int []goaldifference;
        int[] goalscored;
        
        int []points;

        string[,] fixture;
        public Form1()
        {
            InitializeComponent();
            teams = new string[5];
            played = new int[5];
            wins = new int[5];
            loss = new int[5];
            draw = new int[5];
            goalagainst = new int[5];
            goaldifference = new int[5];
            goalscored = new int[5];
            points = new int[5];

            fixture = new string[10,2];

            for (int i = 0; i < 5; i++)
            {
                teams[i] = "";
                played[i] = 0;
                wins[i] = 0;
                loss[i] = 0;
                draw[i] = 0;
                goalagainst[i] = 0;
                goaldifference[i] = 0;
                goalscored[i] = 0;
                points[i] = 0;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (teamName.Text == "")
            {
                MessageBox.Show("Enter team name");
            }

            else
            {
                if (team1.Text == "")
                {
                    team1.Text = "1. " + teamName.Text;
                    teams[0] = t1.Text = teamName.Text;
                    
                }
                else if (team2.Text == "")
                {
                    team2.Text = "2. "+teamName.Text;
                    teams[1] = t2.Text= teamName.Text;
                }
                else if (team3.Text == "")
                {
                    team3.Text = "3. " + teamName.Text;
                    teams[2] = t3.Text =teamName.Text;
                }
                else if (team4.Text == "")
                {
                    team4.Text = "4. " + teamName.Text;
                    teams[3] = t4.Text =teamName.Text;
                }
                else if (team5.Text == "")
                {
                    team5.Text = "5. " + teamName.Text;
                    teams[4] = t5.Text = teamName.Text;
                }
                else
                {
                    MessageBox.Show("too many teams");
                }
            }
            teamName.Text = "";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            goalscored[2] += int.Parse(sc10.Text);
            goalscored[4] += int.Parse(sc11.Text);

            goalagainst[2] +=int.Parse(sc11.Text);
            goalagainst[4] +=int.Parse(sc10.Text);

            if (int.Parse(sc10.Text) == int.Parse(sc11.Text))
            {
                
                draw[2] += 1;
                draw[4] += 1;
                
                points[2] += 1;
                points[4] += 1;
            }
            else if (int.Parse(sc10.Text) > int.Parse(sc11.Text))
            {
                wins[2] += 1;
                loss[4] += 1;

                points[2] += 3;

                
            }
            else if (int.Parse(sc10.Text) < int.Parse(sc11.Text))
            {
                wins[4] += 1;
                loss[2] += 1;

                points[4] += 3;
            }

            goaldifference[2] = goalscored[2] - goalagainst[2];
            goaldifference[4] = goalscored[4] - goalagainst[4];

            played[2] += 1;
            played[4] += 1;

            p3.Text = played[2].ToString();
            p5.Text = played[4].ToString();

            w3.Text = wins[2].ToString();
            w5.Text = wins[4].ToString();

            d3.Text = draw[2].ToString();
            d5.Text = draw[4].ToString();

            l3.Text = loss[2].ToString();
            l5.Text = loss[4].ToString();

            gs3.Text = goalscored[2].ToString();
            gs5.Text = goalscored[4].ToString();

            ga3.Text = goalagainst[2].ToString();
            ga5.Text = goalagainst[4].ToString();

            gd3.Text = goaldifference[2].ToString();
            gd5.Text = goaldifference[4].ToString();

            pt3.Text = points[2].ToString();
            pt5.Text = points[4].ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            goalscored[4] += int.Parse(sc40.Text);
            goalscored[0] += int.Parse(sc41.Text);

            goalagainst[4] += int.Parse(sc41.Text);
            goalagainst[0] += int.Parse(sc40.Text);

            if (int.Parse(sc40.Text) == int.Parse(sc41.Text))
            {

                draw[4] += 1;
                draw[0] += 1;

                points[4] += 1;
                points[0] += 1;
            }
            else if (int.Parse(sc40.Text) > int.Parse(sc41.Text))
            {
                wins[4] += 1;
                loss[0] += 1;

                points[4] += 3;

            }
            else if (int.Parse(sc40.Text) < int.Parse(sc41.Text))
            {
                wins[0] += 1;
                loss[4] += 1;

                points[0] += 3;
            }

            goaldifference[4] = goalscored[4] - goalagainst[4];
            goaldifference[0] = goalscored[0] - goalagainst[0];

            played[4] += 1;
            played[0] += 1;

            p5.Text = played[4].ToString();
            p1.Text = played[0].ToString();

            w5.Text = wins[4].ToString();
            w1.Text = wins[0].ToString();

            d5.Text = draw[4].ToString();
            d1.Text = draw[0].ToString();

            l5.Text = loss[4].ToString();
            l1.Text = loss[0].ToString();

            gs5.Text = goalscored[4].ToString();
            gs1.Text = goalscored[0].ToString();

            ga5.Text = goalagainst[4].ToString();
            ga1.Text = goalagainst[0].ToString();

            gd5.Text = goaldifference[4].ToString();
            gd1.Text = goaldifference[0].ToString();


            pt5.Text = points[4].ToString();
            pt1.Text = points[0].ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (teams[0] != "" && teams[1] != "" && teams[2] != "" && teams[3] != "" && teams[4] != "")
            {
                fixture[0, 0] = fix10.Text = teams[2];
                fixture[0, 1] = fix11.Text = teams[4];
                fixture[1, 0] = fix20.Text = teams[0];
                fixture[1, 1] = fix21.Text = teams[1];
                fixture[2, 0] = fix30.Text = teams[2];
                fixture[2, 1] = fix31.Text = teams[3];
                fixture[3, 0] = fix40.Text = teams[4];
                fixture[3, 1] = fix41.Text = teams[0];
                fixture[4, 0] = fix50.Text = teams[1];
                fixture[4, 1] = fix51.Text = teams[2];
                fixture[5, 0] = fix60.Text = teams[0];
                fixture[5, 1] = fix61.Text = teams[3];
                fixture[6, 0] = fix70.Text = teams[1];
                fixture[6, 1] = fix71.Text = teams[4];
                fixture[7, 0] = fix80.Text = teams[0];
                fixture[7, 1] = fix81.Text = teams[2];
                fixture[8, 0] = fix90.Text = teams[3];
                fixture[8, 1] = fix91.Text = teams[4];
                fixture[9, 0] = fix100.Text = teams[3];
                fixture[9, 1] = fix101.Text = teams[1];

            }
            else
            {
                MessageBox.Show("Enter 5 teams");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            goalscored[0] += int.Parse(sc20.Text);
            goalscored[1] += int.Parse(sc21.Text);

            goalagainst[0] += int.Parse(sc21.Text);
            goalagainst[1] += int.Parse(sc20.Text);

            if (int.Parse(sc20.Text) == int.Parse(sc21.Text))
            {

                draw[0] += 1;
                draw[1] += 1;

                points[0] += 1;
                points[1] += 1;
            }
            else if (int.Parse(sc20.Text) > int.Parse(sc21.Text))
            {
                wins[0] += 1;
                loss[1] += 1;

                points[0] += 3;

            }
            else if (int.Parse(sc20.Text) < int.Parse(sc21.Text))
            {
                wins[1] += 1;
                loss[0] += 1;

                points[1] += 3;
            }

            goaldifference[0] = goalscored[0] - goalagainst[0];
            goaldifference[1] = goalscored[1] - goalagainst[1];

            played[0] += 1;
            played[1] += 1;

            p1.Text = played[0].ToString();
            p2.Text = played[1].ToString();

            w1.Text = wins[0].ToString();
            w2.Text = wins[1].ToString();

            d1.Text = draw[0].ToString();
            d2.Text = draw[1].ToString();

            l1.Text = loss[0].ToString();
            l2.Text = loss[1].ToString();

            gs1.Text = goalscored[0].ToString();
            gs2.Text = goalscored[1].ToString();

            ga1.Text = goalagainst[0].ToString();
            ga2.Text = goalagainst[1].ToString();

            gd1.Text = goaldifference[0].ToString();
            gd2.Text = goaldifference[1].ToString();


            pt1.Text = points[0].ToString();
            pt2.Text = points[1].ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            goalscored[2] += int.Parse(sc30.Text);
            goalscored[3] += int.Parse(sc31.Text);

            goalagainst[2] += int.Parse(sc31.Text);
            goalagainst[3] += int.Parse(sc30.Text);

            if (int.Parse(sc30.Text) == int.Parse(sc31.Text))
            {

                draw[2] += 1;
                draw[3] += 1;

                points[2] += 1;
                points[3] += 1;
            }
            else if (int.Parse(sc30.Text) > int.Parse(sc31.Text))
            {
                wins[2] += 1;
                loss[3] += 1;

                points[2] += 3;

            }
            else if (int.Parse(sc30.Text) < int.Parse(sc31.Text))
            {
                wins[3] += 1;
                loss[2] += 1;

                points[3] += 3;
            }

            goaldifference[2] = goalscored[2] - goalagainst[2];
            goaldifference[3] = goalscored[3] - goalagainst[3];

            played[2] += 1;
            played[3] += 1;

            p3.Text = played[2].ToString();
            p4.Text = played[3].ToString();

            w3.Text = wins[2].ToString();
            w4.Text = wins[3].ToString();

            d3.Text = draw[2].ToString();
            d4.Text = draw[3].ToString();

            l3.Text = loss[2].ToString();
            l4.Text = loss[3].ToString();

            gs3.Text = goalscored[2].ToString();
            gs4.Text = goalscored[3].ToString();

            ga3.Text = goalagainst[2].ToString();
            ga4.Text = goalagainst[3].ToString();

            gd3.Text = goaldifference[2].ToString();
            gd4.Text = goaldifference[3].ToString();


            pt3.Text = points[2].ToString();
            pt4.Text = points[3].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            goalscored[1] += int.Parse(sc50.Text);
            goalscored[2] += int.Parse(sc51.Text);

            goalagainst[1] += int.Parse(sc51.Text);
            goalagainst[2] += int.Parse(sc50.Text);

            if (int.Parse(sc50.Text) == int.Parse(sc51.Text))
            {

                draw[1] += 1;
                draw[2] += 1;

                points[1] += 1;
                points[2] += 1;
            }
            else if (int.Parse(sc50.Text) > int.Parse(sc51.Text))
            {
                wins[1] += 1;
                loss[2] += 1;

                points[1] += 3;

            }
            else if (int.Parse(sc50.Text) < int.Parse(sc51.Text))
            {
                wins[2] += 1;
                loss[1] += 1;

                points[2] += 3;
            }

            goaldifference[1] = goalscored[1] - goalagainst[1];
            goaldifference[2] = goalscored[2] - goalagainst[2];

            played[1] += 1;
            played[2] += 1;

            p2.Text = played[1].ToString();
            p3.Text = played[2].ToString();

            w2.Text = wins[1].ToString();
            w3.Text = wins[2].ToString();

            d2.Text = draw[1].ToString();
            d3.Text = draw[2].ToString();

            l2.Text = loss[1].ToString();
            l3.Text = loss[2].ToString();

            gs2.Text = goalscored[1].ToString();
            gs3.Text = goalscored[2].ToString();

            ga2.Text = goalagainst[1].ToString();
            ga3.Text = goalagainst[2].ToString();

            gd2.Text = goaldifference[1].ToString();
            gd3.Text = goaldifference[2].ToString();


            pt2.Text = points[1].ToString();
            pt3.Text = points[2].ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            goalscored[0] += int.Parse(sc60.Text);
            goalscored[3] += int.Parse(sc61.Text);

            goalagainst[0] += int.Parse(sc61.Text);
            goalagainst[3] += int.Parse(sc60.Text);

            if (int.Parse(sc60.Text) == int.Parse(sc61.Text))
            {

                draw[0] += 1;
                draw[3] += 1;

                points[2] += 1;
                points[4] += 1;
            }
            else if (int.Parse(sc60.Text) > int.Parse(sc61.Text))
            {
                wins[0] += 1;
                loss[3] += 1;

                points[0] += 3;

            }
            else if (int.Parse(sc60.Text) < int.Parse(sc61.Text))
            {
                wins[3] += 1;
                loss[0] += 1;

                points[3] += 3;
            }

            goaldifference[0] = goalscored[0] - goalagainst[0];
            goaldifference[3] = goalscored[3] - goalagainst[3];

            played[0] += 1;
            played[3] += 1;

            p1.Text = played[0].ToString();
            p4.Text = played[3].ToString();

            w1.Text = wins[0].ToString();
            w4.Text = wins[3].ToString();

            d1.Text = draw[0].ToString();
            d4.Text = draw[3].ToString();

            l1.Text = loss[0].ToString();
            l4.Text = loss[3].ToString();

            gs1.Text = goalscored[0].ToString();
            gs4.Text = goalscored[3].ToString();

            ga1.Text = goalagainst[0].ToString();
            ga4.Text = goalagainst[3].ToString();

            gd1.Text = goaldifference[0].ToString();
            gd4.Text = goaldifference[3].ToString();


            pt1.Text = points[0].ToString();
            pt4.Text = points[3].ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            goalscored[1] += int.Parse(sc70.Text);
            goalscored[4] += int.Parse(sc71.Text);

            goalagainst[1] += int.Parse(sc71.Text);
            goalagainst[4] += int.Parse(sc70.Text);

            if (int.Parse(sc70.Text) == int.Parse(sc71.Text))
            {

                draw[1] += 1;
                draw[4] += 1;

                points[1] += 1;
                points[4] += 1;
            }
            else if (int.Parse(sc70.Text) > int.Parse(sc71.Text))
            {
                wins[1] += 1;
                loss[4] += 1;

                points[1] += 3;

            }
            else if (int.Parse(sc70.Text) < int.Parse(sc71.Text))
            {
                wins[4] += 1;
                loss[1] += 1;

                points[4] += 3;
            }

            goaldifference[1] = goalscored[1] - goalagainst[1];
            goaldifference[4] = goalscored[4] - goalagainst[4];

            played[1] += 1;
            played[4] += 1;

            p2.Text = played[1].ToString();
            p5.Text = played[4].ToString();

            w2.Text = wins[1].ToString();
            w5.Text = wins[4].ToString();

            d2.Text = draw[1].ToString();
            d5.Text = draw[4].ToString();

            l2.Text = loss[1].ToString();
            l5.Text = loss[4].ToString();

            gs2.Text = goalscored[1].ToString();
            gs5.Text = goalscored[4].ToString();

            ga2.Text = goalagainst[1].ToString();
            ga5.Text = goalagainst[4].ToString();

            gd2.Text = goaldifference[1].ToString();
            gd5.Text = goaldifference[4].ToString();


            pt2.Text = points[1].ToString();
            pt5.Text = points[4].ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            goalscored[0] += int.Parse(sc80.Text);
            goalscored[2] += int.Parse(sc81.Text);

            goalagainst[0] += int.Parse(sc81.Text);
            goalagainst[2] += int.Parse(sc80.Text);

            if (int.Parse(sc80.Text) == int.Parse(sc81.Text))
            {

                draw[0] += 1;
                draw[2] += 1;

                points[0] += 1;
                points[2] += 1;
            }
            else if (int.Parse(sc80.Text) > int.Parse(sc81.Text))
            {
                wins[0] += 1;
                loss[2] += 1;

                points[0] += 3;

            }
            else if (int.Parse(sc80.Text) < int.Parse(sc81.Text))
            {
                wins[2] += 1;
                loss[0] += 1;

                points[2] += 3;
            }

            goaldifference[0] = goalscored[0] - goalagainst[0];
            goaldifference[2] = goalscored[2] - goalagainst[2];

            played[0] += 1;
            played[2] += 1;

            p1.Text = played[0].ToString();
            p3.Text = played[2].ToString();

            w1.Text = wins[0].ToString();
            w3.Text = wins[2].ToString();

            d1.Text = draw[0].ToString();
            d3.Text = draw[2].ToString();

            l1.Text = loss[0].ToString();
            l3.Text = loss[2].ToString();

            gs1.Text = goalscored[0].ToString();
            gs3.Text = goalscored[2].ToString();

            ga1.Text = goalagainst[0].ToString();
            ga3.Text = goalagainst[2].ToString();

            gd1.Text = goaldifference[0].ToString();
            gd3.Text = goaldifference[2].ToString();


            pt1.Text = points[0].ToString();
            pt3.Text = points[2].ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            goalscored[3] += int.Parse(sc90.Text);
            goalscored[4] += int.Parse(sc91.Text);

            goalagainst[3] += int.Parse(sc91.Text);
            goalagainst[4] += int.Parse(sc90.Text);

            if (int.Parse(sc90.Text) == int.Parse(sc91.Text))
            {

                draw[3] += 1;
                draw[4] += 1;

                points[3] += 1;
                points[4] += 1;
            }
            else if (int.Parse(sc90.Text) > int.Parse(sc91.Text))
            {
                wins[3] += 1;
                loss[4] += 1;

                points[3] += 3;

            }
            else if (int.Parse(sc90.Text) < int.Parse(sc91.Text))
            {
                wins[4] += 1;
                loss[3] += 1;

                points[4] += 3;
            }

            goaldifference[3] = goalscored[3] - goalagainst[3];
            goaldifference[4] = goalscored[4] - goalagainst[4];

            played[3] += 1;
            played[4] += 1;

            p4.Text = played[3].ToString();
            p5.Text = played[4].ToString();

            w4.Text = wins[3].ToString();
            w5.Text = wins[4].ToString();

            d4.Text = draw[3].ToString();
            d5.Text = draw[4].ToString();

            l4.Text = loss[3].ToString();
            l5.Text = loss[4].ToString();

            gs4.Text = goalscored[3].ToString();
            gs5.Text = goalscored[4].ToString();

            ga4.Text = goalagainst[3].ToString();
            ga5.Text = goalagainst[4].ToString();

            gd4.Text = goaldifference[3].ToString();
            gd5.Text = goaldifference[4].ToString();


            pt4.Text = points[3].ToString();
            pt5.Text = points[4].ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            goalscored[3] += int.Parse(sc100.Text);
            goalscored[1] += int.Parse(sc101.Text);

            goalagainst[3] += int.Parse(sc101.Text);
            goalagainst[1] += int.Parse(sc100.Text);

            if (int.Parse(sc100.Text) == int.Parse(sc101.Text))
            {

                draw[3] += 1;
                draw[1] += 1;

                points[3] += 1;
                points[1] += 1;
            }
            else if (int.Parse(sc100.Text) > int.Parse(sc101.Text))
            {
                wins[3] += 1;
                loss[1] += 1;

                points[3] += 3;

            }
            else if (int.Parse(sc100.Text) < int.Parse(sc101.Text))
            {
                wins[1] += 1;
                loss[3] += 1;

                points[1] += 3;
            }

            goaldifference[3] = goalscored[3] - goalagainst[3];
            goaldifference[1] = goalscored[1] - goalagainst[1];

            played[3] += 1;
            played[1] += 1;

            p4.Text = played[3].ToString();
            p2.Text = played[1].ToString();

            w4.Text = wins[3].ToString();
            w2.Text = wins[1].ToString();

            d4.Text = draw[3].ToString();
            d2.Text = draw[1].ToString();

            l4.Text = loss[3].ToString();
            l2.Text = loss[1].ToString();

            gs4.Text = goalscored[3].ToString();
            gs2.Text = goalscored[1].ToString();

            ga4.Text = goalagainst[3].ToString();
            ga2.Text = goalagainst[1].ToString();

            gd4.Text = goaldifference[3].ToString();
            gd2.Text = goaldifference[1].ToString();


            pt4.Text = points[3].ToString();
            pt2.Text = points[1].ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                teams[i] = "";
                played[i] = 0;
                wins[i] = 0;
                loss[i] = 0;
                draw[i] = 0;
                goalagainst[i] = 0;
                goaldifference[i] = 0;
                goalscored[i] = 0;
                points[i] = 0;
            }

            p1.Text = p2.Text = p3.Text = p4.Text = p5.Text = "";
            t1.Text = t2.Text = t3.Text = t4.Text = t5.Text = "";
            w1.Text = w2.Text = w3.Text = w4.Text = w5.Text = "";
            d1.Text = d2.Text = d3.Text = d4.Text = d5.Text = "";
            l1.Text = l2.Text = l3.Text = l4.Text = l5.Text = "";
            gs1.Text = gs2.Text = gs3.Text = gs4.Text = gs5.Text = "";
            ga1.Text = ga2.Text = ga3.Text = ga4.Text = ga5.Text = "";
            gd1.Text = gd2.Text = gd3.Text = gd4.Text = gd5.Text = "";
            pt1.Text = pt2.Text = pt3.Text = pt4.Text = pt5.Text = "";

            team1.Text = team2.Text = team3.Text= team4.Text=team5.Text  ="";


            fixture[0, 0] = fix10.Text = "";
            fixture[0, 1] = fix11.Text = "";
            fixture[1, 0] = fix20.Text = "";
            fixture[1, 1] = fix21.Text = "";
            fixture[2, 0] = fix30.Text = "";
            fixture[2, 1] = fix31.Text = "";
            fixture[3, 0] = fix40.Text = "";
            fixture[3, 1] = fix41.Text = "";
            fixture[4, 0] = fix50.Text = "";
            fixture[4, 1] = fix51.Text = "";
            fixture[5, 0] = fix60.Text = "";
            fixture[5, 1] = fix61.Text = "";
            fixture[6, 0] = fix70.Text = "";
            fixture[6, 1] = fix71.Text = "";
            fixture[7, 0] = fix80.Text = "";
            fixture[7, 1] = fix81.Text = "";
            fixture[8, 0] = fix90.Text = "";
            fixture[8, 1] = fix91.Text = "";
            fixture[9, 0] = fix100.Text = "";
            fixture[9, 1] = fix101.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
