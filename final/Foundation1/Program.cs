using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> titles = new List<string>() {"This was the biggest mistake of my LIFE!!","The Only thing you need to know for web development",
                                                                        "I learned this trick and never looked back","I just quit my job to be a full time freelance web dev!",
                                                                        "Day in the life of a remote web developer","How to get started in tech","The only guide you need to HTML",
                                                                        "Don't learn JavaScript... Learn this","I made the worlds best portfolio, and you can too","I quit YouTube",
                                                                        "The only language you need to know to succeed is...","Creating a portfolio in 1 min, 10 min, and 10 hours"};

        List<string> authors = new List<string>() {"CapybaraBro","TentenHorse","DeltaTriad","DannyTeaDiem","SunSparkles","SugarHouse","CrossRoads Podcast",
                                                                             "SafeWebDev","WebDev for Dummies","Webster not the dictionary","TryGirls","Team8","ProtectSimon"};

        List<string> commenter = new List<string>() {"XxGamerXx","RoseyPlays","DogLover9000","CattoKing","BlenderGuru","DannyBoy","GlonkyBro",
                                                                                     "TheOneandOnly","YourWorstNightmare","David King","Steven Bates","TankMover","XtremeShots",
                                                                                     "ReadyAmFyre","TotallyAHuman","NotARobot","WhoAmIxx","WhereIsObamna","Sodalover","SipsSips",
                                                                                     "TakenAndGone","BewilderedBeast","TokensOfAvalon","TakingABack","ResetButton","ChimneyCooper"};
        
        List<string> commentText = new List<string>() {"This is the greatest video!","I've seen this before... still cool though","BE MY HERO PLEASE","First","Imagine doing this in public",
                                                                                    "I need to try this this is awesome!","What happened at 20:16? It looked like it hurt","What am I watching?","Is it done yet?",
                                                                                    "I think I need to clean my eyes now","What made you think posting this was a good idea?","I agree with you 100%, except for the last part",
                                                                                    "This is pure facts right here, everyone should listen to this","What type of ice cream was that?","What time did you film that last bit? That was beautiful",
                                                                                    "I need to try this out, I've been looking for this!","I have been looking for someone to explain this to me!","Thanks for the video","Why aren't you posting?",
                                                                                    "You really took this from 2008","This is such old content bro","HTML is the worst, no one should use it, I use Python for everything.","What DID YOU SAY?",
                                                                                    "This is the pinacle of content right here","There needs to be more stuff like this","More! More! More!","Finally you posted, after three lightyears"};
        
        Random random = new Random();

        int videoCount = random.Next(2,5);
        int commentCount = random.Next(3,6);
        
        List<Video> videosHere = new List<Video>();
        for (int i = 1; i <= videoCount; i++)
        {
            List<Comment> commentsHere = new List<Comment>();
            Video video = new Video(titles[random.Next(0,titles.Count)], authors[random.Next(0,authors.Count)],random.Next(0,1914),commentsHere);
            for (int j = 1; j <= commentCount; j++)
            {
                Random rand = new Random();
                string commentName = commenter[random.Next(0, commenter.Count)];
                Comment comment = new Comment(commentName,commentText[rand.Next(0,commentText.Count)]);
                commentsHere.Add(comment);
            }
            videosHere.Add(video);
        }
        foreach (Video ytvideo in videosHere)
        {
            ytvideo.DisplayVideoInfo();
        }
    }
}