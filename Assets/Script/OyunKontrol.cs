using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OyunKontrol : MonoBehaviour
{
    public GameObject zombii;
    public Text puantext;
    private int puan;
    private float olusumSureci =10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        olusumSureci -= Time.deltaTime;
        if (olusumSureci < 0)
        {
			//her 10 saniyede belirtilen aralıkta rasgele zombi oluşturma  
            Vector3 pos = new Vector3(Random.Range(153f,322f), 15.0005f, Random.Range(125f,320f));
            //Quaternion.identity kodu ile zombi objesinin herhangi bi açı olmadan ayakta oluşmasını sağlar 
			Instantiate(zombii, pos, Quaternion.identity);
            olusumSureci = 10f;
        }
    }

    public void puanArttir(int p)
    {
        puan += p;
        puantext.text = "" + puan;
    }

    public void OyunBitti()
    {
		//anahtarlama yolu ile değer taşıma işlemidir. 
        PlayerPrefs.SetInt("puan", puan);
        SceneManager.LoadScene("OyunBitti");
    }
}
