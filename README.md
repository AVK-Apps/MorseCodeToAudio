## MorseCodeToAudio

Convert Morse Code from string to bytes[] and then convert to stream for audio playback. See Examples Below.

[![NuGet](https://img.shields.io/nuget/dt/MorseCodeToAudio.svg)](https://www.nuget.org/packages/morsecodetoaudio)

Install using Package Manager console

    Install-Package MorseCodeToAudio

### Example

```csharp
    TextToMorse converter = new TextToMorse();
    byte[] convertedbytes = converter.ConvertToMorse(MorseText);
```

Now using `convertedbytes` you can convert this to a `Stream` and create/play audio. See `UWP` Specific Sample below

You can also control the Frequency, Words Per Minute and Speed of the Audio.

```csharp
    TextToMorse converter = new TextToMorse(20,20,600);
    byte[] convertedbytes = converter.ConvertToMorse(MorseText);
```