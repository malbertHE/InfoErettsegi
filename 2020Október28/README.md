# Sorozatok feladat

A feladat leírás hivatalos forrása: https://dload-oktatas.educatio.hu/erettsegi/feladatok_2020osz_emelt/e_inf_20okt_fl.pdf  
Adat fájlok elérhetősége (e_inffor_20okt_fl.zip fájl): https://www.oktatas.hu/kozneveles/erettsegi/feladatsorok/emelt_szint_2020osz/emelt_8nap 

## Feladat leírása

Sok olyan sorozatrajongó van, aki folyamatosan követi a kedvelt sorozatait. 
Egy, az angol nyelvű sorozatokért rajongó személy feljegyzést készített egy nyolc hónapos időszak kedvenc sorozatairól.

A lista.txt fájl a rajongó által kedvelt sorozatok adásba kerülésének dátumát, a sorozat angol címét, az évadot és az epizód számát, az epizód hosszát percben és egy jelzést tartalmaz, 
hogy a lista készítője megnézte-e már azt az epizódot. Ezek az adatok egymás után külön sorokban szerepelnek. A fájlban biztosan 400-nál kevesebb epizódról van adat, epizódonként 5 sorban.

![/Doc/Sorozatok1.png](/2020Október28/Doc/Sorozatok1.png)

A példában látható, hogy a Puzzles című sorozat 3. évadának 10. epizódja 2018. 01. 19-én került adásba.
Az epizód 43 perces, és még nem nézte meg a lista készítője.
- A dátumokat mindig „éééé.hh.nn” formátumban rögzítették.
Vannak olyan sorozatrészek, amelyeknek a lista rögzítésekor még nem tudták az adásba kerülésük idejét.
Ezeknél a dátum helyett mindig az „NI” rövidítés szerepel.
- Az évad jelzése vezető nullák nélkül történik, az epizód számát pedig mindig két számjeggyel rögzítették.
Az évad és az epizód számát egy „x” választja el egymástól.
- Az egyes sorozatok epizódjai mindig ugyanolyan hosszúak.
- Az epizóddal kapcsolatos utolsó adat értéke „0” vagy „1”.
Az 1-es számjegy jelöli, hogy az adott részt már megtekintette a lista készítője, a 0 pedig azt, hogy még nem látta.

Készítsen programot a lista.txt állomány adatainak feldolgozására!
A program forráskódját mentse sorozatok néven!
(A program megírásakor a felhasználó által megadott adatok helyességét, érvényességét nem kell ellenőriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.) 

A képernyőre írást igénylő részfeladatok eredményének megjelenítése előtt írja a képernyőre a feladat sorszámát (például 2. feladat:)!
Ha a felhasználótól kér be adatot, jelenítse meg a képernyőn, hogy milyen értéket vár! Az ékezetmentes kiírás is elfogadott.

1. Olvassa be és tárolja el a lista.txt fájl tartalmát!
2. Írassa ki a képernyőre, hogy hány olyan epizód adatait tartalmazza a fájl, amelynek ismert az adásba kerülési dátuma!
3. Határozza meg, hogy a fájlban lévő epizódok hány százalékát látta már a listát rögzítő személy! A százalékértéket a minta szerint, két tizedesjeggyel jelenítse meg a képernyőn!
4. Számítsa ki, hogy összesen mennyi időt töltött a személy az epizódok megnézésével!
Az eredményt a minta szerint nap, óra, perc formában adja meg!
5. Kérjen be a felhasználótól egy dátumot „éééé.hh.nn” formában!
Határozza meg, hogy az adott dátumig megjelent epizódokból melyeket nem látta még!
Az aznapi epizódokat is számolja bele!
A feltételnek megfelelő epizódok esetén írja a képernyőre tabulátorral elválasztva az évad- és az epizódszámot, valamint a sorozat címét a minta szerint!
6. Készítse el az alábbi algoritmus alapján a hét napját meghatározó függvényt!
A függvény neve Hetnapja legyen!
A függvény az év, hónap és nap megadása után szöveges eredményként visszaadja, hogy az adott nap a hét melyik napja volt.
(Az a és b egész számok maradékos osztása esetén az a div b kifejezés adja meg a hányadost, az a mod b pedig a maradékot, például 17 div 7 = 2 és 17 mod 7 = 3.)
```
Függvény hetnapja(ev, ho, nap : Egész) : Szöveg
 napok: Tömb(0..6: Szöveg)= (″v″, ″h″, ″k″, ″sze″, ″cs″, ″p″, ″szo″)
 honapok: Tömb(0..11: Egész)= (0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4)
 Ha ho < 3 akkor ev := ev -1
 hetnapja := napok[(ev + ev div 4 – ev div 100 +
 ev div 400 + honapok[ho-1] + nap) mod 7]
Függvény vége
```
7. Kérjen be a felhasználótól egy napot az előző feladatban látható rövidített alakban!
A napokat egy (h, k, p, v), kettő (cs), vagy három (sze, szo) karakterrel adja meg!
Határozza meg, hogy a fájlban lévő sorozatok közül melyike(ke)t vetítik az adott napon!
A sorozatok nevét a minta szerint jelenítse meg a képernyőn!
Ha az adott napon egy sorozatot sem adtak adásba, akkor „Az adott napon nem kerül adásba sorozat.” üzenetet jelenítse meg!
8. Határozza meg sorozatonként az epizódok összesített vetítési idejét és az epizódok számát!
A számításnál vegye figyelembe a vetítési dátummal nem rendelkező epizódokat is!
A megoldás során felhasználhatja, hogy egy sorozat epizódjainak adatai egymást követik a forrásállományban. A listát írja ki a summa.txt fájlba!
A fájl egy sorában a sorozat címe, az adott sorozatra vonatkozó összesített vetítési idő percben és az epizódok száma szerepeljen szóközzel elválasztva! 

Minta a szöveges kimenetek kialakításához:  
```
2. feladat
A listában 202 db vetítési dátummal rendelkező epizód van.

3. feladat
A listában lévő epizódok 45,66%-át látta.

4. feladat
Sorozatnézéssel 2 napot 15 órát és 32 percet töltött.

5. feladat
Adjon meg egy dátumot! Dátum= 2017.10.18
7x01 The Fable
7x02 The Fable
15x04 Military Police
5x03 Spy School
5x04 Spy School
4x04 The Elite Minds

7. feladat
Adja meg a hét egy napját (például cs)! Nap= cs
The Hospital
Spectacular Power
Upper Story
Chicago Flame
Shrinktime
```

Minta a summa.txt fájl kialakításához:
```
Games 420 7
The Fable 588 14
The IT Guy 450 10 
```

## Megoldás magyarázata
A legtöbb érettségire készülő diák szeretné az érettségit minél kevesebb tanulással megúszni.
Valószínű te is.
Csak azok tanulnak egy adott tárgyra többet, akik vagy hajtanak a 'jegyre' vagy az adott tárgy felkeltette az érdeklődésüket.
Én csak bíztatni tudlak, hogy a programozás keltse fel az érdeklődésedet, de tudom, hogy sokan csak túl akarnak jutni egy újabb megmérettetésen és úgy gondolták, hogy az informatikát könnyebb letudni, mint például a kémiát, hiszen amúgy is folyamatosan a gép előtt ülsz.
Azt viszont sokan nem veszik figyelembe, hogy egy dolog játszani vagy filmet nézni a számítógépen és egy másik azt programozásra használni.
Ennek a példának a bemutatásában arra törekszem, hogy még az eddig bemutatott megoldásoknál is kevesebb tanulással tudd megúszni, ha te csak túl akarsz jutni az érettségin.

A kevés tanulás a C# nyelven azt jelenti, hogy csak pár 'parancsot' tanulsz meg és pár 'mintát'.
Itt nem lesz Linq, ciklusoknál csak a for lesz használva, nem készítünk saját típust és igyekszünk mindent megoldani a legkevesebb C# tudással.

Az első feladat, az adatbeolvasás egy sor.
Egy szöveg tömbbe beolvassuk a megadott nevű fájlból az adatokat.
Nem dolgozzuk tovább fel, mert ahhoz egy saját típust kéne készítsünk.
Megoldható anélkül is, csak egy kicsit többet kell gépelni.

A második feladatot egy for ciklussal oldjuk meg, de ezúttal nem egyesével, hanem ötösével léptetjük a ciklus számlálót, mert egy entitás, vagyis egy egyed adatai 5 sorban vannak.
Használunk egy számlálót, amit 0-tól indítunk és akkor növeljük eggyel, ha az i-edik elem, vagyis a dátum nem egyenlő 'NI'-vel, vagyis ismert a vetítés dátuma.

A harmadik feladatban is egy hasonló for ciklust használunk, mint a másodikban.
Ezúttal viszont nem az i-edik, hanem az i+4-edik elemet vizsgáljuk, mert az tartalmazza azt, hogy megnézték-e a sorozatot vagy nem.

A negyedik feladat for ciklusa azonos a harmadik feladatéval, annyi a különbség, hogy a ciklusmagban, ha növelni kell, akkor a megadott percnyi értékkel növelünk és nem eggyel, mert nem darabszámot számolunk, hanem az összesen eltelt percek számát, legalábbis azokból a sorozatokból amiket megnéztek.
Itt nem árt arról tudni, hogy kevesebb számolással is meg lehet úszni, ha az eltelt percek számát betöltöd egy [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=net-6.0) változóba, de itt most ezt kihagytam, mert arról volt szó, hogy a lehető legkevesebb tudással oldjuk meg a feladatot.

Az ötödik feladatnál mindenképpen meg kell tanulni még valamit, hogy megoldható legyen.
Vagy azt, hogy hogyan lehet kivágni egy részt egy karakterláncból vagy azt, hogy létezik dátum típus.
Ezen kívül más megoldások is vannak, de ahhoz még többet kéne megtanulni.
Mivel a két megoldás közül a dátum típus ad egyszerűbb és szebb megoldást, ezért itt most ezt választottam.

A hatodik feladatnál valósítsuk meg a pszeudokódot pont úgy ahogy kéri.

A hetedik feladatnál a dátumot ismét dátum típusra alakítjuk.
Lehetne a karakterláncból csak az évet, hónapot, napot kivenni, de akkor már megint egy új dolgot kéne megtanulni.
A tömböt már használtuk, és használhatnánk most is, de szerintem minimum, hogy a listákat is ismerjük érettségi feladat megoldásánál.
Lista nélkül tömböt kéne használni és a tömb növelése, vagy egy statikus de jó nagy tömb létrehozása ahova biztosan elférnek az adatok nagyon csúnya megoldások lennének.

Ráadásul itt a hetedik feladatnál csaltam.
Azt ígértem, hogy a lehető legkevesebb tudással oldjuk meg, e helyett használtam a listák Contains függvényét.
Ezt fel lehetne cserélni for ciklusra, de ez már a te feladatod lesz.

A nyolcadik feladatnál ismét okoz egy kis problémát, hogy nem készítettünk saját típust.
Lenne még több lehetőségünk is, például használhatnánk a Tuple osztályt, de az már megint egy új valami, amit meg kéne tanulni.
Én továbbra is azt mondom, hogy tanuld meg ezeket, de ha nem tanultad meg, akkor se akadj el.
Megoldhatod 3 lista használatával vagy megoldhatod 1 listával és több for ciklussal.
Mindegyik megoldás nagyon csúnya.
Sokkal többet kell gépelned és folyamatosan szem előtt kell tartanod az egyedi megoldásod korlátait, pl. ha 3 listával oldod meg, akkor figyelned kell arra, hogy azonos indexen azonos entitások legyenek.
Ez van. Ha valaki nem tanul, akkor szenved.
A lényeg, hogy ne es kétségbe.
Kellenek azok a pontok, úgyhogy oldjuk meg 3 listával.
A feladat megoldásánál, ha már a feladat leírása felajánlja, használjuk fel azt az infót, hogy egy sorozat epizódjainak adatai egymást követik.
Így könnyebb megoldani for ciklus esetén és most ez a cél.
Persze, ha most használhatnánk Linq kifejezéseket, akkor ezzel se kéne foglalkozni.
Alkalmazunk még egy trükköt, hogy egy újabb listát és/vagy egy újabb ciklust megspóroljunk, a sorozatNevek listába folyamatosan javítjuk a nevet arra amit majd ki kell írni a fájlba.
Ezt kiírhatnánk a [FileStream](https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-6.0) segítségével, ahelyett, hogy a sorozatNevek listával szórakozunk, de ez ugye megint új ismereteket igényelne.

## További gyakorló feladatok
- A Contains függvényt alakítsd át ciklusra.
- Készíts saját típust a 8. feladathoz és old meg egy listával és ne hárommal.
- Én azt javaslom, hogy inkább tanulj egy kicsivel többet és old meg az egészet úgy, hogy ne használj egy for ciklust se.
Nem azért mert feltétlenül minden helyzetben az a legjobb megoldás, hanem azért, hogy gyakorolj és lásd a különbséget.

## Megjegyzés
Nagyon gáz így fejleszteni, ha csak pár dolgot ismersz.
Csúnya és néha átláthatatlan kódok jönnek így létre.
