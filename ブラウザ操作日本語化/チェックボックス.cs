using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するチェックボックスの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">チェックボックスのBy</param>
public class チェックボックス(By by) : Web要素(by)
{
    /// <summary>
    /// クリックする
    /// </summary>
    public void クリックする()
    {
        // クリックする処理
        element.Click();
    }

    /// <summary>
    /// 選択する
    /// </summary>
    public void 選択する()
    {
        // 選択する処理
        if (!element.Selected)
        {
            element.Click();
        }
    }

    /// <summary>
    /// 解除する
    /// </summary>
    public void 解除する()
    {
        // 解除する処理
        if (element.Selected)
        {
            element.Click();
        }
    }

    // public String? 文字列
    // {
    //     get { return element.Text; }
    // }

    public Boolean 選択されている
    {
        get { return element.Selected; }
    }

    public Boolean 選択されていない
    {
        get { return !element.Selected; }
    }
}