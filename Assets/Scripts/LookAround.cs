using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float speed = 3;
    public GameObject livingRoom;
    public GameObject cantina;
    public GameObject cube;
    public GameObject mezzanine;
    public Animator anim;

    void Start()
    {
        livingRoom.SetActive(true);
        cantina.SetActive(false);
        cube.SetActive(false);
        mezzanine.SetActive(false);
 
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));
        }
    }

    public void goCantina()
    {
        StartCoroutine("cantinaf");
    }

    private IEnumerator cantinaf()
    {
        anim.SetTrigger("fadeout");  
        yield return new WaitForSeconds(0.40f);
        livingRoom.SetActive(false);
        cantina.SetActive(true);
        cube.SetActive(false);
        mezzanine.SetActive(false);
        anim.SetTrigger("fadein");      
    }

    public void goLivingRoom()
    {
        StartCoroutine("livingroomf");
    }

    private IEnumerator livingroomf()
    {
        anim.SetTrigger("fadeout");  
        yield return new WaitForSeconds(0.40f);
        livingRoom.SetActive(true);
        cantina.SetActive(false);
        cube.SetActive(false);
        mezzanine.SetActive(false);
        anim.SetTrigger("fadein");
    }

    public void goCube()
    {
        StartCoroutine("cubef");
    }

    private IEnumerator cubef()
    {
        anim.SetTrigger("fadeout");  
        yield return new WaitForSeconds(0.40f);
        livingRoom.SetActive(false);
        cantina.SetActive(false);
        cube.SetActive(true);
        mezzanine.SetActive(false);
        anim.SetTrigger("fadein");
    }

    public void goMezzanine()
    {
        StartCoroutine("mezzaninef");
    }

    private IEnumerator mezzaninef()
    {
        anim.SetTrigger("fadeout");  
        yield return new WaitForSeconds(0.40f);
        livingRoom.SetActive(false);
        cantina.SetActive(false);
        cube.SetActive(false);
        mezzanine.SetActive(true);
        anim.SetTrigger("fadein");
    }

    public void ShowOrHide(GameObject Target)
    {
        Target.SetActive(!Target.activeInHierarchy);
    }

}
