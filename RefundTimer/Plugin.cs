using BepInEx;
using UnityEngine;
using System.IO;
using System;

[BepInPlugin("com.walkslow.gorillatag.refundtimer", "Rufund Timer", "1.0.0")]
public class RefundTimer : BaseUnityPlugin
{
private const float MaxPlaySeconds = 7080f;
private const string SaveDir = "BepInEx/plugins/PlayTimer";
private const string SaveFile = "timerdata.txt";
private float timeLeft = MaxPlaySeconds;
private bool timerActive = true;
void Start()
{
Directory.CreateDirectory(SaveDir);
string path = Path.Combine(SaveDir, SaveFile);
if (File.Exists(path))
{
string content = File.ReadAllText(path);
if (float.TryParse(content, out float savedTime))
{
timeLeft = savedTime;
Logger.LogInfo($"Loaded remaining time: {timeLeft} seconds");
}
}
}
void Update()
{
if (!timerActive) return;
timeLeft -= Time.unscaledDeltaTime;
if (timeLeft <= 0)
{
SaveTime(0);
Application.Quit();
timerActive = false;
}
}
void OnGUI()
{
GUI.Label(new Rect(10, 10, 350, 30), $"Time left: {TimeSpan.FromSeconds(Mathf.Max(0, timeLeft)):hh\\:mm\\:ss}");
}
void OnApplicationQuit()
{
SaveTime(timeLeft);
}
private void SaveTime(float time)
{
string path = Path.Combine(SaveDir, SaveFile);
File.WriteAllText(path, time.ToString());
Logger.LogInfo($"Saved remaining time: {time} seconds");
}
}
