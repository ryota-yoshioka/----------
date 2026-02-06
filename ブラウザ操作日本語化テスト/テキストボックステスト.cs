using OpenQA.Selenium;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class テキストボックステスト : Webユニットテスト
{
    public class テスト画面 : 画面
    {
        public テキストボックス テキストボックス;

        private テスト画面()
        {
            ブラウザ.移動する("https://www.selenium.dev/selenium/web/web-form.html");
            this.テキストボックス = new テキストボックス(By.Id("my-text-id"));
        }

        public static テスト画面 移動する()
        {
            return new テスト画面();
        }
    }

    [TestMethod]
    public void TestMethod1()
    {
        var 画面 = テスト画面.移動する();
        Assert.AreEqual("", 画面.テキストボックス.文字列);
        画面
            .テキストボックス.入力する("Selenium Test");
        Thread.Sleep(3000);
        Assert.AreEqual("Selenium Test", 画面.テキストボックス.文字列);
    }
}