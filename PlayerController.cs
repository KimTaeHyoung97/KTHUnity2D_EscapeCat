using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float character_dir = 0f;
    bool isDie = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDie) return;

        character_dir = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            character_dir = -0.5f;
            transform.Translate(-0.05f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            character_dir = 0.5f;
            transform.Translate(0.05f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.05f, 0);
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.05f, 0);
        }

        if(character_dir != 0)
        {
            transform.localScale = new Vector3 (character_dir, .8f, .1f);
        }
    }
    public void Die()
    {
        isDie = true;
    }
}
