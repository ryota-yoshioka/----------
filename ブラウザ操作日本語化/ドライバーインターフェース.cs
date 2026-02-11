namespace ブラウザ操作日本語化;

public interface ドライバーインターフェース
{
    public void 終了する();

    public void ナビゲートする(string url);

    public int デフォルトの待機秒数 { get; set; }

    public 画面インターフェース 先頭画面 { get; }
}