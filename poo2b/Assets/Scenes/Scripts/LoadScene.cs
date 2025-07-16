using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName;
    {
        SceneManager.LoadScene(sceneName);
    }

}    