namespace ブラウザ操作日本語化;

public abstract class ブラウザ
{
    public ドライバーインターフェース ドライバ;

    public ブラウザ(ドライバーインターフェース ドライバ)
    {
        this.ドライバ = ドライバ;
    }

    public 画面インターフェース 先頭画面 => ドライバ.先頭画面;
    public void 閉じる()
    {
        ドライバ.終了する();
    }

    /// <summary>
    /// 指定されたURLに移動する
    /// </summary>
    /// <param name="url">移動先のURL</param>
    public void 移動する(string url)
    {
        ドライバ.ナビゲートする(url);
    }

    public int 暗黙の待機秒数
    {
        get => ドライバ.デフォルトの待機秒数;
        set => ドライバ.デフォルトの待機秒数 = value;
    }
}