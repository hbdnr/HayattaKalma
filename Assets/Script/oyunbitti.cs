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
		//imlecin ortaya ��kar�lmas�
        Cursor.visible = true;
		//anahtarlama yolu ile de�er alma i�lemidir. 
        puann.text = "Puan�n�z: "+PlayerPrefs.GetInt("puan");
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
