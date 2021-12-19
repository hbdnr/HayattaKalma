using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiHareket : MonoBehaviour
{
    private int zombican = 3;
    private GameObject oyuncu;
    private float mesafe;
    private int puann = 10;
    private OyunKontrol o;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.Find("Oyuncu");
        o = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
		//zombinin oyuncuyu takip etmesi 
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
        //zombi ile oyuncunun arasındaki mesafe
		mesafe = Vector3.Distance(transform.position, oyuncu.transform.position);
		if (mesafe < 10f)
        {
			//mesafe 10 dan küçükse zombinin saldırma animasyonu devrede
            GetComponentInChildren<Animation>().Play("Zombie_Attack_01");
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("mermi"))
        {
            zombican--;
			//eğer zombiye değen objenin tag ı mermi ise zombinin canı 1 azaltılacak
			//zombi canı 1 den küçükse 
            if (zombican < 1)
            {
				//oyuncunun puanına 10 puan eklenecek
                o.puanArttir(puann);
				//zombinin öldüğü anımasyonu çağırılacak
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                //animasyonun süresi geçtikten sonra zombi objesi yok edilecek.
				Destroy(this.gameObject, 1.667f);
            }
        }
    }
}
