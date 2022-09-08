using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static int score;
    public TMP_Text count;
    public Image[] image;
    
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
     count.text = score.ToString();
        
            if (score >= 3)
            {
                image[0].gameObject.SetActive(true);
            }
            if (score >= 8)
            {
                image[1].gameObject.SetActive(true);
            }
        if (score >= 13)
        {
            image[2].gameObject.SetActive(true);
           
        }
        if (score >= 18)
        {
            image[3].gameObject.SetActive(true);

        }
        if (score >= 23)
        {
            image[4].gameObject.SetActive(true);

        }
    }
    
}
