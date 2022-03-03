# Sudoku feladat

A feladat le�r�s hivatalos forr�sa: https://dload-oktatas.educatio.hu/erettsegi/feladatok_2021osz_emelt/e_inf_21okt_fl.pdf  
Adat f�jlok el�rhet�s�ge (e_inffor_21okt_fl.zip f�jl): https://www.oktatas.hu/kozneveles/erettsegi/feladatsorok/emelt_szint_2021osz/emelt_8nap

## Feladat le�r�sa

A sudoku egy logikai j�t�k, melyben megadott szab�lyok szerint sz�mjegyeket kell elhelyezni egy t�bl�zatban.
Ebben a feladatban 9�9-es t�bl�zatot haszn�lunk.

A t�bl�zat � az al�bbi �br�nak megfelel�en � 9 darab 3�3-as r�szt�bl�zatra van felosztva.
Minden r�szt�bl�zatot az 1, 2, 3, 4, 5, 6, 7, 8, 9 sz�mokkal kell kit�lteni �gy, hogy az eg�sz 9�9-es t�bl�zat minden sor�ban �s minden oszlop�ban az 1...9 sz�mok mindegyike pontosan egyszer forduljon el�.
A rejtv�ny k�sz�t�je el�re ki szokta t�lteni a t�bl�zat bizonyos cell�it.
A rejtv�nyfejt� feladata kit�lteni a marad�k cell�kat a le�rt szab�lyoknak megfelel�en.

A bemenetet tartalmaz� sz�vegf�jlok els� 9 sor�nak mindegyike 9 eg�sz sz�mot tartalmaz, a j�t�k kiindul�si �llapot�nak megfelel�en.
A kit�ltetlen mez�k hely�n a 0 sz�m olvashat�.
A k�vetkez� n�h�ny sorban a j�t�kos egy-egy lehets�ges kit�lt�si l�p�s�t r�gz�tett�k.
Egy l�p�st h�rom eg�sz sz�m �r le: a sz�mot, amelyet a j�t�kos be akar �rni, majd a sor �s az oszlop sz�m�t, ahova �rni szeretn�.
A bemeneti f�jl egy-egy sor�ban a sz�mokat egy-egy sz�k�z v�lasztja el egym�st�l.
A t�bl�zat ellentmond�smentes, teh�t megoldhat� feladatot �r le.
A j�t�kos �ltal megtett l�p�sek sz�ma legal�bb 1, legfeljebb 10, k�z�tt�k lehet hib�s.

P�ld�ul:  
![/Doc/Sudoku1.png](/2021Okt�ber26/Doc/Sudoku1.png)  
![/Doc/Sudoku2.png](/2021Okt�ber26/Doc/Sudoku2.png)

A fenti p�ld�ban a nehez.txt bemeneti f�jl tartalma l�that�.
A 10. sorban szerepl� sz�mok azt jelentik, hogy a 9-es �rt�ket kell a 2. sor 4. hely�re be�rni.
Az adott sorban �s az adott oszlopban nem szerepel m�g a 9-es, s�t, az �rintett n�gyzetben sem, �gy a l�p�ssel nem alakul ki hiba, megtehet�.
A 11. sorbeli l�p�s is megtehet�. A 13. sor hib�s l�p�st tartalmaz, mert a 2. sorban m�r szerepel a 7-es sz�m.

A jobb oldalon l�that� k�pen a k�rbe �rt sz�mok megadj�k, hogy az egyes 3�3 m�ret� r�szt�bl�kat milyen sz�mmal azonos�tjuk.

K�sz�tsen programot, amely a bemeneti �llom�nyok egyik�t felhaszn�lva (konnyu.txt, kozepes.txt, nehez.txt) az al�bbi k�rd�sekre v�laszol!
A program forr�sk�dj�t mentse sudoku n�ven!
(A program meg�r�sakor a felhaszn�l� �ltal megadott adatok helyess�g�t, �rv�nyess�g�t nem kell ellen�riznie, felt�telezheti, hogy a rendelkez�sre �ll� adatok a le�rtaknak megfelelnek.)

A k�perny�re �r�st ig�nyl� r�szfeladatok eredm�ny�nek megjelen�t�se el�tt �rja a k�perny�re a feladat sorsz�m�t (p�ld�ul: 4. feladat)! Ha a felhaszn�l�t�l k�r be adatot, jelen�tse meg a k�perny�n, hogy milyen �rt�ket v�r!
Az �kezetmentes ki�r�s is elfogadott.

1. Olvassa be egy f�jl nev�t, egy sor �s egy oszlop sorsz�m�t (1 �s 9 k�z�tti sz�mot)!
A k�s�bbi feladatokat ezen �rt�kek felhaszn�l�s�val kell megoldania!
2. Az el�z� feladatban beolvasott n�vnek megfelel� f�jl tartalm�t olvassa be, �s t�rolja el a t�bl�zat adatait!
Ha ezt nem tudja megtenni, akkor haszn�lja forr�sk�nt a rendelkez�sre �ll� �llom�nyok egyik�t!
3. �rja ki a k�perny�re, hogy a beolvasott sor �s oszlop �rt�k�nek megfelel� hely...  
a) milyen �rt�ket tartalmaz!
Ha az adott helyen a 0 olvashat�, akkor az �Az adott helyet m�g nem t�lt�tt�k ki.� sz�veget jelen�tse meg!  
b) melyik r�szt�bl�zathoz tartozik!
4. Hat�rozza meg a t�bl�zat h�ny sz�zal�ka nincs m�g kit�ltve!
Az eredm�nyt egy tizedesjegy pontoss�ggal jelen�tse meg a k�perny�n!
5. Vizsg�lja meg, hogy a f�jlban szerepl� l�p�sek lehets�gesek-e a beolvasott t�bl�zaton!
Tekintse mindegyiket �gy, mintha az lenne az egyetlen l�p�s az eredeti t�bl�zaton, de ne hajtsa azt v�gre!
�llap�tsa meg, hogy okoz-e valamilyen ellentmond�st a l�p�s v�grehajt�sa!
�rja ki a l�p�shez tartoz� h�rom �rt�ket, majd a k�vetkez� sorba �rja az al�bbi meg�llap�t�sok egyik�t! Ha t�bb meg�llap�t�s is igaz, elegend� csak egyet megjelen�tenie.
- �A helyet m�r kit�lt�tt�k�
- �Az adott sorban m�r szerepel a sz�m�
- �Az adott oszlopban m�r szerepel a sz�m�
- �Az adott r�szt�bl�zatban m�r szerepel a sz�m�
- �A l�p�s megtehet��

Minta a sz�veges kimenetek kialak�t�s�hoz:  
```
1. feladat
Adja meg a bemeneti f�jl nev�t! konnyu.txt
Adja meg egy sor sz�m�t! 1
Adja meg egy oszlop sz�m�t! 1

3. feladat
Az adott helyen szerepl� sz�m: 5
A hely a(z) 1 r�szt�bl�zathoz tartozik.

4. feladat
Az �res helyek ar�nya: 17.3%

5. feladat
A kiv�lasztott sor: 2 oszlop: 4 a sz�m: 9
A helyet m�r kit�lt�tt�k.
A kiv�lasztott sor: 3 oszlop: 6 a sz�m: 7
A l�p�s megtehet�.
A kiv�lasztott sor: 6 oszlop: 6 a sz�m: 3
A r�szt�bl�zatban m�r szerepel a sz�m.
A kiv�lasztott sor: 7 oszlop: 9 a sz�m: 8
Az adott oszlopban m�r szerepel a sz�m.
```

## Megold�s magyar�zata
A feladat els� r�sze nem sok magyar�zatra szorul. 
Egyszer�en beolvasunk egy f�jl nevet, egy sor �s egy oszlop sorsz�mot.
Ne feledd soha, a t�mb 0-t�l sz�mozott, �gy amikor valaki megadja, hogy 1 sor, akkor az 0. sort jelent vagyis mindig x-1 lebegjen a szemed el�tt.

A m�sodik feladatn�l az adatok beolvas�sa f�jlb�l ugyanaz az egy sor, amit mindegyik feladatn�l haszn�ltunk. 
Ezzel megvan a m�sodik feladatra is a pontod, de, hogy a harmadik feladatot k�nnyebben meg tudd oldani, ez�rt az adatbet�lt�sn�l a sudoku t�bl�t c�lszer� feldolgozni.
El�sz�r is nem egy szok�sos egydimenzi�s list�ba vagy t�mbbe t�ltj�k �t az adatokat, hanem egy t�bbdimenzi�s t�mbbe.
A sudoku t�bl�t tekinthetj�k egy 9x9-es m�trixnak.
A feladat szerint az els� 9 sor tartalmazza a sudoku m�trixot.
Ez azt jelenti, hogy a f�jlb�l bet�lt�tt adatokb�l csak ez a 9 sor kell.
Egy lehet�s�g, ha egy ciklussal v�gig megy�nk a teljes list�n, de csak az els� 9 sort dolgozzuk fel, vagyis valahogy �gy:
```csharp
    List<string> sudokuAdatSorok = new List<string>;
    for (int i = 0; i < 9; i++)
        sudokuAdatSorok.Add(adatSorok[i]);
```
Ezt a ciklust kiv�lthatjuk egy sokkal eleg�nsabb �s �tl�that�bb megold�ssal, valahogy �gy:
```csharp
    string[] sudokuAdatSorok = adatSorok.Take(9).ToArray());
```
A m�sodik megold�s j�val r�videbb, kevesebb id� alatt beg�peled �s �tl�that�bb is.
A [Take](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take?view=net-6.0) f�ggv�ny seg�ts�g�vel az eredeti t�mb els� 9 elem�t m�soltuk �t a sudokuAdatSorok t�mbbe.

Term�szetesen ez nem el�g, hiszen a sorokat is sz�t kell szedni �s �t is kell alak�tani.
Gyorsan be lehet l�tni, hogy a for ciklus viszonylag k�nnyen kiv�lthat� a Linq f�ggv�nyekkel �s ford�tva, a legt�bb esetben.
Ez a m�sodik feladat pont alkalmas arra, hogy kiss� bonyolult helyzetekben is meg tudjuk ezt vizsg�lni.
N�zz�k egyszer for ciklusal:
```csharp
    byte[,] m�trix = new byte[9, 9];
    for (int i = 0; i < adatSorok.Length; i++)
    {
        string[] adatMez�kASorban = adatSorok[i].Split(' ');
        for (int j = 0; j < adatMez�kASorban.Length; j++)
            m�trix[i, j] = byte.Parse(adatMez�kASorban[j]);
    }
```
J�l l�that�, hogy 2 ciklus, egy soronk�nti Split �s egy adattagonk�nti Parse m�veletre volt sz�ks�g.
Most l�ssuk Linq-val:
```csharp
    byte[][] m�trix = adatSorok.Take(9).Select(sor => sor.Split(' ').Select(�rt�k => byte.Parse(�rt�k)).ToArray()).ToArray();
```
B�r els�re nem biztos, hogy l�tszik, de a m�sodik megold�sban itt is kevesebb karakterle�t�sre volt sz�ks�g.
Term�szetesen ez nagyban f�gg az �ltalunk v�lasztott v�ltoz�nevekt�l is.
Nem �ll�tom, hogy a m�sodik megold�s most sokkal egyszer�bb kezd�nek, mint az els�, de ha r��ll a szemed, id�vel a m�sodik megold�st jobban fogod szeretni olvasni, mint az els�t.
Egyszer�en nem kell azon gondolkodni, hogy a ciklus adott iter�ci�j�ban mi t�rt�nik, csak olvasni kell, mint egy mondatot.
N�zz�k meg k�r�lbel�l hogyan lehet ezt olvasni:  
A m�trix k�tdimenzi�s t�mbbe bet�ltj�k az adatSorok egy dimenzi�s t�mbb�l az els� 9 'sor�nak' (elem�nek) a sz�k�z�kn�l sz�tdarabolt r�szeit, melyeket int t�pussal t�rolunk.  
Olvashat� mint egy mondat, szemben az els� megold�sal, ami szint�n k�nnyen olvashat� de ahhoz, hogy mondatszer�en kiolvassuk �rtelmezn�nk kell a ciklus magot.
Nem t�l bonyolult, de �rtelmezni kell.  

Azt az�rt megeml�tem, hogy a m�sodik megold�s sebess�ge a ford�t� optimaliz�l�s�nak hat�konys�g�t�l vagy hat�konytalans�g�t�l f�gg.
Ez azt jelenti, hogy ha nem vagy biztos benne, hogy mi t�rt�nik ford�t�skor, de fontos a sebess�gre optimaliz�l�s, akkor a for ciklus a bar�tod.
Az �retts�gin b�rmelyik megold�st v�laszthatod, amelyik szimpatikusabb vagy jobban meg�rted, mert sebess�gre optimaliz�l�ssal nem kell foglalkoznod.
Ez is j� h�r :) !

A m�trix t�bl�t sz�pen �rtelmezt�k, a tov�bbi feladatokban k�nnyen haszn�lhatjuk, de a l�p�sekkel m�g semmit se kezdt�nk.
Egyenl�re viszont nincs is sz�ks�g az �rtelmez�s�re.
Az �n tan�csom, hogy amivel nem kell foglalkozni, azzal ne foglalkozz, majd csak akkor, ha sz�ks�g van r�, mert ha elakadsz a r�szletekben, akkor nem gy�lnek a pontjaid, neked pedig most ez lesz a legfontosabb, min�l r�videbb id� alatt min�l t�bb pontot gy�jteni.

A harmadik feladat els� fele nagyon egyszer� lett, miut�n sz�pen bet�lt�tt�k egy m�trixba a sudoku t�bl�t, a m�sodik r�sze viszont kicsit bonyolultabb.
Annyira �rdekes ez a r�sz, hogy k�l�n kiemeltem egy f�ggv�nybe, hogy nevet tudjak adni neki. 
�gy n�vvel ell�tva m�r k�nnyebben �rtelmezhet�.
Pr�b�ld �szrevenni, hogy a sz�m�t�stechnik�ban a matematika a bar�tod.
Megoldhatn�d ez a feladatr�szt sokf�le k�pen p�ld�ul ciklusokkal �s el�gaz�sokkal de azzal sok id�d menne el �s lehet, hogy belegabalyodn�l.
T�rekedj az egyszer� �s sz�p megold�sokra, k�l�nben belezavarodsz.

A negyedik megold�sban a Linq feneketlen k�tj�ba tekinthetsz be.
Nem baj, ha bele sz�d�lsz, mert nagyon j�l haszn�lhat�.
Itt is bemutatn�m, hogy oldhatod meg ciklussal �s hogy oldhatod meg a Linq egy m�sik lehet�s�g�vel.
L�ssuk for ciklussal:
```csharp
    int null�s�rt�kekSz�ma = 0;
    for (int i = 0; i < 9; i++)
        for (int j = 0; j < 9; j++)
            if (m�trix[i][j] == 0)
                null�s�rt�kekSz�ma++;
    float �resHelxekAr�nya = (float)null�s�rt�kekSz�ma / (9 * 9) * 100;
```
Ugyanez Linq-val:
```csharp
    float �resHelyekAr�nya = (from sor in m�trix from mez� in sor where mez� == 0 select mez�).Count() / (9 * 9) * 100;
```
El�sz�r olvassuk ki azt�n szedj�k sz�t. Kiolvasva ez valahogy �gy hangzana (m�r ha �ppen olvasod):
az �resHelyekAr�nya v�ltoz�ba belet�ltj�k a m�trixb�l a soroknak azon mez�it, amelyek megegyeznek 0-val, majd megsz�moljuk �ket �s elosztjuk a sudoku t�bla mez�sz�maival majd sz�zzal megszorzunk, vagyis a 0-�s mez�k sz�zal�k�t sz�moljuk ki.  
N�zz�k ezt sz�tszedve.
L�thatod, hogy [p�r �j kulcssz�](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords) ker�lt be a k�dba.
A from kulcssz� seg�ts�g�vel egy t�mbb�l vagy list�b�l ki tudunk emelni elemeket, melyekre a where kulcssz� ut�n felt�teleket adunk, majd a select ut�n megadjuk, hogy mit is akarunk ebb�l kiszedni.
A j� ebben az eg�szben, hogy ak�rmilyen m�lys�gig, vagyis b�rmilyen dimenzi�ig boncolgathatjuk a t�mb�nket.
Most 2 dimenzi�s t�mb�nk volt.
Az els� from seg�ts�g�vel kiszedt�k a m�trixb�l a sort, amit egy sor nev� v�ltoz�val l�ttunk el, ami m�r egy dimenzi�s �s a m�sodik from seg�ts�g�vel abb�l kivett�k a mez�ket, amit egy mez� v�ltoz�n�vvel l�ttunk el.
J�l olvashat�, hogy a sor-t a m�trix-b�l, a mez�-t a sor-b�l szedt�k ki.
Ezek ut�n a mez�re egy felt�telt adtunk meg, m�gpedig azt, hogy 0 legyen, majd az �gy kapott adatcsomagb�l a select seg�ts�g�vel kiv�lasztottuk a mez�t.
Ez itt most tal�n kicsit �rthetetlennek t�nik, de itt nem mindig csak egy 'valamib�l' v�laszthatunk.
Aki j�rtas egy kicsit az SQL-ben, annak a fenti megold�st nem neh�z �tl�tnia.
Ha megtetszett, akkor gyakorold be �s lesz m�g egy fegyvered az �retts�gin a kezedben.

Itt a negyedik feladatn�l van m�g 2 probl�ma.  

Az egyik, hogy a C#-ban 2 eg�sz sz�mot elosztva egy eg�sz sz�mot fogsz kapni!
�RTED? Mert �retts�gin nem fogod �rteni, hogy mi t�rt�nik.
Csak azt fogod l�tni, hogy az eredm�nyed nem az amire v�rt�l.
�ppen ez�rt ilyen esetben az egyik sz�mot '�talak�tjuk' t�rt sz�mm� vagy �gy is mondhatn�nk, hogy [explicit t�pus konverzi�t alkalmazunk](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions).
Itt most a (float) seg�ts�g�vel k�nyszer�tett�k ki ezt.

A m�sik probl�ma, hogy 2 tizedes jegyig kell megform�zni.
Ahogy �n l�ttam az �retts�gin vagy eg�sz sz�mokkal foglalkozol, vagy t�rt sz�mokkal, de ezekben az esetekben a ki�r�sokat rendszerint 2 tizedesjegy pontoss�ggal k�ri.
Gyakorold be az itteni megold�st, vagy [n�zz ut�na]((https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)), milyen lehet�s�geid vannak m�g.

Az �t�dik feladatn�l el�rkez�nk oda, hogy foglalkoznunk kell az adat f�jl t�bbi sor�val is nem csak az els� 9 sorral.
Itt �rdemes saj�t t�pust l�trehozni.
�n most ugyan ebben a f�jlban hozom l�tre, neked is ezt javaslom, hogy ha m�gis m�solnod kell valahova a forr�st, akkor csak egy f�jlt kelljen m�solnod.
Norm�l esetben minden 'saj�t  t�pust' k�l�n f�jlba hozunk l�tre, aminek a neve megegyezik a t�pus nev�vel.
�gy k�nnyebb megtal�lni a dolgokat egy f�jlkezel�b�l is, de te most nem kell foglalkozz ezzel.
Ezt az �j t�pust felhaszn�lva l�trehozunk egy olyan list�t, amiben a l�p�sek vannak elt�rolva.
A l�p�sek list�ba az adatSorok t�mbb�l kiszedj�k a 9. sort�l kezdve a sorokat.
Ezt a [Skip](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skip?view=net-6.0) f�ggv�ny seg�ts�g�vel tessz�k meg.
Ami itt m�g �j, hogy kiv�laszt�sn�l nem csak a lista egy adat�t vagy t�bbet kiv�lasztunk �s abb�l t�mb�t vagy list�t k�sz�t�nk, hanem egy �j objektumot hozunk l�tre egy L�p�s objektumot, majd ezekb�l k�sz�t�nk list�t.
Menet k�zben m�g a sz�vegesen t�rolt sz�mokat sz�mm� alak�tjuk, �gy a l�p�sek list�ban rendelkez�sre �llnak az adatok, amiket fel fogunk haszn�lni.
A ki�r�shoz egy ForEach met�dust haszn�lunk fel.
Ezzel megsp�roljuk a ciklus �r�st.
A ki�rand� inform�ci�k �sszeszed�s�hez k�sz�t�nk egy f�ggv�nyt.
A f�ggv�nyben olyan dolgok vannak amik m�r kor�bban meg lettek magyar�zva, �gy ezekre most nem t�rek ki ism�t.

Ami �rdekes m�g, a L�p�s saj�t t�pus kapott egy f�ggv�nyt, m�gpedig egy speci�lis f�ggv�nyt, aminek a neve a [ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-6.0).
Ide b�rmilyen f�ggv�nyt meg�rhattunk volna, aminek m�s a neve �s akkor nem futsz szembe az override kulcssz�val, de ez egy hasznos f�ggv�ny amir�l j� ha tudsz, m�g akkor is ha itt most nem magyar�zom el �s az �retts�gin nem sz�ks�ges az ismerete, mert m�sk�ppen is megoldhat� a feladat.

## Tov�bbi gyakorl� feladatok
- M�sold le magadhoz a projektet �s pr�b�ld meg a ciklusokat helyettes�teni Linq f�ggv�nyekkel.
- Pr�b�ld megfejteni ezeknek a Linq f�ggv�nyek az el�nyeit �s korl�tait ezekben az esetekben.
- �rd �t, hogy a r�szt�bl�zat sz�m�t ne f�ggv�ny sz�molja ki, hanem k�zvetlen�l a Main met�dusban legyen kisz�molva.