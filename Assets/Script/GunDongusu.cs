using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDongusu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//belirtilen hızda ...
        transform.RotateAround(new Vector3(250f, 0, 250f), Vector3.right, 0.1f * Time.deltaTime);
    }
}