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

You can also control the Character Speed, Words Per Minute and Frequency of the Audio.

```csharp
    TextToMorse converter = new TextToMorse(20,20,600);
    byte[] convertedbytes = converter.ConvertToMorse(MorseText);
```

### UWP Example

You can use [MemoryRandomAccessStream](https://gist.github.com/avknaidu/e6303014de19b19483a4f81e709ee490) to convert this to `Stream` and Play using Media Player.

```csharp
	byte[] outfile = converter.ConvertToMorse(Text);
	MemoryRandomAccessStream randomAccessStream = new MemoryRandomAccessStream(outfile);
	MediaPlayer mediaPlayer = new MediaPlayer();
	mediaPlayer.Source = MediaSource.CreateFromStream(randomAccessStream, "wav");
	mediaPlayer.Play();
```