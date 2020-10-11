using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.Assertions.Must;

public class SwitchColor : MonoBehaviour
{

    public float timeStart = 5; // Таймер для смены цвета
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

        if (Input.GetMouseButtonDown(0) && DataOnMash.countClick <= 10 && gameObject) // Цвет меняется не больше чем 10 нажатий (за условием задания) 
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 255f, 0);
        }


    }

    void ChangeColor()
    {
        if (name == "Cube(Clone)" || name == "Capsule(Clone)" || name == "Sphere(Clone)")
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            timeStart = 5;
        }
    }

}
