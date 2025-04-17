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
    private float _timeRemaining = 5f; // ������ 5 ������
    private bool _isQuestionActive = false; // ������� �� ������

string[] Answers1 = { "1", "2", "3", "4" };
string[] Answers2 = { "Błędy", "Kod", "Dane", "Logi" };
string[] Answers3 = { "Pętla", "If", "Funkcja", "Klasa" };
string[] Answers4 = { "1", "2", "3", "4" };
string[] Answers5 = { "1", "2", "3", "4" };
string[] Answers6 = { "OOP", "SQL", "HTTP", "CSS" };
string[] Answers7 = { "1", "2", "3", "4" };
string[] Answers8 = { "Git", "SVN", "Mercurial", "FTP" };
string[] Answers9 = { "1", "2", "3", "4" };
string[] Answers10 = { "Stack", "Heap", "Queue", "Tree" };
string[] Answers11 = { "1", "2", "3", "4" };
string[] Answers12 = { "TCP", "UDP", "HTTP", "FTP" };
string[] Answers13 = { "1", "2", "3", "4" };
string[] Answers14 = { "Agile", "Scrum", "Waterfall", "Kanban" };
string[] Answers15 = { "1", "2", "3", "4" };
string[] Answers16 = { "CSS", "HTML", "XML", "JSON" };
string[] Answers17 = { "1", "2", "3", "4" };
string[] Answers18 = { "Linux", "Windows", "macOS", "Android" };
string[] Answers19 = { "1", "2", "3", "4" };
string[] Answers20 = { "REST", "SOAP", "GraphQL", "gRPC" };
string[] Answers21 = { "1", "2", "3", "4" };
string[] Answers22 = { "GitHub", "GitLab", "Bitbucket", "Jira" };
string[] Answers23 = { "1", "2", "3", "4" };
string[] Answers24 = { "React", "Vue", "Angular", "Svelte" };
string[] Answers25 = { "1", "2", "3", "4" };
string[] Answers26 = { "Python", "Java", "C++", "Go" };
string[] Answers27 = { "1", "2", "3", "4" };
string[] Answers28 = { "MySQL", "MongoDB", "PostgreSQL", "Redis" };
string[] Answers29 = { "1", "2", "3", "4" };
string[] Answers30 = { "Docker", "K8s", "VM", "CI/CD" };
string[] Answers31 = { "1", "2", "3", "4" };
string[] Answers32 = { "1", "2", "3", "4" };
string[] Answers33 = { "1", "2", "3", "4" };
string[] Answers34 = { "Stos", "Kolejka", "Lista", "Drzewo" };
string[] Answers35 = { "1", "2", "3", "4" };
string[] Answers36 = { "Encapsulation", "Inheritance", "Polymorphism", "Abstraction" };
string[] Answers37 = { "1", "2", "3", "4" };
string[] Answers38 = { "1", "2", "3", "4" };
string[] Answers39 = { "1", "2", "3", "4" };
string[] Answers40 = { "1", "2", "3", "4" };
string[] Answers41 = { "1", "2", "3", "4" };
string[] Answers42 = { "1", "2", "3", "4" };
string[] Answers43 = { "1", "2", "3", "4" };
string[] Answers44 = { "1", "2", "3", "4" };
string[] Answers45 = { "1", "2", "3", "4" };
string[] Answers46 = { "1", "2", "3", "4" };
string[] Answers47 = { "1", "2", "3", "4" };
string[] Answers48 = { "1", "2", "3", "4" };
string[] Answers49 = { "1", "2", "3", "4" };
string[] Answers50 = { "1", "2", "3", "4" };
string[] shuffledAnswers = new string[4];

void Start()
{
    randQestion();
}

public void randQestion()
{
    _NamberOfQuestion = Random.Range(1, 11);
    switch (_NamberOfQuestion)
    {
        case 1:
            _Question.text = "Co oznacza DRY? \n" +
                "1. Do Repeat Yourself.\n" +
                "2. Don't Repeat Yourself.\n" +
                "3. Data Retrieval Yield.\n" +
                "4. Dynamic Resource Yielding.";
            _TrueAnswer = "2";
            shuffledAnswers = Answers1.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 2:
            _Question.text = "Co sprawdza debuger?";
            _TrueAnswer = "Błędy";
            shuffledAnswers = Answers2.OrderBy(x => Random.value).ToArray(); 
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 3:
            _Question.text = "Która konstrukcja pozwala wielokrotnie wykonać ten sam kod?";
            _TrueAnswer = "Pętla";
            shuffledAnswers = Answers3.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 4:
            _Question.text = "Co oznacza SOLID?\n" +
                "1. Zbiór zasad projektowania kodu\n" +
                "2. Typ struktury danych\n" +
                "3. Sposób debugowania\n" +
                "4. Język programowania";
            _TrueAnswer = "1";
            shuffledAnswers = Answers4.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 5:
            _Question.text = "Które z tych jest typem danych?\n" +
                "1. Integer\n" +
                "2. Function\n" +
                "3. Loop\n" +
                "4. Class";
            _TrueAnswer = "1";
            shuffledAnswers = Answers5.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        // Nowe pytania (6-10)
        case 6:
            _Question.text = "Który z tych akronimów dotyczy programowania obiektowego?";
            _TrueAnswer = "OOP";
            shuffledAnswers = Answers6.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 7:
            _Question.text = "SRP to:\n" +
        "1. 1 odpowiedzialność klasy\n" +
        "2. Funkcja ≤10 linii\n" +
        "3. Jasne nazwy zmiennych\n" +
        "4. 1 język programowania";
            _TrueAnswer = "1";
            shuffledAnswers = Answers7.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 8:
            _Question.text = "Które narzędzie jest systemem kontroli wersji?";
            _TrueAnswer = "Git";
            shuffledAnswers = Answers8.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 9:
            _Question.text = "Co oznacza 'polimorfizm' w OOP?\n" +
                "1. Możliwość nadpisywania metod\n" +
                "2. Ukrywanie implementacji\n" +
                "3. Dziedziczenie właściwości\n" +
                "4. Tworzenie wielu instancji klasy";
            _TrueAnswer = "1";
            shuffledAnswers = Answers9.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 10:
            _Question.text = "Która struktura danych działa na zasadzie LIFO?";
            _TrueAnswer = "Stack";
            shuffledAnswers = Answers10.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

                case 11:
            _Question.text = "Który protokół jest bezpołączeniowy?\n" +
                "1. TCP\n" +
                "2. UDP\n" +
                "3. HTTP\n" +
                "4. FTP";
            _TrueAnswer = "2";
            shuffledAnswers = Answers11.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 12:
            _Question.text = "Który protokół służy do przesyłania plików?";
            _TrueAnswer = "FTP";
            shuffledAnswers = Answers12.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 13:
           _Question.text = "Cel refaktoryzacji:\n" +
        "1. Czytelność bez zmian funkcji\n" +
        "2. Nowe funkcje\n" +
        "3. Usuwanie komentarzy\n" +
        "4. Zmiana języka";
            _TrueAnswer = "1";
            shuffledAnswers = Answers13.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 14:
            _Question.text = "Która metoda zarządzania projektem używa sprintów?";
            _TrueAnswer = "Scrum";
            shuffledAnswers = Answers14.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 15:
            _Question.text = "Co oznacza '404' w protokole HTTP?\n" +
                "1. Nie znaleziono\n" +
                "2. Brak dostępu\n" +
                "3. Błąd serwera\n" +
                "4. Przekierowanie";
            _TrueAnswer = "1";
            shuffledAnswers = Answers15.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 16:
            _Question.text = "Które z tych jest językiem znaczników?";
            _TrueAnswer = "HTML";
            shuffledAnswers = Answers16.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 17:
           _Question.text = "Testy jednostkowe:\n" +
        "1. Test komponentów\n" +
        "2. Test UI\n" +
        "3. Test wydajności\n" +
        "4. Test integracji";
            _TrueAnswer = "1";
            shuffledAnswers = Answers17.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

       case 18:
    _Question.text = "Który system operacyjny jest oparty na jądrze Linux?";  // 48 chars
    _TrueAnswer = "Android";
    shuffledAnswers = Answers18.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 19:
    _Question.text = "Co jest kluczą cechą architektury mikroserwisów?\n" +  // 99 chars total
        "1. Luźne powiązania między komponentami\n" +
        "2. Wspólna baza danych\n" +
        "3. Jeden monolityczny kod\n" +
        "4. Brak komunikacji sieciowej";
    _TrueAnswer = "1";
    shuffledAnswers = Answers19.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 20:
    _Question.text = "Które z tych jest architekturą API?";  // 36 chars
    _TrueAnswer = "REST";
    shuffledAnswers = Answers20.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 21:
    _Question.text = "Co jest głównym celem Continuous Integration?\n" +  // 98 chars total
        "1. Automatyczne mergowanie i testowanie kodu\n" +
        "2. Ręczne wdrażanie zmian\n" +
        "3. Tworzenie dokumentacji\n" +
        "4. Zarządzanie zadaniami";
    _TrueAnswer = "1";
    shuffledAnswers = Answers21.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 22:
    _Question.text = "Które narzędzie jest hostem repozytoriów Git?";  // 47 chars
    _TrueAnswer = "GitHub";
    shuffledAnswers = Answers22.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 23:
    _Question.text = "Co jest podstawową zasadą programowania defensywnego?\n" +  // 99 chars total
        "1. Oczekiwanie nieprawidłowych danych wejściowych\n" +
        "2. Ignorowanie błędów\n" +
        "3. Używanie tylko globalnych zmiennych\n" +
        "4. Brak walidacji danych";
    _TrueAnswer = "1";
    shuffledAnswers = Answers23.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 24:
    _Question.text = "Które z tych jest frameworkiem frontendowym?";  // 44 chars
    _TrueAnswer = "React";
    shuffledAnswers = Answers24.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 25:
    _Question.text = "Co jest główną zaletą języków interpretowanych?\n" +  // 98 chars total
        "1. Łatwość debugowania\n" +
        "2. Najwyższa wydajność\n" +
        "3. Brak potrzeby interpretera\n" +
        "4. Niski poziom abstrakcji";
    _TrueAnswer = "1";
    shuffledAnswers = Answers25.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 26:
    _Question.text = "Który język jest kompilowany do bytecode'u?";  // 42 chars
    _TrueAnswer = "Java";
    shuffledAnswers = Answers26.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 27:
    _Question.text = "DevOps to:\n" +  // Shortened from 99 to 63 chars
        "1. Integracja dev i ops\n" +
        "2. Oddzielenie zespołów\n" +
        "3. Ręczne wdrażanie\n" +
        "4. Brak automatyzacji";
    _TrueAnswer = "1";
    shuffledAnswers = Answers27.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 28:
    _Question.text = "Która baza danych jest NoSQL?";  // 32 chars
    _TrueAnswer = "MongoDB";
    shuffledAnswers = Answers28.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 29:
    _Question.text = "Cel konteneryzacji:\n" +  // Shortened from 98 to 81 chars
        "1. Izolacja środowisk\n" +
        "2. Wirtualizacja sprzętu\n" +
        "3. Większe zużycie zasobów\n" +
        "4. Ręczna konfiguracja";
    _TrueAnswer = "1";
    shuffledAnswers = Answers29.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 30:
    _Question.text = "Które narzędzie służy do orchestracji kontenerów?";  // 51 chars
    _TrueAnswer = "K8s";
    shuffledAnswers = Answers30.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 31:
    _Question.text = "KISS oznacza:\n" +  // Shortened from 167 to 89 chars
        "1. Keep It Secure\n" +
        "2. Keep It Simple\n" +
        "3. Keep It Standard\n" +
        "4. Keep It Sync";
    _TrueAnswer = "2";
    shuffledAnswers = Answers31.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 32:
    _Question.text = "Która zasada SOLID to OCP?\n" +  // Shortened from 126 to 85 chars
        "1. SRP\n" +
        "2. LSP\n" +
        "3. OCP\n" +
        "4. DIP";
    _TrueAnswer = "3";
    shuffledAnswers = Answers32.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 33:
    _Question.text = "Cel wzorca Observer:\n" +  // Shortened from 98 to 83 chars
        "1. Pojedyncza instancja\n" +
        "2. Hermetyzacja\n" +
        "3. Powiadamianie\n" +
        "4. Tworzenie obiektów";
    _TrueAnswer = "3";
    shuffledAnswers = Answers33.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 34:
    _Question.text = "Struktura FIFO to:\n" +  // 79 chars
        "1. Stos\n" +
        "2. Kolejka\n" +
        "3. Lista\n" +
        "4. Drzewo";
    _TrueAnswer = "2";
    shuffledAnswers = Answers34.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 35:
    _Question.text = "Abstrakcja to:\n" +  // Shortened from 98 to 84 chars
        "1. Wiele instancji\n" +
        "2. Łączenie danych\n" +
        "3. Ukrywanie złożoności\n" +
        "4. Nadpisywanie metod";
    _TrueAnswer = "3";
    shuffledAnswers = Answers35.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 36:
    _Question.text = "Która z tych jest podstawową koncepcją OOP?\n" +  // 92 chars
        "1. Inheritance\n" +
        "2. Polymorphism\n" +
        "3. Encapsulation\n" +
        "4. Abstraction";
    _TrueAnswer = "3";
    shuffledAnswers = Answers36.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 37:
    _Question.text = "Technical debt to:\n" +  // Shortened from 99 to 82 chars
        "1. Koszt przyszłych poprawek\n" +
        "2. Koszt licencji\n" +
        "3. Wydajność\n" +
        "4. Czas kompilacji";
    _TrueAnswer = "1";
    shuffledAnswers = Answers37.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 38:
    _Question.text = "Pair programming to:\n" +  // Shortened from 98 to 83 chars
        "1. Dwa języki\n" +
        "2. Dwie osoby przy 1 PC\n" +
        "3. Pary instrukcji\n" +
        "4. Testowanie w duecie";
    _TrueAnswer = "2";
    shuffledAnswers = Answers38.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 39:
    _Question.text = "Callback to:\n" +  // Shortened from 98 to 82 chars
        "1. Powrót do kodu\n" +
        "2. Błąd\n" +
        "3. Debugowanie\n" +
        "4. Funkcja jako argument";
    _TrueAnswer = "4";
    shuffledAnswers = Answers39.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 40:
    _Question.text = "Garbage collection to:\n" +  // Shortened from 98 to 81 chars
        "1. Usuwanie plików\n" +
        "2. Optymalizacja\n" +
        "3. Czyszczenie DB\n" +
        "4. Zarządzanie pamięcią";
    _TrueAnswer = "4";
    shuffledAnswers = Answers40.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

// Cases 41-50 remain unchanged as they were already optimized

case 41:
_Question.text = "Dependency injection to:\n" +
"1. Wstrzykiwanie kodu\n" +
"2. Biblioteki zależne\n" +
"3. Debugowanie\n" +
"4. Dostarczanie zależności";
_TrueAnswer = "4";
shuffledAnswers = Answers41.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 42:
_Question.text = "Closure w JS to:\n" +
"1. Koniec programu\n" +
"2. Zamknięcie okna\n" +
"3. Typ danych\n" +
"4. Funkcja z zakresem";
_TrueAnswer = "4";
shuffledAnswers = Answers42.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 43:
_Question.text = "Idempotentność API to:\n" +
"1. Szybkość\n" +
"2. Bezpieczeństwo\n" +
"3. Cache'owanie\n" +
"4. Ten sam efekt";
_TrueAnswer = "4";
shuffledAnswers = Answers43.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 44:
_Question.text = "Mocking w testach to:\n" +
"1. Test UI\n" +
"2. Wydajność\n" +
"3. Dane testowe\n" +
"4. Symulacja obiektów";
_TrueAnswer = "4";
shuffledAnswers = Answers44.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 45:
_Question.text = "Overengineering to:\n" +
"1. Nadmierna komplikacja\n" +
"2. Optymalizacja\n" +
"3. Nowe technologie\n" +
"4. Dokumentacja";
_TrueAnswer = "1";
shuffledAnswers = Answers45.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 46:
_Question.text = "Technical spike to:\n" +
"1. Badanie rozwiązania\n" +
"2. Wzrost wydajności\n" +
"3. Problem techniczny\n" +
"4. Spotkanie devów";
_TrueAnswer = "1";
shuffledAnswers = Answers46.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 47:
_Question.text = "Feature flag to:\n" +
"1. Włączanie funkcji\n" +
"2. Dokumentacja\n" +
"3. Flaga w GIT\n" +
"4. Test A/B";
_TrueAnswer = "1";
shuffledAnswers = Answers47.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 48:
_Question.text = "Blue-green deploy to:\n" +
"1. Dwa środowiska\n" +
"2. Kolory interfejsu\n" +
"3. Testowanie\n" +
"4. Monitoring";
_TrueAnswer = "1";
shuffledAnswers = Answers48.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 49:
_Question.text = "YAGNI to:\n" +
"1. Interfejs sieciowy\n" +
"2. Grupa architektów\n" +
"3. Nie implementuj zbędnego\n" +
"4. Instrukcja procesora";
_TrueAnswer = "3";
shuffledAnswers = Answers49.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;

case 50:
_Question.text = "Technical debt to:\n" +
"1. Infrastruktura\n" +
"2. Wydajność\n" +
"3. Koszt poprawek\n" +
"4. Czas kompilacji";
_TrueAnswer = "3";
shuffledAnswers = Answers50.OrderBy(x => Random.value).ToArray();
MachMoney = 100;
WhichButtonWhichText();
break;


    }

    ResetTimer();
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

        _isQuestionActive = true; // ���������� ������
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
            TotalTime.Hour -= 24; // ��������� ��������� �� ��������� ����
            TotalTime.Day += 1;   // ��������� ����� ����
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


