using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data_Store2 : MonoBehaviour
{
    public int mennyikatt = 0;
    public Text textbox;
    public GameObject box;
    public Dictionary<string, int> ossz_cont = new Dictionary<string, int>();
    public int elso = 1;
    public List<string> volt = new List<string>();
    public int osszkatt = 0;

    void Start()
    {
        box = GameObject.Find("Current_items");
        textbox = GameObject.Find("Current_items").GetComponent<Text>();
    }
    public void OnMouseOver()
    {
        box.SetActive(true);
        if (elso.Equals(1))
            textbox.text = "Current: 0";
        else
        {
            textbox.text = "Current: " + ossz_cont[this.gameObject.name].ToString();
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (!volt.Contains(this.gameObject.name))
            {
                volt.Add(this.gameObject.name);
            }
            if (elso.Equals(1))
            {
                ossz_cont.Add(this.gameObject.name, +1);
                mennyikatt += 1;
                Data_Store3.osszkatt += 1;
                elso = 0;
            }
            else
            {
                ossz_cont[this.gameObject.name] += 1;
                Data_Store3.osszkatt += 1;
            }
            textbox.text = "Current: " + ossz_cont[this.gameObject.name].ToString();
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (!volt.Contains(this.gameObject.name))
            {
                volt.Add(this.gameObject.name);
            }
            if (elso.Equals(1))
            {
                ossz_cont.Add(this.gameObject.name, -1);
                mennyikatt -= 1;
                Data_Store3.osszkatt -= 1;
                elso = 0;
            }
            else
            {
                ossz_cont[this.gameObject.name] -= 1;
                Data_Store3.osszkatt -= 1;
            }
            textbox.text = "Current: " + ossz_cont[this.gameObject.name].ToString();
        }
    }
    public void OnMouseExit()
    {
        box.SetActive(false);
    }
    void Update()
    {

    }

}
