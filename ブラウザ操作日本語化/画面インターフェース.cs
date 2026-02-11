namespace ブラウザ操作日本語化;

public interface 画面インターフェース
{
    /// <summary>
    /// 画面のタイトル
    /// </summary>
    String タイトル { get; }

    public void ナビゲートする(string url);
    public 画面要素インターフェース Idで要素を探す(string id);
    public 画面要素インターフェース Nameで要素を探す(string name);
    public 画面要素インターフェース TagNameで要素を探す(string tagName);
}