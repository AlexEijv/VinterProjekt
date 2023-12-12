
//En metod för att inte behöva skriva en ny while loop kosntant
string AskForABC()
{
  string input = "";
  while (input != "a" && input != "b" && input != "c")
  {
    input = Console.ReadLine().ToLower();
    if (input != "a" && input != "b" && input != "c")
    {
      Console.WriteLine("Du har fan tappat det. JAG SA A B ELLER C");
    }
  }
  return input;
}

void Start()
{
  Console.WriteLine("Du vaknar upp på en buss hållplats.");
  Console.WriteLine("Du kollar namnet på hållplatsen");
  Console.WriteLine("SkitNamn. Vad är det för namn?");
  Console.WriteLine("Du ser att vägen går vänster och höger, bakom dig finns en stig.");
  Console.WriteLine("Vart går du?");
  Console.WriteLine("a) vänster, b) stigen, c) höger");
}

void StartA()
{
  Console.WriteLine("Du går längs vägen, det är helt dött ute. Inga bilar eller människor");
  Console.WriteLine("Du hör inte ens en fågel kvittra. Du får en panikattack och dör");
  Console.WriteLine("Vill du spela igen? (ja/nej)");
}

void StartB()
{
  Console.WriteLine("Du går igenom stigen men ser inget.");
  Console.WriteLine("Det är HELT Kolsvart");
  Console.WriteLine("Du hör steg bakom dig och grenar knastra");
  Console.WriteLine("Du vänder dig om, tänder en ficklampa. Du blir rädd.");
  Console.WriteLine("Du ser en figur. Han är svart, typ mörkgrå. Du börjar kuta djupare in i skogen");
  Console.WriteLine("Du ser stigen fortsätta höger och vänster");
  Console.WriteLine("Vart går du?");
  Console.WriteLine("a) Höger b) Vänster c) Knäcker en tröcca");
}

void StartC()
{
  Console.WriteLine("Du ser en ung dam. Hon är blond och har på sig en klänning");
  Console.WriteLine("Du känner igen henne, men är inte helt säker på vem det är");
  Console.WriteLine("Nu minns du. Det är Askungen");
  Console.WriteLine("Ilskan tar över din kropp och blodet börjar koka, DU KOKAR!!");
  Console.WriteLine("Hon vill prata, men du förstår inget, ilskan har tagit över");
  Console.WriteLine("Du ger henne en fet högerkrok så hon hamnar på marken.");
  Console.WriteLine("Du släpar sedan henne till en bro och släpper ned henne.");
  Console.WriteLine("Du vinkar hejdå.");
  Console.WriteLine("Du vaknar sedan upp på busshållplatsen och insåg att det var PTSD");
  Console.WriteLine("Du knäcker en trocca och ringer en taxi hem.");
  Console.WriteLine("Vill du spela igen? (ja/nej)");
}

void PathA()
{
  Console.WriteLine("Du börjar kuta höger");
  Console.WriteLine("Du har aldrig kutat så här snabbt i hela ditt liv.");
  Console.WriteLine("Du snubblar över en sten och ramlar.");
  Console.WriteLine("Du vaknar upp i ett hus. Du frågar dig själv");
  Console.WriteLine("Vart är jag?");
  Console.WriteLine("Du känner igen dig, men vet inte riktigt vart du är");
  Console.WriteLine("Du ser en dörr framför dig, en tröcca på ett bord bredvid dig och en säng bakom dig");
  Console.WriteLine("a) Dörren b) Tröccan c) Sängen");
}

void PathB()
{
  Console.WriteLine("Du kutar vänster, snabbare än usain bolt");
  Console.WriteLine("Du springer rakt in i ett träd");
  Console.WriteLine("Du sprang så snabbt så att du dog");
  Console.WriteLine("Vill du spela igen? (ja/nej)");
}

void PathC()
{
  Console.WriteLine("Du knäcker en tröcca");
  Console.WriteLine("Den svarta, typ mörkgråa figuren försvinner");
  Console.WriteLine("Du inser att det bara var abstinensen av tröcca som fick dig att se honom");
  Console.WriteLine("Vill du spela igen? (ja/nej)");
}

void homeA()
{
  Console.WriteLine("Du öppnar dörren och ser att du är hemma. Du gick ner till kylen och tog en kall tröcca. Du njöt.");
  Console.WriteLine("GRATTIS, DU ÖVERLEVDE!!!");
  Console.WriteLine("Vill du spela igen? (Ja/Nej)");
  Console.ReadLine();
}

void HomeB()
{
  Console.WriteLine("Du knäcker en tröcca och njuter. Du insåg sen att du var hemma. Du vann");
  Console.WriteLine("Vill du spela igen? (Ja/Nej)");
  Console.ReadLine();
}
void HomeC()
{
  Console.WriteLine("Du går och lägger dig, du ser sedan den svarta, typ mörkgråa figuren stå där.");
  Console.WriteLine("Du fick en abstinens attack och dog");
  Console.WriteLine("Vill du spela igen? (Ja/Nej)");
  Console.ReadLine();
}

//Bool och while loop för att kunna köra igen utan att starta om
bool replay = true;
while (replay)
{
  Start();
  string gång = AskForABC();

  if (gång == "a")
  {
    StartA();

    string replayChoice = Console.ReadLine().ToLower();
    if (replayChoice.ToLower() != "ja")
    {
      replay = false;
      Console.WriteLine("Tack för du har spelat");
    }
  }

  else if (gång == "b")
  {
    StartB();

    gång = AskForABC();


    if (gång == "a")
    {
      PathA();

      gång = AskForABC();


      if (gång == "a")
      {
        homeA();
        string replayChoice = Console.ReadLine().ToLower();
        if (replayChoice.ToLower() != "ja")
        {
          replay = false;
          Console.WriteLine("Tack för du har spelat");
        }
      }
      else if (gång == "b")
      {
        HomeB();
        string replayChoice = Console.ReadLine().ToLower();
        if (replayChoice.ToLower() != "ja")
        {
          replay = false;
          Console.WriteLine("Tack för du har spelat");
        }
      }

      else if (gång == "c")
      {
        HomeC();
        string replayChoice = Console.ReadLine().ToLower();
        if (replayChoice.ToLower() != "ja")
        {
          replay = false;
          Console.WriteLine("Tack för du har spelat");
        }
      }
    }
    else if (gång == "b")
    {
      PathB();
      string replayChoice = Console.ReadLine().ToLower();
        if (replayChoice.ToLower() != "ja")
        {
          replay = false;
          Console.WriteLine("Tack för du har spelat");
        }
    }
    else if(gång == "c")
    {
      PathC();
      string replayChoice = Console.ReadLine().ToLower();
        if (replayChoice.ToLower() != "ja")
        {
          replay = false;
          Console.WriteLine("Tack för du har spelat");
        }
    }
  }


  else if (gång == "c")
  {
    StartC();

    //String för att kunna starta om
    string replayChoice = Console.ReadLine().ToLower();
    if (replayChoice.ToLower() != "ja")
    {
      replay = false;
      Console.WriteLine("Tack för du har spelat");
    }
  }
}





Console.WriteLine("Tryck på valfri knapp för att avsluta");
Console.ReadLine();