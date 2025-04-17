using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Questions : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Answer1;
    [SerializeField] private TextMeshProUGUI _Answer2;
    [SerializeField] private TextMeshProUGUI _Answer3;
    [SerializeField] private TextMeshProUGUI _Answer4;
    [SerializeField] private TextMeshProUGUI _Question;
    [SerializeField] private Image timeBar;
    public GameObject QuestPanel;
    public string _TrueAnswer;
    public int _NamberOfQuestion;
    public int _TrueButton;
    public int MachMoney;
    private float _timeRemaining = 5f; // Таймер 5 секунд
    private bool _isQuestionActive = false; // активен ли вопрос

    string[] Answers1 = { "Да", "100%", "Конечно", "Россия" };
    string[] Answers2 = { "1", "2", "3", "4" };
    string[] shuffledAnswers = new string[4];

    void Start()
    {
        randQestion();
    }

    public void randQestion()
    {
        _NamberOfQuestion = Random.Range(1, 3);
        switch (_NamberOfQuestion)
        {
            case 1:
                _Question.text = "Даня вообще даун?";
                _TrueAnswer = "Россия";
                shuffledAnswers = Answers1.OrderBy(x => Random.value).ToArray();
                MachMoney = 52;
                WhichButtonWhichText();
                break;

            case 2:
                _Question.text = "Oleg52";
                _TrueAnswer = "2";
                shuffledAnswers = Answers2.OrderBy(x => Random.value).ToArray();
                MachMoney = 100;
                WhichButtonWhichText();
                break;
        }

        ResetTimer(); // Сбрасываем таймер при появлении нового вопроса
    }

    void Update()
    {
        timeBar.fillAmount = _timeRemaining / 5f;

        if (_isQuestionActive)
        {
            _timeRemaining -= Time.deltaTime;
            if (_timeRemaining <= 0)
            {
                CloseQuestion();
            }
        }

        if (_Answer1.text == _TrueAnswer) _TrueButton = 1;
        else if (_Answer2.text == _TrueAnswer) _TrueButton = 2;
        else if (_Answer3.text == _TrueAnswer) _TrueButton = 3;
        else _TrueButton = 4;
    }

    public void WhichButtonWhichText()
    {
        _Answer1.text = shuffledAnswers[0];
        _Answer2.text = shuffledAnswers[1];
        _Answer3.text = shuffledAnswers[2];
        _Answer4.text = shuffledAnswers[3];

        _isQuestionActive = true; // Активируем таймер
    }

    public void CloseQuestion()
    {
        QuestPanel.SetActive(false);
        _isQuestionActive = false;
        randQestion();
    }

    public void MinusStats()
    {
        TotalTime.Hour += 3;
        Sleeping.SleepPoints -= 10;
        Eating.EatPoints -= 10;
        if (TotalTime.Hour >= 24)
        {
            TotalTime.Hour -= 24; // Корректно переходим на следующий день
            TotalTime.Day += 1;   // Добавляем новый день
        }
    }

    public void ResetTimer()
    {
        _timeRemaining = 5f;
        timeBar.fillAmount = 1f;
        _isQuestionActive = true;
    }

    public void Answer1()
    {
        if (_TrueButton == 1) CorrectAnswer();
        else AnCorrectAnswer();
    }

    public void Answer2()
    {
        if (_TrueButton == 2) CorrectAnswer();
        else AnCorrectAnswer();
    }

    public void Answer3()
    {
        if (_TrueButton == 3) CorrectAnswer();
        else AnCorrectAnswer();
    }

    public void Answer4()
    {
        if (_TrueButton == 4) CorrectAnswer();
        else AnCorrectAnswer();
    }

    private void CorrectAnswer()
    {
        Balance.Money += MachMoney;
        QuestPanel.SetActive(false);
        _isQuestionActive = false;

        int slot = PlayerPrefs.GetInt("SaveSlot", 1);
        SaveSystem.SaveGameData(slot);

        randQestion();
    }

    private void AnCorrectAnswer()
    {
        Health.HealthPoints -= 20 * Hardnes.Hardnesfactor;

        int slot = PlayerPrefs.GetInt("SaveSlot", 1);
        SaveSystem.SaveGameData(slot);
    }
}


