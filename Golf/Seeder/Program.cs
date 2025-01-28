using API.Data;

APIContext db = new APIContext();

var sorok = File.ReadAllLines(@"c:\Users\Diak\..FJD\Backend\2025-01-28\GolfForras\csv\golfjatekosok.txt").Skip(1);
foreach (var line in sorok)
    db.Player.Add(new API.Models.Player(line));
db.SaveChanges();

sorok = File.ReadAllLines(@"c:\Users\Diak\..FJD\Backend\2025-01-28\GolfForras\csv\golferedmenyek.csv").Skip(1);
foreach (var line in sorok)
    db.Result.Add(new API.Models.Result(line));
db.SaveChanges();