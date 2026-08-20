using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class Scene3KodDeneme1 : MonoBehaviour
{
    int sayim = 0;
    int birincisayi_, ikincisayi_;

    public TMP_InputField _inputfield;
    public TextMeshProUGUI textim;

    private void Start()
    {
            _inputfield.GetComponent<TMP_InputField>();
        _inputfield.text = "dsafdarf";    
        _inputfield.contentType = TMP_InputField.ContentType.IntegerNumber;
    }



    
    public void tiklama()
    {
      
            //2
        if (_inputfield.text.Length > 1)
        {
            Debug.Log("Yanlislik var");
        }
     
        else
        {
            //    textim.text = _inputfield.text; calisiyor#
            sayim++;

            if(sayim == 1)
            {
                var sayim1 = _inputfield.text;
                birincisayi_ = int.Parse(sayim1);
               

                PlayerPrefs.SetInt("birincisayim", birincisayi_);
                Debug.Log(PlayerPrefs.GetInt("birincisayim"));
            }

            if(sayim == 2)
            {
               var sayim2 =  _inputfield.text;
                ikincisayi_ = int.Parse(sayim2);
                PlayerPrefs.SetInt("ikincisayi", ikincisayi_);

                Debug.Log(PlayerPrefs.GetInt("ikincisayi") );
                textim.text = Random.Range(PlayerPrefs.GetInt("birincisayim"), PlayerPrefs.GetInt("ikincisayi")).ToString();
                PlayerPrefs.DeleteAll();
            }
           

    
        }
    
    }
}
