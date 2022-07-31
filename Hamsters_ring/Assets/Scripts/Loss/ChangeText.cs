using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TextBlick());
    }

    IEnumerator TextBlick()
    {
        while (true)
        {
            if (GetComponent<TextMeshProUGUI>().color == Color.white)
            {
                GetComponent<TextMeshProUGUI>().color = new Color(0.3f, 0.4f, 0.6f, 0.3f);
            }
            else
            {
                GetComponent<TextMeshProUGUI>().color = Color.white;
            }
            
            yield return new WaitForSeconds(0.2f);
        }
    }
}
