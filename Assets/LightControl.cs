using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public Light isik;
    public bool acik;
    public int zaman;
    void Start()
    {
        StartCoroutine(Degis());   
    }

    // Update is called once per frame
    void Update()
    {
        zaman = Random.Range(1, 5);
        if(acik)
        {
            isik.enabled = true;
        }
        if(!acik)
        {
            isik.enabled = false;
        }
    }
    IEnumerator Degis()
    {
        acik = !acik;
        yield return new WaitForSeconds(zaman);
        acik = !acik;

        Yeniden();
    }
    void Yeniden()
    {
        StartCoroutine(Degis());
    }
}
