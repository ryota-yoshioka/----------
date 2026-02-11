namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するドロップダウンの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="driver">WebDriver</param>
/// <param name="by">ドロップダウンのBy</param>
public class ドロップダウン : フォーム要素
{
    private ドロップダウン(画面要素インターフェース 要素) : base(要素)
    {
    }
    public static ドロップダウン ById(画面 親画面, string id)
    {
        return new ドロップダウン(親画面.Idで要素を探す(id));
    }
    public static ドロップダウン ByName(画面 親画面, string name)
    {
        return new ドロップダウン(親画面.Nameで要素を探す(name));
    }

    public IList<オプション> 全ての選択されたオプション
    {
        get
        {
            return [.. インターフェース
                        .全ての選択された選択肢()
                        .Select(e => new オプション(this, e))];
        }    
    }

    public bool 複数選択可能 => インターフェース.複数選択可能;

    public IList<オプション> 全てのオプションを取得する
    {
        get
        {
            return [.. インターフェース
                        .選択肢のリスト()
                        .Select(e => new オプション(this, e))];
        }
    }

    public オプション 選択されたオプション
    {
        get
        {
            return new オプション(this, インターフェース.選択された選択肢);
        }
    }

    /// <summary>
    /// 選択する
    /// </summary>
    public void 選択する(string 文字列)
    {
        インターフェース.テキストで選択する(文字列);
    }

    /// <summary>
    /// 値で選択する
    /// </summary>
    public void 値で選択する(string 値)
    {
        インターフェース.値で選択する(値);
    }

    /// <summary>
    /// 順番で選択する
    /// </summary>
    public void 順番で選択する(int 順番)
    {
        インターフェース.順番で選択する(順番);
    }

    // public String? 文字列
    // {
    //     get { return element.Text; }
    // }

    public Boolean 選択されている
    {
        get { return インターフェース.選択されている; }
    }

    public Boolean 選択されていない
    {
        get { return !インターフェース.選択されている; }
    }
}