using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            eCommerce negozio = new eCommerce(); // CREA NUOVO NEGOZIO DI TIPO ECOMMERCE

            // ==================== METODI DI PAGAMENTO ================
            MetodoPagamento carta = new MetodoPagamento() { Tipologia = "Carta di credito"};
            MetodoPagamento bonifico = new MetodoPagamento() { Tipologia = "Bonifico bancario" };
            MetodoPagamento prepagata = new MetodoPagamento() { Tipologia = "Carta prepagata" };
            MetodoPagamento contanti = new MetodoPagamento() { Tipologia = "Contanti alla consegna" };

            // ==================== PRODOTTI =============================
            Prodotto cappelloPrada = new Prodotto() { Brand = "Prada", Descrizione = "Berretto in lana", Giacenza = 5, NomeProdotto = "PradaWool", Prezzo = 230 };
            Prodotto magliaGucci = new Prodotto() { Brand = "Gucci", Descrizione = "Maglia in cotone", Giacenza = 10, NomeProdotto = "magliaGucci", Prezzo = 342 };
            Prodotto scarpeNike = new Prodotto() { Brand = "Nike", Descrizione = "Scarpe running", Giacenza = 12, NomeProdotto = "scarpeNike", Prezzo = 765 };
            Prodotto cappelloLV = new Prodotto() { Brand = "LV", Descrizione = "Berretto in lana", Giacenza = 4, NomeProdotto = "cappelloLV", Prezzo = 322 };
            Prodotto magliaAX = new Prodotto() { Brand = "ArmaniX", Descrizione = "Maglia in cotone", Giacenza = 32, NomeProdotto = "magliaAX", Prezzo = 78 };
            Prodotto scarpeBAL = new Prodotto() { Brand = "Balenciaga", Descrizione = "Scarpe running", Giacenza = 15, NomeProdotto = "scarpeBAL", Prezzo = 560 };
            Prodotto sciarpaDior = new Prodotto() { Brand = "Dior", Descrizione = "Sciarpa in lana", Giacenza = 50, NomeProdotto = "sciarpaDior", Prezzo = 450 };
            Prodotto occhialiRB = new Prodotto() { Brand = "RayBan", Descrizione = "Occhiali da sole polarizzati", Giacenza = 22, NomeProdotto = "occhialiRB", Prezzo = 330 };
            Prodotto occhialiLV = new Prodotto() { Brand = "LV", Descrizione = "Occhiali da sole polarizzati", Giacenza = 11, NomeProdotto = "occhialiLV", Prezzo = 875 };
            Prodotto cappottoPrada = new Prodotto() { Brand = "Prada", Descrizione = "Cappotto in lana", Giacenza = 51, NomeProdotto = "cappottoPrada", Prezzo = 860 };
            negozio.ListaProdottiTOT.Add(cappelloPrada);
            negozio.ListaProdottiTOT.Add(magliaGucci);
            negozio.ListaProdottiTOT.Add(scarpeNike);
            negozio.ListaProdottiTOT.Add(cappelloLV);
            negozio.ListaProdottiTOT.Add(magliaAX);
            negozio.ListaProdottiTOT.Add(scarpeBAL);
            negozio.ListaProdottiTOT.Add(sciarpaDior);
            negozio.ListaProdottiTOT.Add(occhialiRB);
            negozio.ListaProdottiTOT.Add(occhialiLV);
            negozio.ListaProdottiTOT.Add(cappottoPrada);

            // ==================== ORDINI =====================
            Ordine ordine1 = new Ordine()
            {
                IDordine = 1,
                Data = new DateTime(2022, 12, 3),
                DatiSpedizione = new Spedizione() 
                { 
                    CodiceSpedizione="FR32", 
                    Corriere= "BRT", 
                    DataConsegna= new DateTime(2022, 12, 6)
                }
            };
            ordine1.Prodotti.Add(cappelloPrada);
            ordine1.Prodotti.Add(magliaAX);
            ordine1.Prodotti.Add(cappottoPrada);
            ordine1.Importo = 0;
            foreach(Prodotto prod in ordine1.Prodotti)
            {
                ordine1.Importo += prod.Prezzo;
            }

            Ordine ordine2 = new Ordine()
            {
                IDordine = 2,
                Data = new DateTime(2022, 12, 3),
                DatiSpedizione = new Spedizione()
                {
                    CodiceSpedizione = "FR32",
                    Corriere = "BRT",
                    DataConsegna = new DateTime(2022, 12, 6)
                }
            };
            ordine2.Prodotti.Add(cappelloPrada);
            ordine2.Prodotti.Add(magliaAX);
            ordine2.Prodotti.Add(cappottoPrada);
            ordine2.Importo = 0;
            foreach (Prodotto prod in ordine2.Prodotti)
            {
                ordine2.Importo += prod.Prezzo;
            }

            Ordine ordine3 = new Ordine()
            {
                IDordine = 3,
                Data = new DateTime(2022, 12, 3),
                DatiSpedizione = new Spedizione()
                {
                    CodiceSpedizione = "FR32",
                    Corriere = "BRT",
                    DataConsegna = new DateTime(2022, 12, 6)
                }
            };
            ordine3.Prodotti.Add(cappelloPrada);
            ordine3.Prodotti.Add(magliaAX);
            ordine3.Prodotti.Add(occhialiRB);
            ordine3.Importo = 0;
            foreach (Prodotto prod in ordine3.Prodotti)
            {
                ordine3.Importo += prod.Prezzo;
            }

            Ordine ordine4 = new Ordine()
            {
                IDordine = 4,
                Data = new DateTime(2022, 12, 3),
                DatiSpedizione = new Spedizione()
                {
                    CodiceSpedizione = "FR32",
                    Corriere = "BRT",
                    DataConsegna = new DateTime(2022, 12, 6)
                }
            };
            ordine4.Prodotti.Add(occhialiRB);
            ordine4.Prodotti.Add(magliaAX);
            ordine4.Prodotti.Add(cappottoPrada);
            ordine4.Importo = 0;
            foreach (Prodotto prod in ordine4.Prodotti)
            {
                ordine4.Importo += prod.Prezzo;
            }

            Ordine ordine5 = new Ordine()
            {
                IDordine = 5,
                Data = new DateTime(2022, 12, 3),
                DatiSpedizione = new Spedizione()
                {
                    CodiceSpedizione = "FR32",
                    Corriere = "BRT",
                    DataConsegna = new DateTime(2022, 12, 6)
                }
            };
            ordine5.Prodotti.Add(cappelloPrada);
            ordine5.Prodotti.Add(occhialiRB);
            ordine5.Prodotti.Add(cappottoPrada);
            ordine5.Importo = 0;
            foreach (Prodotto prod in ordine5.Prodotti)
            {
                ordine5.Importo += prod.Prezzo;
            }

            negozio.ListaOrdiniTOT.Add(ordine1);
            negozio.ListaOrdiniTOT.Add(ordine2);
            negozio.ListaOrdiniTOT.Add(ordine3);
            negozio.ListaOrdiniTOT.Add(ordine4);
            negozio.ListaOrdiniTOT.Add(ordine5);

            // ======================= CLIENTI ===================
            Cliente cliente1 = new Cliente(){ Nome = "Mario", Cognome = "Rossi"};
            Indirizzo cliente1_ind1 = new Indirizzo() { Via = "Via Mare", Civico = 2, CAP = "10000", Comune = "Comune", Provincia = "AA" };
            Indirizzo cliente1_ind2 = new Indirizzo() { Via = "Via Giugno", Civico = 23, CAP = "10000", Comune = "Comune", Provincia = "AA" };
            cliente1.Indirizzi.Add(cliente1_ind1);
            cliente1.Indirizzi.Add(cliente1_ind2);
            cliente1.MetodiPagamento.Add(bonifico);
            cliente1.OrdiniEffettuati.Add(ordine3);

            Cliente cliente2 = new Cliente() { Nome = "Tizio", Cognome = "Rossi" };
            Indirizzo cliente2_ind1 = new Indirizzo() { Via = "Via Roma", Civico = 12, CAP = "12345", Comune = "Muneco", Provincia = "BB" };
            Indirizzo cliente2_ind2 = new Indirizzo() { Via = "Via Repubblica", Civico = 41, CAP = "12345", Comune = "Muneco", Provincia = "BB" };
            cliente2.Indirizzi.Add(cliente2_ind1);
            cliente2.Indirizzi.Add(cliente2_ind2);
            cliente2.MetodiPagamento.Add(prepagata);
            cliente2.OrdiniEffettuati.Add(ordine3);

            Cliente cliente3 = new Cliente() { Nome = "Caio", Cognome = "Rossi" };
            Indirizzo cliente3_ind1 = new Indirizzo() { Via = "Via Aprile", Civico = 3, CAP = "34567", Comune = "Necomu", Provincia = "CC" };
            Indirizzo cliente3_ind2 = new Indirizzo() { Via = "Via Maggio", Civico = 15, CAP = "34567", Comune = "Necomu", Provincia = "CC" };
            cliente3.Indirizzi.Add(cliente3_ind1);
            cliente3.Indirizzi.Add(cliente3_ind2);
            cliente3.MetodiPagamento.Add(prepagata);
            cliente3.MetodiPagamento.Add(carta);
            cliente3.OrdiniEffettuati.Add(ordine3);

            negozio.ListaClienti.Add(cliente1);
            negozio.ListaClienti.Add(cliente2);
            negozio.ListaClienti.Add(cliente3);


            // METODO PRINCIPALE ====================================
            negozio.Menu();
        }
    }

    // ================= E-COMMERCE =================
    class eCommerce
    {
        public Cliente Utente { get; set; }
        
        public List<Ordine> ListaOrdiniTOT { get; set; } = new List<Ordine>();
        public List<Cliente> ListaClienti { get; set; } = new List<Cliente>();
        public List<Prodotto> ListaProdottiTOT { get; set; } = new List<Prodotto>();



        public void Menu()
        {
            var operazione = 0;
            Console.WriteLine("====================================================");
            Console.WriteLine("                      eCommerce                     ");
            Console.WriteLine("====================================================");
            Console.WriteLine("Scegli un'operazione da effettuare:");
            Console.WriteLine("1. ELENCO CLIENTI");
            Console.WriteLine("2. IMPORTO TOTALE ORDINI");
            Console.WriteLine("3. Ordini per importo");
            Console.WriteLine("4. Elenco prodotti per quantità");
            Console.WriteLine("5. Elenco articoli per ID ordine");
            Console.WriteLine("6. Dettagli ordine per ID ordine");
            Console.WriteLine("7. ESCI");
            Console.WriteLine("____________________________________________________");

            while (operazione != 7)
            {
                operazione = Convert.ToInt32(Console.ReadLine());

                switch (operazione)
                {
                    case 1:
                        Console.Clear();
                        StampaElencoClienti();
                        Console.Write("Premi ENTER per continuare ->"); Console.ReadLine(); Console.Clear(); Menu();
                        break;
                    case 2:
                        Console.Clear();
                        StampaImportoTotale();
                        Console.Write("Premi ENTER per continuare ->"); Console.ReadLine(); Console.Clear(); Menu();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Inserisci un valore di soglia: "); double sogliaImporto = Convert.ToDouble(Console.ReadLine());
                        OrdiniSopraImporto(sogliaImporto);
                        Console.Write("Premi ENTER per continuare ->"); Console.ReadLine(); Console.Clear(); Menu();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Inserisci un valore di soglia: "); int sogliaGiacenza = Convert.ToInt32(Console.ReadLine());
                        ProdottiSottoGiacenza(sogliaGiacenza);
                        Console.Write("Premi ENTER per continuare ->"); Console.ReadLine(); Console.Clear(); Menu();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Inserisci ID ordine: "); int ID = Convert.ToInt32(Console.ReadLine());
                        bool idPresente = false;
                        foreach(Ordine order in ListaOrdiniTOT)
                        {
                            if (order.IDordine == ID) {
                                idPresente = true;
                                StampaArticoliPerOrdine(order);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (!idPresente)
                        {
                            Console.WriteLine("Non sono presenti ordini associati all'ID.");
                        }
                        Console.Write("Premi ENTER per continuare ->"); Console.ReadLine(); Console.Clear(); Menu();
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("Inserisci ID ordine: "); int ID_dettagli = Convert.ToInt32(Console.ReadLine());
                        bool idPresente_dettagli = false;
                        foreach (Ordine order in ListaOrdiniTOT)
                        {
                            if (order.IDordine == ID_dettagli)
                            {
                                idPresente_dettagli = true;
                                StampaDettagliOrdine(order);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (!idPresente_dettagli)
                        {
                            Console.WriteLine("Non sono presenti ordini associati all'ID.");
                        }
                        Console.Write("Premi ENTER per continuare ->"); Console.ReadLine(); Console.Clear(); Menu();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Comando non presente nella lista.");
                        Console.Write("Premi ENTER per continuare ->"); Console.ReadLine(); Console.Clear(); Menu();
                        break;
                }
                break;
            }

        }

        // ================ METODI ==================
        public void StampaElencoClienti()
        {
            Console.WriteLine("NOME========|COGNOME========|NumeroOrdiniEffettuati");
            foreach (Cliente client in ListaClienti)
            {
                int num_ordini = 0;
                foreach(Ordine order in client.OrdiniEffettuati) {num_ordini += 1;} // conta numero ordini effettuati per ciascun cliente
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"{client.Nome}       |{client.Cognome}       |{num_ordini}");
                foreach(Indirizzo address in client.Indirizzi)
                {
                    string ind = $"{address.Via}, {address.Civico}, {address.CAP} {address.Comune} ({address.Provincia})";
                    Console.WriteLine($"Indirizzo: {ind}");
                }
                foreach(MetodoPagamento pay in client.MetodiPagamento)
                {
                    Console.WriteLine($"Metodo di pagamento: {pay.Tipologia}");
                }
                Console.WriteLine("---------------------------------------------------");
            }
        }

        public void StampaImportoTotale()
        {
            double importoTOT = 0;
            foreach(Ordine order in ListaOrdiniTOT)
            {
                importoTOT += order.Importo;
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"L'incasso totale ammonta a: {importoTOT.ToString("C2")}");
            Console.WriteLine("------------------------------------------------------");
            foreach (Ordine order in ListaOrdiniTOT){
                Console.WriteLine($"ID ordine: {order.IDordine} | Importo: {order.Importo.ToString("C2")}");
            }
            Console.WriteLine("------------------------------------------------------");
        }

        public void OrdiniSopraImporto(double soglia)
        {
            foreach(Ordine order in ListaOrdiniTOT)
            {
                double importoOrdine = 0;
                foreach(Prodotto product in order.Prodotti)
                {
                    importoOrdine += product.Prezzo;
                }

                if (importoOrdine >= soglia)
                {
                    Console.WriteLine($"ID: {order.IDordine} | Importo: {order.Importo.ToString("C2")} | Data: {order.Data} | Corriere: {order.DatiSpedizione.Corriere}");
                }
                else
                {
                    continue;
                }

            }
        }

        public void ProdottiSottoGiacenza(int soglia)
        {
            foreach (Prodotto product in ListaProdottiTOT)
            {
                if (product.Giacenza <= soglia)
                {
                    Console.WriteLine($"NomeProdotto: {product.NomeProdotto} | Giacenza: {product.Giacenza}");
                }
                else
                {
                    continue;
                }

            }
        }

        public void StampaArticoliPerOrdine(Ordine order)
        {
            foreach(Prodotto product in order.Prodotti)
            {
                Console.WriteLine($"NomeProdotto: {product.NomeProdotto} | Brand: {product.Brand} | Prezzo: {product.Prezzo.ToString("C2")}");
            }
        }

        public void StampaDettagliOrdine(Ordine order)
        {
            Console.WriteLine($"-------- DETTAGLI ORDINE ID: {order.IDordine} --------");
            Console.WriteLine($"Data: {order.Data}");
            Console.WriteLine($"Importo totale: {order.Importo}");
            foreach (Prodotto prod in order.Prodotti)
            {
                string prodotto = $"{prod.NomeProdotto} | {prod.Descrizione} | {prod.Brand} | {prod.Prezzo}";
                Console.WriteLine($"Prodotto: {prodotto}");
            }
            string spedizione = $"{order.DatiSpedizione.Corriere} | {order.DatiSpedizione.CodiceSpedizione} | {order.DatiSpedizione.DataConsegna}";
            Console.WriteLine($"Dati di spedizione: {spedizione}");
        }

    }

    // ================== CLIENTE ==================
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Indirizzo> Indirizzi { get; set; } = new List<Indirizzo>();
        public List<MetodoPagamento> MetodiPagamento { get; set; } = new List<MetodoPagamento>();
        public List<Ordine> OrdiniEffettuati { get; set; } = new List<Ordine>();
    }

    public class Indirizzo
    {
        public string Via { get; set; }
        public int Civico { get; set; }
        public string CAP { get; set; }
        public string Comune { get; set; }
        public string Provincia { get; set; }
    }

    public class MetodoPagamento
    {
        public string Tipologia { get; set; }
    }

    // ================== ORDINE ==================
    public class Ordine
    {
        public int IDordine { get; set; }
        public DateTime Data { get; set; }
        public double Importo { get; set; }
        public List<Prodotto> Prodotti { get; set; } = new List<Prodotto>();
        public Spedizione DatiSpedizione { get; set; }
    }

    public class Prodotto
    {
        public string Brand { get; set; }
        public string NomeProdotto { get; set; }
        public double Prezzo { get; set; }
        public string Descrizione { get; set; }
        public int Giacenza { get; set; }

    }

    public class Spedizione
    {
        public string Corriere { get; set; }
        public string CodiceSpedizione { get; set; }
        public DateTime DataConsegna { get; set; }
    }
}
