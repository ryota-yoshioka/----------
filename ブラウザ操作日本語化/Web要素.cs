using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ブラウザ操作日本語化;

/// <summary>
/// Web要素のインターフェース（Selenium版）
/// </summary>
public class Web要素 : 画面要素インターフェース
{
    private readonly IWebElement element;

    public Web要素(IWebElement element)
    {
        this.element = element;
    }

    public bool 有効である => element.Enabled;

    public bool 表示されている => element.Displayed;

    public void クリックする()
    {
        element.Click();
    }

    public string テキスト => element.Text;

    public void クリアする()
    {
        element.Clear();
    }
 
    public void キー入力を送る(string text)
    {
        element.SendKeys(text);
    }

    public string? 属性を取得する(string attributeName)
    {
        return element.GetAttribute(attributeName);
    }

    public bool 選択されている => element.Selected;

    public IList<画面要素インターフェース> 選択肢のリスト()
    {
        var selectElement = new SelectElement(element);
        return [.. selectElement.Options.Select(opt => new Web要素(opt))];
    }
    public IList<画面要素インターフェース> 全ての選択された選択肢()
    {
        var selectElement = new SelectElement(element);
        return [.. selectElement.AllSelectedOptions.Select(opt => new Web要素(opt))];
    }
    public 画面要素インターフェース 選択された選択肢
    {
        get
        {
            var selectElement = new SelectElement(element);
            return new Web要素(selectElement.SelectedOption);
        }
    }
    public bool 複数選択可能 => new SelectElement(element).IsMultiple;

    public void テキストで選択する(string text)
    {
        var selectElement = new SelectElement(element);
        selectElement.SelectByText(text);
    }
    public void 値で選択する(string value)
    {
        var selectElement = new SelectElement(element);
        selectElement.SelectByValue(value);
    }
    public void 順番で選択する(int index)
    {
        var selectElement = new SelectElement(element);
        selectElement.SelectByIndex(index);
    }
    public 画面要素インターフェース ラップされた要素
    {
        get
        {
            return new Web要素(new SelectElement(element).WrappedElement);
        }
    }
    public void 全て選択解除する()
    {
        var select = new SelectElement(element);
        select.DeselectAll();
    }
    public void 順番で選択解除する(int index)
    {
        var select = new SelectElement(element);
        select.DeselectByIndex(index);
    }

    public void テキストで選択解除する(string text)
    {
        var select = new SelectElement(element);
        select.DeselectByText(text);
    }

    public void 値で選択解除する(string value)
    {
        var select = new SelectElement(element);
        select.DeselectByValue(value);
    }
}
