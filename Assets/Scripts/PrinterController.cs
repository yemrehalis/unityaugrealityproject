using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterController : MonoBehaviour


{

    public Animator anim;
    public bool PrintOn;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        PrintOn = false;

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void PrintStart()
    {
        if (PrintOn==false)

        {
            PrintOn = true;
            anim.Play("bed_animation_down");
            PrintOn = false;


        }


    }
    
}
