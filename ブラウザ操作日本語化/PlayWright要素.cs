using Microsoft.Playwright;

namespace ブラウザ操作日本語化;

public class Playwright要素 : 画面要素インターフェース
{
    private readonly ILocator element;

    public Playwright要素(ILocator ロケーター)
    {
        this.element = ロケーター;
    }

    public String? 値 => element.GetAttributeAsync("value").Result;
    public bool 有効である => element.IsEnabledAsync().Result;

    public bool 表示されている => element.IsVisibleAsync().Result;

    public void クリックする()
    {
        element.ClickAsync().Wait();
    }

    public string テキスト => element.InnerTextAsync().Result!;
    public String 入力文字列 => element.InputValueAsync().Result;
    public String オプションの表示文字列 => element.TextContentAsync().Result ?? string.Empty;


    public void クリアする()
    {
        element.ClearAsync().Wait();
    }
 
    public void キー入力を送る(string text)
    {
        element.FillAsync(text).Wait();
    }

    public string? 属性を取得する(string attributeName)
    {
        return element.GetAttributeAsync(attributeName).Result;
    }

    public bool 選択されている => (element.GetAttributeAsync("selected").Result != null);
    public bool チェックされている => element.IsCheckedAsync().Result;

    public IList<画面要素インターフェース> 選択肢のリスト()
    {
        return [.. element.Locator("option").AllAsync().Result.Select(opt => new Playwright要素(opt))];
    }
    public IList<画面要素インターフェース> 全ての選択された選択肢()
    {
        return [.. this.選択肢のリスト().Where(_ => _.選択されている)];
    }
    public 画面要素インターフェース? 選択された選択肢
    {
        get
        {
            var inputValue = element.InputValueAsync().Result;
            var selectedOption = element.Locator($"option[value='{inputValue}']");
            if (selectedOption != null)
            {
                return new Playwright要素(selectedOption);
            }
            return null;
        }
    }
    public bool 複数選択可能 => element.GetAttributeAsync("multiple").Result != null;

    public void テキストで選択する(string text)
    {
        element.SelectOptionAsync([new SelectOptionValue { Label = text }]).Wait();
    }
    public void 値で選択する(string value)
    {
        element.SelectOptionAsync(value).Wait();
    }
    public void 順番で選択する(int index)
    {
        element.SelectOptionAsync([new SelectOptionValue {Index = index}]).Wait();
    }
    public 画面要素インターフェース ラップされた要素
    {
        get
        {
            return new Playwright要素(element.Locator("").First);
        }
    }
    public void 全て選択解除する()
    {
        element.SelectOptionAsync("").Wait();
    }
    public void 順番で選択解除する(int index)
    {
        var options = this.選択肢のリスト();
        options.RemoveAt(index);
        var array = options.Select(_ => _.属性を取得する("value")!).ToArray();
        element.SelectOptionAsync(array).Wait();
    }

    public void テキストで選択解除する(string text)
    {
        var options = element.GetByRole(AriaRole.Option, new() { Selected =  true}).AllAsync().Result;
        var names = options.Select(_ => _.InnerTextAsync().Result).Where(_ => _ != text).ToArray();
        element.SelectOptionAsync(names).Wait();
    }

    public void 値で選択解除する(string value)
    {
        var options = element.GetByRole(AriaRole.Option, new() { Selected =  true}).AllAsync().Result;
        var values = options.Select(_ => _.GetAttributeAsync("value").Result!).Where(_ => _ != value).ToArray();
        element.SelectOptionAsync(values).Wait();
    }
}