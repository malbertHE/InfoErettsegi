# Gödör feladat

A feladat leírás hivatalos forrása: https://dload-oktatas.educatio.hu/erettsegi/feladatok_2021tavasz_emelt/e_inf_21maj_fl.pdf
A forrás fájlokat innen tudjuk leszedni (e_inffor_21maj_fl.zip fájl): https://www.oktatas.hu/kozneveles/erettsegi/feladatsorok/emelt_szint_2021tavasz/emelt_11nap 

## Feladat leírása

Egy teljesen sík terepen a talaj olyan anyagból van, ami nem ereszti át a vizet. Ezen a területen egy egyenes mentén munkagépekkel 10 méter széles csatornát építenek. 
A munka még nem készült el, ezért a csatorna mélysége nem állandó, helyenként a felszín is érintetlen.
A már elkészült résszel, mint különálló gödrök sorozatával foglalkozik a feladat. 
Az egyszerûbb kezelés érdekében a gödröket úgy tekintjük, hogy oldalfaluk függõleges, teljes szélességben azonos mélységû, így a keresztmetszeti kép jól leírja a terepviszonyokat.

![/Doc/Godor1.png](/2021Május21/Doc/Godor1.png)

A melyseg.txt fájlban méterenként rögzítették, hogy azon a szakaszon milyen mélyen van a gödör alja. Minden sor egy-egy egész számot tartalmaz, amely a mélység értékét mutatja – szintén méterben.
A fájl legfeljebb 2000 számot tartalmaz, értékük legfeljebb 30 lehet.
Tudjuk, hogy az elsõ és az utolsó méteren sértetlen a felszín, tehát ott biztosan a 0 szám áll.

![/Doc/Godor2.png](/2021Május21/Doc/Godor2.png)

A fenti példában látható keresztmetszeti képen a melyseg.txt bemeneti fájl tartalmának a kezdete látható.
Az egyszerûbb szemléltetés miatt a forrásfájlban külön sorokban szereplõ értékeket itt az ábrán egymás mellett szerepeltetjük.
Leolvasható, hogy az elsõ méteren 0 a mélység.
Az elsõ gödör a 7. méteren kezdõdik.
Az elsõ gödör 16 méter hosszan tart, legnagyobb mélysége 4 méter, térfogata 440 m^3 . A második gödör a 26. méternél kezdõdik, 3 méter hosszan tart, térfogata 60 m^3.

Készítsen programot, amely a melyseg.txt állományt felhasználva az alábbi kérdésekre válaszol!
A program forráskódját mentse godor néven!
(A program megírásakor a felhasználó által megadott adatok helyességét, érvényességét nem kell ellenõriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.)

A képernyõre írást igénylõ részfeladatok eredményének megjelenítése elõtt írja a képernyõre a feladat sorszámát (például: 2. feladat)! 
Ha a felhasználótól kér be adatot, jelenítse meg a képernyõn, hogy milyen értéket vár! Az ékezetmentes kiírás is elfogadott.

1. Olvassa be és tárolja el a melyseg.txt fájl tartalmát! Írja ki a képernyõre, hogy az adatforrás hány adatot tartalmaz!
2. Olvasson be egy távolságértéket, majd írja a képernyõre, hogy milyen mélyen van a gödör alja azon a helyen! Ezt a távolságértéket használja majd a 6. feladat megoldása során is!
3. Határozza meg, hogy a felszín hány százaléka maradt érintetlen és jelenítse meg 2 tizedes pontossággal!
4. Írja ki a godrok.txt fájlba a gödrök leírását, azaz azokat a számsorokat, amelyek egy-egy gödör méterenkénti mélységét adják meg!
Minden gödör leírása külön sorba kerüljön! 
Az állomány pontosan a gödrök számával egyezõ számú sort tartalmazzon!
A godrok.txt fájl elsõ két sorának tartalma:  
 2 2 2 2 4 4 3 2 2 3 3 4 4 3 2 2  
 2 2 2
5. Határozza meg a gödrök számát és írja a képernyõre!
6. Ha a 2. feladatban beolvasott helyen nincs gödör, akkor „Az adott helyen nincs gödör.” üzenetet jelenítse meg, ha ott gödör található, akkor határozza meg, hogy  
a) mi a gödör kezdõ és végpontja! A meghatározott értékeket írja a képernyõre! 
(Ha nem tudja meghatározni, használja a további részfeladatoknál a 7 és 22 értéket, mint a kezdõ és a végpont helyét)  
b) a legmélyebb pontja felé mindkét irányból folyamatosan mélyül-e! 
Azaz a gödör az egyik szélétõl monoton mélyül egy pontig, és onnantól monoton emelkedik a másik széléig. 
Az eredménytõl függõen írja ki a képernyõre a „Nem mélyül folyamatosan.” vagy a „Folyamatosan mélyül.” mondatot!  
c) mekkora a legnagyobb mélysége! A meghatározott értéket írja a képernyõre!  
d) mekkora a térfogata, ha szélessége minden helyen 10 méternyi!
A meghatározott értéket írja a képernyõre!  
e) a félkész csatorna esõben jelentõs mennyiségû vizet fogad be.
Egy gödör annyi vizet képes befogadni anélkül, hogy egy nagyobb szélvihar hatására se öntsön ki, amennyi esetén a víz felszíne legalább 1 méter mélyen van a külsõ felszínhez képest.
Írja a képernyõre ezt a vízmennyiséget!


Minta a szöveges kimenetek kialakításához:  
```
1. feladat  
A fájl adatainak száma: 694  
2. feladat  
Adjon meg egy távolságértéket! 9  
Ezen a helyen a felszín 2 méter mélyen van.  
3. feladat  
Az érintetlen terület aránya 10.09%.  
5. feladat  
A gödrök száma: 22  
6. feladat  
a)  
A gödör kezdete: 7 méter, a gödör vége: 22 méter.  
b)  
Nem mélyül folyamatosan.  
c)  
A legnagyobb mélysége 4 méter.  
d)  
A térfogata 440 m^3.  
e)  
A vízmennyiség 280 m^3.
``` 

## Megoldás magyarázata
Nem minden sort magyarázok meg, mert nagyon egyértelmûek, csak azokat a sorokat, ahol valami lényeges történik:
- Az elsõ feladatunk, hogy beolvassunk az adatokat a melyseg.txt fájlból. Ezt meg is tesszük és letároljuk a felszín tömbben. A beolvasástól kezdve a fájl tartalmát el tudjuk érni a felszín tömbben.
Szintén az elsõ feladat része volt, hogy kiírjuk a fájl adatainak számát. Mivel minden sorban 1 adat volt, ezért ez egyenlõ a tömb elemszámával. Ha 2 soronként lenne egy adat, akkor a tömb elemszámát osztanánk kettõvel.
- A második feladatban be kell kérjünk egy számot. Mivel csak szöveget tudunk bekérni, ezért a bekérést követõen át is alakítjuk számmá és azonnal átadjuk ezt az értéket a	godorIndex változónkra.
Az így beolvasott index segítségével a felszín tömb adott elemét fel tudjuk használni kiíratásra. Fontos, hogy a megadott godorIndex változóból vonjunk ki egyet, mert a tömbök sorszámozása 0-tól indul.
- A harmadik feladatban leszûrjük a felszín tömböt azokra az elemekre, amik értéke 0, majd ezeket a Length segítségével megszámoljuk. Ez után már tudunk százalékot számítani.
A kiírásnál figyelni kell a két tizedes jegy kiírással, mert a százalék számításunk ettõl kicsit pontosabb.
- A negyedik feladat megoldásához felhasználunk egy forech ciklust, amivel végig megyünk a felszínen és megnézzük, hogy hol van gödör.
Ahol gödör kezdõdik, ott kiírjuk a gödör adatai a godrok lista soron következõ elemére. 
A godorMelysegek karakterláncban gyûjtjük össze a gödör információit, vagyis a méterenkénti mélység értékeket.
A végén a godrok lista tartalmát írjuk ki a godrok.txt fájlba.
- Az ötödik feladatunk az elõbbi megoldásnak köszönhetõen nagyon leegyszerûsödött, csak a godrok lista elemszámát kell kiírjuk.
- A hatodik feladatban a megadott godorIndex-en lévõ elemrõl írunk ki információkat.
Ez a legbonyolultabb rész.
Elsõként megvizsgáljuk, hogy van-e az adott helyen gödör.
Amennyiben van gödör az adott helyen, akkor megkeressük a gödör elejét és végét 2 for ciklussal.
Az így megtalált részbõl folyamatosan kiszedjük az értéket és egy másik szám listába írjuk ki, hogy a feladat többi pontját egyszerûsítsük.
Ez után meghatározzuk, hogy a gödör folyamatosan mélyül-e vagy sem.
Itt már az új szám listával dolgozunk, mert a számokat könnyen össze tudjuk hasonlítani, hogy melyik nagyobb.
A feladat többi részét egyszerûsítjük, a maximum kereséshez a Max függvényt, a térfogat és vízmélység számításhoz a Sum függvényt használjuk fel.
Ez sokkal egyszerûbbé és átláthatóvá teszi az adott alpontok megoldását.

## Javaslat
Másold le magadhoz a projektet és próbáld meg a ciklusokat helyettesíteni Linq függvényekkel.
Próbáld megfejteni ezeknek a Linq függvények az elõnyeit és korlátait ezekben az esetekben.