using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    Image hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = FindObjectOfType<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeceaseHP()
    {
        hp.fillAmount -= 0.2f;
    }
}
