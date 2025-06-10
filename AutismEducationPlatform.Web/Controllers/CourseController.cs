using AutismEducationPlatform.Web.Models;
using AutismEducationPlatform.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutismEducationPlatform.Web.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var courses = new List<CourseCardViewModel>
            {
                new CourseCardViewModel 
                {
                    Title = "HAYVANLAR",
                    Description = "Hayvanları tanıyalım ve öğrenelim",
                    ImageUrl = "/images/courses/animals.jpg",
                    IconClass = "fas fa-paw",
                    BackgroundColor = "bg-primary"
                },
                new CourseCardViewModel 
                {
                    Title = "ŞEKİLLER",
                    Description = "Geometrik şekilleri keşfedelim",
                    ImageUrl = "/images/courses/shapes.jpg",
                    IconClass = "fas fa-shapes",
                    BackgroundColor = "bg-success"
                },
                new CourseCardViewModel 
                {
                    Title = "SAYILAR",
                    Description = "Sayıları öğrenelim ve sayalım",
                    ImageUrl = "/images/courses/numbers.jpg",
                    IconClass = "fas fa-calculator",
                    BackgroundColor = "bg-info"
                },
                new CourseCardViewModel 
                {
                    Title = "RENKLER",
                    Description = "Renklerin dünyasına yolculuk",
                    ImageUrl = "/images/courses/colors.jpg",
                    IconClass = "fas fa-palette",
                    BackgroundColor = "bg-warning"
                },
                new CourseCardViewModel 
                {
                    Title = "TRAFİK LEVHALARI",
                    Description = "Trafik levhalarını tanıyalım",
                    ImageUrl = "/images/courses/traffic.jpg",
                    IconClass = "fas fa-traffic-light",
                    BackgroundColor = "bg-danger"
                },
                new CourseCardViewModel 
                {
                    Title = "GÖRGÜ KURALLARI",
                    Description = "Görgü kurallarını öğrenelim",
                    ImageUrl = "/images/courses/manners.jpg",
                    IconClass = "fas fa-hands-helping",
                    BackgroundColor = "bg-secondary"
                },
                new CourseCardViewModel 
                { 
                    Title = "MASALLAR",
                    Description = "Eğitici masallar dinleyelim",
                    ImageUrl = "/images/courses/tales.jpg",
                    IconClass = "fas fa-book-reader",
                    BackgroundColor = "bg-primary"
                },
                new CourseCardViewModel 
                { 
                    Title = "EĞİTİCİ VİDEOLAR",
                    Description = "Eğitici videolar izleyelim",
                    ImageUrl = "/images/courses/videos.jpg",
                    IconClass = "fas fa-video",
                    BackgroundColor = "bg-success"
                }
            };

            return View(courses);
        }

        public IActionResult Details(string title)
        {
            if (title == "HAYVANLAR")
            {
                return RedirectToAction("Animals");
            }
            if (title == "MASALLAR")
            {
                return RedirectToAction("Tales");
            }
            if (title == "EĞİTİCİ VİDEOLAR")
            {
                return RedirectToAction("EducationalVideos");
            }
            if (title == "RENKLER")
            {
                return RedirectToAction("Colors");
            }
            if (title == "SAYILAR")
            {
                return RedirectToAction("Numbers");
            }
            if (title == "ŞEKİLLER")
            {
                return RedirectToAction("Shapes");
            }
            if (title == "TRAFİK LEVHALARI")
            {
                return RedirectToAction("TrafficSigns");
            }
            if (title == "GÖRGÜ KURALLARI")
            {
                return RedirectToAction("Manners");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Animals()
        {
            var animals = new List<AnimalViewModel>
            {
                new AnimalViewModel { Name = "Kedi", ImagePath = "/images/animals/cat.jpg", SoundPath = "/sounds/animals/kedi.mp3", Description = "Miyav diyen sevimli dostumuz" },
                new AnimalViewModel { Name = "Köpek", ImagePath = "/images/animals/dog.jpg", SoundPath = "/sounds/animals/kopek.mp3", Description = "Hav hav diyen sadık dostumuz" },
                new AnimalViewModel { Name = "At", ImagePath = "/images/animals/horse.jpg", SoundPath = "/sounds/animals/at.mp3", Description = "Güçlü ve zarif hayvan" },
                new AnimalViewModel { Name = "İnek", ImagePath = "/images/animals/cow.jpg", SoundPath = "/sounds/animals/inek.mp3", Description = "Bize süt veren hayvan" },
                new AnimalViewModel { Name = "Kuş", ImagePath = "/images/animals/bird.jpg", SoundPath = "/sounds/animals/kus.mp3", Description = "Cik cik öten minik dostumuz" },
                new AnimalViewModel { Name = "Fil", ImagePath = "/images/animals/elephant.jpg", SoundPath = "/sounds/animals/fil.mp3", Description = "Büyük ve akıllı hayvan" },
                new AnimalViewModel { Name = "Tavuk", ImagePath = "/images/animals/chicken.jpg", SoundPath = "/sounds/animals/tavuk.mp3", Description = "Gıt gıt gıdak diyen kümes hayvanı" },
                new AnimalViewModel { Name = "Aslan", ImagePath = "/images/animals/lion.jpg", SoundPath = "/sounds/animals/aslan.mp3", Description = "Ormanların kralı" }
            };

            return View(animals);
        }

        public IActionResult Shapes()
        {
            var shapes = new List<ShapeViewModel>
            {
                new ShapeViewModel 
                { 
                    Name = "Kare", 
                    ImagePath = "/images/shapes/kare.jpg", 
                    Description = "Dört kenarı eşit olan şekil",
                    Color = "bg-primary",
                    Sides = 4
                },
                new ShapeViewModel 
                { 
                    Name = "Üçgen", 
                    ImagePath = "/images/shapes/ucgen.jpg", 
                    Description = "Üç kenarı olan şekil",
                    Color = "bg-success",
                    Sides = 3
                },
                new ShapeViewModel 
                { 
                    Name = "Daire", 
                    ImagePath = "/images/shapes/daire.jpg", 
                    Description = "Yuvarlak şekil",
                    Color = "bg-danger",
                    Sides = 0
                },
                new ShapeViewModel 
                { 
                    Name = "Dikdörtgen", 
                    ImagePath = "/images/shapes/dikdortgen.jpg", 
                    Description = "İki kenarı uzun, iki kenarı kısa olan şekil",
                    Color = "bg-warning",
                    Sides = 4
                },
                new ShapeViewModel 
                { 
                    Name = "Beşgen", 
                    ImagePath = "/images/shapes/besgen.jpg", 
                    Description = "Beş kenarı olan şekil",
                    Color = "bg-info",
                    Sides = 5
                },
                new ShapeViewModel 
                { 
                    Name = "Altıgen", 
                    ImagePath = "/images/shapes/altigen.jpg", 
                    Description = "Altı kenarı olan şekil",
                    Color = "bg-secondary",
                    Sides = 6
                },
                new ShapeViewModel 
                { 
                    Name = "Yıldız", 
                    ImagePath = "/images/shapes/yildiz.jpg", 
                    Description = "Beş köşeli yıldız şekli",
                    Color = "bg-primary",
                    Sides = 10
                },
                new ShapeViewModel 
                { 
                    Name = "Oval", 
                    ImagePath = "/images/shapes/oval.jpg", 
                    Description = "Uzun daire şekli",
                    Color = "bg-success",
                    Sides = 0
                }
            };

            return View(shapes);
        }

        public IActionResult Numbers()
        {
            var numbers = new List<NumberViewModel>
            {
                new NumberViewModel
                {
                    Value = 0,
                    Name = "Sıfır",
                    ImagePath = "/images/numbers/0.jpg",
                    Description = "Hiç yok, boş",
                    Color = "bg-primary",
                    Example = "Hiç kurabiye kalmadı"
                },
                new NumberViewModel
                {
                    Value = 1,
                    Name = "Bir",
                    ImagePath = "/images/numbers/1.jpg",
                    Description = "Tek, bir tane",
                    Color = "bg-success",
                    Example = "Bir güneş"
                },
                new NumberViewModel
                {
                    Value = 2,
                    Name = "İki",
                    ImagePath = "/images/numbers/2.jpg",
                    Description = "Çift, iki tane",
                    Color = "bg-danger",
                    Example = "İki göz"
                },
                new NumberViewModel
                {
                    Value = 3,
                    Name = "Üç",
                    ImagePath = "/images/numbers/3.jpg",
                    Description = "Üç tane",
                    Color = "bg-warning",
                    Example = "Üç tekerlekli bisiklet"
                },
                new NumberViewModel
                {
                    Value = 4,
                    Name = "Dört",
                    ImagePath = "/images/numbers/4.jpg",
                    Description = "Dört tane",
                    Color = "bg-info",
                    Example = "Dört mevsim"
                },
                new NumberViewModel
                {
                    Value = 5,
                    Name = "Beş",
                    ImagePath = "/images/numbers/5.jpg",
                    Description = "Beş tane",
                    Color = "bg-secondary",
                    Example = "Beş parmak"
                },
                new NumberViewModel
                {
                    Value = 6,
                    Name = "Altı",
                    ImagePath = "/images/numbers/6.jpg",
                    Description = "Altı tane",
                    Color = "bg-primary",
                    Example = "Altı yüzlü zar"
                },
                new NumberViewModel
                {
                    Value = 7,
                    Name = "Yedi",
                    ImagePath = "/images/numbers/7.jpg",
                    Description = "Yedi tane",
                    Color = "bg-success",
                    Example = "Haftanın yedi günü"
                },
                new NumberViewModel
                {
                    Value = 8,
                    Name = "Sekiz",
                    ImagePath = "/images/numbers/8.jpg",
                    Description = "Sekiz tane",
                    Color = "bg-danger",
                    Example = "Ahtapotun sekiz kolu"
                },
                new NumberViewModel
                {
                    Value = 9,
                    Name = "Dokuz",
                    ImagePath = "/images/numbers/9.jpg",
                    Description = "Dokuz tane",
                    Color = "bg-warning",
                    Example = "Kedinin dokuz canı"
                }
            };

            return View(numbers);
        }

        public IActionResult Colors()
        {
            var colors = new List<ColorViewModel>
            {
                new ColorViewModel
                {
                    Name = "Kırmızı",
                    ImagePath = "/images/colors/kirmizi.jpg",
                    Description = "Ateş ve güneş rengi",
                    HexCode = "#E53935",
                    Example = "Kırmızı elma"
                },
                new ColorViewModel
                {
                    Name = "Mavi",
                    ImagePath = "/images/colors/mavi.jpg",
                    Description = "Gökyüzü ve deniz rengi",
                    HexCode = "#1E88E5",
                    Example = "Mavi gökyüzü"
                },
                new ColorViewModel
                {
                    Name = "Sarı",
                    ImagePath = "/images/colors/sari.jpg",
                    Description = "Güneş ve limon rengi",
                    HexCode = "#FDD835",
                    Example = "Sarı muz"
                },
                new ColorViewModel
                {
                    Name = "Turuncu",
                    ImagePath = "/images/colors/turuncu.jpg",
                    Description = "Portakal rengi",
                    HexCode = "#FB8C00",
                    Example = "Turuncu portakal"
                },
                new ColorViewModel
                {
                    Name = "Mor",
                    ImagePath = "/images/colors/mor.jpg",
                    Description = "Patlıcan rengi",
                    HexCode = "#8E24AA",
                    Example = "Mor üzüm"
                },
                new ColorViewModel
                {
                    Name = "Pembe",
                    ImagePath = "/images/colors/pembe.jpg",
                    Description = "Çiçek rengi",
                    HexCode = "#EC407A",
                    Example = "Pembe gül"
                },
                new ColorViewModel
                {
                    Name = "Kahverengi",
                    ImagePath = "/images/colors/kahverengi.jpg",
                    Description = "Toprak rengi",
                    HexCode = "#6D4C41",
                    Example = "Kahverengi ağaç gövdesi"
                },
                new ColorViewModel
                {
                    Name = "Siyah",
                    ImagePath = "/images/colors/siyah.jpg",
                    Description = "Gece rengi",
                    HexCode = "#212121",
                    Example = "Siyah kedi"
                }
            };

            return View(colors);
        }

        public IActionResult TrafficSigns()
        {
            var signs = new List<TrafficSignViewModel>
            {
                new TrafficSignViewModel
                {
                    Name = "Dur",
                    ImagePath = "/images/traffic/dur.jpg",
                    Description = "Kırmızı renkli, sekizgen şeklindeki bu levha, aracınızı tamamen durdurmanız gerektiğini gösterir",
                    Color = "bg-danger",
                    SignType = "Uyarı Levhası",
                    Example = "Kavşaklarda ve tehlikeli yol kesişmelerinde bulunur, mutlaka durmanız gerekir"
                },
                new TrafficSignViewModel
                {
                    Name = "Yaya Geçidi",
                    ImagePath = "/images/traffic/yaya.jpg",
                    Description = "Mavi zemin üzerinde beyaz çizgilerle gösterilen, yayaların güvenle karşıdan karşıya geçebileceği yer",
                    Color = "bg-primary",
                    SignType = "Bilgi Levhası",
                    Example = "Okulların, parkların ve kalabalık caddelerin önünde bulunur, yayalara yol vermeliyiz"
                },
                new TrafficSignViewModel
                {
                    Name = "Okul Geçidi",
                    ImagePath = "/images/traffic/okul.jpg",
                    Description = "Sarı zemin üzerinde öğrenci figürü olan bu levha, yakında okul ve öğrenci geçidi olduğunu gösterir",
                    Color = "bg-warning",
                    SignType = "Uyarı Levhası",
                    Example = "Okulların çevresinde bulunur, öğrencilerin güvenliği için yavaşlamalıyız"
                },
                new TrafficSignViewModel
                {
                    Name = "Park Yeri",
                    ImagePath = "/images/traffic/park.jpg",
                    Description = "Mavi zemin üzerinde 'P' harfi olan bu levha, araçların park edebileceği alanı gösterir",
                    Color = "bg-info",
                    SignType = "Bilgi Levhası",
                    Example = "Alışveriş merkezleri ve şehir merkezlerinde bulunur, araçlarımızı güvenle park edebiliriz"
                },
                new TrafficSignViewModel
                {
                    Name = "Bisiklet Yolu",
                    ImagePath = "/images/traffic/bisiklet.jpg",
                    Description = "Yeşil zemin üzerinde bisiklet figürü olan bu levha, bisikletliler için ayrılmış özel yolu gösterir",
                    Color = "bg-success",
                    SignType = "Bilgi Levhası",
                    Example = "Parklarda ve sahil yollarında bulunur, sadece bisikletliler kullanabilir"
                },
                new TrafficSignViewModel
                {
                    Name = "Hastane",
                    ImagePath = "/images/traffic/hastane.jpg",
                    Description = "Kırmızı zemin üzerinde 'H' harfi olan bu levha, yakında hastane olduğunu gösterir",
                    Color = "bg-danger",
                    SignType = "Bilgi Levhası",
                    Example = "Hastanelerin yakınında bulunur, sessiz olmamız ve yavaş gitmemiz gerekir"
                },
                new TrafficSignViewModel
                {
                    Name = "Işıklı İşaret",
                    ImagePath = "/images/traffic/isik.jpg",
                    Description = "Sarı zemin üzerinde trafik lambası figürü olan bu levha, ileride trafik ışığı olduğunu gösterir",
                    Color = "bg-warning",
                    SignType = "Uyarı Levhası",
                    Example = "Büyük kavşaklarda bulunur, trafik ışıklarına dikkat etmeliyiz"
                },
                new TrafficSignViewModel
                {
                    Name = "Yön Levhası",
                    ImagePath = "/images/traffic/yon.jpg",
                    Description = "Mavi zemin üzerinde ok işaretleri olan bu levha, gidebileceğimiz yönleri ve mesafeleri gösterir",
                    Color = "bg-primary",
                    SignType = "Bilgi Levhası",
                    Example = "Yol ayrımlarında ve kavşaklarda bulunur, gideceğimiz yönü bulmamıza yardımcı olur"
                }
            };

            return View(signs);
        }

        public IActionResult Manners()
        {
            var manners = new List<MannersViewModel>
            {
                new MannersViewModel
                {
                    Title = "Teşekkür Etmek",
                    Description = "Biri bize yardım ettiğinde veya bir şey verdiğinde teşekkür etmeliyiz",
                    ImagePath = "/images/manners/tesekkur.jpg",
                    Category = "Temel Görgü Kuralları",
                    Color = "bg-primary",
                    Example = "Arkadaşımız kalemini ödünç verdiğinde",
                    CorrectBehavior = "Teşekkür ederim diyerek minnettarlığımızı göstermeliyiz"
                },
                new MannersViewModel
                {
                    Title = "Kapıyı Çalmak",
                    Description = "Bir odaya girmeden önce kapıyı çalmalı ve izin istemeliyiz",
                    ImagePath = "/images/manners/kapi.jpg",
                    Category = "Ev Kuralları",
                    Color = "bg-success",
                    Example = "Annemizin odasına girmek istediğimizde",
                    CorrectBehavior = "Tık tık diyerek kapıyı çalmalı ve 'Girebilir miyim?' diye sormalıyız"
                },
                new MannersViewModel
                {
                    Title = "Sofra Adabı",
                    Description = "Yemek yerken ağzımızı kapatmalı ve sessiz yemeliyiz",
                    ImagePath = "/images/manners/sofra.png",
                    Category = "Yemek Kuralları",
                    Color = "bg-warning",
                    Example = "Ailece akşam yemeği yerken",
                    CorrectBehavior = "Ağzımız kapalı çiğnemeli ve konuşurken yutkunmalıyız"
                },
                new MannersViewModel
                {
                    Title = "Sıra Beklemek",
                    Description = "Bir yerde sıra varsa, sıramızı beklemeliyiz",
                    ImagePath = "/images/manners/sira.jpg",
                    Category = "Sosyal Alan Kuralları",
                    Color = "bg-info",
                    Example = "Markette kasa sırasında beklerken",
                    CorrectBehavior = "Sabırla sıramızı beklemeli ve öne geçmemeliyiz"
                },
                new MannersViewModel
                {
                    Title = "Selamlaşmak",
                    Description = "Birine rastladığımızda veya bir yere girdiğimizde selamlaşmalıyız",
                    ImagePath = "/images/manners/selam.jpg",
                    Category = "Temel Görgü Kuralları",
                    Color = "bg-danger",
                    Example = "Sabah okula geldiğimizde",
                    CorrectBehavior = "Günaydın veya merhaba diyerek selamlaşmalıyız"
                },
                new MannersViewModel
                {
                    Title = "Özür Dilemek",
                    Description = "Yanlış bir şey yaptığımızda özür dilemeliyiz",
                    ImagePath = "/images/manners/ozur.jpg",
                    Category = "Temel Görgü Kuralları",
                    Color = "bg-primary",
                    Example = "Yanlışlıkla birine çarptığımızda",
                    CorrectBehavior = "Özür dilerim diyerek hatamızı kabul etmeliyiz"
                },
                new MannersViewModel
                {
                    Title = "Dinlemek",
                    Description = "Biri konuşurken dikkatle dinlemeli ve sözünü kesmemeliyiz",
                    ImagePath = "/images/manners/dinle.jpg",
                    Category = "İletişim Kuralları",
                    Color = "bg-success",
                    Example = "Öğretmenimiz ders anlatırken",
                    CorrectBehavior = "Sessizce ve dikkatle dinlemeli, sözünü bitirmesini beklemeliyiz"
                },
                new MannersViewModel
                {
                    Title = "Paylaşmak",
                    Description = "Oyuncaklarımızı ve eşyalarımızı arkadaşlarımızla paylaşmalıyız",
                    ImagePath = "/images/manners/paylasma.png",
                    Category = "Sosyal Alan Kuralları",
                    Color = "bg-warning",
                    Example = "Arkadaşımız oyuncağımızla oynamak istediğinde",
                    CorrectBehavior = "Oyuncağımızı paylaşmalı ve sırayla oynamalıyız"
                }
            };

            return View(manners);
        }

        public IActionResult Tales()
        {
            var tales = new List<TaleViewModel>
            {
                new TaleViewModel
                {
                    Title = "Pamuk Prenses ve Yedi Cüceler",
                    Description = "Kötü kalpli kraliçeden kaçan güzel prensesin, yedi cüce ile tanışması ve yaşadığı maceraları anlatan, dostluk ve iyiliğin kötülüğü yendiği bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=XCtzC66zJyo",
                    IconClass = "fas fa-crown",
                    IconColor = "text-warning",
                    ImageUrl = "https://img.youtube.com/vi/XCtzC66zJyo/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Çirkin Ördek Yavrusu",
                    Description = "Farklı görünen bir ördek yavrusunun, zamanla güzel bir kuğuya dönüşmesini ve kendini kabul etme sürecini anlatan, önyargıları kıran bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=44MsdO8RQ4g",
                    IconClass = "fas fa-feather",
                    IconColor = "text-info",
                    ImageUrl = "https://img.youtube.com/vi/44MsdO8RQ4g/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Hansel ve Gretel",
                    Description = "İki kardeşin ormanda kaybolup şekerden yapılmış bir eve rastlamaları ve kötü kalpli cadıdan kurtulma maceralarını anlatan, kardeşlik ve zekânın önemini vurgulayan bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=jpRq4PSIg_U",
                    IconClass = "fas fa-home",
                    IconColor = "text-success",
                    ImageUrl = "https://img.youtube.com/vi/jpRq4PSIg_U/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "İnatçı Yavru Fil",
                    Description = "Küçük bir filin inatçılığı bırakıp, büyüklerini dinlemenin önemini öğrendiği, eğlenceli ve öğretici bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=qaNZkV8d0xs",
                    IconClass = "fas fa-elephant",
                    IconColor = "text-secondary",
                    ImageUrl = "https://img.youtube.com/vi/qaNZkV8d0xs/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Bremen Mızıkacıları",
                    Description = "Farklı hayvanların bir araya gelerek müzik grubu kurması ve yaşadıkları maceraları anlatan, dostluk ve dayanışmanın önemini vurgulayan bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=yyZh24aXRT4",
                    IconClass = "fas fa-music",
                    IconColor = "text-danger",
                    ImageUrl = "https://img.youtube.com/vi/yyZh24aXRT4/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Tavşan ve Kaplumbağa",
                    Description = "Kendini beğenmiş tavşan ile azimli kaplumbağanın yarış hikayesi. Sabır, azim ve alçakgönüllülüğün önemini anlatan klasik bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=OtAhcLHMvw0",
                    IconClass = "fas fa-running",
                    IconColor = "text-success",
                    ImageUrl = "https://img.youtube.com/vi/OtAhcLHMvw0/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Peter Pan",
                    Description = "Hiç büyümeyen Peter Pan'ın, Wendy ve kardeşleriyle Varolmayan Ülke'de yaşadığı maceraları anlatan, hayal gücü ve çocukluğun değerini vurgulayan bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=0mfrvDVYP-w",
                    IconClass = "fas fa-child",
                    IconColor = "text-primary",
                    ImageUrl = "https://img.youtube.com/vi/0mfrvDVYP-w/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Polyanna",
                    Description = "Her durumda mutluluk bulmayı başaran küçük bir kızın hikayesi. Pozitif düşünmenin ve hayata iyi yönden bakmanın önemini anlatan bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=4v5msB7xVh8",
                    IconClass = "fas fa-smile",
                    IconColor = "text-warning",
                    ImageUrl = "https://img.youtube.com/vi/4v5msB7xVh8/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Külkedisi",
                    Description = "Üvey ailesi tarafından kötü davranılan genç bir kızın, sihirli bir gecede prensle tanışması ve hayallerine kavuşmasını anlatan, umut ve iyiliğin kazandığı bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=-vHfkGd0J_s",
                    IconClass = "fas fa-shoe-prints",
                    IconColor = "text-info",
                    ImageUrl = "https://img.youtube.com/vi/-vHfkGd0J_s/maxresdefault.jpg"
                },
                new TaleViewModel
                {
                    Title = "Rapunzel",
                    Description = "Uzun saçlı prensesin kuleden kurtulma hikayesi. Cesaret ve özgürlüğün önemini anlatan, macera dolu bir masal.",
                    VideoUrl = "https://www.youtube.com/watch?v=YblC4cu905E",
                    IconClass = "fas fa-tower",
                    IconColor = "text-purple",
                    ImageUrl = "https://img.youtube.com/vi/YblC4cu905E/maxresdefault.jpg"
                }
            };

            return View(tales);
        }

        public IActionResult EducationalVideos()
        {
            var videos = new List<EducationalVideoViewModel>
            {
                new EducationalVideoViewModel
                {
                    Title = "Harfleri Öğreniyorum",
                    Description = "Çocuklar için eğlenceli ve öğretici bir şekilde Türkçe alfabedeki harfleri öğrenme videosu.",
                    VideoUrl = "https://www.youtube.com/watch?v=ZMzbu9Ml5iQ",
                    IconClass = "fas fa-alphabet",
                    IconColor = "text-primary",
                    ImageUrl = "https://img.youtube.com/vi/ZMzbu9Ml5iQ/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Ailemizi Tanıyalım",
                    Description = "Aile bireylerini ve aile kavramını öğreten, sevgi dolu bir eğitim videosu.",
                    VideoUrl = "https://www.youtube.com/watch?v=hQHtIMRl5C8",
                    IconClass = "fas fa-users",
                    IconColor = "text-success",
                    ImageUrl = "https://img.youtube.com/vi/hQHtIMRl5C8/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Vücudumuzu Tanıyalım",
                    Description = "Vücut bölümlerimizi ve işlevlerini eğlenceli bir şekilde öğreten video.",
                    VideoUrl = "https://www.youtube.com/watch?v=1WtM6I4DGQY",
                    IconClass = "fas fa-child",
                    IconColor = "text-info",
                    ImageUrl = "https://img.youtube.com/vi/1WtM6I4DGQY/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Meyveleri Öğreniyoruz",
                    Description = "Farklı meyveleri ve özelliklerini tanıtan eğlenceli bir öğrenme videosu.",
                    VideoUrl = "https://www.youtube.com/watch?v=F60qUvfQcZI",
                    IconClass = "fas fa-apple-alt",
                    IconColor = "text-danger",
                    ImageUrl = "https://img.youtube.com/vi/F60qUvfQcZI/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Kişisel Temizlik",
                    Description = "Temel hijyen kurallarını ve kişisel temizliğin önemini anlatan eğitici video.",
                    VideoUrl = "https://www.youtube.com/watch?v=2Wd0wtJF76A",
                    IconClass = "fas fa-shower",
                    IconColor = "text-primary",
                    ImageUrl = "https://img.youtube.com/vi/2Wd0wtJF76A/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Duygular",
                    Description = "Temel duyguları ve bu duyguları nasıl ifade edebileceğimizi öğreten video.",
                    VideoUrl = "https://www.youtube.com/watch?v=j5uMU7UXyA4",
                    IconClass = "fas fa-smile",
                    IconColor = "text-warning",
                    ImageUrl = "https://img.youtube.com/vi/j5uMU7UXyA4/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Duyu Organlarımız",
                    Description = "Beş duyu organımızı ve işlevlerini öğreten eğlenceli bir video.",
                    VideoUrl = "https://www.youtube.com/watch?v=JtOPDM74-Ng",
                    IconClass = "fas fa-eye",
                    IconColor = "text-success",
                    ImageUrl = "https://img.youtube.com/vi/JtOPDM74-Ng/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Diş Fırçalama",
                    Description = "Doğru diş fırçalama tekniklerini ve ağız sağlığının önemini anlatan eğitici video.",
                    VideoUrl = "https://www.youtube.com/watch?v=f25qwpKIXwE",
                    IconClass = "fas fa-tooth",
                    IconColor = "text-info",
                    ImageUrl = "https://img.youtube.com/vi/f25qwpKIXwE/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "İç Organlarımız",
                    Description = "Vücudumuzdaki iç organları ve görevlerini anlatan öğretici video.",
                    VideoUrl = "https://www.youtube.com/watch?v=uLH759yckbE",
                    IconClass = "fas fa-heart",
                    IconColor = "text-danger",
                    ImageUrl = "https://img.youtube.com/vi/uLH759yckbE/maxresdefault.jpg"
                },
                new EducationalVideoViewModel
                {
                    Title = "Meslekleri Öğreniyoruz",
                    Description = "Farklı meslekleri ve bu mesleklerin topluma katkılarını tanıtan eğitici video.",
                    VideoUrl = "https://www.youtube.com/watch?v=aUl9lLPXAJ0",
                    IconClass = "fas fa-briefcase",
                    IconColor = "text-primary",
                    ImageUrl = "https://img.youtube.com/vi/aUl9lLPXAJ0/maxresdefault.jpg"
                }
            };

            return View(videos);
        }
    }
} 