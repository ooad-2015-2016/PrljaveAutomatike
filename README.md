# PrljaveAutomatike

Clanovi tima:

1. Nadja Kovacevic
2. Amar Begovic
3. Emir Alagic
4. Alma Dzaferovic

#Tema:
        Kino

##Opis teme:

Kino je kulturno mjesto u gradu u kojem posjetitelji mogu uzivati gledajuci najnovije filmove,serije ili
 stare kultne filmove. Takodje posjetitelji mogu konzumirati hranu i pice. Svrha sistema je omogucavanje
 korisnicima da gledaju sadrzaj po zelji. Sistem treba da omoguci uposlenicima da posjetitelje rasporede
u kino sale po njihovoj zelji u skladu sa nultim pocetnim uslovima. Cijeli sistem se razvija radi lakse
organizacije, rada, rasporeda i smanjenja ljudskih resursa, odnosno manjeg utroska novca.


##Funkcionalnosti sistema:

- mogucnost određivanja kapaciteta (popunjenosti) sale, u cilju rezervacije mjesta u kino sali;
- mogucnost rezervacije i kupovine karata, odnosno mogucnost zauzimanja odredjenog mjesta u kino sali
 (što pored standardne kupovine karata ukljucuje i specijalne slucajeve poput rezervacija cijelih kino sala i sl)
- mogucnost upravljanja programskim sadržajem (dodavanje filma/serije u određeno vrijeme, mijenjanje termina, i sl.)
- mogucnost upravljanja sadržajem i cijenom hrane/pica
- mogucnost dodavanja specijalnih ponuda u vidu smanjenja cijene ulaznica (studentskih, školskih,
 penzionerskih popusta, učlanjivanja u kino klub i sl.)

##Procesi:

- Kreiranje i izmjena projekcija
Menadžer kina je ujedno i menadžer sistema. 
Ima potpunu kontrolu nad programom i svim parametrima neke projekcije. 
Može kreirati nove projekcije, podešavati vrijeme i salu emitovanja, te cijenu projekcija.
 Takodjer, može poništiti neke od trenutno postojecih projekcija, pomjeriti vrijeme emitovanja, 
promijeniti salu i/ili cijenu.

- Prodaja karata
Klijent po dolasku u kino na kasi kupuje kartu za neku od ponudjenih projekcija, te rezerviše salu i mjesto sjedenja.
 Ukoliko klijent ispunjava uslove (clan Kino Kluba, student, penzioner,..) za neke od ponuđenih posebnih pogodnosti 
, blagajnik mu uračunava procenat popusta. Rezervacije ovakvih usluga se primaju najviše 7 dana unaprijed.

- Održavanje inventara hrane i pića
U slučaju da je količina hrane i/ili pića pri isteku, sistem automatski šalje upozorenje menadžeru,
 koji ima mogućnost potvrde nove narudžbe (kao i određivanje njene količine). Menadžer svoju odluku prosljeđuje odgovarajućem uposleniku (onome u čijem je opisu posla da dobavlja zalihe, ako je to potrebno).

- Organizacija specijalnih događaja u kinu
Kino nudi mogućnost iznajmljivanja cijele sale za posebne prigode (rođendani i sl.), pri čemu je rezervaciju
 neophodno obaviti bar 7 dana unaprijed.

- Učlanjenje u Kino Klub
Sistem nudi i mogućnost dodavanja novih članova u Kino Klub, koji se obavezuju time na godišnju pretplatu 
kinu i ostvaruju posebne pogodnosti. Osim mogučnosti dodavanja novih članova, sistem dozvoljava i izmjenu 
podataka o postojećim članovima, kao i uklanjanju nekog člana iz Kino Kluba (na zahtjev člana). 
Pri tome, upravljanje ovim informacijama vrši menadžer i/ili vlasnik kina.

- Podnošenje dnevnog izvještaja rada u kinu
Svakog dana na kraju radnog vremena, sistem automatski proslijeđuje izvještaj o dnevnom radu,
 sa svim specifikacijama o pruženim uslugama i bilo kakvim internim promjenama unutar sistema. 
Izvještaj se podnosi menadžeru i vlasniku kina. 



##Akteri:


1.  Posjetitelj, odnosno korisnik usluga, je osoba koja ima mogućnost kupovine karata, kupovine hrane/pića, i korištenja različitih pogodnosti koje ovaj sistem nudi, ukoliko zadovoljava kriterije korištenja tih pogodnosti;

2.  Uposlenici (grupa ljudi koja obavlja različite procese u cilju funkcionisanja sistema): osoba zadužena za prodaju hrane/pića i karata, koja prima zahtjeve Posjetitelja, procesuira ih, i (ne)zadovoljava, zavisno od mogućnosti (slučaja); osoba zadužena za dobavljanje i dostavljanje hrane/pića, i za kontrolisanje zaliha; osoba zadužena za projekciju, itd...

3.  Menadžer (supervizor, onaj koji nadgleda i kontroliše proces), osoba zadužena za praćenje procesa i eventualne optimizacije i popravke na bilo koji način vezane za procese.
