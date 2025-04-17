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
    private float _timeRemaining = 30f; // ������ 5 ������
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
            _Question.text = "Co oznacza akronim DRY w kontekście programowania? \n" +
                "1. Do Repeat Yourself – Powtarzaj ten sam kod wielokrotnie.\n" +
                "2. Don't Repeat Yourself – Unikaj powielania tego samego kodu.\n" +
                "3. Data Retrieval Yield – Sposób pobierania danych z bazy.\n" +
                "4. Dynamic Resource Yielding – Dynamiczne zarządzanie zasobami.";
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
            _Question.text = "Co oznacza SOLID w programowaniu obiektowym?\n" +
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
            _Question.text = "Co opisuje zasadę 'Single Responsibility'?\n" +
                "1. Klasa powinna mieć tylko jedną odpowiedzialność\n" +
                "2. Funkcja nie może przekraczać 10 linii kodu\n" +
                "3. Zmienne muszą być jednoznacznie nazwane\n" +
                "4. Kod powinien być pisany w jednym języku";
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
            _Question.text = "Co jest głównym celem refaktoryzacji kodu?\n" +
                "1. Poprawa czytelności bez zmiany funkcjonalności\n" +
                "2. Dodawanie nowych funkcji\n" +
                "3. Usuwanie komentarzy\n" +
                "4. Zmiana języka programowania";
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
            _Question.text = "Co jest głównym celem testów jednostkowych?\n" +
                "1. Sprawdzenie pojedynczych komponentów\n" +
                "2. Testowanie interfejsu użytkownika\n" +
                "3. Sprawdzenie wydajności\n" +
                "4. Testowanie integracji systemów";
            _TrueAnswer = "1";
            shuffledAnswers = Answers17.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 18:
            _Question.text = "Który system operacyjny jest oparty na jądrze Linux?";
            _TrueAnswer = "Android";
            shuffledAnswers = Answers18.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 19:
            _Question.text = "Co jest kluczą cechą architektury mikroserwisów?\n" +
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
            _Question.text = "Które z tych jest architekturą API?";
            _TrueAnswer = "REST";
            shuffledAnswers = Answers20.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 21:
            _Question.text = "Co jest głównym celem Continuous Integration?\n" +
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
            _Question.text = "Które narzędzie jest hostem repozytoriów Git?";
            _TrueAnswer = "GitHub";
            shuffledAnswers = Answers22.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 23:
            _Question.text = "Co jest podstawową zasadą programowania defensywnego?\n" +
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
            _Question.text = "Które z tych jest frameworkiem frontendowym?";
            _TrueAnswer = "React";
            shuffledAnswers = Answers24.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 25:
            _Question.text = "Co jest główną zaletą języków interpretowanych?\n" +
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
            _Question.text = "Który język jest kompilowany do bytecode'u?";
            _TrueAnswer = "Java";
            shuffledAnswers = Answers26.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 27:
            _Question.text = "Co jest kluczowe w podejściu DevOps?\n" +
                "1. Integracja rozwoju i operacji\n" +
                "2. Oddzielenie zespołów\n" +
                "3. Ręczne wdrażanie\n" +
                "4. Brak automatyzacji";
            _TrueAnswer = "1";
            shuffledAnswers = Answers27.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 28:
            _Question.text = "Która baza danych jest NoSQL?";
            _TrueAnswer = "MongoDB";
            shuffledAnswers = Answers28.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 29:
            _Question.text = "Co jest głównym celem konteneryzacji?\n" +
                "1. Izolacja środowisk wykonawczych\n" +
                "2. Wirtualizacja sprzętu\n" +
                "3. Zwiększenie zużycia zasobów\n" +
                "4. Ręczna konfiguracja";
            _TrueAnswer = "1";
            shuffledAnswers = Answers29.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;

        case 30:
            _Question.text = "Które narzędzie służy do orchestracji kontenerów?";
            _TrueAnswer = "K8s";
            shuffledAnswers = Answers30.OrderBy(x => Random.value).ToArray();
            MachMoney = 100;
            WhichButtonWhichText();
            break;
            case 31:
    _Question.text = "Co oznacza akronim KISS w programowaniu?\n" +
        "1. Keep It Secure, Safe - Utrzymuj bezpieczeństwo kodu\n" +
        "2. Keep It Simple, Stupid - Utrzymuj prostotę kodu\n" +
        "3. Keep It Standardized, Structured - Utrzymuj standaryzację\n" +
        "4. Keep It Synchronized, Stable - Utrzymuj synchronizację";
    _TrueAnswer = "2";
    shuffledAnswers = Answers31.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 32:
    _Question.text = "Która zasada SOLID mówi, że klasy powinny być otwarte na rozbudowę ale zamknięte na modyfikację?\n" +
        "1. Single Responsibility Principle\n" +
        "2. Liskov Substitution Principle\n" +
        "3. Open-Closed Principle\n" +
        "4. Dependency Inversion Principle";
    _TrueAnswer = "3";
    shuffledAnswers = Answers32.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 33:
    _Question.text = "Co jest głównym celem wzorca projektowego Observer?\n" +
        "1. Tworzenie pojedynczej instancji klasy\n" +
        "2. Hermetyzacja złożonych operacji\n" +
        "3. Powiadamianie obiektów o zmianach stanu\n" +
        "4. Dynamiczne tworzenie obiektów";
    _TrueAnswer = "3";
    shuffledAnswers = Answers33.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 34:
    _Question.text = "Która struktura danych działa na zasadzie FIFO?\n" +
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
    _Question.text = "Co oznacza 'abstrakcja' w programowaniu obiektowym?\n" +
        "1. Tworzenie wielu instancji klasy\n" +
        "2. Łączenie danych i funkcji w jedną całość\n" +
        "3. Ukrywanie złożoności poprzez pokazywanie tylko istotnych cech\n" +
        "4. Nadpisywanie metod klasy bazowej";
    _TrueAnswer = "3";
    shuffledAnswers = Answers35.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 36:
    _Question.text = "Która z tych jest podstawową koncepcją OOP?\n" +
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
    _Question.text = "Co to jest 'technical debt' (dług techniczny)?\n" +
        "1. Koszt przyszłych poprawek wynikający z obecnych uproszczeń\n" +
        "2. Koszt licencji na oprogramowanie\n" +
        "3. Wydajność systemu\n" +
        "4. Czas potrzebny na kompilację kodu";
    _TrueAnswer = "1";
    shuffledAnswers = Answers37.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 38:
    _Question.text = "Co to jest 'pair programming'?\n" +
        "1. Programowanie w dwóch językach jednocześnie\n" +
        "2. Dwie osoby pracujące razem przy jednym komputerze\n" +
        "3. Pisanie kodu w parach instrukcji\n" +
        "4. Testowanie kodu przez dwóch programistów";
    _TrueAnswer = "2";
    shuffledAnswers = Answers38.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 39:
    _Question.text = "Co to jest 'callback' w programowaniu?\n" +
        "1. Powrót do poprzedniej linii kodu\n" +
        "2. Komunikat o błędzie\n" +
        "3. Mechanizm debugowania\n" +
        "4. Funkcja przekazywana jako argument do innej funkcji";
    _TrueAnswer = "4";
    shuffledAnswers = Answers39.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 40:
    _Question.text = "Co to jest 'garbage collection'?\n" +
        "1. Usuwanie nieużywanych plików\n" +
        "2. Optymalizacja kodu\n" +
        "3. Czyszczenie bazy danych\n" +
        "4. Automatyczne zarządzanie pamięcią";
    _TrueAnswer = "4";
    shuffledAnswers = Answers40.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 41:
    _Question.text = "Co to jest 'dependency injection'?\n" +
        "1. Wstrzykiwanie kodu do istniejącej aplikacji\n" +
        "2. Instalacja bibliotek zależnych\n" +
        "3. Mechanizm debugowania\n" +  // Przeniesione z pozycji 4
        "4. Dostarczanie zależności z zewnątrz zamiast tworzenia ich wewnątrz klasy";  // Poprawna odpowiedź teraz jako 4
    _TrueAnswer = "4";  // Zmienione z "3" na "4"
    shuffledAnswers = Answers41.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 42:
    _Question.text = "Co to jest 'closure' w JavaScript?\n" +
        "1. Zakończenie programu\n" +
        "2. Zamknięcie okna przeglądarki\n" +
        "3. Typ danych\n" +  // Przeniesione z pozycji 4
        "4. Funkcja z zapamiętanym zakresem leksykalnym";  // Poprawna odpowiedź teraz jako 4
    _TrueAnswer = "4";  // Zmienione z "3" na "4"
    shuffledAnswers = Answers42.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 43:
    _Question.text = "Co to jest 'idempotentność' w kontekście API?\n" +
        "1. Szybkość działania endpointu\n" +
        "2. Bezpieczeństwo połączenia\n" +
        "3. Mechanizm cache'owania\n" +  // Przeniesione z pozycji 4
        "4. Właściwość, że wielokrotne wywołanie daje ten sam efekt";  // Poprawna odpowiedź teraz jako 4
    _TrueAnswer = "4";  // Zmienione z "3" na "4"
    shuffledAnswers = Answers43.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 44:
    _Question.text = "Co to jest 'mocking' w testowaniu?\n" +
        "1. Testowanie interfejsu użytkownika\n" +
        "2. Pomiar wydajności\n" +
        "3. Generowanie danych testowych\n" +  // Przeniesione z pozycji 4
        "4. Symulowanie zachowania obiektów";  // Poprawna odpowiedź teraz jako 4
    _TrueAnswer = "4";  // Zmienione z "3" na "4"
    shuffledAnswers = Answers44.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 45:
    _Question.text = "Co to jest 'overengineering'?\n" +
        "1. Nadmierne komplikowanie rozwiązania\n" +  // Poprawna odpowiedź przeniesiona na pozycję 1
        "2. Optymalizacja kodu\n" +
        "3. Używanie nowych technologii\n" +
        "4. Rozbudowana dokumentacja";
    _TrueAnswer = "1";  // Zmienione z "3" na "1"
    shuffledAnswers = Answers45.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 46:
    _Question.text = "Co to jest 'technical spike' w Agile?\n" +
        "1. Eksperyment mający na celu zbadanie rozwiązania\n" +  // Poprawna odpowiedź przeniesiona na pozycję 1
        "2. Nagły wzrost wydajności\n" +
        "3. Problem techniczny\n" +
        "4. Spotkanie zespołu developerskiego";
    _TrueAnswer = "1";  // Zmienione z "3" na "1"
    shuffledAnswers = Answers46.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 47:
    _Question.text = "Co to jest 'feature flag'?\n" +
        "1. Mechanizm włączania/wyłączania funkcjonalności bez deploy'owania kodu\n" +  // Poprawna odpowiedź przeniesiona na pozycję 1
        "2. Oznaczenie nowej funkcji w dokumentacji\n" +
        "3. Flaga w systemie kontroli wersji\n" +
        "4. Testowanie A/B";
    _TrueAnswer = "1";  // Zmienione z "3" na "1"
    shuffledAnswers = Answers47.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 48:
    _Question.text = "Co to jest 'blue-green deployment'?\n" +
        "1. Strategia wdrażania z dwoma identycznymi środowiskami\n" +  // Poprawna odpowiedź przeniesiona na pozycję 1
        "2. Kolorystyka interfejsu\n" +
        "3. Metoda testowania\n" +
        "4. Narzędzie do monitorowania";
    _TrueAnswer = "1";  // Zmienione z "3" na "1"
    shuffledAnswers = Answers48.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 49:
    _Question.text = "Co to jest 'YAGNI' w programowaniu?\n" +
        "1. Yet Another Generic Network Interface\n" +
        "2. Young Architects Group Networking Initiative\n" +
        "3. You Aren't Gonna Need It - Nie implementuj czegoś, czego nie potrzebujesz\n" +
        "4. Yield And Get Next Instruction";
    _TrueAnswer = "3";
    shuffledAnswers = Answers49.OrderBy(x => Random.value).ToArray();
    MachMoney = 100;
    WhichButtonWhichText();
    break;

case 50:
    _Question.text = "Co to jest 'technical debt'?\n" +
        "1. Koszt utrzymania infrastruktury\n" +
        "2. Wydajność systemu\n" +
        "3. Koszt przyszłych poprawek wynikający z obecnych uproszczeń\n" +
        "4. Czas potrzebny na kompilację kodu";
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
        timeBar.fillAmount = _timeRemaining / 30f;

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
        _timeRemaining = 30f;
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


