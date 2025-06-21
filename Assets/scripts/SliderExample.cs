using UnityEngine;
using UnityEngine.UI;
public class SliderExample : MonoBehaviour
{
    public void OnSliderValueChange(Slider mySlider)
    {
        Debug.Log("Slider Value: " + mySlider.value);
    }
}
