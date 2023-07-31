using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject Target;


    public GameObject TPloc1;
    public GameObject TPloc2;
    public GameObject TPloc3;
    public GameObject TPloc4;
    public GameObject TPloc5;
    public GameObject TPloc6;
    public GameObject TPloc7;
    public GameObject TPloc8;



    public void checkpoint1()
    {
        Target.gameObject.transform.position = TPloc1.gameObject.transform.position;
    }

    public void checkpoint2()
    {
        Target.gameObject.transform.position = TPloc2.gameObject.transform.position;
    }

    public void checkpoint3()
    {
        Target.gameObject.transform.position = TPloc3.gameObject.transform.position;
    }

    public void checkpoint4()
    {
        Target.gameObject.transform.position = TPloc4.gameObject.transform.position;
    }

    public void checkpoint5()
    {
        Target.gameObject.transform.position = TPloc5.gameObject.transform.position;
    }

    public void checkpoint6()
    {
        Target.gameObject.transform.position = TPloc6.gameObject.transform.position;
    }

    public void checkpoint7()
    {
        Target.gameObject.transform.position = TPloc7.gameObject.transform.position;
    }

    public void checkpoint8()
    {
        Target.gameObject.transform.position = TPloc8.gameObject.transform.position;
    }

}
