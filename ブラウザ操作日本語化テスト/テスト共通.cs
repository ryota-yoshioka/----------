using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public class テスト共通
{
    [AssemblyInitialize]
    public static void テスト開始時(TestContext context)
    {
        Chromeブラウザ.起動する();
    }

    [AssemblyCleanup]
    public static void テスト終了時()
    {
        Chromeブラウザ.終了する();
    }
}