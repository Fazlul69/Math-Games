using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour
{
    public Image sliderImage;
    public Text result, right;
    public GameObject options;
    // Start is called before the first frame update
    void Start()
    {

        int randomResult = Random.Range(1,20);
        int randomRight = Random.Range(1, 20);
        result.text = "" + randomResult;
        right.text = "" + randomRight;

        int realResult = randomResult - randomRight;
        Debug.Log("Real Result"+realResult);

        
    }

    // Update is called once per frame
    void Update()
    {
        sliderImage.fillAmount -= 0.1f / 9;
        if (sliderImage.fillAmount == 0) {

            Debug.Log("Game Over");
        }
    }
}
