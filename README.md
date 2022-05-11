# Informatika érettségi

Az alábbi projektek informatika érettségi program megoldásokat tartalmaznak és olyan érettségizőknek lett írva, akik emelt szintű informatika érettségit akarnak tenni, de a programozás részébe bizonytalanok.
A megoldások kifejezetten arra fókuszálnak, hogy minél kevesebb karakterleütéssel minél rövidebb idő alatt oldják meg a feladatot, lehetőleg minél egyszerűbben és érthetőbben.
A megoldások nem törekednek semmilyen optimalizálásra, adat ellenőrzésekre. Csak és kizárólag a feladat pontos végrehajtása a cél.

A magyarázatok kezdőknek szólnak, és a megoldások VS és C# párossal készültek.
Ha nem kezdő vagy, de érettségire készülsz, akkor ugord át ezt a részt és nézegesd meg a megoldásokat, hátha felfedezel valami hasznosat, ami kisegíthet az érettségin.
Ha nem érettségire készülsz, akkor ez nem a te oldalad, mert olyan megoldásokat találsz itt, amiket nem célszerű éles helyzetben használni. 
Csak arra jók, hogy minél rövidebb idő alatt elkészíthető legyen egy egyszerű feladat úgy, hogy nincs megkötés a kód minőségére.

## [Code Snippet](https://docs.microsoft.com/en-us/visualstudio/ide/visual-csharp-code-snippets?view=vs-2022)-ek

Annak érdekében, hogy minél kevesebbet gépeljünk, célszerű a Code Snippet-eket használni. A lényege, hogy pár karakter és a tab segítségével kész kód blokkokat helyettesít be.
Itt csak azok kerülnek említésre, amiket az érettségi feladatoknál szinte biztos, hogy alkalmazhatjuk.

Lássuk az érettségihez leghasznosabb snippet-eket:
1. Az biztos, hogy konzolra írásra sokszor szükség lesz.
Gépeljük be a forráskódba oda ahova a konzolra írást szeretnénk kiírni a cw billentyűpárost, majd kétszer üssük le a TAB gombot.
Ennek hatására megjelenik a következő kód a cw karakterpáros helyén:
```csharp
	Console.WriteLine();
```
Ezzel kiírásonként 16 billentyű leütést spórolhatunk meg.
Mondhatnánk, hogy ez nem sok, de pl. a [2021Május21](/2021Május21) projekt esetében 11x használtuk a konzolra kiírást sortöréssel, vagyis 176 billentyű leütést spórolhattunk meg.  
2. Ezek a kód behelyettesítések nem csak gépelés könnyítésre jók.
Ha valaki nem emlékszik egy for vagy bármely más ciklus vagy elágazás szintaxisára, akkor a Code Snippet szintén nagy segítség.
Az érettségi feladatok megoldásakor szükség lesz ciklusok használatára.
Ezeket a ciklusokat a for ciklussal a legcélszerűbb megoldani, vagyis ennek az egy ciklusnak a megtanulásával az érettségi feladatok mind megoldhatóak.
Amennyiben mégis elfelejtenénk érettségi közben ennek az egy ciklusnak is a szintaxisát, akkor elég begépelni a for karakterhármast majd a TAB billentyű kétszeri leütésére a következő kód részlet jelenik meg:
```csharp
    for (int i = 0; i < length; i++)
    {

    }
```
Ezek után már nincs más teendőnk, mint a length változót a megfelelő változóra, a kívánt tömb vagy lista hosszának a változójára cserélni és megírni a for ciklus magját.  
3. Biztos, hogy elágazásra is szükség lesz. Ehhez is van segítség. Az if karakterpáros begépelésével és a TAB billentyű kétszeri leütésével a következő kód részlet jelenik meg:
```csharp
    if (true)
    {

    }
```
Ezek után már csak a true logikai értéket kell átírni a szükséges feltételvizsgálatra.  

## [IntelliSense](https://visualstudio.microsoft.com/services/intellicode/)

Egy újabb lehetőség, hogy egyszerűsítsd az érettségin a programozást.  
Ezzel is 2 fegyvert kapsz egyszerre a kezedbe. Az IntelliSense igyekszik 'kitalálni a gondolatodat' és különféle lehetőségeket ajánl fel.  
Vegyük például azt, hogy be szeretnél olvasni valamit a konzolról, de nem emlékszel a függvény nevére. 
Mivel tudod, hogy a konzollal akarsz kezdeni valamit, ezért elég elkezdened begépelni Console szót, amire az IntelliSense felajánlja neked a lehetőségeket.
A felajánlott listában az egérrel is választhatunk vagy a kurzor billentyűkkel is navigálhatunk, majd a kiválasztott elemre ráállva elég a TAB gombot vagy az ENTER gombot leütni és máris begépeli helyettünk.
Fontos, hogy a lista elejére mindig azt próbálja betenni, amire nagy valószínűséggel szükségünk lehet, így segítve azt, hogy ne kelljen a listában sokáig keresgélni.
A beolvasást tehát legrövidebben úgy tudjuk elérni, ha begépeljük a Con karakterhármast majd az IntelliSense által feldobott listán valószínű első helyen szerepel a Console, vagyis ebben az esetben
elég egy TAB billentyűt írni és máris behelyettesítette. Ezek után egy pontot begépelve legördül a lista, hogy a Console osztály milyen lehetőségeket biztosít. 
Tudjuk, hogy beolvasni akarunk, ezért elkezdjük begépelni a Read szót. 
Már az R betű leütésekor meglátjuk a lehetőségeket. 
Ezeken végig navigálva megjelenik egy kis segítség, ami nagyon hasznos lehet számodra. 
Ebből megtudod melyik metódus mire is jó, van-e paramétere és ha van, akkor milyen paramétereket vár el kötelezően és esetleg opcionálisan, valamint azt is megtudod, hogy mi a visszatérési érték.
Ezek nagyon hasznosak lehetnek adott esetben, ezért javaslom, hogy tanulmányozd egy kicsit az IntelliSense adta lehetőségeket, esetleg látogass el erre az oldalra: https://visualstudio.microsoft.com/services/intellicode/ .

## A [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/ide/?view=vs-2022)

Fontos látni, hogy a különböző Visual Studio verziók kicsit eltérnek egymástól, ezért az itt bemutatott lépések nem feltétlenül igazak minden verzióra, de minden 2022 előtti verzión végrehajthatóak.
Valószínűleg az utána következő verziókon is.
Ami itt be lesz mutatva, az a 2019-es verzió, ettől függetlenül mindig van egy [aktuális verzió](https://visualstudio.microsoft.com/).
Itt most csak arra a minimális tudásra összpontosítunk ami az érettségi feladat megoldásához szükséges.

### [Új alkalmazás készítése](https://docs.microsoft.com/en-us/visualstudio/ide/create-new-project?view=vs-2022)
Elindítjuk a Visual Studio 2019-es verziót és a felugró ablakon kiválasztjuk az új projekt létrehozását:  
![/Doc/CreateNewProject.png](/Doc/CreateNewProject.png)  
Ez után egy újabb ablak ugrik fel, ahol ki kell választani, ha esetleg nem lenne alapból kiválasztva azt, hogy C# és Console projektet akarsz létrehozni.
Ezek után már könnyen kiválaszthatjuk, hogy milyen projektet akarunk létrehozni.
Én javaslom, ha egyszerűsíteni akarod az életedet, hogy az érettségi megoldásban elégedj meg a .NET Framework lehetőségeivel:  
![/Doc/CreateNewProject2.png](/Doc/CreateNewProject2.png)  
A projekt kiválasztása után kattintsunk a next gombra.
A következő oldalon megadhatjuk a projekt nevét és a projekt helyét.
Ez a kettő fontos lesz, mert pontot kapsz arra, ha a forrásod megfelelően van elnevezve, de az még fontosabb, hogy tudd, hova hoztad létre a projektet.
Az érettségin le lesz írva, hogy hova kell az elkészített forrás fájlokat tenni, ezért célszerű ezt a mappát kiválasztani, így utólag nem kell a forrás fájlokat másolgatni:  
![/Doc/CreateNewProject3.png](/Doc/CreateNewProject3.png)  
Ezek után már rákattinthatunk a Create gombra, az ablak többi részével itt most nem kell foglalkozz.
Több ablak nem ugrik fel, helyette elindul a Visual Studio.
Legyél egy kicsit türelmes, lassú gépen ez 30-40 másodperc is lehet.

A fent leírt lépések fontosak voltak.
Ezeket [gyakorold](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022) be, különben gyorsan elvérzel az elején és 0 pontot szerzel.

### [Program futtatása](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/run-program?view=vs-2022)
Sajnos még mindig 0 pontnál vagy, de már elkezdhetsz dolgozni és már tudod futtatni a legenerált kódot.
Igaz, hogy egyenlőre még semmit nem csinál, de pont ezért ülsz te a billentyű előtt, hogy begépeld amit kér az érettségi feladat.

A program futtatására két gyors lehetőséged van, az F5 billentyű vagy a Start gomb a felső ikontálcán.
A futó program azonnal leáll, amint végrehajtódott, vagyis, ha nem írsz bele olyan parancsot a végére, hogy 'állj már meg', akkor olyan gyorsan le fog futni az üres vagy pár sorból álló programod, 
feltéve, hogy nem készítettél végtelen ciklust, hogy észre se veszed. Na jó, észreveszed, hogy valami történt, de ennyi.
Ezen ne lepődj meg.
Az érettségin nem feltétel, hogy a program álljon is meg, de ezt úgy fogjuk megtanulni, hogy megálljon, mert könnyebb dolgod lesz amikor ellenőrzöd, hogy mit is készítettél.

### A [Main metódus](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line)
Ez egy különleges függvény.
Nem szükséges az ismerete ahhoz, hogy megold a feladatokat, mindössze annyit kell tudnod, hogy ezt nehogy átnevezd.
Ez a program belépési pontja, minden konzolos alkalmazás szigorúan egy Main nevű függvényt tartalmaz.
Amikor elindul a program, akkor ennek a függvénynek az első sora kerül végrehajtásra.
Amennyiben nincs elágazás, akkor a következő sorral folytatja és így tovább egyiket a másik után hajtja végre.

Ahova te a kódodat fogod írni:
```csharp
    class Program
    {
        static void Main(string[] args)
        {
            //... 
            //ide kezded el megírni, ebbe a sorba a prgramodat
            //...
        }
    }
```

Figyelj a kapcsos zárójel párokra.
Ha ezek nincsenek párba, akkor nem fog fordulni a program és fura hibaüzenetek fognak megjelenni, attól függően, hogy honnan hagytad el a zárójelet és mi következik utána.
A lényeg, hogy a Main metódus nyitó kapcsos zárójele előtt kezd el megírni a programot és a záró zárójel előtt fejezd be.
Nem feltétlenül kell mindent a Main metódusba megírni, ha te magad is írsz metódusokat és azokat meghívod a Main-ben, akkor részekre bonthatod a feladatot, de ezekre majd kitérek a konkrét megoldásoknál,
ha egyáltalán szükség lesz rá. Szerencsés esetben, ha a feladat könnyű, általában az, akkor gyorsan meg tudod oldani a Main-en belül, nem feltétlenül kell további metódusokat létrehozni.

### [Hibakeresés](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-debugger?view=vs-2022)
Kétféle hibával fogsz találkozni, ha valamit elrontasz:
- fordítás idejű hibával, ami meggátolja, hogy a programod leforduljon és elinduljon,
- illetve futás idejű hibával, ami kicsit rosszabb, mert ki kell derítened, hogy futás közben mi is történik és e miatt kell kicsit beleássad magad a hibakeresésbe.

Arra ne számíts, hogy mindig mindent hiba nélkül fogsz megoldani, mert minden ember hibázik, nincs kivétel.

Most nézzük meg, hol és hogyan tudod megnézni, a fordítási hibákat.
A VS biztosít számodra egy Error List ablakot, ami alapból meg kéne nyíljon, ha a programot indítani akarod és van fordítási hibád, ami meggátolja a fordítást és ezért nem indítható a program.
Ez az ablak rendszerint alul jelenik meg.
Ha mégse jelenne meg, akkor a menüben a View\Error List menüpontra kattints rá.

Nézzünk egy példát.
Van ez a kód:
```csharp
    static void Main(string[] args)
    {
        i = 2;
    }
```
amiről láttjuk, hogy hibás, hiszen nincs deklarálva az i, de lássuk mit ír ki ilyenkor az Error List:  
![/Doc/ErrorList.png](/Doc/ErrorList.png)  
Amikor hasonló üzenetet látsz, csak legfeljebb az 'i' helyén más szöveg van, akkor azonnal tudd, hogy az idézőjelek között lévő szöveg nincs deklarálva, vagyis gyorsan add meg a változónak a megfelelő típust.
Ebben az esetben, ha ez az i egész számon értelmezett, akkor mondjuk így:
```csharp
    int i = 2;
```

Most nézzünk egy példát a futás idejű hibákra.
Most az alábbi kódunk van, amit már tudunk fordítani, de futás közben hibát fog dobni:
```csharp
    static void Main(string[] args)
    {
        int j = 2;
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(j / i);
        }
    }
```
Ez a kód lefordul, el lehet indítani, de futás közben ezt fogja kiírni:  
![/Doc/Exception.png](/Doc/Exception.png)  
Futás idejű hibánál mindig megáll a program ott ahol a hiba történt és megjelenik a hibás sor mellet egy kis piros körben egy fehér x.
Ha a hibabuborék nem ugrik fel, akkor erre rákattintva fel fog jönni.
Sajnos ritkán lesz meg az a luxusod, hogy magyarul jön fel a hibaüzenet, erre számíts.

Mit tehetsz, ha ennyiből nem jössz rá, hogy mi a baj.
Sajnos nem lesz interneted, úgyhogy a google kilőve.
Ilyenkor 2 dolgot tehetsz:
- Nézz rá a kódodra és próbáld értelmezni, hogy mit is akartál éppen leprogramozni. Az esetek egy részében ez elég, hogy rájöjj mi a gond.
- Próbáld meg soronként futtatni a kódot az adott helyen és nézni, hogy milyen változód milyen értéket vesz fel, ez is segít rájönni, hogy mi is lehet a gond.

Akkor nézzük meg, hogy kell legegyszerűbben soronként futtatni a programot és nézni a változók értékeit.
Először is meg kell [állítsd a program futását](https://docs.microsoft.com/en-us/visualstudio/debugger/using-breakpoints?view=vs-2022) ott ahol vizsgálni akarod. 
Állítsd le a programot, ha éppen fut és már túlfutott azon a részen ahol vizsgálni akarod és kattints rá a sor szélére és ahova kattintottál, ott megjelenik egy piros kör és a sor is pirosra színeződik.
Persze ez beállításfüggő, de ez az alap.
Valami ilyesmit kell láss:  
![/Doc/BreakPoint.png](/Doc/BreakPoint.png)  

A hibákat felderíteni néha időigényes, ezért igyekezz figyelni, hogy ne hibázz, ill. gyakorolj, mert gyakorlás közben előjönnek a hibák és így emlékezetből tudni fogod, hogy milyen típusú hibák 
esetén mit kell megnézned, hol lehet a hiba.

## Mit is kell leadni
A feladat szerint mindig a forrás fájlt, aminek a pontos nevét is megadják és pont levonás jár azért, ha nem így nevezzük el, ám a projekt mappa nem csak a forrás fájlokat tartalmazza, hanem sok más fájl is belekerül.
Az érettségihez nem szükséges minden fájlról tudni, hogy mi van benne és mire jó, de aki nem csak az érettségi miatt tanul, az nem árt [erről is tudjon](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-projects-solutions?view=vs-2022).
Amennyiben a megoldást abba a fájlba végeztük, amit megadtak leadási mappának, akkor nagy baj nem lehet, legfeljebb a neve nem fog stimmelni, ha nem jól neveztük el, de a megoldásunkat értékelni fogják.
Ellenkező esetben oda kell másoljuk a megfelelő mappába.
Ez további időt fog elvenni, így én nem ezt a megoldást javaslom, de ha így döntöttél, akkor mindig az összes cs kiterjesztésű fájlt kell ide másolni.
Ha egy új projekt fájlt hoztunk létre akkor alapértelmezetten egy Program.cs fájl fog létrejönni és ebben lesz a Program osztály, amiben a Main metódus.
Amennyiben csak ebben a fájlban fejlesztettünk, akkor elég csak ezt a fájlt leadni, mert ez a forrás fájl és ebből bármikor újjáépíthető a teljes projekt.
A teljes mappát is átmásolhatjuk, amennyiben nem vagyunk biztosak, hogy mit is kell átmásolni, a lényeg, hogy minden forrás fájlt leadjunk, amit elkészítettünk.

## A megoldásokhoz szükséges tudás

Ebben a fejezetben felsorolásként tekintheted meg azt, hogy az összes itt megoldott érettségin pontosan mik is lettek felhasználva.
Ezeket megtanulva nagy valószínűséggel sikeresen meg fogsz tudni oldani ilyen jellegű feladatokat.
Az alábbi felsorolásoknál a sorrendet az határozza meg, hogy hányszor voltak felhasználva az egyes megoldásokban, vagyis a lista elején találod azokat, amiket a legtöbbet fogod használni egy érettségi megoldásakor.

### [Minimális alapok](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/)
A feladatok megoldása nem lehetésges a változók, elágazások és ciklusok minimális ismerete nélkül.
A következő három alfejezetben elolvashatod azt a minimumot, ami nélkül nem fog menni az érettségi.

#### [Változók](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables)
Változókra azért lesz szükséged, hogy adatokat ideiglenesen el tudjad tárolni.
Egy változót először deklarálunk, majd inicializálunk vagyis kezdeti értéket adunk neki.
Mivel változó, ezért a későbbiekben az értékét tetszés szerint át lehet írni, ill. ki lehet olvasni.

A változók deklarálásakor kötelező megadni a [típusát](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/) és a nevét.
A neve azért lesz fontos, mert ezen keresztül hivatkozhatsz rá a kód további részében, vagyis ha meg akarod szólítani, vagyis kiolvasni az értékét vagy beleírni új értéket akkor tudnod kell a nevét.
A típusa sokféle lehet, a két legfontosabb:
- [string](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0): szöveg tárolására,
- [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=net-6.0): egész szám tárolására.

Egyes feladatoknál szükséged lehet még a következőkre:
- [float](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types): tört szám esetén,
- [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=net-6.0): dátum-idő esetén,
- [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=net-6.0): időkülönbség esetén.

Ezeken kívül még használni fogod a [tömböket](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/), [listákat](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0), esetleg saját típusokat.
Ezeket adott megoldásokban írom le.

Pár példa a két leggyakrabban használt változóval:
```csharp
    Console.Write("Add meg a neved: ");
    string felhasználóNeve = Console.ReadLine();
    Console.WriteLine("Üdvözöllek {0}! Szép neved van.", felhasználóNeve);
```

Lássunk egy olyan példát, amihez hasonló adatbekérés biztosan lesz az érettségiben:
```csharp
    Console.Write("Adjon meg egy egész számot: ");
    int megadottSzám = int.Parse(Console.ReadLine());
    Console.WriteLine("A megadott szám kétszerese: {0}", 2*megadottSzám);
```
A fenti kódrészlet kiír egy szövegett sortörés nélkül, majd beolvas egy a felhasználó által bírt karakterláncot, amit számmá alakít, az [int.Parse](https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-6.0) függvény segítségével.
Csak akkor fogja tudni számmá alakítani, ha a felhasználó valóban számot írt bele.
Amennyiben azt is kéne ellenőrizni, hogy a felhasználó valóban számot adott meg és olyat ami elfér az int típusban, akkor az [int.TryParse](https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-6.0) függvénnyel tudnánk egyszerűen megvalósítani az ellenőrzést.
Az érettségi feladatoknál viszont erre nincs szükség.

#### A legfontosabb string műveletek
Ne feledd, hogy a string az egy karakterlánc vagyis egy karaktertömb, ezért a tömb műveleteket használhatod rá.
Ezeket is érdemes begyakorold, megtalálod a megoldásokban, illetve a becsatolt linkeknél, itt csak egy rövid felsorolást kapsz azokról, amik érettségin hasznosak lehetnek:
- összefűzés: [Concat](https://docs.microsoft.com/en-us/dotnet/api/system.string.concat?view=net-6.0),
- részkarakterlánc létezésének vizsgálata: [Contains](https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-6.0),
- szöveg formázás: [Format](https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=net-6.0),
- karakterlánc feltöltése balról: [PadLeft](https://docs.microsoft.com/en-us/dotnet/api/system.string.padleft?view=net-6.0),
- karakterlánc feltöltése jobbról: [PadRight](https://docs.microsoft.com/en-us/dotnet/api/system.string.padright?view=net-6.0),
- részkarakterlánc kivágása: [Remove](https://docs.microsoft.com/en-us/dotnet/api/system.string.remove?view=net-6.0),
- részkarakterlánc cseréje: [Replace](https://docs.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-6.0),
- szétvágás: [Split](https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-6.0).

#### Elágazás
A Code Snippet-eknél már volt szó elágazásokról, ezen kívül a megoldott feladatoknál is láthatod a használatukat.
Itt talán annyira érdemes figyelnie annak aki kezdő, hogy mindig legyél tisztában vele mit mivel akarsz összehasonlítani.
Csak azonos típusokat tudsz összehasonlítani.
Ne keverd az értékadást ami egy darab egyenlőség jel a logikai egyenlőség vizsgálattal, ami két darab egyenlőség jel.
Azt is el szokták felejteni kezdők, hogy az [if](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements) kulcsszót mindig egy nyitó és záró zárójel követ, amiben benne van a logikai vizsgálat.
A logikai vizsgálatoknál rendszerint azt nézzük meg, hogy két érték azonos-e, pl. két szám változó, ilyenkor igaz értéket ad vissza, különben hamisat.
A negálás a felkiáltó jel, tehát ha azt nézed meg, hogy két változó egyenlő, akkor == , ha azt, hogy nem egyenlő, akkor != logikai operátort használj.
Fontos még a lusta és/vagy, amivel összetett feltételeket tudsz megadni.
Az és esetén: && , ill. vagy esetén || karakterpárost használd.
Ha nem igazán érted az összetett feltételeket, akkor próbáld kerülni.
Ezek minden esetben kiválthatóak egymásba ágyazott feltételvizsgálatokkal, persze ilyenkor a kód lesz kicsit bonyolultabb.
Nézz meg pár példát, ha nem nagyon érted, akár az itteni megoldásokban, akár más helyen még nézz utána, gyakorold, mert e nélkül nem fog menni az érettségi.

#### Ciklusok
Erről is volt szó a Code Snippet-eknél, egész pontosan a [for](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements) ciklusról.
Van több is, de a for ciklussal minden feladat megoldható, amivel az érettségin találkozol.
Ha a minimumra törekszel, akkor elég csak ezt megtanulnod, de ez mindenképpen kell.
A for ciklusnál amit mindenképpen jegyezz meg, hogy a for után a zárójelben az első rész csak egyszer fut le, a ciklus elején.
Itt érdemes inicializálni egy számlálót, pl. 'int i = 0', amennyiben a ciklust 0-tól akarjuk indítani.
Ezt egy pontosvessző követi, ami után egy feltételvizsgálat jön.
A ciklus addig fog futni amíg ez a feltétel igaz.
Ezt az ellenőrzést minden iteráció elején elvégzi, vagyis, ha a feltétel nem teljesül már az elején, akkor egyszer se fogja végrehajtani a ciklusmagot.
Itt rendszerint azt adjuk meg, hogy a ciklus i változója meddig számoljon el, pl. ha egy tömbön vagy listán megyünk végig, akkor a tömb vagy lista hosszát adjuk meg.
Fontos tudni, hogy mind a tömb mind a lista elemei 0-tól vannak számozva.
Amennyiben túlfutunk a tömbön vagy listán, akkor futás idejű hibával fog a program leállni.
Ezt a hibát nagyon sokszor szokták kezdők elkövetni.
Tehát valahogy így old meg a feltételvizsgálatot: 'i < tömb.length'.
Az utolsó változó minden iteráció végén fut le.
Ezt arra célszerű használni, hogy léptessük a változót, pl. i++ , ami eggyel növeli vagy i+=x ami x-el növeli meg minden iteráció végén az i változót.

### [Console osztály](https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.7.2) felhasznált parancsai

#### Egy sor kiírása, sortöréssel: [WriteLine](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.7.2#system-console-writeline(system-string))
1. Csak egy üres sor kiírása:
```csharp
    Console.WriteLine();
```

2. Szöveg kiírása sortöréssel:
```csharp
    Console.WriteLine("A két idézőjel közzé Kell beírni a szöveget.");
```

3. Szöveg kiírása változó részekkel:
Erre több lehetőség is van, kezdjük a WriteLine standard megoldásával:
```csharp
    int a = 2;
    int b = 3;
    Console.WriteLine("A {0} és {1} egység oldalú téglalap kerülete: {2}.", 
        a, b, a*2+b*2);
```
Itt arra kell figyelni, hogy a szövegben lévő paraméterek szigorúan 0-tól induló monoton egyesével növekvő sorszám és pont annyi paramétert kell vesszővel elválasztva megadni, amennyi paraméterre hivatkozik a szöveg.

Egy másik lehetőség a fenti példára:
```csharp
    int a = 2;
    int b = 3;
    Console.WriteLine($"A {a} és {b} egység oldalú téglalap kerülete: {a*2+b*2}.");
```

Egy kerülendő megoldás, de érettségin belefér:
```csharp
    Console.WriteLine("A " + 2.ToString() + " és " + 3.ToString() + 
        " egység oldalú téglalap kerülete: " + (2*2+3*2).ToString() + ".");
```

Ezen kívül vannak még lehetőségeink, pl. a string osztály is biztosít ilyen függvényt, a [Concat](https://docs.microsoft.com/en-us/dotnet/api/system.string.concat?view=net-6.0) függvényt, de talán a fent leírtak alkalmazása a legcélszerűbb, a legkevesebb gépeléssel és tudással is használható.

Egyes feladatoknál előjön az a probléma, hogy adatokat formázottan kell kiírni, például egy tört számot 2 tizedessel. Ezekre a formázásokra találsz példákat az egyes megoldásokban.

#### Egy sor kiírása, sortörés nélkül: [Write](https://docs.microsoft.com/en-us/dotnet/api/system.console.write?view=net-6.0)
A WriteLine akár akarjuk, akár nem, sort fog törni, az érettségi feladatokban viszont adatbekéréseknél ez gondot okoz.
Ilyenkor lehet használni a Console.Write metódust.
Hasonló módon használhatjuk ezt is mint a WriteLine metódust, azzal a különbséggel, hogy itt kötelező kiírni valamilyen szöveget, mert a metódus mindenképpen vár egy paramétert, vagyis a következő kód hibát fog dobni:
```csharp
    Console.Write();
```
A hiba: `No overload for method 'Write' takes 0 arguments`.

#### Adat beolvasás konzolról: [ReadLine](https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-6.0)
Nem mindegyik feladatnál, de a legtöbbnél szükség van arra, hogy konzolról adatot kérjünk be. 
Ez nem bonyolult, de egy-két dologra érdemes figyelni.
Nézzük azt az esetet, amikor egy sima szöveget kell beolvasni:
```csharp
    string begépeltSzöveg = Console.ReadLine();
```
Ez a sor azt fogja eredményezni, hogy a program futása megáll és vár arra, hogy a felhasználó begépeljen valamit egészen addig amíg az ENTER gombot le nem üti.
Ekkor a begépelt szöveg az ENTER karakterkód nélkül bekerül a begépletSzöveg változóba, amit a program további részén fel lehet használni.
A gond nem is ezzel van, hanem azzal, hogy jellemzően valamilyen szám érték beolvasását kéri a feladat.
Ahogy láttam minden esetben egész szám beolvasását.
Ezt így oldhatjuk meg:
```csharp
    int begépeltSzám = int.Parse(Console.ReadLine());
```
Ez a megoldás feltételezi, hogy tényleg számot írtak, de az érettségi feladatokban eddig minden esetben ott volt ez a mondat:
`A program megírásakor a felhasználó által megadott adatok helyességét, érvényességét nem kell ellenőriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.`

Természetesen így nem írunk programot, de az érettségi időre megy és azzal spórolni kell.

### Tömbök és listák
Tömbök és/vagy listák nélkül nem fogsz tudni megoldani érettségin programozási feladatokat.
A szükséges minimális tudást itt láthatod:

#### Egy dimenziós tömbök: [Single-Dimensional Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays)
Tömböt akkor célszerű használnod, ha tudod a tömb létrehozásának pillanatában, hogy hány eleme lesz a tömbnek.
Lentebb erre látsz egy olyan példát a fájl beolvasásnál, ahol pont erre van szükség.
Ne használd olyankor, ha mód van rá, amikor nem tudod előre, hogy hány elemet szeretnél tárolni, mert például egy leválogatás végén derül csak ki, de a leválogatás egyes elemeit folyamatosan le kell tárold.
Mivel a megoldásokban jellemzően nem tudható előre, hogy mennyi elemet is kell eltárolni, ezért a listákat célszerű használni, én is azt mutatom be inkább.

#### Listák: [List<T> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)
Kicsit több mindent lehet velük kezdeni mint a tömbökkel alap esetben.
Nézzünk egy egyszerű mintát lista létrehozására:
```csharp
    List<string> szövegLista = new List<string>();
```
Ez nem volt valami bonyolult, de azt tudni kell, hogy a listákat csak akkor éred el, ha betöltöd a [System.Collections.Generic](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-6.0) névteret.
Ezt két féle képen tudod gyorsan megtenni.
Vagy begépeled a kód fájl első sorába a következőt:
```csharp
    using System.Collections.Generic;
```
Vagy hagyod, hogy a VS kisegítsen.
Amennyiben vársz egy pár tized másodpercet (gép teljesítményétől függően), megjelenik egy kis sárga égő.
Erre ráhúzva az egeret feldobja a lehetőségeket.
Itt válaszd ki a `using System.Collections.Generic;` sort, így helyetted beilleszti a kódba.
Ezt is érdemes kihasználni gyorsításra, amennyiben elég gyors a gép és nem kell várni arra, hogy feldobja a sárga égőt, akkor gyorsabban ki tudod választani egérrel, mint begépelni, feltéve, ha nem vagy gyorsgépíró.

Eddig ott tartunk, hogy létrehoztunk egy listát.
Ezt viszont fel is kéne tölteni adatokkal.
Nézzünk erre egy mintát:
```csharp
    foreach (string adat in adatok)
        szövegLista.Add(adat);
```
Megj: ez egy fontos rész lesz számodra, ezért mindenképpen tanulmányozd az egyes megoldásokban a lista használatát.

### Fájl kezelések
A fájl kezelést se úszod meg. 
Minden feladatnál az adatok egy részét vagy egészét fájlból kell beolvasni és néha fájlba kell kiírni egyes eredményeket.
Ezt is több féle képen oldhatnánk meg, de a legjobban akkor jársz, ha a [fájl osztály](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0) alább leírt 2 metódusát tanulod meg.
Itt is fontos tudni, hogy a File osztályt csak akkor éred el, ha betöltöd a [System.IO](https://docs.microsoft.com/en-us/dotnet/api/system.io?view=net-6.0) névteret, hasonló módon mint a System.Collections.Generic névteret.

#### Adat beolvasása fájlból: [ReadAllLines](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=net-6.0#system-io-file-readalllines(system-string))
Itt egyszerű dolgod van, egy string tömbbe beolvasod a fájl összes sorát és ezzel rendszerint teljesítetted is az érettségin a programozás első feladatát, amiért pont is jár. 
A megoldás csupán ennyi:
```csharp
    string[] adatSorok = File.ReadAllLines("adat.txt");
```

Természetesen az adatok értelmezése egy másik kérdés lesz, de az "Olvassa be és tárolja el az adat fájl tartalmát!" ennyivel már megvalósult.

#### Adat kiírása fájlba: [WriteAllLines](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writealllines?view=net-6.0)
Ez egy kicsit bonyolultabb kezdőknek, mint a beolvasás.
Azt kell figyelembe venni, hogy mit is akarsz kiírni.
Azokban az érettségi feladatokban, ahol fájlba kell adatot írni, minden esetben alkalmazható ez a minta.
Kigyűjtöd az adatokat egy string listába, majd ezt a string listát kiírod fájlba.
Ezt így tudod megtenni:
```csharp
    List<string> gyűjtöttAdatokLista = new List<string>();
    /* ... itt összeszeded az adatokat a listába, ezt lásd az egyes feladat 
        megoldásoknál ... */
    File.WriteAllLines("gyűjtöttAdatok.txt", gyűjtöttAdatokLista);
```
A fenti kód első sora létrehoz egy új szöveges listát, aminek a neve: gyújtöttAdatokLista.
Ezt a részt követi az ahol összeszeded az adatokat és feltöltöd ezt az új listádat.
Ez lehet például egy ciklus, amikor valami más listán vagy tömbön mész végig és kigyűjtöd a szükséges adatokat.
Ezt követi végül a fájlba kiírás.
Itt megadod első paraméterben a fájl nevét, majd a lista nevét.

### Saját típusok
Az érettségi minden esetben megoldható saját adat típusok nélkül is, de egyes esetekben sokkal könnyebb dolgod lesz, ha készítesz saját adattípust.
Ezt is többféle képen megtehetnéd, most egy olyan lehetőséget mutatok, ami egyszerű és gyors és nem kell sok új dolgot tanulj.
Azt már láthattad, hogy a Main metódusod egy Program osztályban volt.
Ezt az osztály kulcsszót, a [class](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes) kulcsszót másra is fel tudod használni, pl. létrehozhatsz saját típusokat.
Nézzünk egy olyan példát, ahol emberekről akarunk adatokat tárolni, például a nevüket, a születési dátumukat és egy sorszámot róluk.
Ezt így tudod megtenni könnyen a class kulcsszóval:
```csharp
    class Ember
    {
        public string Név;
        public DateTime SzületésiDátum;
        public int Sorszám;
    }
```
Fontos, hogy a class kulcsszó után adod meg ennek az osztálynak vagy most nevezzük **saját adattípusnak**, mert most csak adat tárolására fogod használni a nevét, majd létrehozol egy nyitó és záró kapcsos zárójelet
ami kijelöli a fordító számára, hogy az osztály leírása mettől meddig tart.
E két zárójel közzé írod meg a nyilvános vagy más szóval publikus adattagokat.
Fontos, hogy publikus, mert csak így fogod kívülről elérni vagyis így fogod tudni használni, tehát az egyes adattagok esetében mindig a public kulcsszóval kezded.
Ezt követi az adattag típusa, pl. string, int, DateTime stb., majd ezt a neve, ami alapján hivatkozni tudsz rá.

Amennyiben készítettél egy ilyen osztályt, akkor létre tudsz hozni olyan listákat vagy tömböket, amik ilyen Ember adat elemekből állnak.
Lista esetén például:
```csharp
    List<Ember> emberek = new List<Ember>();
```
Ezzel máris van egy olyan listánk, amiben tudsz emberekről információt tárolni.
Itt már nem egyszerűen számokat vagy szövegeket tárolsz, hanem összetett, könnyebben értelmezhető adatokat.
A listát fel is kell tölteni majd és a használatuk is kicsit más lesz, de ezek használatát meg tudod nézni az egyes példáknál.

### Még több gyorsítás
A ciklusok írásánál néha van egyszerűbb és átláthatóbb megoldás is.
Olyan megoldás, amihez kevesebbet gépelsz és mégis jobban megértheted.
Ezek olyan függvények, amik mögött valójában már megírták a ciklust, de éppen ezért lesz neked könnyeb dolgod.
Ezeknek a függvényeknek egy részét csak akkor éred el, ha betöltöd a System.Linq névteret, ezeket a függvényeket Linq függvényeknek is nevezik.
A következőkben ezekre nézünk példákat.

#### Leválogatás
Ez minden érettségin előjön.
Megoldhatod egy ciklussal is, de megoldhatod a [FindAll](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.findall?view=net-6.0) függvénnyel is.
Tegyük fel, hogy van egy listád, amiben számok vannak és ki kell gyűjtened egy másik listába az összes kettest.
A feladatnak amúgy nem sok értelme van, de ettől most vonatkoztassunk el.
A következő kód segítségével gyorsabban és könnyebben megteheted ezt, mintha ciklussal oldanád meg:
```csharp
    List<int> kettesSzámokLista = számokLista.FindAll(szám => szám == 2);
```
A FindAll függvényben olyan úgynevezett [lambda](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions) kifejezést használtunk, aminek segítségével meg tudtuk adni a leválogatáshoz szükséges feltételt.
Ezt így tudnánk magyarra lefordítani, hogy érthető legyen mi történt:
A számokList listából vedd ki az összes olyan elemet, ahol az elemeket elnevezzük 'szám'-nak és ezek a 'szám'-ok egyenlóek kettővel, majd ezeket az elemeket helyezd el a kettesSzámokLista listában. 
Ugyanezt tömb esetében így tehetnéd meg:
```csharp
    int[] kettesSzámokTömb = Array.FindAll(számokTömb, szám => szám == 2);
```
Nem csak egy feltételt tudunk megadni, az elágazásoknál tanult feltételek bármelyikét alkalmazni lehet, a lényeg, hogy olyan logikai vizsgálatokat adj meg, amelyek valamilyen korlátozást jelentenek az adott elemre.
Például: 'szám != 2 && szám != 4', ami azt jelenti, hogy minden olyan szám kerüljön a listába, ami nem 2 és nem 4.
A vagy kifejezést is használhatod, pl. 'szám == 2 || szám == 4' ami azt jelenti, hogy a leválogatásba csak azok kerülnek bele amik vagy 2 vagy 4 értékűek.

A példáknál majd láthatod, hogy a fenti egyszerű leválogatástól sokkal összetettebb adatszerkezetek esetén is használhatod.

#### Egy elem megkeresése
A FindAll segítségével több elemet kerestünk meg a listából vagy tömbből, a [Find](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-6.0) segítségével viszont egy elemet is meg tudunk keresni.
Ebben az esetben arra kell figyelni, hogy a visszatérési értékünk itt már nem egy másik lista vagy tömb lesz, hanem csak egy elem, mégpedig egy olyan elem, ami az eredeti listában volt.
Ha az eredeti listában szám volt, akkor itt is szám lesz, ha más akkor itt is más lesz a visszatérési érték.
Nézzünk egy olyan példát, amikor egy szöveges listából kikeressük azt ami a 'kettő' karakterlánccal egyenlő:
```csharp
    string kettőKarakterlánc = szövegLista.FindAll(szöveg => szöveg == 'kettő');
```

#### Elemek számlálása
Ezt a [Count](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=net-6.0) függvénnyel teheted meg.
A most következő példában összetett adat típust mutatok be, hogy ezt is értsd, mert elképzelhető, hogy szükséged lesz rá az érettségin.
Ehhez a példához felhasználjuk az Ember osztályunkat.
Számoljuk meg, hogy egy Ember listában hány embernek kezdődik a neve 'Kis' betűkkel:
```csharp
    List<Ember> kisEmberek = 
        emberek.Count(ember => ember.Név.Substring(0,3) == 'Kis');
```
A fenti feltételviszgálatnál láthatod, hogyan kell összetett adatszerkezeteket használni.
Itt az ember nevű objektum, ami amúgy az emberek lista elemeit takarja, vesszük ki a Név adattagot és ennek az első 3 karakterét vizsgáljuk meg, hogy egyenlő-e 'Kis' karakterlánccal.

#### További lehetőségek
Nem csak a fent bemutatott függvényeket tudod felhasználni, mindenképpen nézd meg a következőket is, mert adott esetben jól jöhetnek:
- első elem keresés: [First](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.first?view=net-6.0),
- utolsó elem keresés: [Last](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.last?view=net-6.0),
- átlag: [Average](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=net-6.0),
- maximum keresés: [Max](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max?view=net-6.0),
- minimum keresés: [Min](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min?view=net-6.0),
- szumma: [Sum](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=net-6.0),
- különböző elemek leválogatása: [Distinct](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct?view=net-6.0),
- létezés vizsgálata: [Exists](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.exists?view=net-6.0),
- adott elem sorszámának vagyis indexének a megkeresése: [IndexOf](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.indexof?view=net-6.0),
- kiválasztás: [Select](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=net-6.0).

## Eddigi megoldások
- [2021 Október 26.](/2021Október26/): Sudoku. A Linq ereje érettségi feladatoknál.
- [2021 Május 21.](/2021Május21/): Gödör. Példák for, foreach és Linq függvényekre.
- [2020 Október 28.](/2020Október28/): Sorozatok. Érettségi feladat megoldás a lehető legkevesebb tanulással.

:warning: FIGYELEM! A fentiekkel csak annyi tudást szerezhettél, ami egy érettségihez éppen elég, ettől még nem lettél programozó, de ilyen kis feladatokat már meg fogsz tudni oldani.Ezen kívül vedd figyelembe, hogy bármennyire is igyekeztem, én is ember vagyok és hibázhatok!

Ne feledd használni az IntelliSense-t, ha szükséged van rá!

A változó neveid legyenek érthetőek, de ne feltétlenül olyan hosszúak, mint amiket én a példában bemutattam, mert sokat fogsz gépelni.
Én azért használtam ennyire hosszú változó neveket, hogy minél könnyebb legyen átlátni.

Ne állj meg ezen a szinten, hanem gondolkodj el azon, hogy miért tetted le az emelt szintű érettségit.
Ha azért, hogy programozó legyél, akkor ne a minimumra törekedj, mert soha nem éred el a célod. 
Amit az iskolában tanulsz az nem elég arra, hogy programozó legyél.

Jó tanulást! 