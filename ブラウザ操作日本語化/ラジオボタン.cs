using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するラジオボタンの基底クラス
/// </summary>
/// <remarks>
/// コンストラクタ
/// </remarks>
/// <param name="by">ラジオボタンのBy</param>
public class ラジオボタン : フォーム要素
{
    private ラジオボタン(画面要素インターフェース 要素) : base(要素)
    {
    }

    public static ラジオボタン ById(画面 親画面, string id)
    {
        return new ラジオボタン(親画面.Idで要素を探す(id));
    }
    public static ラジオボタン ByName(画面 親画面, string name)
    {
        return new ラジオボタン(親画面.Nameで要素を探す(name));
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
        if (!インターフェース.チェックされている)
        {
            インターフェース.クリックする();
        }
    }

    // public String? 文字列
    // {
    //     get { return element.Text; }
    // }

    public Boolean 選択されている => インターフェース.チェックされている;
    public Boolean 選択されていない => !インターフェース.チェックされている;
}