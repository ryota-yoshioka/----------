using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するオプション（ドロップダウンの選択肢）の基底クラス
/// </summary>
public class オプション : フォーム要素
{
    private readonly ドロップダウン 親ドロップダウン;

    public オプション(ドロップダウン 親ドロップダウン, 画面要素インターフェース 要素) : base(要素)
    {
        this.親ドロップダウン = 親ドロップダウン;
    }

    /// <summary>
    /// 選択する
    /// </summary>
    public void 選択する()
    {
        if (!選択されている)
        {
            インターフェース.クリックする();
        }
    }

    public String 文字列
    {
        get { return インターフェース.オプションの表示文字列; }
    }

    public Boolean 選択されている
    {
        get { return インターフェース.選択されている; }
    }

    public Boolean 選択されていない
    {
        get { return !インターフェース.選択されている; }
    }
}