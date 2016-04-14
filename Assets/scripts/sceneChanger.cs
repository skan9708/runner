using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ToScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
