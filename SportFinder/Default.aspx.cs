using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportFinder
{
    public partial class _Default : Page
    {
        //initialize string array with answers for 5 questions
        static string[] answers = new string[5];

        //declaring the variables for each kind of sport
        string team = "Football Basketball Handball Table-tennis Polo Swimming Cycling Auto-racing Paintball Tennis Baseball Cricket Rugby Sailing Canoeing Kayaking " +
            "Rafting Football-tennis Pocket-billiards Bowling Cycle-polo Fishing Hunting Sledding Ice-hockey Biathlon Rally Figure-skating Curling";
        string individual = "Table-tennis Squash Swimming Skateboarding Auto-racing Motorcycle-racing Grappling Striking Mixed-martial-arts Fencing Hunting Duathlon " +
            "Surfing Sailing Tennis Football-tennis Pocket-billiards Snooker Bowling Skating Archery Fishing Canoeing Kayaking Rafting Golf Figure-skating Skiing " +
            "Cross-country-skiing Speed-skating Sledding Snowboarding Triathlon";
        string fast = "Skiing Speed-skating Sledding Snowboarding Ice-hockey Biathlon Rally Table-tennis Squash Swimming Skateboarding Auto-racing Motorcycle-racing " +
            "Grappling Striking Mixed-martial-arts Fencing Duathlon Triathlon Surfing Sailing Tennis Football Basketball Handball Polo Cycling Paintball " +
            "Canoeing Kayaking Rafting Baseball Cricket Rugby Hunting";
        string slow = "Figure-skating Cross-country-skiing Biathlon Figure-skating Curling Football-tennis Pocket-billiards Snooker Bowling Swimming Skateboarding " +
            "Skating Archery Fencing Golf Surfing Fishing Sailing Canoeing Kayaking Rafting Skating Hunting Basketball Polo Cycle-polo Paintball";
        string summer = "Football Basketball Handball Table-tennis Polo Swimming Cycling Auto-racing Paintball Tennis Baseball Cricket Rugby Sailing Canoeing Kayaking " +
            "Rafting Football-tennis Pocket-billiards Bowling Cycle-polo Fishing Hunting Squash Skateboarding Motorcycle-racing Grappling Striking Mixed-martial-arts " +
            "Fencing Duathlon Triathlon Surfing Snooker Skating Archery Fishing Golf";
        string winter = "Skiing Sledding Ice-hockey Biathlon Rally Figure-skating Curling Cross-country-skiing Speed-skating Snowboarding";
        string snow = "Skiing Cross-country-skiing Biathlon Rally Snowboarding";
        string ice = "Figure-skating Sledding Ice-hockey Curling Speed-skating";
        string indoor = "Football Basketball Handball Table-tennis Polo Swimming Cycling Auto-racing Paintball Football-tennis Pocket-billiards Bowling Cycle-polo " +
            "Squash Skateboarding Motorcycle-racing Grappling Striking Mixed-martial-arts Fencing Snooker Skating Archery";
        string outdoor = "Tennis Baseball Cricket Football Rugby Sailing Canoeing Kayaking Rafting Cycling Auto-racing Paintball Football-tennis Fishing Cycle-polo " +
            "Hunting Surfing Swimming Skateboarding Duathlon Triathlon Motorcycle-racing Golf Skating Archery";
        string ball = "Football Basketball Handball Table-tennis Tennis Baseball Cricket Rugby Football-tennis Pocket-billiards Bowling Squash Snooker Golf";
        string water = "Swimming Polo Sailing Canoeing Kayaking Rafting Fishing Surfing";
        string wheels = "Cycling Auto-racing Cycle-polo Skateboarding Motorcycle-racing Duathlon Triathlon Skating";
        string combat = "Paintball Hunting Fencing Archery Grappling Striking Mixed-martial-arts";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //when Start button is pressed, first question appears and start button becomes invisible
        protected void StartBtn_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            StartBtn.Visible = false;
            Title1Label.Visible = false;
            Title2Label.Visible = true;
        }

        //on Team button pressed, second question apears
        //the other following questions and also the results become invisible
        //showing the selected button
        //initialize first position in array with team sports
        protected void TeamBtn_Click(object sender, EventArgs e)
        {
            MultiView2.ActiveViewIndex = 0;
            MultiView3.Visible = false;
            MultiView4.Visible = false;
            MultiView5.Visible = false;
            ResultsBtn.Visible = false;
            Reset_Results(TeamBtn, IndividualBtn, FastBtn, SlowBtn);
            answers[0] = team;

        }

        //on Individual button pressed, second question apears
        //the other following questions and also the results become invisible
        //showing the selected button
        //initialize first position in array with individual sports
        protected void IndividualBtn_Click(object sender, EventArgs e)
        {
            MultiView2.ActiveViewIndex = 0;
            MultiView3.Visible = false;
            MultiView4.Visible = false;
            MultiView5.Visible = false;
            ResultsBtn.Visible = false;
            Reset_Results(IndividualBtn, TeamBtn, FastBtn, SlowBtn);
            answers[0] = individual;
        }

        //on Fast button pressed, 3rd question apears
        //the other following questions and also the results become invisible
        //showing the selected button
        //initialize second position in array with fast sports
        protected void FastBtn_Click(object sender, EventArgs e)
        {
            MultiView3.Visible = true;
            MultiView3.ActiveViewIndex = 0;
            MultiView4.Visible = false;
            MultiView5.Visible = false;
            ResultsBtn.Visible = false;
            Reset_Results(FastBtn, SlowBtn, SummerBtn, WinterBtn);
            answers[1] = fast;
        }

        //on Slow button pressed, 3rd question apears
        //the other following questions and also the results become invisible
        //showing the selected button
        //initialize second position in array with slow sports
        protected void SlowBtn_Click(object sender, EventArgs e)
        {
            MultiView3.Visible = true;
            MultiView3.ActiveViewIndex = 0;
            MultiView4.Visible = false;
            MultiView5.Visible = false;
            ResultsBtn.Visible = false;
            Reset_Results(SlowBtn, FastBtn, SummerBtn, WinterBtn);
            answers[1] = slow;
        }

        //on Summer button pressed, 4th question apears
        //the other following questions and also the results become invisible
        //showing the selected button
        //initialize third position in array with summer sports
        protected void SummerBtn_Click(object sender, EventArgs e)
        {
            MultiView4.Visible = true;
            MultiView4.ActiveViewIndex = 0;
            MultiView5.Visible = false;
            ResultsBtn.Visible = false;
            Reset_Results(SummerBtn, WinterBtn, IndoorBtn, OutdoorBtn);
            answers[2] = summer;
        }

        //on Winter button pressed, 4th question apears
        //the other following questions and also the results become invisible
        //showing the selected button
        //initialize third position in array with winter sports
        protected void WinterBtn_Click(object sender, EventArgs e)
        {
            MultiView4.Visible = true;
            MultiView4.ActiveViewIndex = 1;
            MultiView5.Visible = false;
            ResultsBtn.Visible = false;
            Reset_Results(WinterBtn, SummerBtn, SnowBtn, IceBtn);
            answers[2] = winter;
        }

        //on Snow button pressed, results button apears
        //the results labels become invisible
        //showing the selected button
        //initialize fourth position in array with snow sports
        //delete fifth position in array
        protected void SnowBtn_Click(object sender, EventArgs e)
        {
            ResultsBtn.Visible = true;
            Reset_Results(SnowBtn, IceBtn, IndoorBtn, OutdoorBtn);
            answers[3] = snow;
            answers[4] = null;
        }

        //on Ice button pressed, results button apears
        //the results labels become invisible
        //showing the selected button
        //initialize fourth position in array with ice sports
        //delete fifth position in array
        protected void IceBtn_Click(object sender, EventArgs e)
        {
            ResultsBtn.Visible = true;
            Reset_Results(IceBtn, SnowBtn, IndoorBtn, OutdoorBtn);
            answers[3] = ice;
            answers[4] = null;
        }

        //on Indoor button pressed, 5th question apears
        //the results button becomes invisible
        //the results labels become invisible
        //showing the selected button
        //initialize fourth position in array with indoor sports
        protected void IndoorBtn_Click(object sender, EventArgs e)
        {
            MultiView5.Visible = true;
            MultiView5.ActiveViewIndex = 0;
            ResultsBtn.Visible = false;
            Reset_Results(IndoorBtn, OutdoorBtn, BallBtn, WaterBtn, WheelsBtn, CombatBtn);
            answers[3] = indoor;
        }

        //on Outdoor button pressed, 5th question apears
        //the results button becomes invisible
        //the results labels become invisible
        //showing the selected button
        //initialize third position in array with outdoor sports
        protected void OutdoorBtn_Click(object sender, EventArgs e)
        {
            MultiView5.Visible = true;
            MultiView5.ActiveViewIndex = 0;
            ResultsBtn.Visible = false;
            Reset_Results(OutdoorBtn, IndoorBtn, BallBtn, WaterBtn, WheelsBtn, CombatBtn);
            answers[3] = outdoor;
        }

        //on Ball button pressed, results button apears
        //the results labels become invisible
        //showing the selected button
        //initialize fifth position in array with ball sports
        protected void BallBtn_Click(object sender, EventArgs e)
        {
            ResultsBtn.Visible = true;
            Reset_Results(BallBtn, WaterBtn, WheelsBtn, CombatBtn);
            answers[4] = ball;
        }

        //on Water button pressed, results button apears
        //the results labels become invisible
        //showing the selected button
        //initialize fifth position in array with water sports
        protected void WaterBtn_Click(object sender, EventArgs e)
        {
            ResultsBtn.Visible = true;
            Reset_Results(WaterBtn, BallBtn, WheelsBtn, CombatBtn);
            answers[4] = water;
        }

        //on Wheels button pressed, results button apears
        //the results labels become invisible
        //showing the selected button
        //initialize fifth position in array with wheels sports
        protected void WheelsBtn_Click(object sender, EventArgs e)
        {
            ResultsBtn.Visible = true;
            Reset_Results(WheelsBtn, CombatBtn, WaterBtn, BallBtn);
            answers[4] = wheels;
        }

        //on Combat button pressed, results button apears
        //the results labels become invisible
        //showing the selected button
        //initialize fifth position in array with combat sports
        protected void CombatBtn_Click(object sender, EventArgs e)
        {
            ResultsBtn.Visible = true;
            Reset_Results(CombatBtn, WaterBtn, BallBtn, WheelsBtn);
            answers[4] = combat;
        }

        //on Results button pressed, the labels become visible
        //applying formula for showing the results
        protected void ResultsBtn_Click(object sender, EventArgs e)
        {
            ResultsTxtLbl.Visible = true;
            ResultsLbl.Visible = true;
            ResultsLbl.Text = Calculate_Results();
        }

        //hiding result labels and apply button background colors
        protected void Reset_Results(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5 = null, Button btn6 = null)
        {
            if ((btn5 == null)||(btn6 == null))
            {
                btn5 = new Button();
                btn6 = new Button();
            }
            ResultsTxtLbl.Visible = false;
            ResultsLbl.Visible = false;
            btn1.Attributes.Add("style", "background-color: rgb(46, 75, 42)");
            btn2.Attributes.Add("style", "background-color: ''");
            btn3.Attributes.Add("style", "background-color: ''");
            btn4.Attributes.Add("style", "background-color: ''");
            btn5.Attributes.Add("style", "background-color: ''");
            btn6.Attributes.Add("style", "background-color: ''");
        }

        //calculate results by intersection of strings
        protected string Calculate_Results()
        {
            string[] string1 = answers[0].Split(' ');
            string[] string2 = answers[1].Split(' ');
            string[] string3 = answers[2].Split(' ');
            string[] string4 = answers[3].Split(' ');
            IEnumerable<string> results;
            IEnumerable<string> results2;

            if (answers[4] == null)
            {
                results = string1.Intersect(string2, StringComparer.Ordinal);
                results2 = results.Intersect(string3, StringComparer.Ordinal);
                results = results2.Intersect(string4, StringComparer.Ordinal);
            }
            else
            {
                string[] string5 = answers[4].Split(' ');
                results = string1.Intersect(string2, StringComparer.Ordinal);
                results2 = results.Intersect(string3, StringComparer.Ordinal);
                results2 = results2.Intersect(string4, StringComparer.Ordinal);
                results = results2.Intersect(string5, StringComparer.Ordinal);
            }
            return (string.Join(", ", results));
        }
    }
}