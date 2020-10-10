using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class SwitchColor : MonoBehaviour
{
    public float timeStart = 5;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (DataOnMash.createObj)
        {
            timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timeStart).ToString();

            if (timeStart <= 0)
            {
                //timeStart = 5;
                ChangeColor();
            }
        }
    }

    void ChangeColor()
    {
        if (name == "Cube(Clone)")
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            //Thread.Sleep(750);
            timeStart = 5;
        }

    }

}
