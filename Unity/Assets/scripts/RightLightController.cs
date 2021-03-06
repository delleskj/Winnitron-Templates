﻿using UnityEngine;
using System.Collections;

public class RightLightController : MonoBehaviour 
{
    public Animator p1_u;
    public Animator p1_d;
    public Animator p1_l;
    public Animator p1_r;
    public Animator p1_1;
    public Animator p1_2;

    public Animator p2_u;
    public Animator p2_d;
    public Animator p2_l;
    public Animator p2_r;
    public Animator p2_1;
    public Animator p2_2;

    public Animator p3_u;
    public Animator p3_d;
    public Animator p3_l;
    public Animator p3_r;
    public Animator p3_1;
    public Animator p3_2;

    public Animator p4_u;
    public Animator p4_d;
    public Animator p4_l;
    public Animator p4_r;
    public Animator p4_1;
    public Animator p4_2;
	
	void Update () 
    {
        if (Input.GetButtonDown("P1_Up"))      { p1_u.SetTrigger("register"); }
        if (Input.GetButtonDown("P1_Down"))    { p1_d.SetTrigger("register"); }
        if (Input.GetButtonDown("P1_Left"))    { p1_l.SetTrigger("register"); }
        if (Input.GetButtonDown("P1_Right"))   { p1_r.SetTrigger("register"); }
        if (Input.GetButtonDown("P1_Button1")) { p1_1.SetTrigger("register"); }
        if (Input.GetButtonDown("P1_Button2")) { p1_2.SetTrigger("register"); }

        if (Input.GetButtonDown("P2_Up"))      { p2_u.SetTrigger("register"); }
        if (Input.GetButtonDown("P2_Down"))    { p2_d.SetTrigger("register"); }
        if (Input.GetButtonDown("P2_Left"))    { p2_l.SetTrigger("register"); }
        if (Input.GetButtonDown("P2_Right"))   { p2_r.SetTrigger("register"); }
        if (Input.GetButtonDown("P2_Button1")) { p2_1.SetTrigger("register"); }
        if (Input.GetButtonDown("P2_Button2")) { p2_2.SetTrigger("register"); }

        if (Input.GetButtonDown("P3_Up"))      { p3_u.SetTrigger("register"); }
        if (Input.GetButtonDown("P3_Down"))    { p3_d.SetTrigger("register"); }
        if (Input.GetButtonDown("P3_Left"))    { p3_l.SetTrigger("register"); }
        if (Input.GetButtonDown("P3_Right"))   { p3_r.SetTrigger("register"); }
        if (Input.GetButtonDown("P3_Button1")) { p3_1.SetTrigger("register"); }
        if (Input.GetButtonDown("P3_Button2")) { p3_2.SetTrigger("register"); }

        if (Input.GetButtonDown("P4_Up"))      { p4_u.SetTrigger("register"); }
        if (Input.GetButtonDown("P4_Down"))    { p4_d.SetTrigger("register"); }
        if (Input.GetButtonDown("P4_Left"))    { p4_l.SetTrigger("register"); }
        if (Input.GetButtonDown("P4_Right"))   { p4_r.SetTrigger("register"); }
        if (Input.GetButtonDown("P4_Button1")) { p4_1.SetTrigger("register"); }
        if (Input.GetButtonDown("P4_Button2")) { p4_2.SetTrigger("register"); }
	}
}
