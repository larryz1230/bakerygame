using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.UI;

public class BirdBehavior : MonoBehaviour

    
{
    public Text txt;
    public Text endtxt;
    public Button button;

    public static class Score
    {
        public static int count;

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Score.count);
        txt = GameObject.Find("Canvas/score").GetComponent<Text>();
        button = GameObject.Find("Canvas/Button").GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
        endtxt = GameObject.Find("Canvas/fired").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = newPosition.x;
        if (x > 9)
        {
            x = 9;
        }
        if (x < -9)
        {
            x = -9;
        }
        transform.position = new Vector3(x, -2, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       
        col.gameObject.transform.position = new Vector3(Range(-8, 8), 4, 0); 
         Score.count++;
         Debug.Log(Score.count);
         Debug.Log("name" + col.gameObject.name);
        txt.text = "Score: " + Score.count.ToString();



    }

    void TaskOnClick()
    {
        Score.count = 0;
        txt.text = "Score: ";
        endtxt.text = "";

    }

}


