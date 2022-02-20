using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour


{
    public Text endtxt;
    static class Score
    {
        public static int count;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Score.count);

    }


    void OnCollisionEnter2D(Collision2D col)
    {

            Destroy(col.gameObject);
            Debug.Log("Game Over");
            endtxt = GameObject.Find("Canvas/fired").GetComponent<Text>();
        endtxt.text = "Fired!";


    }
}


