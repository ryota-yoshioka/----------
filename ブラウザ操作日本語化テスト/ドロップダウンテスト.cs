using OpenQA.Selenium;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class ドロップダウンテスト : Webユニットテスト
{
    public class テスト画面 : 画面
    {
        public ドロップダウン ドロップダウン;

        private テスト画面() : base()
        {
            ブラウザ.移動する("https://www.selenium.dev/selenium/web/formPage.html");
            ドロップダウン = new ドロップダウン(By.Name("selectomatic"));
        }
        public static テスト画面 移動する()
        {
            return new テスト画面();
        }

        public テスト画面 Twoを選択する()
        {
            ドロップダウン.選択する("Two");
            return this;
        }
        public テスト画面 Fourを選択する()
        {
            ドロップダウン.値で選択する("four");
            return this;
        }
        public テスト画面 StillLearningHowToCountApparentlyを選択する()
        {
            ドロップダウン.順番で選択する(3);
            return this;
        }

        public bool Twoが選択されている =>
            ドロップダウン.選択された選択肢.文字列 == "Two";
        public bool Fourが選択されている =>
            ドロップダウン.選択された選択肢.文字列 == "Four";
        public bool StillLearningHowToCountApparentlyが選択されている =>
            ドロップダウン.選択された選択肢.文字列 == "Still learning how to count, apparently";
    }

    [TestMethod]
    public void SelectOption()
    {
        var 画面 = テスト画面.移動する();

        // var 選択肢のリスト = テスト画面.ドロップダウン.選択肢を取得する;
        // var twoElement = 選択肢のリスト[1];
        // var fourElement = 選択肢のリスト[2];
        // var countElement = 選択肢のリスト[3];

        画面.Fourを選択する();
        Assert.IsTrue(画面.Fourが選択されている);

        画面.Twoを選択する();
        Assert.IsTrue(画面.Twoが選択されている);

        画面.StillLearningHowToCountApparentlyを選択する();
        Assert.IsTrue(画面.StillLearningHowToCountApparentlyが選択されている);
    }

    // [TestMethod]
    // public void SelectMultipleOption()
    // {
    //     var selectElement = driver.FindElement(By.Name("multi"));
    //     var select = new SelectElement(selectElement);

    //     var hamElement = driver.FindElement(By.CssSelector("option[value=ham]"));
    //     var gravyElement = driver.FindElement(By.CssSelector("option[value='onion gravy']"));
    //     var eggElement = driver.FindElement(By.CssSelector("option[value=eggs]"));
    //     var sausageElement = driver.FindElement(By.CssSelector("option[value='sausages']"));

    //     IList<IWebElement> optionList = select.Options;
    //     IWebElement[] optionElements = selectElement.FindElements(By.TagName("option")).ToArray();
    //     CollectionAssert.AreEqual(optionElements, optionList.ToArray());

    //     IList<IWebElement> selectedOptionList = select.AllSelectedOptions;
    //     IWebElement[] expectedSelection = { eggElement, sausageElement };
    //     CollectionAssert.AreEqual(expectedSelection, selectedOptionList.ToArray());

    //     select.SelectByValue("ham");
    //     select.SelectByValue("onion gravy");
    //     Assert.IsTrue(hamElement.Selected);
    //     Assert.IsTrue(gravyElement.Selected);

    //     select.DeselectByValue("eggs");
    //     select.DeselectByValue("sausages");
    //     Assert.IsFalse(eggElement.Selected);
    //     Assert.IsFalse(sausageElement.Selected);
    // }
}