namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するチェックボックスの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">チェックボックスのBy</param>
public class チェックボックス : フォーム要素
{
    private チェックボックス(画面要素インターフェース 要素) : base(要素)
    {
    }

    public static チェックボックス ById(画面 親画面, string id)
    {
        return new チェックボックス(親画面.Idで要素を探す(id));
    }
    public static チェックボックス ByTagName(画面 親画面, string tagName)
    {
        return new チェックボックス(親画面.TagNameで要素を探す(tagName));
    }

    public void クリックする()
    {
        インターフェース.クリックする();
    }

    /// <summary>
    /// 選択する
    /// </summary>
    public void 選択する()
    {
        // 選択する処理
        if (!インターフェース.選択されている)
        {
            インターフェース.クリックする();
        }
    }

    /// <summary>
    /// 解除する
    /// </summary>
    public void 解除する()
    {
        // 解除する処理
        if (インターフェース.選択されている)
        {
            インターフェース.クリックする();
        }
    }

    // public String? 文字列
    // {
    //     get { return element.Text; }
    // }

    public Boolean 選択されている => インターフェース.選択されている;
    public Boolean 選択されていない => !インターフェース.選択されている;
}