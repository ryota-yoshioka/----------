namespace ブラウザ操作日本語化;

public interface 画面要素インターフェース
{
    bool 有効である { get; }

    bool 表示されている { get; }

    void クリックする();

    string テキスト { get; }
    String 入力文字列 { get; }
    String オプションの表示文字列 { get; }

    void クリアする();
 
    void キー入力を送る(String キー入力);

    String? 属性を取得する(String 属性名);

    bool 選択されている { get; }
    bool チェックされている { get; }

    public IList<画面要素インターフェース> 選択肢のリスト();
    public IList<画面要素インターフェース> 全ての選択された選択肢();
    public 画面要素インターフェース? 選択された選択肢 { get; }
    public bool 複数選択可能 { get; }

    public void テキストで選択する(string テキスト);
    public void 値で選択する(string 値);
    public void 順番で選択する(int 順番);
    public 画面要素インターフェース ラップされた要素 { get; }
    public void 全て選択解除する();
    public void 順番で選択解除する(int 順番);
    public void テキストで選択解除する(string テキスト);
    public void 値で選択解除する(string 値);
}