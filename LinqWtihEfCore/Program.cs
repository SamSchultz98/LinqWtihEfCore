using ExtensionMethodTutorial;
using LinqWtihEfCore;


"prs".CWL();


/*
List<FootballTeam> teams = new()
{
    new FootballTeam {Name = "Bengals", State = "Ohio"},
new FootballTeam { Name = "Browns", State = "Ohio" },
new FootballTeam { Name = "Bengals", State = "Ohio" },
new FootballTeam { Name = "Steelers", State = "Pennsylvania" },
new FootballTeam { Name = "Ravens", State = "Naryland" }

};


var filteredTeamsInOhioGreg= teams.Where(team => team.State == "Ohio").OrderByDescending(team => team.Name);

foreach (var team in filteredTeamsInOhioGreg)
{
    team.Name.CWL();
}

*/


/*
List<string> names = new();
names.AddRange(new string[] { "Josh", "Billy", "James", "Karl", "Caleb", "Ian", "Jack", "Sam" });
//var sortedNames = names.Where(n => n.Length % 2 == 1).OrderBy(n => n);
var sortedNames = from n in names
                  where n.Length % 2 == 1
                  orderby n
                  select n;
for (int i = 0; i < 3; i++)
{
    switch (i)
    {
        case 0: names.Add("Abe"); break;
        case 1: names.Add("Betty"); break;
        case 2: names.Add("Chris"); break;
    }
    System.Threading.Thread.Sleep(1000);
    foreach (var name in sortedNames)
    {
        name.CWL();
    }
    string.Empty.CWL();
}

//var sortedNames = names.Where(n => n.Length % 2 == 1 ).OrderBy(n => n);      //n is a fred, and because the data equals simple strings it is saying "I want to sort the whole string"



/*
 * 
int i = 0;

i.Add(2).CW();

string title = "LinqWithEfCore";

title.Write();

title.AppendString("Appended to string").Write();

5.Mult(5).Add(3.Mult(5)).Sub(2).CW();
*/

