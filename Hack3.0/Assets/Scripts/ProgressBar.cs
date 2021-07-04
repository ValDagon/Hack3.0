using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    private Slider slider;

    public float FillSpeed = 0.5f;
    private float targetProgress = 0;
    public int Count = 0;
    public int UserValue = 0;

    public InputField InputField;

    public Text TimeText;
    public Text AttemptText;
    public Text EasyText;
    public Text InstructionsText;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
            slider.value += FillSpeed * Time.deltaTime;
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;

    }

    public void StartHack()
    {
        slider.value = 0f;
        IncrementProgress(1f);
    }

    public void ButtonDude()
    {
        UserValue = 1;
        Count += 1;
    }

    public void ButtonDogge()
    {
        UserValue = 2;
        Count += 1;
    }

    public void ButtonHacker()
    {
        UserValue = 3;
        Count += 1;
    }

    public void ProgressBarEnd()
    {
        if (UserValue == 1)
        {
            if (slider.value == 1f)
            {
                TimeText.text = "0.27 секунд";
                AttemptText.text = "1";
                InputField.text = "12345";
                print(Count);
                if (Count == 3)
                {
                    EasyText.text = "Почему так легко и быстро?";
                    InstructionsText.text = "Если ваш пароль — «12345» или «пароль», на его взлом уйдёт 0,29 миллисекунды. Пароль, в основе которого — слово с цифрой в конце, взламывается примерно за час. Количество символов тоже имеет значение.На взлом пароля из 12 разных символов уйдёт уже до двух столетий даже на мощнейшем компьютере.";
                }
            }
        }

        else if (UserValue == 2)
        {
            if (slider.value == 1f)
            {
                TimeText.text = "1 час";
                AttemptText.text = "10231";
                InputField.text = "кот1";
                print(Count);
                if (Count == 3)
                {
                    EasyText.text = "Почему так легко и быстро?";
                    InstructionsText.text = "Если ваш пароль — «12345» или «пароль», на его взлом уйдёт 0,29 миллисекунды. Пароль, в основе которого — слово с цифрой в конце, взламывается примерно за час. Количество символов тоже имеет значение.На взлом пароля из 12 разных символов уйдёт уже до двух столетий даже на мощнейшем компьютере.";
                }
            }
        }

        else if (UserValue == 3)
        {
            if (slider.value == 1f)
            {
                TimeText.text = "200 лет";
                AttemptText.text = "Бесконечность";
                InputField.text = "hdaghg1234sa";
                print(Count);
                if (Count == 3)
                {
                    EasyText.text = "Почему так легко и быстро?";
                    InstructionsText.text = "Если ваш пароль — «12345» или «пароль», на его взлом уйдёт 0,29 миллисекунды. Пароль, в основе которого — слово с цифрой в конце, взламывается примерно за час. Количество символов тоже имеет значение.На взлом пароля из 12 разных символов уйдёт уже до двух столетий даже на мощнейшем компьютере.";
                }
            }
        }
    }
}
