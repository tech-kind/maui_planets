namespace MauiPlanets.Services;

public static class PlanetsService
{
    private static List<Planet> _planets = new()
    {
        new()
        {
            Name = "水星",
            Subtitle = "最も小さな惑星",
            HeroImage = "mercury.png",
            Description = "水星は4つの地球型惑星の中で最初にできた惑星です。ほとんどが岩石でできており、太陽に最も近い惑星です。",
            AccentColorStart = Color.FromArgb("#353535"),
            AccentColorEnd = Color.FromArgb("#8d9098"),
            Images = new()
            {
                "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
            }
        },
        new()
        {
            Name = "金星",
            Subtitle = "宝石のような輝き",
            HeroImage = "venus.png",
            Description = "すべての惑星の中で、金星は地球に最もよく似た惑星です。金星は地球の「姉妹星」とも呼ばれています。しかし、似ているところがある一方で、大きく違うところもあります。",
            AccentColorStart = Color.FromArgb("#a6393b"),
            AccentColorEnd = Color.FromArgb("#d17f21"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
            }
        },
        new()
        {
            Name = "地球",
            Subtitle = "生命のゆりかご",
            HeroImage = "earth.png",
            Description = "地球は、生命が存在する唯一の惑星として知られています。これまでに約150万種の動物や植物が発見されています。他の惑星には少量の氷や水蒸気が存在することもありますが、地球は2/3が水です。地球は呼吸できる大気の条件を完璧に満たしているのです。",
            AccentColorStart = Color.FromArgb("#0e3d68"),
            AccentColorEnd = Color.FromArgb("#2e97c7"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
            }
        },
        new()
        {
            Name = "火星",
            Subtitle = "美しき赤色",
            HeroImage = "mars.png",
            Description = "火星ほど、人類の想像力をかきたてる惑星はないでしょう。火星の赤みがかった色などは不思議な魅力があります。火星人が地球を侵略しているという話も、50年以上前からあります。しかし、火星には本当に生命体が存在するのでしょうか？",
            AccentColorStart = Color.FromArgb("#a23036"),
            AccentColorEnd = Color.FromArgb("#eb3333"),
            Images = new()
            {
                "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
            }
        },
        new()
        {
            Name = "木星",
            Subtitle = "巨大なガスの塊",
            HeroImage = "jupiter.png",
            Description = "木星は、ガス惑星と呼ばれる惑星の中で最初にできた惑星です。木星は大きさと質量が惑星の中で一番大きいです。直径は地球の11倍あります。木星にある「大赤斑」は、実は猛烈な嵐なのです。",
            AccentColorStart = Color.FromArgb("#9d4a40"),
            AccentColorEnd = Color.FromArgb("#cd8026"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
            }
        },
        new()
        {
            Name = "土星",
            Subtitle = "リングのある星",
            HeroImage = "saturn.png",
            Description = "土星を取り巻くリングは、ほとんどの人が知っているでしょう。このリングは、主に惑星の周りを回る氷の粒子でできています。リング自体は大きく見えますが、粒子は非常に小さく、通常は3メートルもありません。",
            AccentColorStart = Color.FromArgb("#996237"),
            AccentColorEnd = Color.FromArgb("#c6502f"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
            }
        },
        new()
        {
            Name = "天王星",
            Subtitle = "まさに冷たいボール",
            HeroImage = "uranus.png",
            Description = "天王星は、望遠鏡でなければ見ることができないほど遠い惑星です。1781年に初めて発見されたとき、科学者たちは何を発見したのかわかりませんでした。しかし、詳しく調べていくうちに、太陽のまわりを回っていることがわかりました。7番目の惑星を発見です。",
            AccentColorStart = Color.FromArgb("#9d4a40"),
            AccentColorEnd = Color.FromArgb("#996237"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
            }
        },
        new()
        {
            Name = "海王星",
            Subtitle = "遠くの8番目の惑星",
            HeroImage = "neptune.png",
            Description = "数学が得意なジョン・C・アダムスは、見たこともない位置に惑星が存在すると考えました。1843年に海王星を発見したとき、アダムスが言っていたことが正しいと証明されたのです。",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
            }
        }
    };

    public static List<Planet> GetAllPlanets() => _planets;

    public static Planet GetPlanet(string planetName)
        => _planets.Where(x => x.Name == planetName).FirstOrDefault();

    public static List<Planet> GetFeaturedPlanets()
    {
        var rnd = new Random();
        var randomizedPlanets = _planets.OrderBy(item => rnd.Next());

        return randomizedPlanets.Take(2).ToList();
    }
}
