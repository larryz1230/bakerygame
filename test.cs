using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour

    
{

    public BirdBehavior birdBehavior;
    public Button button;

    static class Count
    {
        public static int counter;
    }

    public GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
        instantiate();
        button = GameObject.Find("Canvas/Button").GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
    }



    public void instantiate()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }


    void TaskOnClick()
    {
        instantiate();

    }

}
