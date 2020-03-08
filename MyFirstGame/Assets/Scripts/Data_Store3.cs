using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data_Store3 : MonoBehaviour
{
    public GameObject box;
    static public int osszkatt = 0;
    public Text alltext;

    void Start()
    {
        alltext = GameObject.Find("All_item").GetComponent<Text>();
        box = GameObject.Find("All_item");
        box.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        alltext.text = "Clicked on Object: " + osszkatt.ToString() + " time(s)";
    }
}
