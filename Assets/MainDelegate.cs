using UnityEngine;

public class MainDelegate : MonoBehaviour
{
  public delegate void ChangeColor(Color newColor);
  public ChangeColor onChangeColor;

  public delegate void OnComplite();
  public OnComplite onComplite;

  private void Start()
  {
    onChangeColor = UpdateColor;
    onChangeColor(Color.green);
    onComplite += Task;
    onComplite += Task2;
    onComplite += Task3;

    if (onComplite != null)
    onComplite();
  }

  public void UpdateColor(Color newColor)
  {
    Debug.Log($"Changing color to: {newColor.ToString()}");
  }

  public void Task()
  {
    Debug.Log("Task Finished");
  }

  public void Task2()
  {
    Debug.Log("Task 2 Finished");
  }

  public void Task3()
  {
    Debug.Log("Task 3 Finished");
  }
}