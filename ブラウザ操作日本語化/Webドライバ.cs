using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

public class Webドライバ : ドライバーインターフェース, 画面インターフェース
{
    private readonly IWebDriver ドライバ;

    public Webドライバ(IWebDriver ドライバ)
    {
        this.ドライバ = ドライバ;
    }

    public 画面インターフェース 先頭画面 => this;
    public String タイトル => ドライバ.Title;

    public void 終了する()
    {
        ドライバ.Quit();
    }

    public void ナビゲートする(string url)
    {
        ドライバ.Navigate().GoToUrl(url);
    }

    // public abstract void 最大化する();
    // public abstract void 閉じる();
    public string タイトルを取得する() => ドライバ.Title;
    // public abstract string 現在のURLを取得する();
    // public abstract void ページを更新する();
    // public abstract void 戻る();
    // public abstract void 進む();
    // public abstract void スクリーンショットを保存する(string ファイルパス);
    public 画面要素インターフェース Idで要素を探す(string id)
    {
        return new Web要素(ドライバ.FindElement(By.Id(id)));
    }
    public 画面要素インターフェース Nameで要素を探す(string name)
    {
        return new Web要素(ドライバ.FindElement(By.Name(name)));
    }
    public 画面要素インターフェース TagNameで要素を探す(string tagName)
    {
        return new Web要素(ドライバ.FindElement(By.TagName(tagName)));
    }
    // public abstract void 要素をクリックする(string セレクタ);
    // public abstract void テキストを入力する(string セレクタ, string テキスト);
    // public abstract string 要素のテキストを取得する(string セレクタ);
    // public abstract bool 要素が存在するか(string セレクタ);
    // public abstract void 待機する(int 秒数);
    // public abstract void JavaScriptを実行する(string スクリプト);
    // public abstract void フレームに切り替える(string セレクタ);
    // public abstract void 元のコンテキストに戻る();
    // public abstract void アラートを受け入れる();
    // public abstract void アラートを拒否する();
    // public abstract string アラートのテキストを取得する();
    // public abstract void アラートにテキストを入力する(string テキスト);
    // public abstract void クッキーを追加する(string 名前, string 値);
    // public abstract string クッキーの値を取得する(string 名前);
    // public abstract void クッキーを削除する(string 名前);
    // public abstract void すべてのクッキーを削除する();
    // public abstract void スクロールする(int 横方向, int 縦方向);
    // public abstract void 要素までスクロールする(string セレクタ);
    // public abstract void ウィンドウを切り替える(string ウィンドウハンドル);
    // public abstract string 現在のウィンドウハンドルを取得する();
    // public abstract IList<string> すべてのウィンドウハンドルを取得する();
    // public abstract void 新しいタブを開く();
    // public abstract void タブを閉じる();
    // public abstract void タブを切り替える(int タブインデックス);
    // public abstract int タブの数を取得する();
    // public abstract void ページのソースを取得する();
    // public abstract void クッキーの一覧を取得する();
    // public abstract void 要素の属性を取得する(string セレクタ, string 属性名);
    // public abstract void 要素の属性を設定する(string セレクタ, string 属性名, string 値);
    // public abstract void 要素のスタイルを取得する(string セレクタ, string スタイル名);
    // public abstract void 要素のスタイルを設定する(string セレクタ, string スタイル名, string 値);
    // public abstract void スクリーン全体のスクリーンショットを取得する();
    // public abstract void 要素のスクリーンショットを取得する(string セレクタ);
    // public abstract void ページのズームを設定する(double ズームレベル);
    // public abstract double ページのズームレベルを取得する();
    // public abstract void ヘッドレスモードを有効にする();
    // public abstract void ヘッドレスモードを無効にする();
    // public abstract bool ヘッドレスモードかどうかを取得する();
    // public abstract void プロキシ設定を行う(string プロキシアドレス);
    // public abstract string プロキシ設定を取得する();
    // public abstract void ブラウザの履歴をクリアする();
    // public abstract void キャッシュをクリアする();
    // public abstract void クッキーをクリアする();
    // public abstract void セッションを終了する();
    // public abstract void ドライバを再起動する();
    // public abstract void デバイスエミュレーションを有効にする(string デバイス名);
    // public abstract void デバイスエミュレーションを無効にする();
    // public abstract bool デバイスエミュレーションが有効かどうかを取得する();
    // public abstract void ネットワーク速度を制限する(int ダウンロード速度, int アップロード速度);
    // public abstract void ネットワーク速度の制限を解除する();
    // public abstract void コンソールログを取得する();
    // public abstract void パフォーマンスログを取得する();
    // public abstract void スクリプトタイムアウトを設定する(int 秒数);
    // public abstract int スクリプトタイムアウトを取得する();
    // public abstract void ページロードタイムアウトを設定する(int 秒数);
    // public abstract int ページロードタイムアウトを取得する();
    // public abstract void 要素の存在を待機する(string セレクタ, int 秒数);
    // public abstract void 要素の可視性を待機する(string セレクタ, int 秒数);
    // public abstract void 要素のクリック可能性を待機する(string セレクタ, int 秒数);
    // public abstract void タイトルの一致を待機する(string タイトル, int 秒数);
    // public abstract void URLの一致を待機する(string URL, int 秒数);
    // public abstract void アラートの出現を待機する(int 秒数);
    // public abstract void フレームの切り替えを待機する(string セレクタ, int 秒数);
    // public abstract void 新しいウィンドウの出現を待機する(int 秒数);
    // public abstract void タブの数の変化を待機する(int 期待される数, int 秒数);
    // public abstract void ページの読み込み完了を待機する(int 秒数);
    // public abstract void JavaScriptの完了を待機する(int 秒数);
    // public abstract void ネットワークのアイドル状態を待機する(int 秒数);
    // public abstract void 要素の属性の変化を待機する(string セレクタ, string 属性名, string 期待される値, int 秒数);
    // public abstract void 要素のスタイルの変化を待機する(string セレクタ, string スタイル名, string 期待される値, int 秒数);
    // public abstract void スクロール位置の変化を待機する(int 期待されるX, int 期待されるY, int 秒数);
    // public abstract void ウィンドウサイズの変化を待機する(int 期待される幅, int 期待される高さ, int 秒数);
    // public abstract void ビューポートサイズの変化を待機する(int 期待される幅, int 期待される高さ, int 秒数);
    // public abstract void ブラウザの状態をリセットする();
    // public abstract void デバッグ情報を取得する();
    // public abstract void ログレベルを設定する(string レベル);
    // public abstract string ログレベルを取得する();
    // public abstract void 拡張機能を追加する(string 拡張機能のパス);
    // public abstract void 拡張機能を削除する(string 拡張機能の名前);
    // public abstract IList<string> すべての拡張機能を取得する();
    // public abstract void ブラウザのバージョンを取得する();
    // public abstract void ドライバのバージョンを取得する();
    // public abstract void プラットフォーム情報を取得する();
    // public abstract void システム情報を取得する();
    // public abstract void セッション情報を取得する();
    // public abstract void ブラウザの設定を取得する();
    // public abstract void ブラウザの設定を変更する(string 設定名, string 値);
    public int デフォルトの待機秒数
    {
        get
        {
            return (int)ドライバ.Manage().Timeouts().ImplicitWait.TotalSeconds;
        }
        set
        {
            ドライバ.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }
    }

    // public abstract void スクリーンサイズを設定する(int 幅, int 高さ);
    // public abstract (int 幅, int 高さ) スクリーンサイズを取得する();
    // public abstract void ビューポートサイズを設定する(int 幅, int 高さ);
    // public abstract (int 幅, int 高さ) ビューポートサイズを取得する();
    // public abstract void ユーザーエージェントを設定する(string ユーザーエージェント);
    // public abstract string ユーザーエージェントを取得する();
    // public abstract void 地理位置情報を設定する(double 緯度, double 経度, double 精度);
    // public abstract (double 緯度, double 経度, double 精度) 地理位置情報を取得する();
    // public abstract void ネットワーク条件を設定する(bool オフライン, int 待機時間, int ダウンロード速度, int アップロード速度);
    // public abstract (bool オフライン, int 待機時間, int ダウンロード速度, int アップロード速度) ネットワーク条件を取得する();
    // public abstract void ブラウザの言語を設定する(string 言語);
    // public abstract string ブラウザの言語を取得する();
    // public abstract void タイムゾーンを設定する(string タイムゾーン);
    // public abstract string タイムゾーンを取得する();
    // public abstract void 画面の向きを設定する(string 向き);
    // public abstract string 画面の向きを取得する();
    // public abstract void バッテリー状態を設定する(int レベル, bool 充電中);
    // public abstract (int レベル, bool 充電中) バッテリー状態を取得する();
    // public abstract void メモリ使用量を取得する();
    // public abstract void CPU使用率を取得する();
    // public abstract void ネットワーク使用量を取得する();
    // public abstract void ストレージ使用量を取得する();
    // public abstract void セッションの状態を保存する(string ファイルパス);
    // public abstract void セッションの状態を復元する(string ファイルパス);
    // public abstract void ブラウザの拡張機能を管理する();
    // public abstract void ブラウザのテーマを変更する(string テーマ名);
    // public abstract string ブラウザのテーマを取得する();
    // public abstract void ブラウザのプライバシーモードを有効にする();
    // public abstract void ブラウザのプライバシーモードを無効にする();
    // public abstract bool ブラウザのプライバシーモードが有効かどうかを取得する();
    // public abstract void ブラウザの拡張機能を有効にする(string 拡張機能の名前);
    // public abstract void ブラウザの拡張機能を無効にする(string 拡張機能の名前);
    // public abstract bool ブラウザの拡張機能が有効かどうかを取得する(string 拡張機能の名前);
    // public abstract void ブラウザの自動更新を有効にする();
    // public abstract void ブラウザの自動更新を無効にする();
    // public abstract bool ブラウザの自動更新が有効かどうかを取得する();
    // public abstract void ブラウザのセキュリティ設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのセキュリティ設定を取得する(string 設定名);
    // public abstract void ブラウザのパフォーマンス設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのパフォーマンス設定を取得する(string 設定名);
    // public abstract void ブラウザのアクセシビリティ設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのアクセシビリティ設定を取得する(string 設定名);
    // public abstract void ブラウザの通知設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザの通知設定を取得する(string 設定名);
    // public abstract void ブラウザの位置情報設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザの位置情報設定を取得する(string 設定名);
    // public abstract void ブラウザのマルチメディア設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのマルチメディア設定を取得する(string 設定名);
    // public abstract void ブラウザのダウンロード設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのダウンロード設定を取得する(string 設定名);
    // public abstract void ブラウザのアップロード設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのアップロード設定を取得する(string 設定名);
    // public abstract void ブラウザの印刷設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザの印刷設定を取得する(string 設定名);
    // public abstract void ブラウザの同期設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザの同期設定を取得する(string 設定名);
    // public abstract void ブラウザの拡張機能の設定を変更する(string 拡張機能の名前, string 設定名, string 値);
    // public abstract string ブラウザの拡張機能の設定を取得する(string 拡張機能の名前, string 設定名);
    // public abstract void ブラウザのプロキシ設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのプロキシ設定を取得する(string 設定名);
    // public abstract void ブラウザのネットワーク設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのネットワーク設定を取得する(string 設定名);
    // public abstract void ブラウザのシステム設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのシステム設定を取得する(string 設定名);
    // public abstract void ブラウザのユーザー設定を変更する(string 設定名, string 値);
    // public abstract string ブラウザのユーザー設定を取得する(string 設定名);
    // public abstract void ブラウザのデフォルト設定を復元する();
    // public abstract void ブラウザの状態をエクスポートする(string ファイルパス);
    // public abstract void ブラウザの状態をインポートする(string ファイルパス);
    // public abstract void ブラウザの診断情報を取得する();
    // public abstract void ブラウザのヘルプ情報を取得する();
    // public abstract void ブラウザのライセンス情報を取得する();
    // public abstract void ブラウザのバグレポートを送信する(string レポート内容);
    // public abstract void ブラウザのフィードバックを送信する(string フィードバック内容);
    // public abstract void ブラウザのアップデートを確認する();
    // public abstract void ブラウザのアップデートをインストールする();
    // public abstract void ブラウザのアンインストールを実行する();
    // public abstract void ブラウザの再インストールを実行する();
    // public abstract void ブラウザの設定ウィンドウを開く();
    // public abstract void ブラウザの拡張機能ウィンドウを開く();
    // public abstract void ブラウザのデベロッパーツールを開く();
    // public abstract void ブラウザのタスクマネージャーを開く();
    // public abstract void ブラウザのダウンロードマネージャーを開く();
    // public abstract void ブラウザの履歴ウィンドウを開く();
    // public abstract void ブラウザのブックマークマネージャーを開く();
    // public abstract void ブラウザの拡張機能ストアを開く();
    // public abstract void ブラウザのヘルプセンターを開く();
    // public abstract void ブラウザのフィードバックフォームを開く();
    // public abstract void ブラウザのアップデートセンターを開く();
    // public abstract void ブラウザのアンインストールウィザードを開く();
    // public abstract void ブラウザの再インストールウィザードを開く();
    // public abstract void ブラウザのバージョン情報ウィンドウを開く();
    // public abstract void ブラウザのライセンス情報ウィンドウを開く();
    // public abstract void ブラウザの診断ツールを開く();
    // public abstract void ブラウザのデバッグツールを開く();
    // public abstract void ブラウザのパフォーマンスモニターを開く();
    // public abstract void ブラウザのネットワークモニターを開く();
    // public abstract void ブラウザのメモリモニターを開く();
    // public abstract void ブラウザのCPUモニターを開く();
    // public abstract void ブラウザのストレージモニターを開く();
    // public abstract void ブラウザのセキュリティモニターを開く();
    // public abstract void ブラウザのアクセシビリティモニターを開く();
    // public abstract void ブラウザの通知モニターを開く();
    // public abstract void ブラウザの位置情報モニターを開く();
    // public abstract void ブラウザのマルチメディアモニターを開く();
    // public abstract void ブラウザのダウンロードモニターを開く();
    // public abstract void ブラウザのアップロードモニターを開く();
    // public abstract void ブラウザの印刷モニターを開く();
    // public abstract void ブラウザの同期モニターを開く();
    // public abstract void ブラウザの拡張機能モニターを開く();
    // public abstract void ブラウザのプロキシモニターを開く();
    // // public abstract void ブラウザのネットワークモニターを開く();
    // public abstract void ブラウザのシステムモニターを開く();
    // public abstract void ブラウザのユーザーモニターを開く();
    // public abstract void ブラウザの設定モニターを開く();
    // public abstract void ブラウザの状態モニターを開く();
    // public abstract void ブラウザの診断モニターを開く();
    // public abstract void ブラウザのヘルプモニターを開く();
    // public abstract void ブラウザのライセンスモニターを開く();
    // public abstract void ブラウザのバグレポートモニターを開く();
    // public abstract void ブラウザのフィードバックモニターを開く();
    // public abstract void ブラウザのアップデートモニターを開く();
    // public abstract void ブラウザのアンインストールモニターを開く();
    // public abstract void ブラウザの再インストールモニターを開く();
    // public abstract void ブラウザのバージョン情報モニターを開く();
    // public abstract void ブラウザのライセンス情報モニターを開く();
    // public abstract void ブラウザの診断ツールモニターを開く();
    // public abstract void ブラウザのデバッグツールモニターを開く();
}