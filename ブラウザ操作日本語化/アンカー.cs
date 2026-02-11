using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するアンカーの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">アンカーのBy</param>
public class アンカー : フォーム要素
{
    private アンカー(画面要素インターフェース 要素) : base(要素)
    {
    }

    public static アンカー ById(画面 親画面, string id)
    {
        return new アンカー(親画面.Idで要素を探す(id));
    }
    public static アンカー ByTagName(画面 親画面, string tagName)
    {
        return new アンカー(親画面.TagNameで要素を探す(tagName));
    }

    public String? 文字列
    {
        get { return インターフェース.テキスト; }
    }

    public void クリックする()
    {
        インターフェース.クリックする();
    }
}