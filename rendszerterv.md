# Rendszerterv

## 1. A rendszer célja

A rendszer célja egy könyvtári nyilvántartási alkalmazás megvalósítása, amely segíti a könyvek és kölcsönzések nyomon követését. A fő cél az, hogy a rendszer átlátható módon kezelje a könyvkatalógust, a kölcsönzési adatokat, valamint támogassa a felhasználói és adminisztrátori funkciókat. A rendszer célja továbbá a felhasználói élmény javítása és az adatbiztonság növelése.

##  2. Projektterv
A projektet Scrum keretrendszerben valósítjuk meg. A projekt során a szereplők és azok felelősségi körei a következők:

Fejlesztők: A fejlesztők felelősek a frontend és backend fejlesztési feladatok elvégzéséért. Ők valósítják meg a felhasználói felületet és a háttérrendszert, biztosítva az alkalmazás teljes funkcionalitását.

Tesztelők: A tesztelők feladata a rendszer alapos tesztelése és a hibák felderítése. Ők végzik a funkcionalitás, a teljesítmény és a felhasználói élmény tesztelését, valamint dokumentálják az esetlegesen felmerülő hibákat.

Projektvezető: A projektvezető feladata a projekt teljes körű koordinálása. Ő felelős a feladatok kiosztásáért, az ütemterv követéséért és a csapat összefogásáért, valamint a projekt előrehaladásának nyomon követéséért.

## 3. Üzleti folyamatok modellje
Könyvek hozzáadása: Az adminisztrátor új könyveket vehet fel az adatbázisba, megadva az azonosítót, a címet, a szerzőt, a kiadás dátumát és a státuszt.

Könyvek kiadása: A felhasználók könyvet kölcsönözhetnek ki, a rendszer rögzíti a kölcsönző nevét, a könyv címét, a kiadás és a lejárat dátumát.

Könyvek visszavétele: A visszahozott könyveket rögzítik a rendszerben, megadva a visszahozó nevét, a könyv címét, a szerzőt és a státuszt.

## 4. Követelmények
### Funkcionális követelmények:
A rendszer támogatja a könyvek hozzáadását, kiadását és visszavételét.
A felhasználók a könyvek adatainak megadásával regisztrálhatják az új példányokat.
Az adminisztrátorok nyomon követhetik a kiadott és visszahozott könyveket.
A rendszer figyeli a visszahozási határidőket és értesítést küld.
### Nem funkcionális követelmények:
A felhasználói felület legyen átlátható és egyszerűen kezelhető.
A rendszer legyen reszponzív és gyors.
Biztosítson magas adatbiztonságot és naplózást az eseményekről.

## 5. Funkcionális terv
### Rendszerszereplők:
Adminisztrátor: Könyvek hozzáadása, módosítása és visszavétele.
Felhasználó: Könyvek kölcsönzése és visszahozása.
### Menühierarchiák:
Kezdőlap: Bejelentkezés és admin felület.
Könyv hozzáadása: Új könyv rögzítése az adatbázisban.
Könyv kiadása: Könyv kikölcsönzése felhasználói adatokkal.
Könyv visszavétele: Visszahozott könyvek adminisztrációja.

## 6.Fizikai környezet
Szerver: Windows alapú szerver környezet a könyvtári adatbázis kezelésére.
Kliens: Windows operációs rendszerű gépek a könyvtárosok és felhasználók számára.
### Fejlesztő eszközök:
IDE: Visual Studio
Nyelv: C# (.NET)
Naplózás: NLog

