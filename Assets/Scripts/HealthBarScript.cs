using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarScript : MonoBehaviour
{

    public int maxHealth = 100;
    public Gradient gradient;
    public Image fill;
    private int currentHealth;
    public Slider slider;

    public void SetMaxHealth(int health){
        slider.value = health;
        slider.maxValue = health;
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health){
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}
