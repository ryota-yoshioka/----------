namespace ブラウザ操作日本語化;

public class ブラウザ
{
    /// <summary>
    /// 指定されたURLに移動する
    /// </summary>
    /// <param name="url">移動先のURL</param>
    public static void 移動する(string url)
    {
        Webユニットテスト.Webドライバ.Navigate().GoToUrl(url);
    }

    /// <summary>
    /// 画面を閉じる
    /// </summary>
    public static void 閉じる()
    {
        Webユニットテスト.Webドライバ.Close();
    }
}