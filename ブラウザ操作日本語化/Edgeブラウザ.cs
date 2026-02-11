using OpenQA.Selenium.Edge;

namespace ブラウザ操作日本語化;

public class Edgeブラウザ : ブラウザ
{
    public Edgeブラウザ() : this(new EdgeOptions())
    {
    }
    public Edgeブラウザ(EdgeOptions options) : base(new Edgeドライバ(options))
    {
    }

    public static Edgeブラウザ 起動する()
    {
        return new Edgeブラウザ();
    }
}