//Bool och while loop för att kunna köra igen utan att starta om

bool replay = true;
while (replay)
{
  Console.WriteLine("Du vaknar upp på en buss hållplats.");
  Console.WriteLine("Du kollar namnet på hållplatsen");
  Console.WriteLine("SkitNamn. Vad är det för namn?");
  Console.WriteLine("Du ser att vägen går vänster och höger, bakom dig finns en stig.");
  Console.WriteLine("Vart går du?");
  Console.WriteLine("a) vänster, b) stigen, c) höger");
  string gå = "";
  string gång = "";
  while (gång != "a" && gång != "b" && gång != "c")
  {
    gång = Console.ReadLine().ToLower();
    if (gång != "a" && gång != "b" && gång != "c")
    {
      Console.WriteLine("Du har fan tappat det. JAG SA A B ELLER C");
    }

    if (gång == "a")
    {
      Console.WriteLine("Du går längs vägen, det är helt dött ute. Inga bilar eller människor");
      Console.WriteLine("Du hör inte ens en fågel kvittra. Du får en panikattack och dör");
      Console.WriteLine("Vill du spela igen? (ja/nej)");


      string replayChoice = Console.ReadLine().ToLower();
      if (replayChoice.ToLower() != "ja")
      {
        replay = false;
        Console.WriteLine("Tack för du har spelat");
      }
    }

    else if (gång == "b")
    {
      Console.WriteLine("Du går igenom stigen men ser inget.");
      Console.WriteLine("Det är HELT Kolsvart");
      Console.WriteLine("Du hör steg bakom dig och grenar knastra");
      Console.WriteLine("Du vänder dig om, tänder en ficklampa. Du blir rädd.");
      Console.WriteLine("Du ser en figur. Han är svart, typ mörkgrå. Du börjar kuta djupare in i skogen");
      Console.WriteLine("Du ser stigen fortsätta höger och vänster");
      Console.WriteLine("Vart går du?");
      Console.WriteLine("a) Höger b) Vänster c) Knäcker en tröcca");

      gång = AskForABC();

      gång = "";
      while (gå != "a" && gå != "b" && gå != "c")
        gå = Console.ReadLine().ToLower();
      if (gå != "a" && gå != "b" && gå != "c")
      {
        Console.WriteLine("Du har fan tappat det. JAG SA A B ELLER C");
      }

      if (gå == "a")
      {
        Console.WriteLine("Du börjar kuta höger");
        Console.WriteLine("Du har aldrig kutat så här snabbt i hela ditt liv.");
        Console.WriteLine("Du snubblar över en sten och ramlar.");
        Console.WriteLine("Du vaknar upp i ett hus. Du frågar dig själv");
        Console.WriteLine("Vart är jag?");
        Console.WriteLine("Du känner igen dig, men vet inte riktigt vart du är");
        Console.WriteLine("Du ser en dörr framför dig, en tröcca på ett bord bredvid dig och en säng bakom dig");
        Console.WriteLine("a) Dörren b) Tröccan c) Sängen");
        Console.ReadLine();

      }
    }


    else if (gång == "c")
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

      //String för att kunna starta om
      string replayChoice = Console.ReadLine().ToLower();
      if (replayChoice.ToLower() != "ja")
      {
        replay = false;
        Console.WriteLine("Tack för du har spelat");
      }
    }
  }

}

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

Console.WriteLine("Tryck på valfri knapp för att avsluta");
Console.ReadLine();