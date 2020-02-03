using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public UIManager ui;
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag=="Ball")
        {
           ui.Incrementscore();
        Destroy(gameObject);
        } 
    }

}
