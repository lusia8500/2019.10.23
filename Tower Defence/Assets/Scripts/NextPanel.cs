using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextPanel : MonoBehaviour
{

    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;

    // Start is called before the first frame update
    void Start()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
    }

    public void Trigger1()
    {
        Panel2.SetActive(true);
    }

    public void Trigger2()
    {
        Panel2.SetActive(true);
    }

    public void Trigger3()
    {
        Panel3.SetActive(true);
    }

    public void Trigger4()
    {
        Panel4.SetActive(true);
    }
}
