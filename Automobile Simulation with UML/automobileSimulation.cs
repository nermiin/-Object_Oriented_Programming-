using System;

namespace ArabaSimulasyonu
{
    #region enum
    public enum MotorDurumu { Calisiyor, Calismiyor }
    public enum KontakAnahtariDurumu { Acik, Kapali }
    public enum GazPedaliDurumu { Basildi,Basilmadi}
    public enum FrenPedaliDurumu { Basildi, Basilmadi }
    public enum DireksiyonDurumu { SagaDonuk, Duz, SolaDonuk }
    public enum TekerleklerDurumu { SagaDonuk ,Duz, SolaDonuk }
    public enum FarKomandaKoluDurumu {Kapali,KisaFarlarAcik,UzunFArlarAcik }
    public enum SinyalKumandaKoluDurumu {  Kapali,SolSinyalAcik,SagSinyalAcik,DortluSinyalAcik }
    public enum FarlarDurumu { Acik, Kapali }
    public enum SinyalLambalariDurumu { Acik, Kapali }
    public enum HizGostergiDurumu { Acik,Kapali}
    #endregion
    #region Elektronik Beyin
    public class ElektronikBeyin:ISonHiz
    {
        #region readonly
        private readonly KontakAnahtari _kontakAnahtari;
        private readonly Motor _motor;
        private readonly GazPedali _gazPedali;
        private readonly FrenPedali _frenPedali;
        private readonly Direksiyon _direksiyon;
        private readonly Tekerlekler _tekerlekler;
        private readonly FarKomandaKolu _farKomandaKolu;
        private readonly Farlar _farlar;
        private readonly SinyalKumandaKolu _sinyalKomandaKolu;
        private readonly SinyalLambalari _sinyalLambalari;
        private readonly HizGostergi _hizGostergi;

        public int SimdikiHizMiktari { get; set; }
        #endregion
        public ElektronikBeyin(KontakAnahtari kontakAnahtari, Motor motor,GazPedali gazPedali,FrenPedali frenPedali,Direksiyon direksiyon,Tekerlekler tekerlekler,FarKomandaKolu farKomandaKolu,Farlar farlar,SinyalKumandaKolu sinyalKomandaKolu,SinyalLambalari sinyalLambalari,HizGostergi hizGostergi)
        {
            #region
            _kontakAnahtari = kontakAnahtari;
            _motor = motor;
            _gazPedali = gazPedali;
            _frenPedali = frenPedali;
            _direksiyon = direksiyon;
            _tekerlekler = tekerlekler;
            _farKomandaKolu = farKomandaKolu;
            _farlar = farlar;
            _sinyalKomandaKolu = sinyalKomandaKolu;
            _sinyalLambalari = sinyalLambalari;
            _hizGostergi = hizGostergi;
            // Kontağın açılması olayı gerçekleştiğinde KontakAcildi metodu otomatik olarak çalışsın
            _kontakAnahtari.KontakAcildiEventHandler += KontakAcildi;
            _farKomandaKolu.FarKumandaKoluAcildiEventHandler += FarKumandaKoluAcildi;
            _sinyalKomandaKolu.SinyalAcildiEventHandler += SinyalKumandaKoluAcildi;
            _farKomandaKolu.FarKumandaKoluAcildiEventHandler += FarKumandaKoluAcildi;
            _sinyalKomandaKolu.SinyalAcildiEventHandler += SinyalKumandaKoluAcildi;
            #endregion
        }
        // Kontak açıldığında bu metot otomatik olarak çalışacaktır.
        private void KontakAcildi(object sender, EventArgs e) 
        {
          // Motor zaten çalışıyorsa devam etme
          if (_motor.Durumu == MotorDurumu.Calisiyor) return;
         // Motoru çalıştır
         _motor.Calistir();
            //----Kontak Anahtarı Çalışma haline gelmeden aşağıdaki Parçalar Çalışmayacaktır --------
            _gazPedali.GazBasildiEventHandler += GazBasildi;
            _frenPedali.FrenBasildiEventHandler += FrenBasildi;
            _direksiyon.DireksiyondondurulduEventHandler += DireksiyonDonduruldu;
            _tekerlekler.TekerlekdondurulduEventHandler += TekerleklerDonduruldu;
            _farKomandaKolu.FarKumandaKoluAcildiEventHandler += FarKumandaKoluAcildi;
            _sinyalKomandaKolu.SinyalAcildiEventHandler += SinyalKumandaKoluAcildi;
            _hizGostergi.HizGostergiEventHandler += HiziGoster;
            //----------------------------------------------------------------
            if (SimdikiHizMiktari != 0)
                KontakAcildi(this, new EventArgs());
        }
        private void GazBasildi (object sender, EventArgs e)
        {
            if (_gazPedali.SimdikiHizMiktari >= 220) return;
            _gazPedali.SimdikiHizMiktari += _motor.HizlanmaMiktari;
        }
        private void FrenBasildi(object sender, EventArgs e)
        {
            _frenPedali.SimdikiHizMiktari -= 10;    
        }
        private void DireksiyonDonduruldu(object sender, EventArgs e)
        {
            if (_direksiyon.Durumu == DireksiyonDurumu.SagaDonuk)
                _direksiyon.OlusanAci += 5;
            else if (_direksiyon.Durumu == DireksiyonDurumu.SolaDonuk)
                _direksiyon.OlusanAci -= 5;
        }
        private void TekerleklerDonduruldu(object sender,EventArgs e)
        {
            if (_direksiyon.OlusanAci >= 45 || _direksiyon.OlusanAci<=-45) return;
            _tekerlekler.DonmeAci += _direksiyon.OlusanAci;
        }
        private void FarKumandaKoluAcildi(object sender, EventArgs e)
        {
            if (_farKomandaKolu.Durum == FarKomandaKoluDurumu.KisaFarlarAcik)
                _farKomandaKolu.KisaFarlariAc();
            else if (_farKomandaKolu.Durum == FarKomandaKoluDurumu.UzunFArlarAcik)
                _farKomandaKolu.UzunFarlariAc();
        }
        private void SinyalKumandaKoluAcildi(object sender, EventArgs e)
        {
            if (_sinyalKomandaKolu.Durum == SinyalKumandaKoluDurumu.SagSinyalAcik)
                _sinyalKomandaKolu.SagSinyalAc();
            else if (_sinyalKomandaKolu.Durum == SinyalKumandaKoluDurumu.SolSinyalAcik)
                _sinyalKomandaKolu.SolSinyalAc();
            else if (_sinyalKomandaKolu.Durum == SinyalKumandaKoluDurumu.DortluSinyalAcik)
                _sinyalKomandaKolu.DortluSinyalAc();
        }
        private void HiziGoster(object sender, EventArgs e)
        {
            _hizGostergi.HiziGoster();
        }
    }
    #endregion
    #region Kontak Anahtarı 
    public class KontakAnahtari
    {
        // Kontak anahtarının durumu için salt okunur (read-only) bir özellik yazılıyor
        public KontakAnahtariDurumu Durum { get; private set; }

        // Kontak açıldığında tetiklenecek olay için event handler tanımlanıyor
        public event EventHandler KontakAcildiEventHandler;

        public KontakAnahtari()
        {
            // Kontak anahtarının başlangıç durumu kapalı olarak ayarlanıyor
                Durum = KontakAnahtariDurumu.Kapali;
        }

        public void Ac()
        {
            // Kontak zaten açıksa devam etme
            if (Durum == KontakAnahtariDurumu.Acik) return;

            // Kontağı açık konuma getir
            Durum = KontakAnahtariDurumu.Acik;

            // Bu satır test amaçlı olarak yazılmıştır
            Console.WriteLine("Kontak açıldı.");

            // Kontağın açılması olayını tetikle
            if (KontakAcildiEventHandler == null) return;
            KontakAcildiEventHandler(this, new EventArgs());
        }
    }
    #endregion
    #region Hız
    interface IBaslayanHiz
    {
        int HizlanmaMiktari { get; set; }
    }
    interface ISonHiz
    {
        int SimdikiHizMiktari { get; set; }
    } 
    #endregion
    #region Motor
    public abstract class Motor :IBaslayanHiz
    {
        public MotorDurumu Durumu { get; private set; }
        public int HizlanmaMiktari { get; set; }
        protected Motor()
        {
            // Motorun başlangıç durumu çalışmıyor olarak ayarlanıyor
                Durumu = MotorDurumu.Calismiyor;
        }
        public void Calistir()
        {
            // Motor zaten çalışıyorsa devam etme
            if (Durumu == MotorDurumu.Calisiyor) return;
            Durumu = MotorDurumu.Calisiyor;
            // Bu satır test amaçlı olarak yazılmıştır
            Console.WriteLine("Motor çalıştı.");
        }
    }

    public class BenzinliMotor :Motor
    {
        public BenzinliMotor()
        {
            HizlanmaMiktari = 10;
        }
    }

    public class DizelliMotor :Motor
    {
        public DizelliMotor()
        {
            HizlanmaMiktari = 8;
        }
    }
    #endregion
    #region GazPedali
    public class GazPedali:IBaslayanHiz,ISonHiz
    {
        public GazPedaliDurumu Durumu { get; private set; }
        public  int HizlanmaMiktari { get; set; }
        public virtual int SimdikiHizMiktari { get; set; }
        public event EventHandler GazBasildiEventHandler;
        public  GazPedali()
        {
                Durumu = GazPedaliDurumu.Basilmadi;
        }
        public void Bas()
        {
            Durumu = GazPedaliDurumu.Basildi;
            SimdikiHizMiktari += HizlanmaMiktari;
            Console.WriteLine("Gaz Basıldı.");
            if (GazBasildiEventHandler == null) return;
            GazBasildiEventHandler(this, new EventArgs());
        }
    }
    #endregion
    #region Fren Pedali
    public class FrenPedali:KontakAnahtari,ISonHiz
    {
        public int SimdikiHizMiktari { get; set; }
        public FrenPedaliDurumu Durumu { get; private set; }
        public event EventHandler FrenBasildiEventHandler;
        public FrenPedali()
        {
           Durumu = FrenPedaliDurumu.Basilmadi;
        }
        public void Bas()
        {
            Durumu = FrenPedaliDurumu.Basildi;
            SimdikiHizMiktari -= 10;
            Console.WriteLine("Fren Basıldı.");
            if (FrenBasildiEventHandler == null) return;
            FrenBasildiEventHandler(this, new EventArgs());
        }
    }
    #endregion
    #region Direksiyon
    public interface IOlusanAci
    {
        int OlusanAci { get; set; }
    }
    public class Direksiyon :KontakAnahtari, IOlusanAci
    {
        public DireksiyonDurumu Durumu { get; private set; }
        public int OlusanAci { get; set; }
        public event EventHandler DireksiyondondurulduEventHandler;
        public Direksiyon()
        {
            Durumu = DireksiyonDurumu.Duz;
        }
        public void SagaDondur()
        {
            if (Durumu == DireksiyonDurumu.SagaDonuk) return;
            Durumu = DireksiyonDurumu.SagaDonuk;
             OlusanAci += 5;
            if (DireksiyondondurulduEventHandler == null) return;
            DireksiyondondurulduEventHandler(this, new EventArgs());
        }
        public void SolaDondur()
        {
            if (Durumu == DireksiyonDurumu.SolaDonuk) return;
            Durumu = DireksiyonDurumu.SolaDonuk;
             OlusanAci -= 5;

            if (DireksiyondondurulduEventHandler == null) return;
            DireksiyondondurulduEventHandler(this, new EventArgs());
        }
    }
    #endregion
    #region Tekerlekler
    interface IDonmeAci
    {
        int DonmeAci { get; set; }
    }
    public class Tekerlekler: IDonmeAci
    {
        public TekerleklerDurumu Durumu { get; private set; }
        public int DonmeAci { get;set; }
        public event EventHandler TekerlekdondurulduEventHandler;
        public Tekerlekler()
        {
            Durumu = TekerleklerDurumu.Duz;
        }
        public void SagaDondur()
        {
            Durumu = TekerleklerDurumu.SagaDonuk;
            Console.WriteLine("Sağa döndürüldü.");
            if (TekerlekdondurulduEventHandler == null) return;
            TekerlekdondurulduEventHandler(this, new EventArgs());

        }
        public void SolaaDondur()
        {
            Durumu = TekerleklerDurumu.SolaDonuk;
            Console.WriteLine("Sola döndürüldü.");
            if (TekerlekdondurulduEventHandler == null) return;
            TekerlekdondurulduEventHandler(this, new EventArgs());

        }
    }
    #endregion
    #region Hız göstergi
    public class HizGostergi
    {
        ISonHiz SonHiz;
        public HizGostergiDurumu Durumu { get; private set; }
        public event EventHandler HizGostergiEventHandler;
        public HizGostergi()
        {
            Durumu = HizGostergiDurumu.Kapali;
        }
        internal void HiziGoster()
        {
            int Hiz = SonHiz.SimdikiHizMiktari;
            Console.WriteLine("Hız =" + Hiz);
        }
    }
    #endregion
    #region Farlar
    public abstract class Farlar
    {
        public FarlarDurumu Durumu { get;protected set; }
        public event EventHandler FarlarAcildiEventHandler;
        public Farlar()
        {
            Durumu = FarlarDurumu.Kapali;
        }
    }
    public class KisaFrlar : Farlar
    {
        public KisaFrlar():base()
        {
           
        }
    }
    public class UzunFrlar : Farlar
    {
        public UzunFrlar():base()
        {
           
        }
    }
    #endregion
    #region Far Komanda Kolu
    public class FarKomandaKolu
    {
        public FarKomandaKoluDurumu Durum { get; private set; }
        public event EventHandler FarKumandaKoluAcildiEventHandler;
        public FarKomandaKolu()
        {
            Durum = FarKomandaKoluDurumu.Kapali;
        }
        public void KisaFarlariAc()
        {
            if (Durum == FarKomandaKoluDurumu.KisaFarlarAcik) return;
                Durum = FarKomandaKoluDurumu.KisaFarlarAcik;
            Console.WriteLine("Kısa Farları Açıldı.");
            if (FarKumandaKoluAcildiEventHandler == null) return;
            FarKumandaKoluAcildiEventHandler(this, new EventArgs());
        }
        public void UzunFarlariAc()
        {
            if (Durum == FarKomandaKoluDurumu.UzunFArlarAcik) return;
            Durum = FarKomandaKoluDurumu.UzunFArlarAcik;
            Console.WriteLine("Uzun Farları Açıldı.");
            if (FarKumandaKoluAcildiEventHandler == null) return;
            FarKumandaKoluAcildiEventHandler(this, new EventArgs());
        }
    }
    #endregion
    #region Sinyal Lambaları
    public abstract class SinyalLambalari
    {
        public SinyalLambalariDurumu Durum { get; protected set; }
        public event EventHandler SinyallarAcildiEventHandler;
        public SinyalLambalari()
        {
            Durum = SinyalLambalariDurumu.Kapali;
        }
    }
    public class SagSinyalLambalari : SinyalLambalari
    {
        public SagSinyalLambalari():base()
        {
          
        }
    }
    public class SolSinyalLambalari : SinyalLambalari
    {
        public SolSinyalLambalari():base()
        {
            
        }
    }
    public class DortluSinyalLambalari : SinyalLambalari
    {
        public DortluSinyalLambalari():base()
        {
           
        }
    }
    #endregion
    #region Sinyal Komanda Kolu
    public class SinyalKumandaKolu
    {
        public SinyalKumandaKoluDurumu Durum { get; private set; }
        public event EventHandler SinyalAcildiEventHandler;
        public SinyalKumandaKolu()
        {
            Durum = SinyalKumandaKoluDurumu.Kapali;
        }
        public void SolSinyalAc()
        {
            if (Durum == SinyalKumandaKoluDurumu.SolSinyalAcik) return;
            Durum = SinyalKumandaKoluDurumu.SolSinyalAcik;
            Console.WriteLine("Sol Sinyal Lambaları Açıldı.");
            if (SinyalAcildiEventHandler == null) return;
            SinyalAcildiEventHandler(this, new EventArgs());
        }
        public void SagSinyalAc()
        {
            if (Durum == SinyalKumandaKoluDurumu.SagSinyalAcik) return;
            Durum = SinyalKumandaKoluDurumu.SagSinyalAcik;
            Console.WriteLine("Sağ Sinyal Lambaları Açıldı.");
            if (SinyalAcildiEventHandler == null) return;
            SinyalAcildiEventHandler(this, new EventArgs());
        }
        public void DortluSinyalAc()
        {
            //if (Durum == SinyalKumandaKoluDurumu.DortluSinyalAcik) return;
            //Durum = SinyalKumandaKoluDurumu.DortluSinyalAcik;
            Durum = SinyalKumandaKoluDurumu.SagSinyalAcik & SinyalKumandaKoluDurumu.SolSinyalAcik;
            Console.WriteLine("Dörtlü Sinyal Lambaları Açıldı.");
            if (SinyalAcildiEventHandler == null) return;
            SinyalAcildiEventHandler(this, new EventArgs());
        }
    }
    #endregion
}