using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するテキストボックスの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">テキストボックスのBy</param>
public class テキストボックス : フォーム要素
{
    private テキストボックス(画面要素インターフェース 要素) : base(要素)
    {
    }

    public static テキストボックス ById(画面 親画面, string id)
    {
        return new テキストボックス(親画面.Idで要素を探す(id));
    }
    public static テキストボックス ByTagName(画面 親画面, string tagName)
    {
        return new テキストボックス(親画面.TagNameで要素を探す(tagName));
    }

    /// <summary>
    /// テキストを入力する
    /// </summary>
    /// <param name="text">入力するテキスト</param>
    public void 入力する(string テキスト)
    {
        インターフェース.キー入力を送る(テキスト);
    }

    public String? 文字列
    {
        set { インターフェース.キー入力を送る(value!); }
        get { return インターフェース.属性を取得する("value"); }
    }
}