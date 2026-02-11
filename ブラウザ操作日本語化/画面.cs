namespace ブラウザ操作日本語化;

/// <summary>
/// 画面を操作するソースコードをブラウザの種類やライブラリで共通化するためのクラス
/// </summary>
public class 画面
{
    #pragma warning disable CA1859
    private readonly 画面インターフェース インターフェース;
    #pragma warning restore CA1859

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public 画面(画面インターフェース インターフェース)
    {
        this.インターフェース = インターフェース;
    }

    public 画面(画面インターフェース インターフェース, string url)
    {
        this.インターフェース = インターフェース;
        this.インターフェース.ナビゲートする(url);
    }

    /// <summary>
    /// 画面のタイトル
    /// </summary>
    public String タイトル => インターフェース.タイトル;

    public 画面要素インターフェース Idで要素を探す(string id)
    {
        return インターフェース.Idで要素を探す(id);
    }
    public 画面要素インターフェース Nameで要素を探す(string name)
    {
        return インターフェース.Nameで要素を探す(name);
    }
    public 画面要素インターフェース TagNameで要素を探す(string tagName)
    {
        return インターフェース.TagNameで要素を探す(tagName);
    }
}