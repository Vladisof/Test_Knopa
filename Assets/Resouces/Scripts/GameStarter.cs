using System.Collections;
using UnityEngine;
using UnityEngine.UI; // Добавь это для доступа к компоненту Text

public class GameStarter : MonoBehaviour
{
  public GameObject objectToShow;       // Объект, который нужно показать
  public Text countdownText;            // Текстовый элемент для отображения отсчета
  public float delayBeforeStart = 3.0f; // Задержка перед показом объекта

  private void Start()
  {
    // Убедимся, что объект изначально скрыт
    objectToShow.SetActive(false);

    // Запускаем корутину отсчета
    StartCoroutine(Countdown());
  }

  private IEnumerator Countdown()
  {
    int count = Mathf.FloorToInt(delayBeforeStart);
    while (count > 0)
    {
      countdownText.text = count.ToString(); // Обновляем текст
      yield return new WaitForSeconds(1);    // Ждем секунду
      count--;                               // Уменьшаем отсчет
    }

    countdownText.text = "GO!";         // Показываем "GO!" или что-то подобное
    yield return new WaitForSeconds(1); // Ждем еще секунду (или меньше, если хочешь)

    // Скрываем текст и показываем объект
    countdownText.gameObject.SetActive(false);
    objectToShow.SetActive(true);
  }
}