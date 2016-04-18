using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public int count = 0;

    void Start()
    {
        gameObject.GetComponent<Text>().text = count.ToString();
    }

    public void Add(int point)
    {
        count += point;
        gameObject.GetComponent<Text>().text = count.ToString();
    }
}
