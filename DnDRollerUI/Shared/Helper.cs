namespace DnDRoller.Shared;

public static class Helper
{
    public delegate void OnUpdateHandler();
    public static event OnUpdateHandler OnUpdate;

    public static void Update()
    {
        OnUpdate?.Invoke();
    }
}