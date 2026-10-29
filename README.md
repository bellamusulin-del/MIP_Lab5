# MIP_Lab5
Să se creeze un nou proiect Windows Forms.
• Să se creeze un model de date Entity Framework 
pentru administrare produse într-un magazin. 
Fiecare obiect din magazin va avea următoarele 
proprietăți:
• Identificator unic.
• Denumire (max. 30 caractere).
• Descriere produs (max. 500 caractere).
• Data intrării în magazin.
• Termen de valabilitate (data expirării).
• Cantitate
 Să se creeze Form-ul principal:
• Va avea un Data Grid View pentru vizualizarea tuturor 
produselor din baza de date.
• Buton Refresh pentru înprospătarea conținutului.
• Meniu (MenuStrip) pentru:
• Adăugare produse.
• Vânzare produse.
• Căutare produse.
Cerința 3
• Căutarea și vizualizarea de produse se va realiza din 
Form-ul principal.
• Căutarea va fi implementată ca opțiune de filtrare a 
evenimentelor disponibile în Data Grid View (sunt permise și 
alte variante)
Să se creeze un Form distinct pentru adăugarea de 
produse.
• Distingem două tipuri de adăugări: produse noi și cantități din 
produse existente. Cele două variante vor fi disponibile ca 
elemente de sub-meniu la “Adăugare produse”.
• La adăugare produse existente se va introduce identificatorul 
unic al produsului la care se dorește creșterea cantității 
disponibile. Identificatorul se va citi de utilizator din Form-ul 
principal.
Să se creeze un Form distinct pentru vânzarea de 
produse.
• Lansarea Form-ului se va realiza la eveniment de Dublu Click pe 
Data Grid View – pe elementul care se dorește a fi vândut.
• Constructorul Form-ului de vânzare va prelua detaliile 
înregistrării și va permite selectarea cantității de produse ce se 
doresc a fi vândute.
• În cazul în care pentru un anumit produs cantitatea disponibilă 
devine 0, produsul se va șterge din baza de date
 Să se transpună operațiile de acces la baza de date 
pe Thread Pool folosind AsyncTask.
• Necesar deoarece anumite operații pot bloca firul principal (vezi 
deschiderea inițială a conexiunii).
• La sfârșitul execuției operației se va notifica thread-ul 
GUI folosind mecanismul “invoke”, transmițând 
totodată rezultatul execuției.
