using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyuncuKontrol : MonoBehaviour
{
    public Transform mermipos;
    public GameObject mermi;
    public Image canimaji;
    private float kalancan = 100f;
    public OyunKontrol o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
			//mermi klonunun belirtilen objenin pozisyonunda oluşturulması
            GameObject go = Instantiate(mermi, mermipos.position, mermipos.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = mermipos.transform.forward * 10f;
			//oluşturulan klonun 2 saniye sonra yok edilmesi 
            Destroy(go.gameObject, 2f);
        }
    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("zombi"))
        {
            float x = kalancan / 100f;
            //zombi oyuncuya her temas ettiğinde oyuncu 10 can kaybedecek 
			kalancan -= 10f;
			//kalancan yüzlük sisteme dönüştürülerek image objesinin
			//fillAmount değerine eşitlenir.
            canimaji.fillAmount = x;
			//Değerin azaldıkça beyazdan kırmızıya dönmesi
            canimaji.color = Color.Lerp(Color.red, Color.white,x);

            if (kalancan <= 0)
            {
                o.OyunBitti();
            }
        }
    }
}
