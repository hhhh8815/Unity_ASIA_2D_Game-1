using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        print("遊戲開始");

        SceneManager.LoadScene("關卡1");  // 場景管理.載入場景("名稱")
        //SceneManager.LoadScene(1);      // 場景管理.載入場景(編號)
    }

    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
