# Kreiranje aplikacije pomoću OpenCvSharp biblioteke
U ovom projektu razvijena je Windows Forms aplikacija koja koristi OpenCvSharp biblioteku. Cilj aplikacije je demonstracija i praktična primena odabranih funkcionalnosti ove biblioteke za obradu i analizu slika.

# Sadržaj

- [OpenCvSharp biblioteka](#opencvsharp-biblioteka)
  - [Mogućnosti biblioteke](#mogućnosti-biblioteke)
  - [Problem koji rešava](#problem-koji-rešava)
  - [Prednosti korišćenja](#prednosti-korišćenja)
  - [Konkurentna rešenja](#konkurentna-rešenja)
- [Instalacija biblioteke](#instalacija-biblioteke)
- [Aplikacija](#aplikacija)
- [Zaključak](#zaključak)

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

# Instalacija biblioteke

## Preduslovi

Za instalaciju OpenCvSharp biblioteke preporučuje se korišćenje Visual Studio okruženja, koje ima ugrađene alate za upravljanje NuGet paketima, olakšavajući instalaciju i upravljanje zavisnostima u .NET projektima.

## Instalacija

Najjednostavniji način za instalaciju OpenCvSharp biblioteke u .NET projekat je korišćenjem NuGet paketa. Instalacija se može izvršiti na dva načina:
1. Kroz NuGet Package Manager Console
   
U Visual Studio-u otvorite Package Manager Console i unesite sledeću komandu:
```
Install-Package OpenCvSharp4
```
2. Kroz NuGet Package Manager UI

U Visual Studio-u kliknite desnim tasterom miša na projekat u Solution Explorer-u, izaberite Manage NuGet Packages. U okviru kartice Browse potražite paket OpenCvSharp4, izaberite ga i kliknite na Install. 

Pored osnovnog paketa OpenCvSharp4, u zavisnosti od platforme na kojoj razvijate aplikaciju, potrebno je instalirati i odgovarajuće dodatne pakete koji obezbeđuju potrebne native biblioteke i dodatne funkcionalnosti. 
- Za Windows platformu neophodno je uključiti paket OpenCvSharp4.runtime.win
- Za Linux platformu koristi se paket OpenCvSharp4.runtime.ubuntu.18.04-x64 (ili druga odgovarajuća verzija)

Još jedan od korisnih paketa je OpenCvSharp4.Extensions, koji pruža dodatne funkcije i alate koji olakšavaju rad sa OpenCvSharp-om, kao što su konverzije između OpenCV objekata i standardnih .NET tipova, dodatne metode za manipulaciju slikama i integraciju sa drugim bibliotekama unutar .NET okruženja. 

![NuGet Package Manager UI](images/nuget-package-manager-ui.png)

U Visual Studio okruženju, u okviru panela References unutar projekta biće prikazani svi dodati NuGet paketi. Ovaj pregled nam omogućava da lako proverimo da li su svi neophodni paketi uspešno uključeni u projekat, što je ključno za pravilno funkcionisanje aplikacije i izbegavanje problema sa zavisnostima.

# Aplikacija

## Opis

U okviru ovog projekta razvijena je aplikacija Image Analyzer koja koristi OpenCvSharp biblioteku za obradu i analizu slika unutar .NET okruženja. Aplikacija omogućava korisniku da učita sliku sa računara, izvrši njenu obradu i nakon toga da sačuva izmenjenu sliku u memoriji računara. 

## Funkcionalnosti 

Glavne funkcionalnosti aplikacije uključuju: 
- Učitavanje i snimanje slike
Osnovni tip za predstavljanje slike u OpenCvSharp biblioteci je klasa Mat. Objekat ove klase sadrži informacije o slici, kao što su dimenzije, broj kanala i vrednosti pojedinačnih piksela.
Treba napomenuti da OpenCvSharp koristi unmanaged resurse za rad sa slikama i drugim objektima, što znači da memorija nije automatski upravljana kao u standardnom .NET okruženju. Zbog toga je neophodno ručno osloboditi zauzetu memoriju kada se objekti više ne koriste pozivanjem metode Dispose nad objektima kao što su Mat, Window i slično ili koristiti using blok koji omogućava automatsko oslobađanje memorije. 

Primer učitavanja slike pomoću funkcije ImRead u prethodno inicijalizovan Mat objekat. Da bismo sliku prikazali unutar PictureBox-a neophodno je izvršiti njenu konverziju iz Mat u Bitmap objekat.
```
private void openImageToolStripMenuItem1_Click(object sender, EventArgs e)
 {
            string CombinedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources");
            openFileDialog.InitialDirectory = Path.GetFullPath(CombinedPath);

            openFileDialog.Filter = "Photos (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif,*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif;*.webp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
				
                originalImage = Cv2.ImRead(openFileDialog.FileName);
		
                bitmapImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(originalImage);
				
                pictureBoxOriginal.Image = bitmapImage;
                pictureBoxEdited.Image = bitmapImage;
            }
            else
            {
                MessageBox.Show("Unable to open an image!");
            }
}
```


# Zaključak

OpenCvSharp predstavlja efikasno rešenje za programere koji žele da iskoriste mogućnosti OpenCV biblioteke unutar .NET okruženja, bez potrebe za učenjem drugih programskih jezika.

Ova biblioteka je laka za korišćenje i omogućava brz razvoj aplikacija zahvaljujući jednostavnom API-ju i dobroj integraciji sa .NET okruženjem.

Međutim, u slučajevima gde su ključne maksimalne performanse i brzina izvršavanja, preporučuje se korišćenje originalne verzije OpenCV biblioteke napisane u C++ jeziku.



