using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するドロップダウンの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="driver">WebDriver</param>
/// <param name="by">ドロップダウンのBy</param>
public class ドロップダウン(By by) : Web要素(by)
{
    public IList<オプション> 選択された全てのオプション
    {
        get
        {
            return [.. new SelectElement(element)
                        .AllSelectedOptions
                        .Select(e => new オプション(this, e))];
        }    
    }

    public bool 複数選択可能
    {
        get
        {
            return new SelectElement(element).IsMultiple;
        }
    }

    public IList<オプション> 選択肢を取得する
    {
        get
        {
            return [.. new SelectElement(element)
                        .Options
                        .Select(e => new オプション(this, e))];
        }
    }

    public オプション 選択された選択肢
    {
        get
        {
            return new オプション(this, new SelectElement(element).SelectedOption);
        }
    }

    public IWebElement WrappedElement
    {
        get
        {
            return new SelectElement(element).WrappedElement;
        }
    }

    public void DeselectAll()
    {
        var select = new SelectElement(element);
        select.DeselectAll();
    }

    public void DeselectByIndex(int index)
    {
        var select = new SelectElement(element);
        select.DeselectByIndex(index);
    }

    public void DeselectByText(string text)
    {
        var select = new SelectElement(element);
        select.DeselectByText(text);
    }

    public void DeselectByValue(string value)
    {
        var select = new SelectElement(element);
        select.DeselectByValue(value);
    }

    public void SelectByIndex(int index)
    {
        var select = new SelectElement(element);
        select.SelectByIndex(index);
    }

    public void SelectByText(string text)
    {
        var select = new SelectElement(element);
        select.SelectByText(text);
    }

    public void SelectByValue(string value)
    {
        var select = new SelectElement(element);
        select.SelectByValue(value);
    }

    /// <summary>
    /// 選択する
    /// </summary>
    public void 選択する(string 文字列)
    {
        // 選択する処理
        var select = new SelectElement(element);
        select.SelectByText(文字列);
    }

    /// <summary>
    /// 値で選択する
    /// </summary>
    public void 値で選択する(string 値)
    {
        // 選択する処理
        var select = new SelectElement(element);
        select.SelectByValue(値);
    }

    /// <summary>
    /// 順番で選択する
    /// </summary>
    public void 順番で選択する(int 順番)
    {
        // 選択する処理
        var select = new SelectElement(element);
        select.SelectByIndex(順番);
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