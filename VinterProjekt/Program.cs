bool replay = true;
while (replay)
{
Console.WriteLine("Du vaknar upp på en buss hållplats.");
Console.WriteLine("Du kollar namnet på hållplatsen");
Console.WriteLine("SkitNamn. Vad är det för namn?");
Console.WriteLine("Du ser att vägen går vänster och höger, bakom dig finns en stig.");
Console.WriteLine("Vart går du?");
Console.WriteLine("a) vänster, b) stigen, c) höger");
Console.ReadLine();

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
    Console.WriteLine("a) Vänster b) Höger c) Knäcker en tröcca");
  }

  else if (gång == "c")
  {
    Console.WriteLine("Du ser en ung dam. Hon är blond och har på sig en klänning");
    Console.WriteLine("Du känner igen henne, men är inte helt säker på vem det är");
    Console.WriteLine("Nu minns du. Det är Askungen");
    Console.WriteLine("Ilskan tar över din kropp och blodet börjar koka, DU KOKAR!!");
    Console.WriteLine("Hon vill prata, men du förstår inget, ilskan tar över");
    Console.WriteLine("Du ger henne en fet högerkrok så hon hamnar på marken.");
    Console.WriteLine("Du släpar sedan henne till en bro och släpper ned henne.");
    Console.WriteLine("Du vinkar hejdå.");
    Console.WriteLine("Du vaknar sedan upp på busshållplatsen och insåg att det var PTSD");
    Console.WriteLine("Du knäcker en trocca och ringer en taxi hem.");
    Console.WriteLine("Vill du spela igen? (ja/nej)");
  
  string replayChoice = Console.ReadLine().ToLower();
  if (replayChoice.ToLower() != "ja")
  {
    replay = false;
    Console.WriteLine("Tack för du har spelat");
  }
  }
  }

}
Console.WriteLine("Tryck på valfri knapp för att avsluta");
Console.ReadLine();