# G�d�r feladat

A feladat le�r�s hivatalos forr�sa: https://dload-oktatas.educatio.hu/erettsegi/feladatok_2021tavasz_emelt/e_inf_21maj_fl.pdf
A forr�s f�jlokat innen tudjuk leszedni (e_inffor_21maj_fl.zip f�jl): https://www.oktatas.hu/kozneveles/erettsegi/feladatsorok/emelt_szint_2021tavasz/emelt_11nap 

## Feladat le�r�sa

Egy teljesen s�k terepen a talaj olyan anyagb�l van, ami nem ereszti �t a vizet. Ezen a ter�leten egy egyenes ment�n munkag�pekkel 10 m�ter sz�les csatorn�t �p�tenek. 
A munka m�g nem k�sz�lt el, ez�rt a csatorna m�lys�ge nem �lland�, helyenk�nt a felsz�n is �rintetlen.
A m�r elk�sz�lt r�sszel, mint k�l�n�ll� g�dr�k sorozat�val foglalkozik a feladat. 
Az egyszer�bb kezel�s �rdek�ben a g�dr�ket �gy tekintj�k, hogy oldalfaluk f�gg�leges, teljes sz�less�gben azonos m�lys�g�, �gy a keresztmetszeti k�p j�l le�rja a terepviszonyokat.

![/Doc/Godor1.png](/2021M�jus21/Doc/Godor1.png)

A melyseg.txt f�jlban m�terenk�nt r�gz�tett�k, hogy azon a szakaszon milyen m�lyen van a g�d�r alja. Minden sor egy-egy eg�sz sz�mot tartalmaz, amely a m�lys�g �rt�k�t mutatja � szint�n m�terben.
A f�jl legfeljebb 2000 sz�mot tartalmaz, �rt�k�k legfeljebb 30 lehet.
Tudjuk, hogy az els� �s az utols� m�teren s�rtetlen a felsz�n, teh�t ott biztosan a 0 sz�m �ll.

![/Doc/Godor2.png](/2021M�jus21/Doc/Godor2.png)

A fenti p�ld�ban l�that� keresztmetszeti k�pen a melyseg.txt bemeneti f�jl tartalm�nak a kezdete l�that�.
Az egyszer�bb szeml�ltet�s miatt a forr�sf�jlban k�l�n sorokban szerepl� �rt�keket itt az �br�n egym�s mellett szerepeltetj�k.
Leolvashat�, hogy az els� m�teren 0 a m�lys�g.
Az els� g�d�r a 7. m�teren kezd�dik.
Az els� g�d�r 16 m�ter hosszan tart, legnagyobb m�lys�ge 4 m�ter, t�rfogata 440 m^3 . A m�sodik g�d�r a 26. m�tern�l kezd�dik, 3 m�ter hosszan tart, t�rfogata 60 m^3.

K�sz�tsen programot, amely a melyseg.txt �llom�nyt felhaszn�lva az al�bbi k�rd�sekre v�laszol!
A program forr�sk�dj�t mentse godor n�ven!
(A program meg�r�sakor a felhaszn�l� �ltal megadott adatok helyess�g�t, �rv�nyess�g�t nem kell ellen�riznie, felt�telezheti, hogy a rendelkez�sre �ll� adatok a le�rtaknak megfelelnek.)

A k�perny�re �r�st ig�nyl� r�szfeladatok eredm�ny�nek megjelen�t�se el�tt �rja a k�perny�re a feladat sorsz�m�t (p�ld�ul: 2. feladat)! 
Ha a felhaszn�l�t�l k�r be adatot, jelen�tse meg a k�perny�n, hogy milyen �rt�ket v�r! Az �kezetmentes ki�r�s is elfogadott.

1. Olvassa be �s t�rolja el a melyseg.txt f�jl tartalm�t! �rja ki a k�perny�re, hogy az adatforr�s h�ny adatot tartalmaz!
2. Olvasson be egy t�vols�g�rt�ket, majd �rja a k�perny�re, hogy milyen m�lyen van a g�d�r alja azon a helyen! Ezt a t�vols�g�rt�ket haszn�lja majd a 6. feladat megold�sa sor�n is!
3. Hat�rozza meg, hogy a felsz�n h�ny sz�zal�ka maradt �rintetlen �s jelen�tse meg 2 tizedes pontoss�ggal!
4. �rja ki a godrok.txt f�jlba a g�dr�k le�r�s�t, azaz azokat a sz�msorokat, amelyek egy-egy g�d�r m�terenk�nti m�lys�g�t adj�k meg!
Minden g�d�r le�r�sa k�l�n sorba ker�lj�n! 
Az �llom�ny pontosan a g�dr�k sz�m�val egyez� sz�m� sort tartalmazzon!
A godrok.txt f�jl els� k�t sor�nak tartalma:  
 2 2 2 2 4 4 3 2 2 3 3 4 4 3 2 2  
 2 2 2
5. Hat�rozza meg a g�dr�k sz�m�t �s �rja a k�perny�re!
6. Ha a 2. feladatban beolvasott helyen nincs g�d�r, akkor �Az adott helyen nincs g�d�r.� �zenetet jelen�tse meg, ha ott g�d�r tal�lhat�, akkor hat�rozza meg, hogy  
a) mi a g�d�r kezd� �s v�gpontja! A meghat�rozott �rt�keket �rja a k�perny�re! 
(Ha nem tudja meghat�rozni, haszn�lja a tov�bbi r�szfeladatokn�l a 7 �s 22 �rt�ket, mint a kezd� �s a v�gpont hely�t)  
b) a legm�lyebb pontja fel� mindk�t ir�nyb�l folyamatosan m�ly�l-e! 
Azaz a g�d�r az egyik sz�l�t�l monoton m�ly�l egy pontig, �s onnant�l monoton emelkedik a m�sik sz�l�ig. 
Az eredm�nyt�l f�gg�en �rja ki a k�perny�re a �Nem m�ly�l folyamatosan.� vagy a �Folyamatosan m�ly�l.� mondatot!  
c) mekkora a legnagyobb m�lys�ge! A meghat�rozott �rt�ket �rja a k�perny�re!  
d) mekkora a t�rfogata, ha sz�less�ge minden helyen 10 m�ternyi!
A meghat�rozott �rt�ket �rja a k�perny�re!  
e) a f�lk�sz csatorna es�ben jelent�s mennyis�g� vizet fogad be.
Egy g�d�r annyi vizet k�pes befogadni an�lk�l, hogy egy nagyobb sz�lvihar hat�s�ra se �nts�n ki, amennyi eset�n a v�z felsz�ne legal�bb 1 m�ter m�lyen van a k�ls� felsz�nhez k�pest.
�rja a k�perny�re ezt a v�zmennyis�get!


Minta a sz�veges kimenetek kialak�t�s�hoz:  
```
1. feladat  
A f�jl adatainak sz�ma: 694  
2. feladat  
Adjon meg egy t�vols�g�rt�ket! 9  
Ezen a helyen a felsz�n 2 m�ter m�lyen van.  
3. feladat  
Az �rintetlen ter�let ar�nya 10.09%.  
5. feladat  
A g�dr�k sz�ma: 22  
6. feladat  
a)  
A g�d�r kezdete: 7 m�ter, a g�d�r v�ge: 22 m�ter.  
b)  
Nem m�ly�l folyamatosan.  
c)  
A legnagyobb m�lys�ge 4 m�ter.  
d)  
A t�rfogata 440 m^3.  
e)  
A v�zmennyis�g 280 m^3.
``` 

## Megold�s magyar�zata
Nem minden sort magyar�zok meg, mert nagyon egy�rtelm�ek, csak azokat a sorokat, ahol valami l�nyeges t�rt�nik:
- Az els� feladatunk, hogy beolvassunk az adatokat a melyseg.txt f�jlb�l. Ezt meg is tessz�k �s let�roljuk a felsz�n t�mbben. A beolvas�st�l kezdve a f�jl tartalm�t el tudjuk �rni a felsz�n t�mbben.
Szint�n az els� feladat r�sze volt, hogy ki�rjuk a f�jl adatainak sz�m�t. Mivel minden sorban 1 adat volt, ez�rt ez egyenl� a t�mb elemsz�m�val. Ha 2 soronk�nt lenne egy adat, akkor a t�mb elemsz�m�t osztan�nk kett�vel.
- A m�sodik feladatban be kell k�rj�nk egy sz�mot. Mivel csak sz�veget tudunk bek�rni, ez�rt a bek�r�st k�vet�en �t is alak�tjuk sz�mm� �s azonnal �tadjuk ezt az �rt�ket a	godorIndex v�ltoz�nkra.
Az �gy beolvasott index seg�ts�g�vel a felsz�n t�mb adott elem�t fel tudjuk haszn�lni ki�rat�sra. Fontos, hogy a megadott godorIndex v�ltoz�b�l vonjunk ki egyet, mert a t�mb�k sorsz�moz�sa 0-t�l indul.
- A harmadik feladatban lesz�rj�k a felsz�n t�mb�t azokra az elemekre, amik �rt�ke 0, majd ezeket a Length seg�ts�g�vel megsz�moljuk. Ez ut�n m�r tudunk sz�zal�kot sz�m�tani.
A ki�r�sn�l figyelni kell a k�t tizedes jegy ki�r�ssal, mert a sz�zal�k sz�m�t�sunk ett�l kicsit pontosabb.
- A negyedik feladat megold�s�hoz felhaszn�lunk egy forech ciklust, amivel v�gig megy�nk a felsz�nen �s megn�zz�k, hogy hol van g�d�r.
Ahol g�d�r kezd�dik, ott ki�rjuk a g�d�r adatai a godrok lista soron k�vetkez� elem�re. 
A godorMelysegek karakterl�ncban gy�jtj�k �ssze a g�d�r inform�ci�it, vagyis a m�terenk�nti m�lys�g �rt�keket.
A v�g�n a godrok lista tartalm�t �rjuk ki a godrok.txt f�jlba.
- Az �t�dik feladatunk az el�bbi megold�snak k�sz�nhet�en nagyon leegyszer�s�d�tt, csak a godrok lista elemsz�m�t kell ki�rjuk.
- A hatodik feladatban a megadott godorIndex-en l�v� elemr�l �runk ki inform�ci�kat.
Ez a legbonyolultabb r�sz.
Els�k�nt megvizsg�ljuk, hogy van-e az adott helyen g�d�r.
Amennyiben van g�d�r az adott helyen, akkor megkeress�k a g�d�r elej�t �s v�g�t 2 for ciklussal.
Az �gy megtal�lt r�szb�l folyamatosan kiszedj�k az �rt�ket �s egy m�sik sz�m list�ba �rjuk ki, hogy a feladat t�bbi pontj�t egyszer�s�ts�k.
Ez ut�n meghat�rozzuk, hogy a g�d�r folyamatosan m�ly�l-e vagy sem.
Itt m�r az �j sz�m list�val dolgozunk, mert a sz�mokat k�nnyen �ssze tudjuk hasonl�tani, hogy melyik nagyobb.
A feladat t�bbi r�sz�t egyszer�s�tj�k, a maximum keres�shez a Max f�ggv�nyt, a t�rfogat �s v�zm�lys�g sz�m�t�shoz a Sum f�ggv�nyt haszn�ljuk fel.
Ez sokkal egyszer�bb� �s �tl�that�v� teszi az adott alpontok megold�s�t.

## Javaslat
M�sold le magadhoz a projektet �s pr�b�ld meg a ciklusokat helyettes�teni Linq f�ggv�nyekkel.
Pr�b�ld megfejteni ezeknek a Linq f�ggv�nyek az el�nyeit �s korl�tait ezekben az esetekben.