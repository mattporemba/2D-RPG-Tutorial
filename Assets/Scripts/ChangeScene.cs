using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadNextScene(string sceneName)
    {
        print("Load " + sceneName + " scene");
        SceneManager.LoadScene(sceneName);
    }
}
