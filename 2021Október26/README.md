# Sudoku feladat

A feladat leírás hivatalos forrása: https://dload-oktatas.educatio.hu/erettsegi/feladatok_2021osz_emelt/e_inf_21okt_fl.pdf  
Adat fájlok elérhetõsége (e_inffor_21okt_fl.zip fájl): https://www.oktatas.hu/kozneveles/erettsegi/feladatsorok/emelt_szint_2021osz/emelt_8nap

## Feladat leírása

A sudoku egy logikai játék, melyben megadott szabályok szerint számjegyeket kell elhelyezni egy táblázatban.
Ebben a feladatban 9×9-es táblázatot használunk.

A táblázat – az alábbi ábrának megfelelõen – 9 darab 3×3-as résztáblázatra van felosztva.
Minden résztáblázatot az 1, 2, 3, 4, 5, 6, 7, 8, 9 számokkal kell kitölteni úgy, hogy az egész 9×9-es táblázat minden sorában és minden oszlopában az 1...9 számok mindegyike pontosan egyszer forduljon elõ.
A rejtvény készítõje elõre ki szokta tölteni a táblázat bizonyos celláit.
A rejtvényfejtõ feladata kitölteni a maradék cellákat a leírt szabályoknak megfelelõen.

A bemenetet tartalmazó szövegfájlok elsõ 9 sorának mindegyike 9 egész számot tartalmaz, a játék kiindulási állapotának megfelelõen.
A kitöltetlen mezõk helyén a 0 szám olvasható.
A következõ néhány sorban a játékos egy-egy lehetséges kitöltési lépését rögzítették.
Egy lépést három egész szám ír le: a számot, amelyet a játékos be akar írni, majd a sor és az oszlop számát, ahova írni szeretné.
A bemeneti fájl egy-egy sorában a számokat egy-egy szóköz választja el egymástól.
A táblázat ellentmondásmentes, tehát megoldható feladatot ír le.
A játékos által megtett lépések száma legalább 1, legfeljebb 10, közöttük lehet hibás.

Például:  
![/Doc/Sudoku1.png](/2021Október26/Doc/Sudoku1.png)  
![/Doc/Sudoku2.png](/2021Október26/Doc/Sudoku2.png)

A fenti példában a nehez.txt bemeneti fájl tartalma látható.
A 10. sorban szereplõ számok azt jelentik, hogy a 9-es értéket kell a 2. sor 4. helyére beírni.
Az adott sorban és az adott oszlopban nem szerepel még a 9-es, sõt, az érintett négyzetben sem, így a lépéssel nem alakul ki hiba, megtehetõ.
A 11. sorbeli lépés is megtehetõ. A 13. sor hibás lépést tartalmaz, mert a 2. sorban már szerepel a 7-es szám.

A jobb oldalon látható képen a körbe írt számok megadják, hogy az egyes 3×3 méretû résztáblákat milyen számmal azonosítjuk.

Készítsen programot, amely a bemeneti állományok egyikét felhasználva (konnyu.txt, kozepes.txt, nehez.txt) az alábbi kérdésekre válaszol!
A program forráskódját mentse sudoku néven!
(A program megírásakor a felhasználó által megadott adatok helyességét, érvényességét nem kell ellenõriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.)

A képernyõre írást igénylõ részfeladatok eredményének megjelenítése elõtt írja a képernyõre a feladat sorszámát (például: 4. feladat)! Ha a felhasználótól kér be adatot, jelenítse meg a képernyõn, hogy milyen értéket vár!
Az ékezetmentes kiírás is elfogadott.

1. Olvassa be egy fájl nevét, egy sor és egy oszlop sorszámát (1 és 9 közötti számot)!
A késõbbi feladatokat ezen értékek felhasználásával kell megoldania!
2. Az elõzõ feladatban beolvasott névnek megfelelõ fájl tartalmát olvassa be, és tárolja el a táblázat adatait!
Ha ezt nem tudja megtenni, akkor használja forrásként a rendelkezésre álló állományok egyikét!
3. Írja ki a képernyõre, hogy a beolvasott sor és oszlop értékének megfelelõ hely...  
a) milyen értéket tartalmaz!
Ha az adott helyen a 0 olvasható, akkor az „Az adott helyet még nem töltötték ki.” szöveget jelenítse meg!  
b) melyik résztáblázathoz tartozik!
4. Határozza meg a táblázat hány százaléka nincs még kitöltve!
Az eredményt egy tizedesjegy pontossággal jelenítse meg a képernyõn!
5. Vizsgálja meg, hogy a fájlban szereplõ lépések lehetségesek-e a beolvasott táblázaton!
Tekintse mindegyiket úgy, mintha az lenne az egyetlen lépés az eredeti táblázaton, de ne hajtsa azt végre!
Állapítsa meg, hogy okoz-e valamilyen ellentmondást a lépés végrehajtása!
Írja ki a lépéshez tartozó három értéket, majd a következõ sorba írja az alábbi megállapítások egyikét! Ha több megállapítás is igaz, elegendõ csak egyet megjelenítenie.
- „A helyet már kitöltötték”
- „Az adott sorban már szerepel a szám”
- „Az adott oszlopban már szerepel a szám”
- „Az adott résztáblázatban már szerepel a szám”
- „A lépés megtehetõ”

Minta a szöveges kimenetek kialakításához:  
```
1. feladat
Adja meg a bemeneti fájl nevét! konnyu.txt
Adja meg egy sor számát! 1
Adja meg egy oszlop számát! 1

3. feladat
Az adott helyen szereplõ szám: 5
A hely a(z) 1 résztáblázathoz tartozik.

4. feladat
Az üres helyek aránya: 17.3%

5. feladat
A kiválasztott sor: 2 oszlop: 4 a szám: 9
A helyet már kitöltötték.
A kiválasztott sor: 3 oszlop: 6 a szám: 7
A lépés megtehetõ.
A kiválasztott sor: 6 oszlop: 6 a szám: 3
A résztáblázatban már szerepel a szám.
A kiválasztott sor: 7 oszlop: 9 a szám: 8
Az adott oszlopban már szerepel a szám.
```

## Megoldás magyarázata
A feladat elsõ része nem sok magyarázatra szorul. 
Egyszerûen beolvasunk egy fájl nevet, egy sor és egy oszlop sorszámot.
Ne feledd soha, a tömb 0-tól számozott, így amikor valaki megadja, hogy 1 sor, akkor az 0. sort jelent vagyis mindig x-1 lebegjen a szemed elött.

A második feladatnál az adatok beolvasása fájlból ugyanaz az egy sor, amit mindegyik feladatnál használtunk. 
Ezzel megvan a második feladatra is a pontod, de, hogy a harmadik feladatot könnyebben meg tudd oldani, ezért az adatbetöltésnél a sudoku táblát célszerû feldolgozni.
Elõször is nem egy szokásos egydimenziós listába vagy tömbbe töltjük át az adatokat, hanem egy többdimenziós tömbbe.
A sudoku táblát tekinthetjük egy 9x9-es mátrixnak.
A feladat szerint az elsõ 9 sor tartalmazza a sudoku mátrixot.
Ez azt jelenti, hogy a fájlból betöltött adatokból csak ez a 9 sor kell.
Egy lehetõség, ha egy ciklussal végig megyünk a teljes listán, de csak az elsõ 9 sort dolgozzuk fel, vagyis valahogy így:
```csharp
    List<string> sudokuAdatSorok = new List<string>;
    for (int i = 0; i < 9; i++)
        sudokuAdatSorok.Add(adatSorok[i]);
```
Ezt a ciklust kiválthatjuk egy sokkal elegánsabb és átláthatóbb megoldással, valahogy így:
```csharp
    string[] sudokuAdatSorok = adatSorok.Take(9).ToArray());
```
A második megoldás jóval rövidebb, kevesebb idõ alatt begépeled és átláthatóbb is.
A [Take](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take?view=net-6.0) függvény segítségével az eredeti tömb elsõ 9 elemét másoltuk át a sudokuAdatSorok tömbbe.

Természetesen ez nem elég, hiszen a sorokat is szét kell szedni és át is kell alakítani.
Gyorsan be lehet látni, hogy a for ciklus viszonylag könnyen kiváltható a Linq függvényekkel és fordítva, a legtöbb esetben.
Ez a második feladat pont alkalmas arra, hogy kissé bonyolult helyzetekben is meg tudjuk ezt vizsgálni.
Nézzük egyszer for ciklusal:
```csharp
    byte[,] mátrix = new byte[9, 9];
    for (int i = 0; i < adatSorok.Length; i++)
    {
        string[] adatMezõkASorban = adatSorok[i].Split(' ');
        for (int j = 0; j < adatMezõkASorban.Length; j++)
            mátrix[i, j] = byte.Parse(adatMezõkASorban[j]);
    }
```
Jól látható, hogy 2 ciklus, egy soronkénti Split és egy adattagonkénti Parse mûveletre volt szükség.
Most lássuk Linq-val:
```csharp
    byte[][] mátrix = adatSorok.Take(9).Select(sor => sor.Split(' ').Select(érték => byte.Parse(érték)).ToArray()).ToArray();
```
Bár elsõre nem biztos, hogy látszik, de a második megoldásban itt is kevesebb karakterleütésre volt szükség.
Természetesen ez nagyban függ az általunk választott változónevektõl is.
Nem állítom, hogy a második megoldás most sokkal egyszerûbb kezdõnek, mint az elsõ, de ha rááll a szemed, idõvel a második megoldást jobban fogod szeretni olvasni, mint az elsõt.
Egyszerûen nem kell azon gondolkodni, hogy a ciklus adott iterációjában mi történik, csak olvasni kell, mint egy mondatot.
Nézzük meg körülbelül hogyan lehet ezt olvasni:  
A mátrix kétdimenziós tömbbe betöltjük az adatSorok egy dimenziós tömbbõl az elsõ 9 'sorának' (elemének) a szóközöknél szétdarabolt részeit, melyeket int típussal tárolunk.  
Olvasható mint egy mondat, szemben az elsõ megoldásal, ami szintén könnyen olvasható de ahhoz, hogy mondatszerûen kiolvassuk értelmeznünk kell a ciklus magot.
Nem túl bonyolult, de értelmezni kell.  

Azt azért megemlítem, hogy a második megoldás sebessége a fordító optimalizálásának hatékonyságától vagy hatékonytalanságától függ.
Ez azt jelenti, hogy ha nem vagy biztos benne, hogy mi történik fordításkor, de fontos a sebességre optimalizálás, akkor a for ciklus a barátod.
Az érettségin bármelyik megoldást választhatod, amelyik szimpatikusabb vagy jobban megérted, mert sebességre optimalizálással nem kell foglalkoznod.
Ez is jó hír :) !

A mátrix táblát szépen értelmeztük, a további feladatokban könnyen használhatjuk, de a lépésekkel még semmit se kezdtünk.
Egyenlõre viszont nincs is szükség az értelmezésére.
Az én tanácsom, hogy amivel nem kell foglalkozni, azzal ne foglalkozz, majd csak akkor, ha szükség van rá, mert ha elakadsz a részletekben, akkor nem gyûlnek a pontjaid, neked pedig most ez lesz a legfontosabb, minél rövidebb idõ alatt minél több pontot gyûjteni.

A harmadik feladat elsõ fele nagyon egyszerû lett, miután szépen betöltöttük egy mátrixba a sudoku táblát, a második része viszont kicsit bonyolultabb.
Annyira érdekes ez a rész, hogy külön kiemeltem egy függvénybe, hogy nevet tudjak adni neki. 
Így névvel ellátva már könnyebben értelmezhetõ.
Próbáld észrevenni, hogy a számítástechnikában a matematika a barátod.
Megoldhatnád ez a feladatrészt sokféle képen például ciklusokkal és elágazásokkal de azzal sok idõd menne el és lehet, hogy belegabalyodnál.
Törekedj az egyszerû és szép megoldásokra, különben belezavarodsz.

A negyedik megoldásban a Linq feneketlen kútjába tekinthetsz be.
Nem baj, ha bele szédülsz, mert nagyon jól használható.
Itt is bemutatnám, hogy oldhatod meg ciklussal és hogy oldhatod meg a Linq egy másik lehetõségével.
Lássuk for ciklussal:
```csharp
    int nullásÉrtékekSzáma = 0;
    for (int i = 0; i < 9; i++)
        for (int j = 0; j < 9; j++)
            if (mátrix[i][j] == 0)
                nullásÉrtékekSzáma++;
    float üresHelxekAránya = (float)nullásÉrtékekSzáma / (9 * 9) * 100;
```
Ugyanez Linq-val:
```csharp
    float üresHelyekAránya = (from sor in mátrix from mezõ in sor where mezõ == 0 select mezõ).Count() / (9 * 9) * 100;
```
Elõször olvassuk ki aztán szedjük szét. Kiolvasva ez valahogy így hangzana (már ha éppen olvasod):
az üresHelyekAránya változóba beletöltjük a mátrixból a soroknak azon mezõit, amelyek megegyeznek 0-val, majd megszámoljuk õket és elosztjuk a sudoku tábla mezõszámaival majd százzal megszorzunk, vagyis a 0-ás mezõk százalékát számoljuk ki.  
Nézzük ezt szétszedve.
Láthatod, hogy [pár új kulcsszó](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords) került be a kódba.
A from kulcsszó segítségével egy tömbbõl vagy listából ki tudunk emelni elemeket, melyekre a where kulcsszó után feltételeket adunk, majd a select után megadjuk, hogy mit is akarunk ebbõl kiszedni.
A jó ebben az egészben, hogy akármilyen mélységig, vagyis bármilyen dimenzióig boncolgathatjuk a tömbünket.
Most 2 dimenziós tömbünk volt.
Az elsõ from segítségével kiszedtük a mátrixból a sort, amit egy sor nevû változóval láttunk el, ami már egy dimenziós és a második from segítségével abból kivettük a mezõket, amit egy mezõ változónévvel láttunk el.
Jól olvasható, hogy a sor-t a mátrix-ból, a mezõ-t a sor-ból szedtük ki.
Ezek után a mezõre egy feltételt adtunk meg, mégpedig azt, hogy 0 legyen, majd az így kapott adatcsomagból a select segítségével kiválasztottuk a mezõt.
Ez itt most talán kicsit érthetetlennek tûnik, de itt nem mindig csak egy 'valamibõl' választhatunk.
Aki jártas egy kicsit az SQL-ben, annak a fenti megoldást nem nehéz átlátnia.
Ha megtetszett, akkor gyakorold be és lesz még egy fegyvered az érettségin a kezedben.

Itt a negyedik feladatnál van még 2 probléma.  

Az egyik, hogy a C#-ban 2 egész számot elosztva egy egész számot fogsz kapni!
ÉRTED? Mert érettségin nem fogod érteni, hogy mi történik.
Csak azt fogod látni, hogy az eredményed nem az amire vártál.
Éppen ezért ilyen esetben az egyik számot 'átalakítjuk' tört számmá vagy úgy is mondhatnánk, hogy [explicit típus konverziót alkalmazunk](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions).
Itt most a (float) segítségével kényszerítettük ki ezt.

A másik probléma, hogy 2 tizedes jegyig kell megformázni.
Ahogy én láttam az érettségin vagy egész számokkal foglalkozol, vagy tört számokkal, de ezekben az esetekben a kiírásokat rendszerint 2 tizedesjegy pontossággal kéri.
Gyakorold be az itteni megoldást, vagy [nézz utána]((https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)), milyen lehetõségeid vannak még.

Az ötödik feladatnál elérkezünk oda, hogy foglalkoznunk kell az adat fájl többi sorával is nem csak az elsõ 9 sorral.
Itt érdemes saját típust létrehozni.
Én most ugyan ebben a fájlban hozom létre, neked is ezt javaslom, hogy ha mégis másolnod kell valahova a forrást, akkor csak egy fájlt kelljen másolnod.
Normál esetben minden 'saját  típust' külön fájlba hozunk létre, aminek a neve megegyezik a típus nevével.
Így könnyebb megtalálni a dolgokat egy fájlkezelõbõl is, de te most nem kell foglalkozz ezzel.
Ezt az új típust felhasználva létrehozunk egy olyan listát, amiben a lépések vannak eltárolva.
A lépések listába az adatSorok tömbbõl kiszedjük a 9. sortól kezdve a sorokat.
Ezt a [Skip](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skip?view=net-6.0) függvény segítségével tesszük meg.
Ami itt még új, hogy kiválasztásnál nem csak a lista egy adatát vagy többet kiválasztunk és abból tömböt vagy listát készítünk, hanem egy új objektumot hozunk létre egy Lépés objektumot, majd ezekbõl készítünk listát.
Menet közben még a szövegesen tárolt számokat számmá alakítjuk, így a lépések listában rendelkezésre állnak az adatok, amiket fel fogunk használni.
A kiíráshoz egy ForEach metódust használunk fel.
Ezzel megspóroljuk a ciklus írást.
A kiírandó információk összeszedéséhez készítünk egy függvényt.
A függvényben olyan dolgok vannak amik már korábban meg lettek magyarázva, így ezekre most nem térek ki ismét.

Ami érdekes még, a Lépés saját típus kapott egy függvényt, mégpedig egy speciális függvényt, aminek a neve a [ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-6.0).
Ide bármilyen függvényt megírhattunk volna, aminek más a neve és akkor nem futsz szembe az override kulcsszóval, de ez egy hasznos függvény amirõl jó ha tudsz, még akkor is ha itt most nem magyarázom el és az érettségin nem szükséges az ismerete, mert másképpen is megoldható a feladat.

## További gyakorló feladatok
- Másold le magadhoz a projektet és próbáld meg a ciklusokat helyettesíteni Linq függvényekkel.
- Próbáld megfejteni ezeknek a Linq függvények az elõnyeit és korlátait ezekben az esetekben.
- Írd át, hogy a résztáblázat számát ne függvény számolja ki, hanem közvetlenül a Main metódusban legyen kiszámolva.