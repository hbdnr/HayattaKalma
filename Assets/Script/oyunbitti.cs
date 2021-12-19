using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunbitti : MonoBehaviour
{
    public Text puann;
    // Start is called before the first frame update
    void Start()
    {
		//imlecin ortaya çýkarýlmasý
        Cursor.visible = true;
		//anahtarlama yolu ile deðer alma iþlemidir. 
        puann.text = "Puanýnýz: "+PlayerPrefs.GetInt("puan");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YenidenOyna()
    {
        SceneManager.LoadScene("Oyun");
    }
}
