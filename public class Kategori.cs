public class Kategori 
{
    public string Ad { get; set; }
    public List<Kategori> AltKategoriler { get; set; }

    public Kategori(string ad) 
    {
        Ad = ad;
        AltKategoriler = new List<Kategori>();
    }

    public List<Kategori> AltKategorileriGetir() 
    {
        List<Kategori> altKategoriler = new List<Kategori>();

        foreach (Kategori altKategori in AltKategoriler) 
        {
            altKategoriler.Add(altKategori);
            altKategoriler.AddRange(altKategori.AltKategorileriGetir());
        }

        return altKategoriler;
    }
}

// Kullanım örneği
Kategori anaKategori = new Kategori("Ana Kategori");

Kategori altKategori1 = new Kategori("Alt Kategori 1");
Kategori altKategori2 = new Kategori("Alt Kategori 2");
Kategori altKategori3 = new Kategori("Alt Kategori 3");

anaKategori.AltKategoriler.Add(altKategori1);
anaKategori.AltKategoriler.Add(altKategori2);

altKategori1.AltKategoriler.Add(altKategori3);

List<Kategori> altKategoriler = anaKategori.AltKategorileriGetir();

foreach (Kategori altKategori in altKategoriler) 
{
    Console.WriteLine(altKategori.Ad);
}