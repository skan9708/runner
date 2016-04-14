using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutoSceneChanger : MonoBehaviour {

    public int duration=100;
    public string targetsene="main";
	int sum = 0;

	void Update ()
    {
        if (duration > sum)
        {
            sum += 1;
        }
        else if (duration == sum)
        {
            SceneManager.LoadSceneAsync(targetsene);
        }
	}
}
