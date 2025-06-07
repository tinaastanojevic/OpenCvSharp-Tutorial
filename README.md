# Kreiranje aplikacije pomoću OpenCvSharp biblioteke
U ovom projektu razvijena je Windows Forms aplikacija koja koristi OpenCvSharp biblioteku. Cilj aplikacije je demonstracija i praktična primena odabranih funkcionalnosti ove biblioteke za obradu i analizu slika.
# Sadržaj

- [OpenCvSharp biblioteka](#opencvsharp-biblioteka)
- [Instalacija i pokretanje](#instalacija-i-pokretanje)

# OpenCvSharp biblioteka

OpenCvSharp predstavlja open-source .NET wrapper za popularnu biblioteku OpenCV, koja se koristi za obradu slika i računarski vid. Iako je OpenCV izvorno razvijena u programskom jeziku C++, OpenCvSharp omogućava korišćenje njenih funkcionalnosti direktno u .NET okruženju.

Zahvaljujući ovoj biblioteci, programeri mogu da razvijaju aplikacije u okviru tehnologija kao što su Windows Forms, WPF i .NET konzolne aplikacije, pri čemu se zadržava većina performansi koje pruža originalna C++ implementacija.

## Mogućnosti biblioteke
Biblioteka OpenCvSharp obuhvata većinu funkcionalnosti koje nudi originalna OpenCV biblioteka. Omogućava učitavanje i prikaz slika, kao i različite oblike obrade slika, uključujući filtriranje, zamućenje , konverziju između različitih modela boja  (grayscale, HSV, YCrCb...), kao i binarizaciju pomoću različitih metoda pragovanja. 

Jedne od značajnijih funkcionalnosti uključuju detekciju ivica i kontura, koje se koriste u različitim zadacima kao što su prepoznavanje objekata, segmentacija i detekcija oblika. 

Pored osnovnih metoda obrade, biblioteka pruža i naprednije tehnike koje se koriste u računarskom vidu. 

OpenCvSharp takođe ima i podršku za rad sa modelima dubokog učenja putem DNN (Deep Neutral Network) modula.
Pored rada sa statičkim slikama, biblioteka omogućava i rad sa video zapisima, uključujući prikaz video zapisa u realnom vremenu, njegovu obradu, kao i snimanje obrađenih video snimaka. Zahvaljujući ovim mogućnostima, OpenCvSharp se može koristiti za razvoj real-time aplikacija.

## Problem koji rešava 

Budući da je originalna OpenCV biblioteka napisana u programskom jeziku C++, njena direktna upotreba u C# projektima predstavlja određeni izazov. Zbog toga je razvijen OpenCvSharp, .NET wrapper koji omogućava korišćenje funkcionalnosti OpenCV biblioteke unutar .NET okruženja bez potrebe za napuštanjem poznatog jezika i razvojne platforme. 

Na taj način uklonjeno je ograničenje koje proizilazi iz razlike između programskih jezika, čime je eliminisana potreba za ručnim pisanjem interop sloja. To značajno pojednostavljuje razvoj aplikacija koje se bave obradom slike i računarskim vidom u C# jeziku.

## Prednosti korišćenja 

OpenCvSharp predstavlja jednostavno rešenje za integraciju OpenCV funkcionalnosti u .NET projekte, pružajući gotovo sve mogućnosti originalne OpenCV biblioteke.

Zahvaljujući optimizovanim native C++ funkcija, ova biblioteka omogućava visoke performanse, što je veoma značajno kod obrade slika i računarskog vida. 

Pored navedenih prednosti, treba napomenuti da OpenCvSharp ima aktivnu zajednicu korisnika i često ažuriran GitHub repozitorijum, kao i dobru dokumentaciju, što olakšava učenje i lakšu primenu biblioteke u različitim aplikacijama.


## Konkurentna rešenja 

OpenCvSharp nije jedina biblioteka koja omogućava korišćenje OpenCV funkcionalnosti unutar .NET aplikacija. Njena najpoznatija alternativa je Emgu CV, koja takođe predstavlja .NET wrapper za OpenCV biblioteku. 

Iako su obe biblioteke namenjene rešavanju sličnih problema, i imaju slične performanse, postoje i stvari po kojima se razlikuju i koje treba uzeti u obzir prilikom odabira jedne od njih.

Glavna razlika odnosi se na dodavanje biblioteke i jednostavnost korišćenja. OpenCvSharp je jednostavnija za dodavanje, jer se može instalirati direktno putem NuGet paketa, dok Emgu CV često zahteva ručno dodavanje native DLL-ova i dodatnih zavisnosti, čime se povećava kompleksnost i veličina projekta.

Još jedna od razlika je što Emgu CV koristi model dvostruke licence: open-source i komercijalne licence. Ukoliko koristimo Emgu CV pod open-source uslovima, naš kod takođe mora da bude otvoren za zajednicu i njeno korišćenje i deljenje. U slulaju razvoja aplikacija zatvorenog koda, neophodna je kupovina komercijalne licence, što može predstavljati dodatni trošak.

Takođe, važno je napomenuti da je OpenCvSharp modernija i češće ažurirana biblioteka u poređenju sa Emgu CV, što je čini pogodnijom za projekte kojima je važnija savremena podrška i kompatibilnost sa novim verzijama OpenCV-ja.

# Instalacija i pokretanje

# Aplikacija

# Zaključak




