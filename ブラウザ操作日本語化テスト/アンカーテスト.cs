using OpenQA.Selenium;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class アンカーテスト : Webユニットテスト
{
    public class テスト画面 : 画面
    {
        public アンカー アンカー;

        private テスト画面()
        {
            ブラウザ.移動する("https://www.selenium.dev/selenium/web/web-form.html");
            this.アンカー = new アンカー(By.TagName("a"));
        }

        public static テスト画面 移動する()
        {
            return new テスト画面();
        }
    }

    [TestMethod]
    public void TestMethod1()
    {
        テスト画面 画面 = テスト画面.移動する();
        Assert.AreEqual("Return to index", 画面.アンカー.文字列);
        画面
            .アンカー.クリックする();
        Assert.AreEqual("Index of Available Pages", 画面.タイトル);
    }
}