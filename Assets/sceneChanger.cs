using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneChanger: MonoBehaviour {

	int sum = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (SceneManager.GetActiveScene().name == "logo")
        {
            if (100 == sum)
            {
                ToScene("main");
            }
            sum += 1;
        }
	}

    public void ToScene(string sceneName)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);
    }
}
