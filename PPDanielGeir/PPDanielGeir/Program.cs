﻿/*2) Butikkoversikt
    Denne appen skal gi en oversikt over hvilke butikker som finnes, hva som er spesialiteten deres (klær, matvarer, leker etc) 
    og prisnivået varene ligger på (1= billig 2=midt på treet 3=sinnsykt dyrt)
    Man skal også kunne legge til nye butikker, og få mulighet til å velge å se en 
    liste over alle butikker, velge å se kun de billigste, velge å se kun de som 
    er midt på treet prismessig eller velge å se bare de butikkene som er rangert 
    som sinnsykt dyre.
    BONUS
    Gjør så man også kan sortere/velge å se butikker som har en viss spesialitet f.eks klær i tillegg til å kunne sortere på pris. 
    Kjekt å se hvor man kan kjøpe billig mat og dyre designer klær, hehe ;)*/
    using PPDanielGeir;
    var shops =  new List<Shop>();
    shops.Add(new Shop("Kiwi", "food", 2 ));
    shops.Add(new Shop("Meny", "food", 3 ));
    shops.Add(new Shop("Elkjøp", "Electronics", 3 ));
    shops.Add(new Shop("Power", "Electronics", 2 ));
   
   var meny = new MainMeny();
   meny.Meny(shops);