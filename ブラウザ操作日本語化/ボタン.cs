using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するボタンの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">ボタンのBy</param>
public class ボタン : フォーム要素
{
    private ボタン(画面要素インターフェース 要素) : base(要素)
    {
    }
    public static ボタン ById(画面 親画面, string id)
    {
        return new ボタン(親画面.Idで要素を探す(id));
    }
    public static ボタン ByTagName(画面 親画面, string tagName)
    {
        return new ボタン(親画面.TagNameで要素を探す(tagName));
    }

    /// <summary>
    /// ボタンを押す
    /// </summary>
    public void 押す()
    {
        インターフェース.クリックする();
    }

    public string? 文字列 => インターフェース.テキスト;
}
